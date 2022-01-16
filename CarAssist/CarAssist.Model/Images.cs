using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssist.Model
{
    public class Images
    {
        public long  Id { get; set; }
        public long VehicleId { get; set; }
        public int SequenceNo { get; set; }
        public string Image { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

    }
}
