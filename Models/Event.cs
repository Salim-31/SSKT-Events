
namespace SSKT_Events.Models;

public class Event
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string EventType { get; set; } = string.Empty;

    public DateTime EventDate { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string Location { get; set; } = string.Empty;

    public decimal Budget { get; set; }

    public string Status { get; set; } = "Planning";

    public int ClientId { get; set; }

    public ApplicationUser? Client { get; set; }
}
