using Arquitetura.OOP._3_Abstracao;

namespace Arquitetura.OOP._4_Polimorfismo
{
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem) :base(nome,voltagem)
        {
        }

        public CafeteiraExpressa() :base("Padrao", 220)
        {
        }

        private static void AquecerAgua()
        {

        }

        private static void MoerGraos()
        {

        }

        public void FazerCafe()
        {
            AquecerAgua();
            MoerGraos();
            //...
        }

        public override void Desligar()
        {
            //Verificar se tem agua 
        }

        public override void Ligar()
        {
            //resfriar aquecedor
        }
    }
}
