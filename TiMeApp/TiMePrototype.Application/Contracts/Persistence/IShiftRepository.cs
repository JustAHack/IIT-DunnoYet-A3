using TiMePrototype.Domain;

namespace TiMePrototype.Application.Contracts.Persistence;

public interface IShiftRepository : IGenericRepository<Shift>
{
    public Task<IReadOnlyList<Shift>> GetUsersShifts(int userId);
}
