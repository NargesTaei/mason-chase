using Domain.IRepository;
using Model;
using Model.Authentication;

namespace BussinessLogic.Authentication
{
    public class CustomerBL : ICustomerBL
    {
        private readonly ICustomerRepository _userRepository;
        public CustomerBL(ICustomerRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public BaseResponse<bool> CreateCustomer(CreateCustomerDto request)
        {
            var user = _userRepository.GetSingleBy(u => u.Email == request.Email).Result;
            if (user != null)
            {
                return new BaseResponse<bool>() { Success = false, ErrorMessage = "Email is duplicate!" };
            }
            _userRepository.Create(request);
            _userRepository.Save();
            return new BaseResponse<bool>() { Success = true, Data = true };
        }
    }
}
