
namespace SSKT_Events.Models;

public class PackageService
{
    public int Id { get; set; }

    public int PackageId { get; set; }

    public Package? Package { get; set; }

    public int ServiceId { get; set; }

    public Service? Service { get; set; }
}
