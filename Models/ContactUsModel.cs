using System.ComponentModel.DataAnnotations;

namespace Dynage.Models
{
    public class ContactUsModel
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Message { get; set; }
    }
}