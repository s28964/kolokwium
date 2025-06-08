using Kolokwium.Models;

namespace Kolokwium.DTOs;

public class GetClientOrdersDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public List<ClientOrderDto> ClientOrderDtos { get; set; } = null!;
}

public class ClientOrderDto
{
    public DateTime Date { get; set; }
    
    public decimal Price { get; set; }
    
}