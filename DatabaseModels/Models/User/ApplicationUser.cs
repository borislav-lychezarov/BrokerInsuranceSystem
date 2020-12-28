namespace DatabaseModels.Models.User
{
    using DatabaseModels.Models.CarInsurances;
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Insurances = new List<Insurance>();
        }
        public ICollection<Insurance> Insurances { get; set; }
    }
}
