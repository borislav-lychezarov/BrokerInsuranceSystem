using System.ComponentModel.DataAnnotations;

namespace BrokerInsuranceSystem.Areas.TheBoss.Models
{
    public class CreateUserModelDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

    }
}
