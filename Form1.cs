using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Clipboard.GetText();
            
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            string str = client.DownloadString(Clipboard.GetText());

            MatchCollection mc = Regex.Matches(str, "<title>(.*)</title>");

            foreach (Match match in mc)
            {
                listBox1.Items.Add(match.Value);



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
