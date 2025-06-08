using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Purchased_Ticket> PurchasedTickets { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Ticket_Concert> TicketConcerts { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Concert>().HasData(new List<Concert>()
        {
            new Concert()
                { ConcertId = 1, Name = "concert1", Date = DateTime.Parse("2025-06-08"), AvailableTickets = 100 },
            new Concert()
                { ConcertId = 2, Name = "concert2", Date = DateTime.Parse("2025-06-19"), AvailableTickets = 200 },
            new Concert()
                { ConcertId = 3, Name = "concert3", Date = DateTime.Parse("2025-06-30"), AvailableTickets = 300 },
        });

        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer() { CustomerId = 1, FirstName = "John", LastName = "Doe", PhoneNumber = "+12 345 6789" },
            new Customer() { CustomerId = 2, FirstName = "Anna", LastName = "Hawkins", PhoneNumber = "+34 567 8901" },
            new Customer() { CustomerId = 3, FirstName = "Andre", LastName = "Ramos", PhoneNumber = "+56 789 0123" },
        });

        modelBuilder.Entity<Purchased_Ticket>().HasData(new List<Purchased_Ticket>()
        {
            new Purchased_Ticket()
                { Ticket_ConcertId = 1, CustomerId = 1, PurchaseDate = DateTime.Parse("2025-06-07") },
            new Purchased_Ticket()
                { Ticket_ConcertId = 2, CustomerId = 2, PurchaseDate = DateTime.Parse("2025-06-17") },
            new Purchased_Ticket()
                { Ticket_ConcertId = 3, CustomerId = 3, PurchaseDate = DateTime.Parse("2025-06-25") },
        });

        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>()
        {
            new Ticket() { TicketId = 1, SerialNumber = "Serial1", SeatNumber = 1 },
            new Ticket() { TicketId = 2, SerialNumber = "Serial2", SeatNumber = 2 },
            new Ticket() { TicketId = 3, SerialNumber = "Serial3", SeatNumber = 3 },
        });

        modelBuilder.Entity<Ticket_Concert>().HasData(new List<Ticket_Concert>()
        {
            new Ticket_Concert() { TicketConcertId = 1, TicketId = 1, ConcertId = 1, Price = 100 },
            new Ticket_Concert() { TicketConcertId = 2, TicketId = 2, ConcertId = 2, Price = 200 },
            new Ticket_Concert() { TicketConcertId = 3, TicketId = 3, ConcertId = 3, Price = 300 },
        });
    }
}