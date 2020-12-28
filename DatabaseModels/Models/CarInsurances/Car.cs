using DatabaseModels.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels.Models.CarInsurances
{
    public class Car
    {
        public Car()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Insurances = new List<Insurance>();
            this.Owners = new List<OwnerCar>();
        }

        public string Id { get;  set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        public decimal Power { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string RegistrationPlate { get; set; }

        [Required]
        [MaxLength(17)]
        public string Vin { get; set; }

        public VehicleType VehicleType { get; set; }


        public EngineType EngineType { get; set; }

        public ICollection<Insurance> Insurances { get; set; }

        public ICollection<OwnerCar> Owners { get; set; }



    }
}
