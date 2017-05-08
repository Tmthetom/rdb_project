using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Hardware
{
    public class GPU
    {
        public String type { get; set; }
        public GPU(String type)
        {
            this.type = type;
        }
    }
}
