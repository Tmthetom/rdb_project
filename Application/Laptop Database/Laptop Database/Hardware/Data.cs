using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Hardware
{
    class Data
    {
        public String serial { get; set; }
        public String screen { get; set; }
        public String resolution { get; set; }
        public String resolution_code { get; set; }
        public String cpu { get; set; }
        public String cores { get; set; }
        public String ram { get; set; }
        public String ram_type { get; set; }
        public String ram_capacity { get; set; }
        public String os { get; set; }
        public String hdd { get; set; }
        public String hdd_type { get; set; }
        public String gpu { get; set; }
        public String color { get; set; }
        public String height { get; set; }
        public String width { get; set; }
        public String depth { get; set; }
        public String weight { get; set; }
        public Data(String serial, String screen, String resolution,
            String resolution_code, String cpu, String cores, String ram,
            String ram_type, String ram_capacity, String os, String hdd,
            String hdd_type, String gpu, String color, String height,
            String width, String depth, String weight)
        {
            this.serial = serial;
            this.screen = screen;
            this.resolution = resolution;
            this.resolution_code = resolution_code;
            this.cpu = cpu;
            this.cores = cores;
            this.ram = ram;
            this.ram_type = ram_type;
            this.ram_capacity = ram_capacity;
            this.os = os;
            this.hdd = hdd;
            this.hdd_type = hdd_type;
            this.gpu = gpu;
            this.color = color;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.weight = weight;
        }
    }

    class DataRoot
    {
        public List<Data> data { get; set; }
    }
}
