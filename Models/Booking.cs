
namespace SSKT_Events.Models;

public class Booking
{
    public int Id { get; set; }

    public DateTime BookedOn { get; set; } = DateTime.Now;

    public string Status { get; set; } = "Pending";

    public string PaymentOption { get; set; } = "FullPayment";

    public string? SpecialRequests { get; set; }

    public int EventId { get; set; }

    public Event? Event { get; set; }

    public int EventOrganizerId { get; set; }

    public ApplicationUser? EventOrganizer { get; set; }

    public int? PackageId { get; set; }

    public Package? Package { get; set; }

    public List<BookingItem> Items { get; set; } = new();

    public List<Payment> Payments { get; set; } = new();
}
