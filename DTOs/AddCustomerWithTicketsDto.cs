namespace Kolokwium.DTOs;

public class AddCustomerWithTicketsDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public List<Purchases> Purchases { get; set; } = null!;
}

public class Purchases
{
    public int SeatNumber { get; set; }
    public string ConcertName { get; set; }
    public decimal Price { get; set; }
}