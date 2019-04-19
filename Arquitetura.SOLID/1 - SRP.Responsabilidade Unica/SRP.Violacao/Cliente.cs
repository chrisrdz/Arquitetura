using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Arquitetura.SOLID.SRP.Violacao
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "Email Invalido";
            if (CPF.Length != 11)
                return "CPF Inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "connectionstring";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into clientes values ({nome}, {email}, {cpf}, {dataCadastro})";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("dataCadastro", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();

                var mail = new MailMessage("empresa@empresa.com", Email);
                var client = new SmtpClient
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.google.com"
                };

                mail.Subject = "Bem Vindo!";
                mail.Body = "Parabens! Voce está cadastrado!";

                client.Send(mail);

                return "Cliente cadastrado com sucesso!";
            }
        }
    }
}
