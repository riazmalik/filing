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
    public partial class filestram : Form
    {
        public filestram()
        {
            InitializeComponent();
        }

        private void filestram_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] b = new byte[100];

            char[] c = new char[100];


            string fname = comboBox3.Text + comboBox4.Text + "\\" + comboBox5.Text;

            FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read);

            fs.Read(b, 0, 99);
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(b, 0, b.Length, c, 0);

            string s = new string(c);

            textBox1.Text = s;
            MessageBox.Show("Read sucessfully");
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] b = new byte[100];

            char[] c = new char[100];

            string fname = comboBox3.Text + comboBox4.Text + "\\" + comboBox5.Text;

            FileStream fs = new FileStream(fname, FileMode.Create);

            c = textBox2.Text.ToCharArray();

            Encoder en = Encoding.UTF8.GetEncoder();
            en.GetBytes(c, 0, c.Length, b, 0, true);
            fs.Write(b, 0, b.Length);
            MessageBox.Show("Write sucessfully");

            fs.Close();
        }
    }
}
