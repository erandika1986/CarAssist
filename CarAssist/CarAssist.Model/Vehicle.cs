using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssist.Model
{
    public class Vehicle
    {
        public long Id { get; set; }
        public long OwnerId { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string RegistrationNo { get; set; }
        public string RegistrationPhoto { get; set; }
        public long Year { get; set; }
        public int VehicleTypeId { get; set; }
        public int FeulId { get; set; }
        public int BrandId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
