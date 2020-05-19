using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenWriteToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullPath = @"D:\Temp\temp.txt";
            string lines = textBox1.Text;
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(lines + "\n");
                writer.WriteLine(" ");
            }
        }
    }
}
