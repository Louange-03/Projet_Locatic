using Locatic.Entities;

namespace Locatic.Services.Interfaces;

public interface IReservationService
{
    Task<IEnumerable<Reservation>> GetAllAsync();
    Task CreateAsync(Reservation reservation);
}