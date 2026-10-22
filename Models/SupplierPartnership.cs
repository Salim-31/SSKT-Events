
namespace SSKT_Events.Models;

public class SupplierPartnership
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public Supplier? Supplier { get; set; }

    public int EventOrganizerId { get; set; }

    public ApplicationUser? EventOrganizer { get; set; }

    public DateTime PartnershipDate { get; set; } = DateTime.Now;

    public bool IsActive { get; set; } = true;
}
