using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication4
{
    public partial class SW : Form
    {
        public SW()
        {
            InitializeComponent();
        }

        private void SW_Load(object sender, EventArgs e)
        {
            DriveInfo[] d = DriveInfo.GetDrives();
            foreach (DriveInfo di in d)
            {
                comboBox3.Items.Add(di.Name);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] dir = dirInfo.GetDirectories();
            comboBox4.Items.Clear();
            foreach (DirectoryInfo d in dir)
            {
                comboBox4.Items.Add(d.Name);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox3.Text + comboBox4.Text;
            DirectoryInfo dir = new DirectoryInfo(fpath);
            FileInfo[] f = dir.GetFiles();
            int i = 1;
            foreach (FileInfo fi in f)
            {
                comboBox5.Items.Add(fi.Name);
                i++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = comboBox3.Text + "//" + comboBox4.Text + "//" + comboBox5.Text;
            StreamWriter sw = new StreamWriter(path);
            sw.WriteAsync(textBox1.Text);
            MessageBox.Show("Written in file");
        }
    }
}
