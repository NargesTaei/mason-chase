using Domain.Entities;
using Model.Authentication;

namespace Domain.IRepository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer Create(CreateCustomerDto createCustomerDto);
    }
}
