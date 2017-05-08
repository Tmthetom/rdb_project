using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Hardware
{
    public class CPU
    {
        public String type { get; set; }
        public int number_cores { get; set; }
        public CPU(String type, int number_cores)
        {
            this.type = type;
            this.number_cores = number_cores;
        }
    }
}
