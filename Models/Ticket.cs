using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Models;

[Table("Ticket")]
public class Ticket
{
    [Key]
    public int TicketId { get; set; }

    [MaxLength(50)] 
    public string SerialNumber { get; set; } = null!;
    
    public int SeatNumber { get; set; }

    public ICollection<Ticket_Concert> TicketConcerts { get; set; } = null!;
}