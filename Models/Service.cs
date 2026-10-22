
namespace SSKT_Events.Models;

public class Service
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int EventOrganizerId { get; set; }

    public ApplicationUser? EventOrganizer { get; set; }

    public bool IsActive { get; set; } = true;
}
