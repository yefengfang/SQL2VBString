using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL2VBString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "sql=\"\"";
            string[] text = textBox1.Text.Split('\n');
            int i=1;
            foreach (string s in text)
            {
                i++;
                if (i % 20 == 0)
                {
                    textBox2.Text =textBox2.Text+ "\r\nsql=sql+\"\"";
                }
                textBox2.Text += " & Chr(13) & _\r\n\" " + s+"\"";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                Clipboard.SetDataObject(textBox2.Text);
        }
    }
}
