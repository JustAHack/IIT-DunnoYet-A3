using TiMePrototype.Domain.Common;

namespace TiMePrototype.Domain;

public class Shift : BaseDomainEntity
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public decimal HourlyRate { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
