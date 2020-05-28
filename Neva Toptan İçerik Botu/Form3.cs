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
using System.Net;
using HtmlAgilityPack;

namespace Neva_Toptan_İçerik_Botu
{
    public partial class Form3 : Form
    {
        public String html, verisite1, verisite2, verisite3, verisite4, verisite5;
        public int isimsayi = 0;
        public int isimmail = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            isimsayi = isimsayi + 1;
            isimmail = isimmail + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("author").SetAttribute("value", listBox1.Items[isimsayi].ToString());
            webBrowser1.Document.GetElementById("email").SetAttribute("value", listBox2.Items[isimmail].ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("tab-title-reviews").InvokeMember("click");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        public Uri url;

        public Form3()
        {
            InitializeComponent();

        }


    }
}
