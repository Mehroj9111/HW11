using Crm.Entities;

namespace Crm.Services;

public sealed class ClientService
{
    private List<Client> clients;

    public ClientService()
    {
        clients = new List<Client>();
    }

 public void CreateClient(string phone, string email, string password)
    {
        Client newClient = new Client();
        newClient.Phone = phone;
        newClient.Email = email;
        newClient.Password = password;
        
        clients.Add(newClient);
    }


}
   