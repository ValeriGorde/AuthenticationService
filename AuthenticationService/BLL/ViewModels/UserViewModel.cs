using System.Net.Mail;
using AuthenticationService.BLL.Models;

namespace AuthenticationService.BLL.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(User user)
        {
            FullName = GetFullName(user.FirstName, user.LastName);
            FromRussia = IsFromRussia(user.Email);
        }

        public string GetFullName(string firstName, string lastName)
        {
            return string.Concat(firstName + " " + lastName);
        }

        public bool IsFromRussia(string email)
        {
            MailAddress emailAddress = new MailAddress(email);
            if (emailAddress.Host.Contains(".ru"))
                return true;
            else return false;
        }

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public bool FromRussia { get; set; }
    }
}
