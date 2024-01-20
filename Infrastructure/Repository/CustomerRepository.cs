using Domain.Entities;
using Domain.IRepository;
using Infrastructure.DbCore;
using Model.Authentication;

namespace Infrastructure.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(Context context) : base(context)
        {
            _context = context;
        }

        public Customer Create(CreateCustomerDto createCustomerDto)
        {
            Customer customer =  Customer.Create(createCustomerDto.PhoneNumber,createCustomerDto.Email,createCustomerDto.FirstName,createCustomerDto.LastName,createCustomerDto.DateOfBirth,createCustomerDto.BankAccountNumber);
            _context.Add(customer);
            _context.SaveChanges();
            return customer;

        }
    }
}
