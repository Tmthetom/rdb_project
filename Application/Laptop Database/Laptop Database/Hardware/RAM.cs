using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Hardware
{
    public class RAM
    {
        public String type { get; set; }
        public double frequency { get; set; }
        public int size { get; set; }
        public RAM(String type, double frequency, int size)
        {
            this.type = type;
            this.frequency = 1000 * frequency;
            this.size = size;
        }
    }
}
