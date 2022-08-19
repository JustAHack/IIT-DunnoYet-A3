using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using TiMePrototype.Application.DTOs.Common;

namespace TiMePrototype.Application.DTOs.Shift;

public class CreateShiftDto : BaseDto
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public decimal HourlyRate { get; set; }
}
