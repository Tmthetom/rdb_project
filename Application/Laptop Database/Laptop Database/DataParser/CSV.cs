using Laptop_Database.Hardware;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.DataParser
{
    class CSV
    {
        public static List<Laptop> Parse(String filePath)
        {
            List<Laptop> laptopList = new List<Laptop>();
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    String serial = fields[0];
                    double screen = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    String resolution = fields[2];
                    String resolution_code = fields[3];
                    String cpu = fields[4];
                    int cores = Convert.ToInt32(fields[5]);
                    String ram = fields[6];
                    double ram_type = double.Parse(fields[7], CultureInfo.InvariantCulture);
                    int ram_capacity = Convert.ToInt32(fields[8]);
                    String os = fields[9];
                    int hdd = Convert.ToInt32(fields[10]);
                    String hdd_type = fields[11];
                    String gpu = fields[12];
                    String color = fields[13];
                    int height = Convert.ToInt32(fields[14]);
                    int width = Convert.ToInt32(fields[15]);
                    int depth = Convert.ToInt32(fields[16]);
                    int weight = Convert.ToInt32(fields[17]);

                    laptopList.Add(new Laptop(serial,
    new Display(screen, resolution, resolution_code),
    new CPU(cpu, cores), new RAM(ram, ram_type, ram_capacity),
    new OS(os), new HDD(hdd, hdd_type), new GPU(gpu),
    color, height, width, depth, weight));
                }
            }
            return laptopList;
        }
    }
}
