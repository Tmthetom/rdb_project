using Laptop_Database.Hardware;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public Laptop(Data raw)
        {
            this.serial = raw.serial;
            this.display = new Display(double.Parse(raw.screen, CultureInfo.InvariantCulture),
                raw.resolution, raw.resolution_code);
            this.cpu = new CPU(raw.cpu, Convert.ToInt32(raw.cores));
            this.ram = new RAM(raw.ram, double.Parse(raw.ram_type, CultureInfo.InvariantCulture),
                Convert.ToInt32(raw.ram_capacity));
            this.os = new OS(raw.os);
            this.hdd = new HDD(Convert.ToInt32(raw.hdd), raw.hdd_type);
            this.gpu = new GPU(raw.gpu);
            this.color = raw.color;
            this.height = Convert.ToInt32(raw.height);
            this.width = Convert.ToInt32(raw.width);
            this.depth = Convert.ToInt32(raw.depth);
            this.weight = Convert.ToInt32(raw.weight);
        }

    }
}
