namespace Exercicios_interface
{
    public class GeradordeExtratosBase
    {
        public void GerarExtrato(Iconta c)
        {
            double v = c.GetSaldo();
        }
    }
}