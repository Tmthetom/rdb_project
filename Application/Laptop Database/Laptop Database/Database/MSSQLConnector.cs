using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laptop_Database.Hardware;

namespace Laptop_Database.Database
{
    class MSSQLConnector : IDBConnector
    {
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

        public override Dictionary<Laptop, bool[]> get()
        {
            Dictionary<Laptop, bool[]> laptops = new Dictionary<Laptop, bool[]>();
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

                SqlCommand comm = new SqlCommand("SELECT producer_code, color, "+
                                                        "width, height,depth, weight, "+
                                                        "display_diagonal, display_width, "+
                                                        "display_height, display_label, "+
                                                        "cpu_type, cpu_cores, ram_type, "+
                                                        "ram_frequency, ram_size, hdd_type, "+
                                                        "hdd_size, os_label, gpu_type, color_consistency, "+
                                                        "width_consistency, height_consistency, depth_consistency, "+
                                                        "weight_consistency, display_diagonal_consistency, "+
                                                        "display_width_consistency, display_height_consistency, "+
                                                        "display_label_consistency, cpu_type_consistency, "+
                                                        "cpu_cores_consistency, ram_type_consistency, ram_frequency_consistency, "+
                                                        "ram_size_consistency, hdd_type_consistency, hdd_size_consistency, "+
                                                        "os_label_consistency, gpu_type_consistency "+
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

                    laptops.Add(temp_laptop, consistencies);
                }
                reader.Close();
                return laptops;
            }
            return null;
        }

        public override Dictionary<Laptop, bool[]> get(string condition)
        {
            Dictionary<Laptop, bool[]> laptops = new Dictionary<Laptop, bool[]>();
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
                                                        "hdd_size, os_label, gpu_type, color_consistency, " +
                                                        "width_consistency, height_consistency, depth_consistency, " +
                                                        "weight_consistency, display_diagonal_consistency, " +
                                                        "display_width_consistency, display_height_consistency, " +
                                                        "display_label_consistency, cpu_type_consistency, " +
                                                        "cpu_cores_consistency, ram_type_consistency, ram_frequency_consistency, " +
                                                        "ram_size_consistency, hdd_type_consistency, hdd_size_consistency, " +
                                                        "os_label_consistency, gpu_type_consistency " +
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

                    laptops.Add(temp_laptop, consistencies);
                }

                SqlCommand comm2 = new SqlCommand("INSERT INTO top_search(pattern) VALUES(@pattern)", connection);
                comm2.Parameters.Add("@pattern", condition);
                comm2.ExecuteNonQuery();
            }
            reader.Close();
            return laptops;
        }

        public override void insert(List<Laptop> laptops, string hash)
        {
            foreach(Hardware.Laptop laptop in laptops)
            {
                insert(laptop, hash);
            }
        }

        public override void insert(Laptop laptop, string hash)
        {
            SqlCommand comm = new SqlCommand("INSERT INTO v_notebooks([hash],[producer_code],[color],[width],[height],"+
                                                                     "[depth],[weight],[display_diagonal],[display_width],"+
                                                                     "[display_height],[display_label],[cpu_type],[cpu_cores],"+
                                                                     "[ram_type],[ram_frequency],[ram_size],[hdd_type],[hdd_size],"+
                                                                     "[os_label],[gpu_type]) VALUES (@hash,@serial,@color,@width,"+
                                                                     "@height,@depth,@weight,@display_diagonal,@display_width,"+
                                                                     "@display_height,@display_label,@cpu_type,@cpu_cores,"+
                                                                     "@ram_type,@ram_frequency,@ram_size,@hdd_type,@hdd_size,"+
                                                                     "'','')", connection);
            comm.Parameters.Add("@hash",hash);
            comm.Parameters.Add("@serial",laptop.serial);
            comm.Parameters.Add("@color",laptop.color);
            comm.Parameters.Add("@width",laptop.width);
            comm.Parameters.Add("@height",laptop.height);
            comm.Parameters.Add("@depth",laptop.depth);
            comm.Parameters.Add("@weight",laptop.weight);
            comm.Parameters.Add("@display_diagonal",laptop.display.diagonal);
            comm.Parameters.Add("@display_width",laptop.display.width);
            comm.Parameters.Add("@display_height",laptop.display.height);
            comm.Parameters.Add("@display_label",laptop.display.label);
            comm.Parameters.Add("@cpu_type",laptop.cpu.type);
            comm.Parameters.Add("@cpu_cores",laptop.cpu.number_cores);
            comm.Parameters.Add("@ram_type",laptop.ram.type);
            comm.Parameters.Add("@ram_frequency",laptop.ram.frequency);
            comm.Parameters.Add("@ram_size",laptop.ram.size);
            comm.Parameters.Add("@hdd_type",laptop.hdd.type);
            comm.Parameters.Add("@hdd_size",laptop.hdd.size);
            comm.Parameters.Add("@os_label",laptop.os.label);
            comm.Parameters.Add("@gpu_type",laptop.gpu.type);
            comm.ExecuteNonQuery();
        }
    }
}
