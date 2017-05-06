using Laptop_Database.Hardware;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Laptop_Database.DataParser
{
    class XML
    {
        public static List<Laptop> Parse(String path) {
            List<Laptop> laptopList = new List<Laptop>();
            XmlDocument document = new XmlDocument();
            document.Load(path);
            XmlElement root = document.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("computer");
            foreach (XmlNode node in nodes)
            {
                String serial = node.SelectSingleNode("serial").InnerText;
                double screen = double.Parse(node.SelectSingleNode("screen").InnerText, CultureInfo.InvariantCulture);
                String resolution = node.SelectSingleNode("resolution").InnerText;
                String resolution_code = node.SelectSingleNode("resolution_code").InnerText;
                String cpu = node.SelectSingleNode("cpu").InnerText;
                int cores = Convert.ToInt32(node.SelectSingleNode("cores").InnerText);
                String ram = node.SelectSingleNode("ram").InnerText;
                double ram_type = double.Parse(node.SelectSingleNode("ram_type").InnerText, CultureInfo.InvariantCulture);
                int ram_capacity = Convert.ToInt32(node.SelectSingleNode("ram_capacity").InnerText);
                String os = node.SelectSingleNode("os").InnerText;
                int hdd = Convert.ToInt32(node.SelectSingleNode("hdd").InnerText);
                String hdd_type = node.SelectSingleNode("hdd_type").InnerText;
                String gpu = node.SelectSingleNode("gpu").InnerText;
                String color = node.SelectSingleNode("color").InnerText;
                int height = Convert.ToInt32(node.SelectSingleNode("height").InnerText);
                int width = Convert.ToInt32(node.SelectSingleNode("width").InnerText);
                int depth = Convert.ToInt32(node.SelectSingleNode("depth").InnerText);
                int weight = Convert.ToInt32(node.SelectSingleNode("weight").InnerText);

                laptopList.Add(new Laptop(serial,
                    new Display(screen, resolution, resolution_code),
                    new CPU(cpu, cores), new RAM(ram, ram_type, ram_capacity),
                    new OS(os), new HDD(hdd, hdd_type), new GPU(gpu),
                    color, height, width, depth, weight));
            }
            return laptopList;
        }
    }
}
