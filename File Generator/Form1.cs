using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            unity.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(quantity.Text);
            int u = unity.SelectedIndex;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Tutti i file (*.*)|*.*";             //serve per salvare
            saveFileDialog1.DefaultExt = "";
            saveFileDialog1.AddExtension = true;

            //Console.WriteLine(u);

            if (u == 0)
            {
                u = 1024;
            }
            if (u == 1)
            {
                u = 1024 * 1024;
            }
            if (u == 2)
            {
                u = 1024 * 1024 * 1024;
            }

            //Console.WriteLine(u);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                //Console.WriteLine("/ C fsutil file createnew " + saveFileDialog1.FileName + " " + x * u * 1024);
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C fsutil file createnew " + saveFileDialog1.FileName + " " + x * u * 1024;
                process.StartInfo = startInfo;
                process.Start();
            }
        }
    }
}
