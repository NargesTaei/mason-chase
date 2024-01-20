using Model.Authentication;
using Model;

namespace BussinessLogic.Authentication
{
    public interface ICustomerBL
    {
        BaseResponse<bool> CreateCustomer(CreateCustomerDto request);
    }
}
