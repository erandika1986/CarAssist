using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssist.Model
{
    public class Insurance
    {
        public long Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string InsuranceCardImage { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdateOn { get; set; }

    }
}
