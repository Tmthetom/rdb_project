using Laptop_Database.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Hardware
{
    class Laptop
    {
        public String serial { get; set; }
        public Display display { get; set; }
        public CPU cpu { get; set; }
        public RAM ram { get; set; }
        public OS os { get; set; }
        public HDD hdd { get; set; }
        public GPU gpu { get; set; }
        public String color { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int depth { get; set; }
        public int weight { get; set; }

        public Laptop(String serial, Display display, CPU cpu,
            RAM ram, OS os, HDD hdd, GPU gpu, String color,
            int height, int width, int depth, int weight)
        {
            this.serial = serial;
            this.display = display;
            this.cpu = cpu;
            this.ram = ram;
            this.os = os;
            this.hdd = hdd;
            this.gpu = gpu;
            this.color = color;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.weight = weight;
        }
    }
}
