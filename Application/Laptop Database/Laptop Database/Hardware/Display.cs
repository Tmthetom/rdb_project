using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laptop_Database.Hardware
{
    public class Display
    {
        public double diagonal { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public String label { get; set; }
        public Display(double diagonal, String resolution, String label)
        {
            int[] widthHeight = ParseResolution(resolution);
            this.diagonal = diagonal;
            this.width = widthHeight[0];
            this.height = widthHeight[1];
            this.label = label;
        }
        public static int[] ParseResolution(String resolution)
        {
            int[] widthHeight = new int[2];
            Regex regex = new Regex(@"([0-9]+)");
            MatchCollection matches = regex.Matches(resolution);
            widthHeight[0] = Convert.ToInt32(matches[0].Groups[1].Value);
            widthHeight[1] = Convert.ToInt32(matches[1].Groups[1].Value);
            return widthHeight;
        }
    }
}
