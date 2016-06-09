using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Portaria.RPi.Api
{
    public class RPiControleAcesso : IDisposable
    {
        private string endpoint;
        private int tempo;
        private HttpClient client;

        public RPiControleAcesso(string apiEndpoint, int tempoLiberacao = 3)
        {
            client = new HttpClient();
            tempo = tempoLiberacao;
            endpoint = apiEndpoint;
        }

        public void Dispose()
        {
            client.Dispose();
        }

        public bool LiberarAcesso()
        {
            try
            {
                var data = new { chave = "cor741tir852", tempoLiberacao = tempo };

                var response = client.PostAsync(endpoint, new StringContent(
                JsonConvert.SerializeObject(data),
                Encoding.UTF8,
                "application/json")).Result;

                var result = response.Content.ReadAsStringAsync().Result;

                var retorno = JsonConvert.DeserializeObject<dynamic>(result);

                return bool.Parse((string)retorno.Sucesso);
            }
            catch
            {
                return false;
            }
        }

        public bool Status
        {
            get
            {
                return RetornaStatusEndPoint();
            }
        }

        private bool RetornaStatusEndPoint()
        {
            try
            {
                var response = client.GetAsync(endpoint).Result;

                var result = response.Content.ReadAsStringAsync().Result;

                var retorno = JsonConvert.DeserializeObject<dynamic>(result);

                return bool.Parse((string)retorno.Liberado);
            }
            catch
            {
                return false;
            }
        }
    }
}
