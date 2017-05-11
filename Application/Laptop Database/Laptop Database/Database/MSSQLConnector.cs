using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laptop_Database.Hardware;
using System.Text.RegularExpressions;

namespace Laptop_Database.Database
{
    public class MSSQLConnector : IDBConnector
    {
        private List<bool> messages = new List<bool>();
        private bool multiple = false;
        public override void createConnection()
        {
            if(server.Equals("") || database.Equals(""))
            {
                return;
            }
            string s = @"Server=" + this.server + @";Database=" + this.database + @";Integrated Security=True;";
            this.connection = new SqlConnection(s);
            try
            {
                connection.Open();
                connection.InfoMessage += new SqlInfoMessageEventHandler(Connection_InfoMessage);
                success = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public override void createConnection(string username, string password)
        {
            if (server.Equals("") || database.Equals(""))
            {
                return;
            }
            string s = @"Server=" + this.server + @";Database=" + this.database + @"User Id=" + username + @";Password=" + password + @";";
            this.connection = new SqlConnection(s);
            try
            {
                connection.Open();
                success = true;
            } catch(SqlException ex)
            {
                throw ex;
            }
        }

        public override List<Laptop> get()
        {
            List<Laptop> laptops = new List<Laptop>();
            SqlDataReader reader = null;
            if (success)
            {
                bool[] consistencies;

                Laptop temp_laptop;
                CPU temp_cpu;
                Display temp_display;
                GPU temp_gpu;
                HDD temp_hdd;
                OS temp_os;
                RAM temp_ram;

                SqlCommand comm = new SqlCommand("SELECT producer_code, color, " +
                                                        "width, height,depth, weight, " +
                                                        "display_diagonal, display_width, " +
                                                        "display_height, display_label, " +
                                                        "cpu_type, cpu_cores, ram_type, " +
                                                        "ram_frequency, ram_size, hdd_type, " +
                                                        "hdd_size, os_label, gpu_type, " +
                                                        "display_diagonal_consistency, display_width_consistency, display_height_consistency, display_label_consistency, " +
                                                        "os_label_consistency, gpu_type_consistency, " +
                                                        "cpu_type_consistency, cpu_cores_consistency, " +
                                                        "ram_type_consistency, ram_frequency_consistency, ram_size_consistency, " +
                                                        "hdd_type_consistency, hdd_size_consistency, " +
                                                        "color_consistency, height_consistency, width_consistency, depth_consistency, weight_consistency " +
                                                 "FROM v_notebooks", this.connection);
                reader = comm.ExecuteReader();
                while(reader.Read())
                {
                    temp_display = new Display(Double.Parse("" + reader[6]), reader[7] + " " + reader[8], "" + reader[9]);
                    temp_cpu = new CPU("" + reader[10], Int32.Parse("" + reader[11]));
                    temp_ram = new RAM("" + reader[12], Double.Parse("" + reader[13]), Int32.Parse("" + reader[14]));
                    temp_hdd = new HDD(Int32.Parse("" + reader[16]), "" + reader[15]);
                    temp_os = new OS("" + reader[17]);
                    temp_gpu = new GPU("" + reader[18]);
                    temp_laptop = new Laptop("" + reader[0], temp_display, temp_cpu, temp_ram, temp_os, temp_hdd, 
                        temp_gpu, "" + reader[1], float.Parse("" + reader[3]), float.Parse("" + reader[2]), float.Parse("" + reader[4]), float.Parse("" + reader[5]));

                    consistencies = new bool[18];
                    for(int i = 0; i < consistencies.Length; i++)
                    {
                        consistencies[i] = Boolean.Parse("" + reader[i + 19]);
                    }
                    temp_laptop.consistencies = consistencies;
                    laptops.Add(temp_laptop);
                }
                reader.Close();
                return laptops;
            }
            return null;
        }

        public override List<Laptop> get(string condition)
        {
            List<Laptop> laptops = new List<Laptop>();
            SqlDataReader reader = null;
            if (success)
            {
                bool[] consistencies;

                Laptop temp_laptop;
                CPU temp_cpu;
                Display temp_display;
                GPU temp_gpu;
                HDD temp_hdd;
                OS temp_os;
                RAM temp_ram;

                SqlCommand comm = new SqlCommand("SELECT producer_code, color, " +
                                                        "width, height,depth, weight, " +
                                                        "display_diagonal, display_width, " +
                                                        "display_height, display_label, " +
                                                        "cpu_type, cpu_cores, ram_type, " +
                                                        "ram_frequency, ram_size, hdd_type, " +
                                                        "hdd_size, os_label, gpu_type, " +
                                                        "display_diagonal_consistency, display_width_consistency, display_height_consistency, display_label_consistency, " +
                                                        "os_label_consistency, gpu_type_consistency, " +
                                                        "cpu_type_consistency, cpu_cores_consistency, " +
                                                        "ram_type_consistency, ram_frequency_consistency, ram_size_consistency, " +
                                                        "hdd_type_consistency, hdd_size_consistency, " +
                                                        "color_consistency, height_consistency, width_consistency, depth_consistency, weight_consistency " +
                                                 "FROM v_notebooks WHERE " + condition, this.connection);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    temp_display = new Display(Double.Parse("" + reader[6]), reader[7] + " " + reader[8], "" + reader[9]);
                    temp_cpu = new CPU("" + reader[10], Int32.Parse("" + reader[11]));
                    temp_ram = new RAM("" + reader[12], Double.Parse("" + reader[13]), Int32.Parse("" + reader[14]));
                    temp_hdd = new HDD(Int32.Parse("" + reader[16]), "" + reader[15]);
                    temp_os = new OS("" + reader[17]);
                    temp_gpu = new GPU("" + reader[18]);
                    temp_laptop = new Laptop("" + reader[0], temp_display, temp_cpu, temp_ram, temp_os, temp_hdd,
                        temp_gpu, "" + reader[1], float.Parse("" + reader[3]), float.Parse("" + reader[2]), 
                        float.Parse("" + reader[4]), float.Parse("" + reader[5]));

                    consistencies = new bool[18];
                    for (int i = 0; i < consistencies.Length; i++)
                    {
                        consistencies[i] = Boolean.Parse("" + reader[i + 19]);
                    }
                    temp_laptop.consistencies = consistencies;
                    laptops.Add(temp_laptop);
                }
                reader.Close();
            }
            reader.Close();
            return laptops;
        }

        public override List<bool> insert(List<Laptop> laptops, string hash)
        {
            messages.Clear();
            multiple = true;
            foreach(Hardware.Laptop laptop in laptops)
            {
                insert(laptop, hash);
            }
            multiple = false;
            return messages;
        }

        public override List<bool> insert(Laptop laptop, string hash)
        {
            if (!multiple)
            {
                messages.Clear();
            }
            SqlCommand comm = new SqlCommand("INSERT INTO v_notebooks([hash],[producer_code],[color],[width],[height],"+
                                                                     "[depth],[weight],[display_diagonal],[display_width],"+
                                                                     "[display_height],[display_label],[cpu_type],[cpu_cores],"+
                                                                     "[ram_type],[ram_frequency],[ram_size],[hdd_type],[hdd_size],"+
                                                                     "[os_label],[gpu_type]) VALUES (@hash,@serial,@color,@width,"+
                                                                     "@height,@depth,@weight,@display_diagonal,@display_width,"+
                                                                     "@display_height,@display_label,@cpu_type,@cpu_cores,"+
                                                                     "@ram_type,@ram_frequency,@ram_size,@hdd_type,@hdd_size,"+
                                                                     "@os_label,@gpu_type)", connection);
            comm.Parameters.AddWithValue("@hash",hash);
            comm.Parameters.AddWithValue("@serial",laptop.serial);
            comm.Parameters.AddWithValue("@color",laptop.color);
            comm.Parameters.AddWithValue("@width",laptop.width);
            comm.Parameters.AddWithValue("@height",laptop.height);
            comm.Parameters.AddWithValue("@depth",laptop.depth);
            comm.Parameters.AddWithValue("@weight",laptop.weight);
            comm.Parameters.AddWithValue("@display_diagonal",laptop.display.diagonal);
            comm.Parameters.AddWithValue("@display_width",laptop.display.width);
            comm.Parameters.AddWithValue("@display_height",laptop.display.height);
            comm.Parameters.AddWithValue("@display_label",laptop.display.label);
            comm.Parameters.AddWithValue("@cpu_type",laptop.cpu.type);
            comm.Parameters.AddWithValue("@cpu_cores",laptop.cpu.number_cores);
            comm.Parameters.AddWithValue("@ram_type",laptop.ram.type);
            comm.Parameters.AddWithValue("@ram_frequency",laptop.ram.frequency);
            comm.Parameters.AddWithValue("@ram_size",laptop.ram.size);
            comm.Parameters.AddWithValue("@hdd_type",laptop.hdd.type);
            comm.Parameters.AddWithValue("@hdd_size",laptop.hdd.size);
            comm.Parameters.AddWithValue("@os_label",laptop.os.label);
            comm.Parameters.AddWithValue("@gpu_type",laptop.gpu.type);
            comm.ExecuteNonQuery();
            return messages;
        }

        public override void insertPattern(string pattern)
        {
            SqlCommand comm = new SqlCommand("INSERT INTO top_search(pattern) VALUES(@pattern)", connection);
            comm.Parameters.AddWithValue("@pattern", pattern);
            comm.ExecuteNonQuery();
        }

        public override List<string> getTopPattern(int numberOfPatterns)
        {
            if(numberOfPatterns < 1) {
                return null;
            }
            if(!success) {
                return null;
            }
            List<string> patterns = new List<string>(numberOfPatterns);
            SqlCommand comm = new SqlCommand("SELECT TOP " + numberOfPatterns + " pattern FROM top_search ORDER BY count DESC", connection);
            SqlDataReader reader = comm.ExecuteReader();
            while(reader.Read()) {
                patterns.Add("" + reader[0]);
            }
            reader.Close();
            return patterns;
        }

        void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            Regex regex = new Regex("(.*?):(.*?)$");
            Match match = regex.Match(e.Message);
            messages.Add(Int32.Parse(match.Groups[2].Value) > 0);
        }

        public override Dictionary<string, int> getMaxValues()
        {
            if(!success)
            {
                return null;
            }
            Dictionary<string, int> maxValues = new Dictionary<string, int>();
            SqlCommand comm = new SqlCommand("SELECT MAX([width]),MAX([height]),MAX([depth]),MAX([weight]),MAX([display_width]),MAX([display_height]),MAX([ram_size]) FROM v_notebooks", connection);
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();

            maxValues.Add("width", Int32.Parse("" + reader[0]));
            maxValues.Add("height", Int32.Parse("" + reader[1]));
            maxValues.Add("depth", Int32.Parse("" + reader[2]));
            maxValues.Add("weight", Int32.Parse("" + reader[3]));
            maxValues.Add("display_width", Int32.Parse("" + reader[4]));
            maxValues.Add("display_height", Int32.Parse("" + reader[5]));
            maxValues.Add("ram_size", Int32.Parse("" + reader[6]));

            reader.Close();
            return maxValues;
        }

        public override Dictionary<string, List<string>> getDistinctValues()
        {
            if(!success)
            {
                return null;
            }
            Dictionary<string, List<string>> values = new Dictionary<string, List<string>>();
            values.Add("color", new List<string>());
            values.Add("display_label", new List<string>());
            values.Add("cpu_type", new List<string>());
            values.Add("ram_type", new List<string>());
            values.Add("hdd_type", new List<string>());
            values.Add("os_label", new List<string>());
            values.Add("gpu_type", new List<string>());

            SqlCommand comm;
            SqlDataReader reader;

            foreach(string key in values.Keys)
            {
                comm = new SqlCommand("SELECT distinct(" + key + ") FROM v_notebooks", connection);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    values[key].Add("" + reader[0]);
                }
                reader.Close();
            }
            return values;
        }

        public override bool wasImported(string hash)
        {
            SqlCommand comm = new SqlCommand("SELECT count(hash) FROM imported_files WHERE hash = @hash", connection);
            comm.Parameters.AddWithValue("@hash", hash);
            SqlDataReader reader = comm.ExecuteReader();
            reader.Read();
            bool result = Int32.Parse("" + reader[0]) > 0;
            reader.Close();
            return result;
        }
    }
}
