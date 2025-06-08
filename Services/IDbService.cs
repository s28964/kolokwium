using Kolokwium.DTOs;

namespace Kolokwium.Services;

public interface IDbService
{
    Task<GetClientOrdersDto> GetClientOrders(int customerId);
    Task AddCustomerWithTickets(int customerId, AddCustomerWithTicketsDto dto);
}