using System.Text.RegularExpressions;

namespace Domain.Entities
{
    public class Customer
    {
      public  Customer() { }
        private Customer(string phoneNumber, string email, string firstName, string lastName, DateTime dateOfBirth, string bankAccountNum)
        {
            PhoneNumber = phoneNumber;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            BankAccountNumber = bankAccountNum;
            DateOfBirth = dateOfBirth;
        }
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get;private set; }
        public string BankAccountNumber { get;private set; }


        public static Customer Create(string phoneNumber, string email, string firstName, string lastName, DateTime dateOfBirth, string bankAccountNum)
        {
            ValidatePhoneNumber(phoneNumber);
            ValidateEmail(email);

            var user = new Customer( phoneNumber,  email,  firstName,  lastName,  dateOfBirth,  bankAccountNum);
            return user;
        }
     
     
        public void Update(string phoneNumber, string email, string firstName, string lastName, DateTime dateOfBirth, string bankAccountNum)
        {
            PhoneNumber = phoneNumber;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            BankAccountNumber = bankAccountNum;
            DateOfBirth = dateOfBirth;
        }

    
        private static void ValidatePhoneNumber(string phoneNumber)
        {

            if (String.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }
            string phoneRegex = @"^0\d{10}$";
            if (!Regex.IsMatch(phoneNumber, phoneRegex))
            {
                throw new ArgumentOutOfRangeException(nameof(phoneNumber));
            }
        }
        private static void ValidateEmail(string email)
        {
            if (String.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(nameof(email));
            }
            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailRegex))
            {
                throw new ArgumentOutOfRangeException(nameof(email));
            }
        }
    }
}
