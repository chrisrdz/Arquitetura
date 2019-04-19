namespace Arquitetura.SOLID.SRP_Solucao
{
    public class ClienteServices
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados Inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            var mail = new EmailServices();
            mail.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabens! Voce está cadastrado!");


            return "Cliente cadastrado com sucesso!";
        }
    }
}
