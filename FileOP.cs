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
    public partial class FileOP : Form
    {
        public FileOP()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void File_Load(object sender, EventArgs e)
        {
            DriveInfo[] d = DriveInfo.GetDrives();
            foreach (DriveInfo di in d)
            {
                comboBox1.Items.Add(di.Name);
            }
            DriveInfo[] d1 = DriveInfo.GetDrives();
            foreach (DriveInfo di in d1)
            {
                comboBox3.Items.Add(di.Name);
            }
            DriveInfo[] d2 = DriveInfo.GetDrives();
            foreach (DriveInfo di in d2)
            {
                comboBox6.Items.Add(di.Name);
            }
            DriveInfo[] d3 = DriveInfo.GetDrives();
            foreach (DriveInfo di in d3)
            {
                comboBox12.Items.Add(di.Name);
            }
            DriveInfo[] d4 = DriveInfo.GetDrives();
            foreach (DriveInfo di in d4)
            {
                comboBox9.Items.Add(di.Name);
            }
            DriveInfo[] d5 = DriveInfo.GetDrives();
            foreach (DriveInfo di in d5)
            {
                comboBox15.Items.Add(di.Name);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(comboBox1.Text);
            DirectoryInfo[] dir = dirInfo.GetDirectories();
            comboBox2.Items.Clear();
            foreach (DirectoryInfo d in dir)
            {
                comboBox2.Items.Add(d.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fcreate = comboBox1.Text +"//"+comboBox2.Text+"//"+textBox5.Text+textBox6.Text ;
           

            if (File.Exists(fcreate))
            {
                MessageBox.Show("File exist rename the file");
                File.Create(fcreate);
            }
        
            else
            {
                File.Create(fcreate);
                MessageBox.Show("File created succesfully");
            }
             
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo1 = new DirectoryInfo(comboBox3.Text);
            DirectoryInfo[] dir1 = dirInfo1.GetDirectories();
            comboBox2.Items.Clear();
            foreach (DirectoryInfo d1 in dir1)
            {
                comboBox4.Items.Add(d1.Name);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo2 = new DirectoryInfo(comboBox6.Text);
            DirectoryInfo[] dir2 = dirInfo2.GetDirectories();
            comboBox2.Items.Clear();
            foreach (DirectoryInfo d2 in dir2)
            {
                comboBox7.Items.Add(d2.Name);
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
            string srpath = comboBox3.Text + "//" + comboBox4.Text + "//" + comboBox5.Text;
            string dtpath = comboBox6.Text + "//" + comboBox7.Text + "//" + comboBox5.Text;
            File.Copy(srpath,dtpath);
            if (File.Exists(dtpath))
            {
                MessageBox.Show("file exsist");

            }
            else
            {
                File.Copy(srpath, dtpath);
                MessageBox.Show("file copy...");
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo1 = new DirectoryInfo(comboBox12.Text);
            DirectoryInfo[] dir1 = dirInfo1.GetDirectories();
            comboBox2.Items.Clear();
            foreach (DirectoryInfo d1 in dir1)
            {
                comboBox11.Items.Add(d1.Name);
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox12.Text + comboBox11.Text;
            DirectoryInfo dir = new DirectoryInfo(fpath);
            FileInfo[] f = dir.GetFiles();
            int i = 1;
            foreach (FileInfo fi in f)
            {
                comboBox10.Items.Add(fi.Name);
                i++;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string srpath = comboBox12.Text + "//" + comboBox11.Text + "//" + comboBox10.Text;
            string dtpath = comboBox9.Text + "//" + comboBox8.Text + "//" + comboBox10.Text;
            File.Move(srpath, dtpath);
            if (File.Exists(dtpath))
            {
                MessageBox.Show("file exsist");

            }
            else
            {
                File.Move(srpath, dtpath);
                MessageBox.Show("file move...");
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo2 = new DirectoryInfo(comboBox9.Text);
            DirectoryInfo[] dir2 = dirInfo2.GetDirectories();
            comboBox2.Items.Clear();
            foreach (DirectoryInfo d2 in dir2)
            {
                comboBox8.Items.Add(d2.Name);
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo2 = new DirectoryInfo(comboBox15.Text);
            DirectoryInfo[] dir2 = dirInfo2.GetDirectories();
            comboBox14.Items.Clear();
            foreach (DirectoryInfo d2 in dir2)
            {
                comboBox14.Items.Add(d2.Name);
            }

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fpath = comboBox15.Text + comboBox14.Text;
            DirectoryInfo dir = new DirectoryInfo(fpath);
            FileInfo[] f = dir.GetFiles();
            int i = 1;
            foreach (FileInfo fi in f)
            {
                comboBox13.Items.Add(fi.Name);
                i++;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fdelete = comboBox15.Text + "//" + comboBox14.Text + "//" + comboBox13.Text;
            File.Delete(fdelete);
            MessageBox.Show("File Deleted...");
                

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
