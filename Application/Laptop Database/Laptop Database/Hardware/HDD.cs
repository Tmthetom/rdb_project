using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Hardware
{
    class HDD
    {
        public int size{ get; set; }
        public String type { get; set; }
        public HDD(int size, String type)
        {
            this.size = size;
            this.type = type;
        }
    }
}
