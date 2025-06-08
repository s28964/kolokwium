using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Models;

[Table("Purchased_Ticket")]
[PrimaryKey(nameof(Ticket_ConcertId), nameof(CustomerId))]
public class Purchased_Ticket
{
    [ForeignKey(nameof(Ticket_Concert))]
    public int Ticket_ConcertId { get; set; }
    
    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    
    public DateTime PurchaseDate { get; set; }

    public Ticket_Concert Ticket_Concert { get; set; } = null!;
    
    public Customer Customer { get; set; } = null!;
}