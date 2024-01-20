using BussinessLogic.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Authentication;

namespace Mc2.CrudTest.Presentation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CustomerController : ControllerBase
    {
     

        private readonly ICustomerBL _costomerBl;

        public CustomerController(ICustomerBL customerBL)
        {
            _costomerBl = customerBL;
        }


        [HttpPost("Create")]
        public IActionResult SendOTPCode([FromBody] CreateCustomerDto request)
        {
            var result =  _costomerBl.CreateCustomer(request);

            if (result.Success) return Ok();

            return BadRequest();
        }

    }
}