using DatabaseModels.Models.CarInsurances;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels.Models.OwnerType
{
    public class Owner
    {
        public Owner()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Cars = new List<OwnerCar>();
        }

        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public ICollection<OwnerCar> Cars { get; set; }
    }
}
