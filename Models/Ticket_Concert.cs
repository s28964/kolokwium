using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Models;

[Table("Ticket_Concert")]
public class Ticket_Concert
{
    [Key]
    public int TicketConcertId { get; set; }
    
    [ForeignKey(nameof(Ticket))]
    public int TicketId { get; set; }
    
    
    [ForeignKey(nameof(Concert))]
    public int ConcertId { get; set; }
    
    [Column(TypeName = "decimal")]
    [Precision(10, 2)]
    public decimal Price { get; set; }
    
    public Ticket ticket { get; set; }
    
    public Concert concert { get; set; }

    public ICollection<Purchased_Ticket> PurchasedTicket { get; set; } = null!;
}