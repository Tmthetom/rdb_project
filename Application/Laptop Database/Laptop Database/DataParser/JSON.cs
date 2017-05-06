using Laptop_Database.Hardware;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.DataParser
{
    class JSON
    {       
        public static List<Laptop> Parse(String filePath)
        {
            List<Laptop> laptopList = new List<Laptop>();
            String json = File.ReadAllText(filePath);
            DataRoot rlr = JsonConvert.DeserializeObject<DataRoot>(json);
            foreach (Data raw in rlr.data) {
                laptopList.Add(new Laptop(raw));
            }
            return laptopList;
        }
    }
}
