using Arquitetura.OOP._1_Base;
using System;

namespace Arquitetura.OOP._2_Heranca
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }

    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "João",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                DataAdmissao = Convert.ToDateTime("2010/01/01"),
                Registro = "123451234"
            };
        }
    }
}
