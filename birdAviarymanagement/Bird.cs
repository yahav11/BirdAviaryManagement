using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birdAviarymanagement
{
    public class Bird
    {
        public string RingId { get; set; }
        public string Type { get; set; }
        public string ColorMutation { get; set; }
        public int HatchYear { get; set; }
        public string Status { get; set; }
        public bool AvailableForSale { get; set; }

        public Bird(string ringId, string type, string colorMutation, int hatchYear, string status, bool availableForSale)
        {
            RingId = ringId;
            Type = type;
            ColorMutation = colorMutation;
            HatchYear = hatchYear;
            Status = status;
            AvailableForSale = availableForSale;
        }
    }
}
