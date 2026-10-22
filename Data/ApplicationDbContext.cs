
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSKT_Events.Models;

namespace SSKT_Events.Data;

public class ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext(options)
{
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public DbSet<Event> Events { get; set; }

    public DbSet<Supplier> Suppliers { get; set; }

    public DbSet<Service> Services { get; set; }

    public DbSet<Package> Packages { get; set; }

    public DbSet<PackageService> PackageServices { get; set; }

    public DbSet<SupplierPartnership> SupplierPartnerships { get; set; }

    public DbSet<Booking> Bookings { get; set; }

    public DbSet<BookingItem> BookingItems { get; set; }

    public DbSet<Payment> Payments { get; set; }
}
