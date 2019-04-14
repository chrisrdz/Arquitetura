namespace Arquitetura.OOP._3_Abstracao
{
    public abstract class Eletrodomestico
    {
        public readonly string _nome;
        public readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();

    }
}
