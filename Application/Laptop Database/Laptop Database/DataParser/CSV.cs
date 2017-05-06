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
                    String screen = fields[1];
                    String resolution = fields[2];
                    String resolution_code = fields[3];
                    String cpu = fields[4];
                    String cores = fields[5];
                    String ram = fields[6];
                    String ram_type = fields[7];
                    String ram_capacity = fields[8];
                    String os = fields[9];
                    String hdd = fields[10];
                    String hdd_type = fields[11];
                    String gpu = fields[12];
                    String color = fields[13];
                    String height = fields[14];
                    String width = fields[15];
                    String depth = fields[16];
                    String weight = fields[17];

                    Data raw = new Data(serial, screen, resolution,
                resolution_code, cpu, cores, ram,
                ram_type, ram_capacity, os, hdd,
                hdd_type, gpu, color, height,
                width, depth, weight);

                    laptopList.Add(new Laptop(raw));
                }
            }
            return laptopList;
        }
    }
}
