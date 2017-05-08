using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Database
{
    public class DatabaseFilter
    {
        public int? ram { get; set; }
        public int? weightLower { get; set; }
        public int? weightUpper { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public int? depth { get; set; }
        public int? resolutionWidth { get; set; }
        public int? resolutionHeight { get; set; }
        public String cpu { get; set; }
        public bool inconsistent { get; set; }
        public DatabaseFilter(int? ram, int? weightLower, int? weightUpper,
            int? width, int? height, int? depth, int? resolutionWidth,
             int? resolutionHeight, String cpu, bool inconsistent)
        {
            this.ram = ram;
            this.weightLower = weightLower;
            this.weightUpper = weightUpper;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.resolutionWidth = resolutionWidth;
            this.resolutionHeight = resolutionHeight;
            this.cpu = cpu;
            this.inconsistent = inconsistent;
        }

        public DatabaseFilter(String str)
        {
            StringReader sr = new StringReader(str);
            using (TextFieldParser parser = new TextFieldParser(sr))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    this.ram = (fields[0] == "") ? (int?)null : Convert.ToInt32(fields[0]);
                    this.weightLower = (fields[1] == "") ? (int?)null : Convert.ToInt32(fields[1]); 
                    this.weightUpper = (fields[2] == "") ? (int?)null : Convert.ToInt32(fields[2]); 
                    this.width = (fields[3] == "") ? (int?)null : Convert.ToInt32(fields[3]);
                    this.height = (fields[4] == "") ? (int?)null : Convert.ToInt32(fields[4]);
                    this.depth = (fields[5] == "") ? (int?)null : Convert.ToInt32(fields[5]);
                    this.resolutionWidth = (fields[6] == "") ? (int?)null : Convert.ToInt32(fields[7]);
                    this.resolutionHeight = (fields[7] == "") ? (int?)null : Convert.ToInt32(fields[6]);
                    this.cpu = (fields[8] == "") ? null : fields[8]; 
                    this.inconsistent = bool.Parse(fields[9]);
                }
            }
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                ram, weightLower, weightUpper, width, height, depth, resolutionWidth,
                resolutionHeight, cpu, inconsistent);
        }
    }
}
