using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Portaria.Data
{
    public class UtilBD
    {
        public void SalvarConfig(string str, string nomeBase)
        {
            XDocument xmlFile = XDocument.Load(Application.StartupPath + @"\Portaria.exe.config");
            var query = from c in xmlFile.Elements("configuration").Elements("connectionStrings").Elements("add")
                        select c;
            foreach (XElement conn in query)
            {
                if (conn.Attribute("name").Value == "PortariaContext")
                {
                    var connStr = new SqlConnectionStringBuilder(str);
                    connStr.InitialCatalog = nomeBase;
                    conn.Attribute("connectionString").Value = connStr.ToString();
                }
                else if(conn.Attribute("name").Value == "PortariaLogContext")
                {
                    var connStr = new SqlConnectionStringBuilder(str);
                    connStr.InitialCatalog = nomeBase + "Log";
                    conn.Attribute("connectionString").Value = connStr.ToString();
                }
            }
            xmlFile.Save(Application.StartupPath + @"\Portaria.exe.config");
        }

        public string GerarConnString(string usuario, string senha, string endereco)
        {
            var connStrBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            connStrBuilder.DataSource = endereco;
            connStrBuilder.Password = senha;
            connStrBuilder.UserID = usuario;
            connStrBuilder.IntegratedSecurity = false;

            return connStrBuilder.ToString();
        }

        public string GerarConnString(string usuario, string senha, string endereco, string nomeBase)
        {
            var connStrBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            connStrBuilder.DataSource = endereco;
            connStrBuilder.Password = senha;
            connStrBuilder.UserID = usuario;
            connStrBuilder.IntegratedSecurity = false;
            connStrBuilder.InitialCatalog = nomeBase;

            return connStrBuilder.ToString();
        }

        public bool TestarConexao(string connStr)
        {
            try
            {
                var x = new System.Data.SqlClient.SqlConnection(connStr);
                x.Open();
                x.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<string> ListarBases(string str)
        {
            var result = new List<string>();

            var x = new System.Data.SqlClient.SqlConnection(str);
            x.Open();
            var databases = x.GetSchema("Databases");
            foreach (DataRow database in databases.Rows)
            {
                result.Add(database.Field<string>("database_name"));
            }

            x.Close();

            return result;
        }

        public bool CriarBases(string nome, string connStr)
        {
            try
            {
                using (var sqlConn = new SqlConnection(connStr))
                {
                    using (var createDbCmd = sqlConn.CreateCommand())
                    {
                        createDbCmd.CommandText = "CREATE DATABASE " + nome;
                        sqlConn.Open();
                        createDbCmd.ExecuteNonQuery();
                        createDbCmd.CommandText = "CREATE DATABASE " + nome + "Log";
                        createDbCmd.ExecuteNonQuery();
                        sqlConn.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
