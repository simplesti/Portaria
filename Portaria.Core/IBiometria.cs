namespace Portaria.Core
{
    public interface IBiometria
    {
        string Nome { get; set; }
        byte[] Biometria { get; set; }
    }
}
