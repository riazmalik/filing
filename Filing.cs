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
    public partial class Filing : Form
    {
        public Filing()
        {
            InitializeComponent();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Filing_Load(object sender, EventArgs e)
        {

            DriveInfo[] d = DriveInfo.GetDrives();
            foreach (DriveInfo di in d)
            {
                comboBox1.Items.Add(di.Name);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string spath = comboBox1.Text + comboBox2.Text;
            DirectoryInfo dir = new DirectoryInfo(spath);
            FileInfo[] f = dir.GetFiles();
            int i = 1;
            foreach (FileInfo fi in f)
            {
                textBox2.Text += i.ToString() + ")." + fi.FullName + Environment.NewLine;
                i++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOP f = new FileOP();
            f.Show();
        }

        private void streamReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SR sr = new SR();
            sr.Show();
        }

        private void streamWritterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SW sw = new SW();
            sw.Show();
        }

        private void fileStreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filestram fs = new filestram();
            fs.Show();
        }
    }
}
