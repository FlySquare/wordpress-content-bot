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
    public partial class Form1 : Form
    {
        public String html, verisite1, verisite2, verisite3, verisite4,verisite5;
        
        public Uri url;

        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {

                webBrowser2.Document.GetElementById("title").SetAttribute("value", textBox2.Text);
                webBrowser2.Document.GetElementById("_regular_price").SetAttribute("value", textBox3.Text);
                webBrowser2.Document.GetElementById("_sku").SetAttribute("value", textBox1.Text);
                webBrowser2.Document.GetElementById("new-tag-product_tag").SetAttribute("value", textBox6.Text);
                webBrowser2.Document.GetElementById("set-post-thumbnail").InvokeMember("click");
                webBrowser2.Document.GetElementById("menu-item-upload").InvokeMember("click");
                webBrowser2.Document.GetElementById("__wp-uploader-id-1").InvokeMember("click");
                webBrowser2.Document.GetElementById("menu-item-browse").InvokeMember("click");
            }

            if (textBox7.Text != "")
            {
                webBrowser1.Document.GetElementById("_sku").SetAttribute("value", textBox14.Text);
                webBrowser1.Document.GetElementById("title").SetAttribute("value", textBox13.Text);
                webBrowser1.Document.GetElementById("_regular_price").SetAttribute("value", textBox12.Text);
                webBrowser1.Document.GetElementById("new-tag-product_tag").SetAttribute("value", textBox10.Text);
                webBrowser1.Document.GetElementById("set-post-thumbnail").InvokeMember("click");
                webBrowser1.Document.GetElementById("menu-item-upload").InvokeMember("click");
                webBrowser1.Document.GetElementById("__wp-uploader-id-1").InvokeMember("click");
                webBrowser1.Document.GetElementById("menu-item-browse").InvokeMember("click");
            }
        
            if (textBox8.Text != "")
            {
                webBrowser3.Document.GetElementById("_sku").SetAttribute("value", textBox19.Text);
                webBrowser3.Document.GetElementById("title").SetAttribute("value", textBox18.Text);
                webBrowser3.Document.GetElementById("_regular_price").SetAttribute("value", textBox17.Text);
                webBrowser3.Document.GetElementById("new-tag-product_tag").SetAttribute("value", textBox15.Text);
                webBrowser3.Document.GetElementById("set-post-thumbnail").InvokeMember("click");
                webBrowser3.Document.GetElementById("menu-item-upload").InvokeMember("click");
                webBrowser3.Document.GetElementById("__wp-uploader-id-1").InvokeMember("click");
                webBrowser3.Document.GetElementById("menu-item-browse").InvokeMember("click");
            }
  
            if (textBox9.Text != "")
            {
                webBrowser4.Document.GetElementById("_sku").SetAttribute("value", textBox24.Text);
                webBrowser4.Document.GetElementById("title").SetAttribute("value", textBox23.Text);
                webBrowser4.Document.GetElementById("_regular_price").SetAttribute("value", textBox22.Text);
                webBrowser4.Document.GetElementById("new-tag-product_tag").SetAttribute("value", textBox20.Text);
                webBrowser4.Document.GetElementById("set-post-thumbnail").InvokeMember("click");
                webBrowser4.Document.GetElementById("menu-item-upload").InvokeMember("click");
                webBrowser4.Document.GetElementById("__wp-uploader-id-1").InvokeMember("click");
                webBrowser4.Document.GetElementById("menu-item-browse").InvokeMember("click");
            }
            if (textBox25.Text != "")
            {
                webBrowser5.Document.GetElementById("_sku").SetAttribute("value", textBox30.Text);
                webBrowser5.Document.GetElementById("title").SetAttribute("value", textBox29.Text);
                webBrowser5.Document.GetElementById("_regular_price").SetAttribute("value", textBox28.Text);
                webBrowser5.Document.GetElementById("new-tag-product_tag").SetAttribute("value", textBox26.Text);
                webBrowser5.Document.GetElementById("set-post-thumbnail").InvokeMember("click");
                webBrowser5.Document.GetElementById("menu-item-upload").InvokeMember("click");
                webBrowser5.Document.GetElementById("__wp-uploader-id-1").InvokeMember("click");
                webBrowser5.Document.GetElementById("menu-item-browse").InvokeMember("click");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text != "")
            {
                verisite1 = textBox5.Text;
                VeriAl(verisite1, "//*[@id='wrapper']/div/main/div[2]/div/div/div[2]/div[1]/div[1]/div/span", textBox1);//ürün stok kodu
                VeriAl(verisite1, "//*[@id='wrapper']/div/main/div[1]/div/ul/li[4]/span", textBox2);//ürün baslik        
                VeriAl(verisite1, "//*[@id='divUrunFiyat']/div/span[1]/span", textBox3); //ürün fiyat       
                VeriAl(verisite1, "//*[@id='Tab1']/text()", textBox4); //ürün aciklama 

                string etikets1 = textBox2.Text;
                string[] etiketListe1 = etikets1.Split(' '); //hobileri , ile ayırıp hobiListe içine aktarıyoruz.
                textBox6.Text = etiketListe1[0] + "," + etiketListe1[1] + "," + etiketListe1[2];
                //1. site verileri
            }
            //1. site verileri

            if (textBox7.Text != "")
            {
                //2. site verileri
                verisite2 = textBox7.Text;
                VeriAl(verisite2, "//*[@id='wrapper']/div/main/div[2]/div/div/div[2]/div[1]/div[1]/div/span", textBox14);//ürün stok kodu
                VeriAl(verisite2, "//*[@id='wrapper']/div/main/div[1]/div/ul/li[4]/span", textBox13);//ürün baslik        
                VeriAl(verisite2, "//*[@id='divUrunFiyat']/div/span[1]/span", textBox12); //ürün fiyat       
                VeriAl(verisite2, "//*[@id='Tab1']/text()", textBox11); //ürün aciklama 

                string etikets2 = textBox13.Text;
                string[] etiketListe2 = etikets2.Split(' '); //hobileri , ile ayırıp hobiListe içine aktarıyoruz.
                textBox10.Text = etiketListe2[0] + "," + etiketListe2[1] + "," + etiketListe2[2];
                //2. site verileri
            }

            if (textBox8.Text != "")
            {
                //3. site verileri
                verisite3 = textBox8.Text;
                VeriAl(verisite3, "//*[@id='wrapper']/div/main/div[2]/div/div/div[2]/div[1]/div[1]/div/span", textBox19);//ürün stok kodu
                VeriAl(verisite3, "//*[@id='wrapper']/div/main/div[1]/div/ul/li[4]/span", textBox18);//ürün baslik        
                VeriAl(verisite3, "//*[@id='divUrunFiyat']/div/span[1]/span", textBox17); //ürün fiyat       
                VeriAl(verisite3, "//*[@id='Tab1']/text()", textBox16); //ürün aciklama 

                string etikets3 = textBox18.Text;
                string[] etiketListe3 = etikets3.Split(' '); //hobileri , ile ayırıp hobiListe içine aktarıyoruz.
                textBox15.Text = etiketListe3[0] + "," + etiketListe3[1] + "," + etiketListe3[2];
                //3. site verileri
            }


            if (textBox9.Text != "")
            {
                //4. site verileri
                verisite4 = textBox9.Text;
                VeriAl(verisite4, "//*[@id='wrapper']/div/main/div[2]/div/div/div[2]/div[1]/div[1]/div/span", textBox24);//ürün stok kodu
                VeriAl(verisite4, "//*[@id='wrapper']/div/main/div[1]/div/ul/li[4]/span", textBox23);//ürün baslik        
                VeriAl(verisite4, "//*[@id='divUrunFiyat']/div/span[1]/span", textBox22); //ürün fiyat       
                VeriAl(verisite4, "//*[@id='Tab1']/text()", textBox21); //ürün aciklama 

                string etikets4 = textBox23.Text;
                string[] etiketListe4 = etikets4.Split(' '); //hobileri , ile ayırıp hobiListe içine aktarıyoruz.
                textBox20.Text = etiketListe4[0] + "," + etiketListe4[1] + "," + etiketListe4[2];
                //4. site verileri

            }

            if (textBox25.Text != "")
            {
                verisite5 = textBox25.Text;
                VeriAl(verisite5, "//*[@id='wrapper']/div/main/div[2]/div/div/div[2]/div[1]/div[1]/div/span", textBox30);//ürün stok kodu
                VeriAl(verisite5, "//*[@id='wrapper']/div/main/div[1]/div/ul/li[4]/span", textBox29);//ürün baslik        
                VeriAl(verisite5, "//*[@id='divUrunFiyat']/div/span[1]/span", textBox28); //ürün fiyat       
                VeriAl(verisite5, "//*[@id='Tab1']/text()", textBox27); //ürün aciklama 

                string etikets5 = textBox29.Text;
                string[] etiketListe5 = etikets5.Split(' '); //hobileri , ile ayırıp hobiListe içine aktarıyoruz.
                textBox26.Text = etiketListe5[0] + "," + etiketListe5[1] + "," + etiketListe5[2];
                //1. site verileri
            }

        }
        public void VeriAl(String Url,String XPath,TextBox CikanSonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch(UriFormatException)
            {
                if(MessageBox.Show("Hatalı Url","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error)== DialogResult.OK)
                {

                }
            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
            WebClient client = new WebClient();
            client.Encoding  = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı Url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }


            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                CikanSonuc.Text = (doc.DocumentNode.SelectSingleNode(XPath).InnerText);
            }
            catch (NullReferenceException)
            {
                if (MessageBox.Show("Hatalı XPath", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!WBEmulator.IsBrowserEmulationSet())
            {
                WBEmulator.SetBrowserEmulationVersion();
            }
          

        }

     


        private void button13_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex <= 0)
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori

                webBrowser2.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
            }
            else
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori
                string subkat = listBox2.Items[listBox2.SelectedIndex].ToString();// sub kategori
                webBrowser1.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser1.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex <= 0)
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori

                webBrowser2.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
            }
            else
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori
                string subkat = listBox2.Items[listBox2.SelectedIndex].ToString();// sub kategori
                webBrowser3.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser3.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex <= 0)
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori

                webBrowser2.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
            }
            else
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori
                string subkat = listBox2.Items[listBox2.SelectedIndex].ToString();// sub kategori
                webBrowser4.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser4.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex <= 0)
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori

                webBrowser2.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
            }
            else
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori
                string subkat = listBox2.Items[listBox2.SelectedIndex].ToString();// sub kategori
                webBrowser1.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser1.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
                webBrowser2.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser2.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
                webBrowser3.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser3.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
                webBrowser4.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser4.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
                webBrowser5.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser5.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");

        }

        private void button17_Click(object sender, EventArgs e)
        {
            webBrowser4.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");

        }

        private void button18_Click(object sender, EventArgs e)
        {
            webBrowser5.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");

        }

        private void button22_Click(object sender, EventArgs e)
        {

            webBrowser1.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser1.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser1.Document.GetElementById("wp-submit").InvokeMember("click");

        }

        private void button21_Click(object sender, EventArgs e)
        {
            webBrowser2.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser2.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser2.Document.GetElementById("wp-submit").InvokeMember("click");
        }

        private void button20_Click(object sender, EventArgs e)
        {

            webBrowser3.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser3.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser3.Document.GetElementById("wp-submit").InvokeMember("click");

        }

        private void button19_Click(object sender, EventArgs e)
        {

            webBrowser4.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser4.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser4.Document.GetElementById("wp-submit").InvokeMember("click");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            webBrowser5.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser5.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser5.Document.GetElementById("wp-submit").InvokeMember("click");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex <= 0)
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori

                webBrowser2.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
            }
            else
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori
                string subkat = listBox2.Items[listBox2.SelectedIndex].ToString();// sub kategori
                webBrowser5.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser5.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            if (listBox2.SelectedIndex <= 0)
            {
               
                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori

                webBrowser2.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
            }
            else
            {

                string kat = listBox1.Items[listBox1.SelectedIndex].ToString();//kategori
                string subkat = listBox2.Items[listBox2.SelectedIndex].ToString();// sub kategori
                webBrowser2.Document.GetElementById("in-product_cat-" + kat).InvokeMember("click");
                webBrowser2.Document.GetElementById("in-product_cat-" + subkat).InvokeMember("click");
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");
            webBrowser2.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");
            webBrowser3.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");
            webBrowser4.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");
            webBrowser5.Navigate("https://bolfps.com/wp-admin/post-new.php?post_type=product");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                webBrowser2.Document.GetElementById("publish").InvokeMember("click");

            }
            if (textBox7.Text != "")
            {
                webBrowser1.Document.GetElementById("publish").InvokeMember("click");

            }
            if (textBox8.Text != "")
            {
                webBrowser3.Document.GetElementById("publish").InvokeMember("click");


            }
            if (textBox9.Text != "")
            {
                webBrowser4.Document.GetElementById("publish").InvokeMember("click");

            }
            if (textBox25.Text != "")
            {
                webBrowser5.Document.GetElementById("publish").InvokeMember("click");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser2.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser2.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser2.Document.GetElementById("wp-submit").InvokeMember("click");

            webBrowser1.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser1.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser1.Document.GetElementById("wp-submit").InvokeMember("click");

            webBrowser3.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser3.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser3.Document.GetElementById("wp-submit").InvokeMember("click");

            webBrowser4.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser4.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser4.Document.GetElementById("wp-submit").InvokeMember("click");

            webBrowser5.Document.GetElementById("user_login").SetAttribute("value", "Umut Can Arda");
            webBrowser5.Document.GetElementById("user_pass").SetAttribute("value", "*hayalimcsgo00*B");
            webBrowser5.Document.GetElementById("wp-submit").InvokeMember("click");

        }

      
        
    }
}
