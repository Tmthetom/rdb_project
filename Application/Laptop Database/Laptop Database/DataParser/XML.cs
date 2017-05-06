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
        public static List<Laptop> Parse(String filePath)
        {
            List<Laptop> laptopList = new List<Laptop>();
            XmlDocument document = new XmlDocument();
            document.Load(filePath);
            XmlElement root = document.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("computer");
            foreach (XmlNode node in nodes)
            {
                String serial = node.SelectSingleNode("serial").InnerText;
                String screen = node.SelectSingleNode("screen").InnerText;
                String resolution = node.SelectSingleNode("resolution").InnerText;
                String resolution_code = node.SelectSingleNode("resolution_code").InnerText;
                String cpu = node.SelectSingleNode("cpu").InnerText;
                String cores = node.SelectSingleNode("cores").InnerText;
                String ram = node.SelectSingleNode("ram").InnerText;
                String ram_type = node.SelectSingleNode("ram_type").InnerText;
                String ram_capacity = node.SelectSingleNode("ram_capacity").InnerText;
                String os = node.SelectSingleNode("os").InnerText;
                String hdd = node.SelectSingleNode("hdd").InnerText;
                String hdd_type = node.SelectSingleNode("hdd_type").InnerText;
                String gpu = node.SelectSingleNode("gpu").InnerText;
                String color = node.SelectSingleNode("color").InnerText;
                String height = node.SelectSingleNode("height").InnerText;
                String width = node.SelectSingleNode("width").InnerText;
                String depth = node.SelectSingleNode("depth").InnerText;
                String weight = node.SelectSingleNode("weight").InnerText;

                Data raw = new Data(serial, screen, resolution,
            resolution_code, cpu, cores, ram,
            ram_type, ram_capacity, os, hdd,
            hdd_type, gpu, color, height,
            width, depth, weight);

                laptopList.Add(new Laptop(raw));
            }
            return laptopList;
        }
    }
}
