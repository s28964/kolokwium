using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Models;

[Table("Customer")]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [MaxLength(50)] public string FirstName { get; set; } = null!;
    
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    
    [MaxLength(100)]
    public string? PhoneNumber { get; set; }
    
    public ICollection<Purchased_Ticket> PurchasedTicket { get; set; } = null!;
}