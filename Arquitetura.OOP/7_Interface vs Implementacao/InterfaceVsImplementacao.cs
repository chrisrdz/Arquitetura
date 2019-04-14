using System;

namespace Arquitetura.OOP._7_Interface_vs_Implementacao
{
    public interface IRepositorio
    {
        void Adcionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adcionar()
        {
            //adicionar
            throw new NotImplementedException();
        }
    }
    //1:50
    public class Implementacao
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adcionar();
        }
    }

    public class Abstracao
    {
        private readonly IRepositorio _repositorio;

        public Abstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adcionar();
        }
    }
}
