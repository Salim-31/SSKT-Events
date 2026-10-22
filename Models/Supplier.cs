
namespace SSKT_Events.Models;

public class Supplier
{
    public int Id { get; set; }

    public string BusinessName { get; set; } = string.Empty;

    public string ContactPerson { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ContactNumber { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
}
