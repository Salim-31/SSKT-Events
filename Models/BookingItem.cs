
namespace SSKT_Events.Models;

public class BookingItem
{
    public int Id { get; set; }

    public int BookingId { get; set; }

    public Booking? Booking { get; set; }

    public int ServiceId { get; set; }

    public Service? Service { get; set; }

    public int Quantity { get; set; } = 1;

    public decimal UnitPrice { get; set; }

    public int? SupplierId { get; set; }

    public Supplier? Supplier { get; set; }

    public string Status { get; set; } = "Pending";
}
