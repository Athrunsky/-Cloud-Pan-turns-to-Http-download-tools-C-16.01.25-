using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newStr;
            string strB = textBox1.Text;
            string strC;

            //string strA = "https://zg.yangsifa.com/wp/?url=pan.baidu.com/s/1mgpbW6G&apikey=c1ef592361b7e084eb09af4a1be00ad6";
            string strA = "https://zg.yangsifa.com/wp/?url=&apikey=c1ef592361b7e084eb09af4a1be00ad6";
            if (textBox2.Text == null) //没有密码
            {
                    textBox1.Text = strB;
                    newStr = strA.Insert(32, strB);
            }

            else
                    textBox1.Text = strB;
                    strC = textBox2.Text;
                    strB = strB + "|" + strC;
                    newStr = strA.Insert(32, strB);
                    textBox4.Text = newStr;

            using (WebClient webClient = new System.Net.WebClient())
            {
                WebClient n = new WebClient();
                var json = n.DownloadString(newStr);
                string valueOriginal = Convert.ToString(json);
                int i = json.IndexOf("\"download\"") + 13;
                int j = json.LastIndexOf("}") - 2;
                int m = j - i;
                int b = json.Length;
                string strDownload = json.Substring(i, j - i);


                textBox3.Text = (strDownload);
                MessageBox.Show("已复制到剪切板");
                Clipboard.SetDataObject(textBox3.Text);

                //&apikey=c1ef592361b7e084eb09af4a1be00ad6
                //https://zg.yangsifa.com/wp/?url=pan.baidu.com/s/1mgpbW6G

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.请确保地址去掉http://\n\r2.目前支持百度网盘，腾讯微云，新浪微盘等\n\r3.尚不支持多个文件的百度云盘链接 ");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
