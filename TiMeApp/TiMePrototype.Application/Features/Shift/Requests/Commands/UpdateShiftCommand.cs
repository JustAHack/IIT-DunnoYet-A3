using MediatR;
using TiMePrototype.Application.DTOs.Shift;
using TiMePrototype.Application.Responses;

namespace TiMePrototype.Application.Features.Shift.Requests.Commands
{
    public class UpdateShiftCommand : IRequest<Unit>
    {
        public UpdateShiftDto ShiftDto { get; set; }
    }
}
