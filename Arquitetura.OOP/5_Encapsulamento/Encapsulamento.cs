using Arquitetura.OOP._4_Polimorfismo;

namespace Arquitetura.OOP._5_Encapsulamento
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var expresso = new CafeteiraExpressa();
            expresso.Ligar();
            expresso.FazerCafe();
            expresso.Desligar();
        }
    }
}
