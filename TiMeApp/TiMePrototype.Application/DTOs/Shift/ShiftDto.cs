using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiMePrototype.Application.DTOs.Common;

namespace TiMePrototype.Application.DTOs.Shift
{
    public class ShiftDto : BaseDto
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
