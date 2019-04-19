using System.Net.Mail;

namespace Arquitetura.SOLID.SRP_Solucao
{
    public class EmailServices
    {
        public static bool IsValid(string email)
        {
            return true;
        }

        public void Enviar(string email, string clienteEmail, string titulo, string body)
        {
            var mail = new MailMessage(email, clienteEmail);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = titulo;
            mail.Body = body;

            client.Send(mail);
        }
    }
}
