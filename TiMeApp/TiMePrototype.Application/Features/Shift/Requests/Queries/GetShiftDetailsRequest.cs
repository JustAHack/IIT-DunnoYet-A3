using MediatR;
using TiMePrototype.Application.DTOs.Shift;

namespace TiMePrototype.Application.Features.Shift.Requests.Queries;

public class GetShiftDetailsRequest : IRequest<UpdateShiftDto>
{
    public int Id { get; set; }
}
