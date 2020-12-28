using DatabaseModels.Models.OwnerType;
using System;

namespace DatabaseModels.Models.CarInsurances
{
    public class OwnerCar
    {
        public OwnerCar()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string CarId { get; set; }

        public Car Car { get; set; }

        public string OwnerId { get; set; }

        public Owner Owner { get; set; }

        public string LegalEntityOwnerId { get; set; }

        public LegalEntityOwner LegalEntityOwner { get; set; }
    }
}
