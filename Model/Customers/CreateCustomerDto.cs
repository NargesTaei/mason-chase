using System.ComponentModel.DataAnnotations;

namespace Model.Authentication
{
    public class CreateCustomerDto
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public DateTime DateOfBirth { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
