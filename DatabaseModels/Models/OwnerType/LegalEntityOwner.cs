using DatabaseModels.Models.CarInsurances;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels.Models.OwnerType
{
    public class LegalEntityOwner
    {
        public LegalEntityOwner()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Cars = new List<OwnerCar>();
        }

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public ICollection<OwnerCar> Cars { get; set; }
    }
}
