using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels.Models.PropertyInsurances
{
    public class House
    {
        public House()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }



    }
}
