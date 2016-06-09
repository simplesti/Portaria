using DPUruNet;

namespace Portaria.ControleAcessoBiometrico
{
    public enum TipoBiometria
    {
        Pessoa = 1,
        Funcionario = 2,
        Usuario = 3
    }

    public class IdBiometria
    {
        public int Id { get; set; }

        public string Biometria { get; set; }

        public TipoBiometria Tipo { get; set; }

        public Fmd Fmd
        {
            get
            {
                return Fmd.DeserializeXml(Biometria);
            }
        }
    }
}
