using System.ComponentModel.DataAnnotations;
namespace Crm.Entities;

public class Client
{
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}
