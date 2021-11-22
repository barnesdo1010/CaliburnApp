using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnApp.Models
{
    class BagHouseModel
    {
        public int BagHouseRecID { get; set; }
        public string StationID { get; set; }
        public double PSIDifferential { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }

    }
}
