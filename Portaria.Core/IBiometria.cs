namespace Portaria.Core
{
    public interface IBiometria
    {
        string Nome { get; set; }
        string Biometria { get; set; }
        bool ControleAcessoAutorizado { get; set; }
    }
}
