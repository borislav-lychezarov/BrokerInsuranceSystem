using DatabaseModels.Models.User;
using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels.Models.CarInsurances
{
    public class Insurance
    {
        public Insurance()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string CarId { get; set; }

        public Car Car { get; set; }

        public bool? IsCanceled { get; set; }

        public string UserId { get; set; }

        public ApplicationUser Creator { get; set; }

        public DateTime CreationDate { get; set; }


    }
}
