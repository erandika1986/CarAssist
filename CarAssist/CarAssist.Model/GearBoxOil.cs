using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssist.Model
{
    public class GearBoxOil
    {
        public long Id { get; set; }
        public decimal ChangeMilage { get; set; }
        public DateTime ChangedOn { get; set; }
        public decimal NextChangeMilage { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
