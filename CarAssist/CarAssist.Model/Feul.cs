using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssist.Model
{
    public class Feul
    {
        public long Id { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
