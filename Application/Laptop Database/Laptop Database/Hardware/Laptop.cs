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
        public float height { get; set; }
        public float width { get; set; }
        public float depth { get; set; }
        public float weight { get; set; }

        /// <summary>
        /// Format: 
        /// color, width, height, depth, weight, 
        /// display_diagonal, display_width, display_height, display_label, 
        /// cpu_type, cpu_cores, 
        /// ram_type, ram_frequency, ram_size, 
        /// hdd_type, hdd_size, 
        /// os_label, 
        /// gpu_type
        /// </summary>
        public bool[] consistencies { get; set; }
        public bool consistency
        {
            get
            {
                for (int i = 0; i < consistencies.Length; i++)
                {
                    if (consistencies[i]) {
                        return true;
                    }
                }
                return false;
            }
        }

        public Laptop(String serial, Display display, CPU cpu,
            RAM ram, OS os, HDD hdd, GPU gpu, String color,
            float height, float width, float depth, float weight)
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
