using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CRUDjsonFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string folder_name = folderBrowserDialog1.SelectedPath;
            textBox2.Text = folder_name;
        }
        class create_file
        {
            public string frst_name { get; set; }
            public string midd_name { get; set; }
            public string lst_name { get; set; }
            public string brth_date { get; set; }
            public string addr { get; set; }
            public string cty { get; set; }
            public string prov { get; set; }
            public string contr{ get; set; }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            create_file new_file = new create_file() {};
            string stringjson = JsonConvert.SerializeObject(new_file, Formatting.Indented);
            string fileName = textBox1.Text;
            string folderName = textBox2.Text;
            string extension = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string path_file = folderName + @"\" + fileName + extension;
            if (!File.Exists(path_file))
            {
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    System.Threading.Thread.Sleep(5);
                }
                File.WriteAllText(path_file, stringjson);
            }
            else
            {
                MessageBox.Show("File already exist");
            }
            progressBar1.Value = 0;
        }

        private void write_file_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(5);
            }

            string theDate = dateTimePicker1.Value.ToShortDateString();
            create_file new_file = new create_file()
            {
                frst_name = first_name.Text,
                midd_name = middle_name.Text,
                lst_name = last_name.Text,
                brth_date = theDate,
                addr = address.Text,
                cty = city.Text,
                prov = proviency.Text,
                contr = country.Text
            };
            string stringjson = JsonConvert.SerializeObject(new_file, Formatting.Indented);
            string fileName = textBox1.Text;
            string folderName = textBox2.Text;
            string extension = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string path_file = folderName + @"\" + fileName + extension;
            File.WriteAllText(path_file, stringjson);
            progressBar1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_repo = new OpenFileDialog();
            file_repo.Filter = "(*.json)|*.json|(*.xml)|*.xml|(*.txt)|*.txt | All files (*.*)|*.*";
            if (file_repo.ShowDialog() == DialogResult.OK) 
            {
                textBox3.Text = file_repo.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileLocation = textBox3.Text;
            string tmp = File.ReadAllText(fileLocation);

            dynamic DynamicData = JsonConvert.DeserializeObject(tmp);

            for (int i = 0; i <= 100; i++) 
            {
                if (i >= 10 && i < 20)
                {
                    progressBar2.Value = i;
                    first_name_1.Text = Convert.ToString(DynamicData.frst_name);
                }
                else if (i >= 20 && i < 30)
                {
                    progressBar2.Value = i;
                    middle_name_1.Text = Convert.ToString(DynamicData.midd_name);
                }
                else if (i >= 30 && i < 40)
                {
                    progressBar2.Value = i;

                    last_name_1.Text = Convert.ToString(DynamicData.lst_name);
                }
                else if (i >= 40 && i < 50)
                {
                    progressBar2.Value = i;

                    birth_date_1.Text = Convert.ToString(DynamicData.brth_date);
                }
                else if (i >= 50 && i < 70)
                {
                    progressBar2.Value = i;
                    address_1.Text = Convert.ToString(DynamicData.addr);
                }
                else if (i >= 70 && i < 85)
                {
                    progressBar2.Value = i;

                    city_1.Text = Convert.ToString(DynamicData.cty);
                    proviency_1.Text = Convert.ToString(DynamicData.prov);
                }
                else if (i >= 85 && i < 100)
                {
                    progressBar2.Value = i;
                    country_1.Text = Convert.ToString(DynamicData.contr);
                }
                else if (i >= 100)
                {
                    progressBar2.Value = i;
                }
                System.Threading.Thread.Sleep(5);
            }
            System.Threading.Thread.Sleep(500);
            progressBar2.Value = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_repo = new OpenFileDialog();
            file_repo.Filter = "(*.json)|*.json|(*.xml)|*.xml|(*.txt)|*.txt | All files (*.*)|*.*";
            if (file_repo.ShowDialog() == DialogResult.OK)
            {
                textBox12.Text = file_repo.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fileLocation = textBox12.Text;
            string tmp = File.ReadAllText(fileLocation);

            dynamic DynamicData = JsonConvert.DeserializeObject(tmp);

            for (int i = 0; i <= 100; i++)
            {
                if (i >= 10 && i < 20)
                {
                    progressBar3.Value = i;
                    first_name_2.Text = Convert.ToString(DynamicData.frst_name);
                }
                else if (i >= 20 && i < 30)
                {
                    progressBar3.Value = i;
                    middle_name_2.Text = Convert.ToString(DynamicData.midd_name);
                }
                else if (i >= 30 && i < 40)
                {
                    progressBar3.Value = i;
                    last_name_2.Text = Convert.ToString(DynamicData.lst_name);
                }
                else if (i >= 40 && i < 50)
                {
                    progressBar3.Value = i;

                    birth_date_2.Text = Convert.ToString(DynamicData.brth_date);
                }
                else if (i >= 50 && i < 70)
                {
                    progressBar3.Value = i;
                    address_2.Text = Convert.ToString(DynamicData.addr);
                }
                else if (i >= 70 && i < 85)
                {
                    progressBar3.Value = i;
                    city_2.Text = Convert.ToString(DynamicData.cty);
                }
                else if (i >= 85 && i < 100)
                {
                    progressBar3.Value = i;
                    proviency_2.Text = Convert.ToString(DynamicData.prov);
                }
                else if (i >= 100)
                {
                    progressBar3.Value = i;
                    country_2.Text = Convert.ToString(DynamicData.contr);
                }
                System.Threading.Thread.Sleep(5);
            }
            System.Threading.Thread.Sleep(500);
            progressBar3.Value = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar3.Value = i;
                System.Threading.Thread.Sleep(5);
            }

            string theDate = dateTimePicker1.Value.ToShortDateString();
            create_file new_file = new create_file()
            {
                frst_name = first_name_2.Text,
                midd_name = middle_name_2.Text,
                lst_name = last_name_2.Text,
                brth_date = birth_date_2.Text,
                addr = address_2.Text,
                cty = city_2.Text,
                prov = proviency_2.Text,
                contr = country_2.Text
            };
            string stringjson = JsonConvert.SerializeObject(new_file, Formatting.Indented);
            string path_file = textBox12.Text;
            File.WriteAllText(path_file, stringjson);
            progressBar3.Value = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.json)|*.json|(*.xml)|*.xml|(*.txt)|*.txt | All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                file_name.Text = System.IO.Path.GetFileName(dlg.FileName.ToString()); // get file name with extension
                //folder_loc.Text = System.IO.Path.GetFullPath(dlg.FileName.ToString()); // get full path (same result as dlg.FileName)
                string folder_location = System.IO.Path.GetFullPath(dlg.FileName.ToString()); // get full path (same result as dlg.FileName)
                folder_loc.Text = Path.GetDirectoryName(folder_location);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string rootFolder = folder_loc.Text;
            string[] files = Directory.GetFiles(rootFolder);
            foreach (string file in files)
            {
                string file_selected = folder_loc.Text +@"\"+ file_name.Text;
                if (file == file_selected)
                {
                    File.Delete(file);
                    MessageBox.Show(file + " already deleted");
                    folder_loc.Text = "     ";
                    file_name.Text = "     ";
                }
            }
        }
    }
}
