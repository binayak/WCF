using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using WCFClientApp;

namespace WCFClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            byte[] data = client.DownloadData("http://localhost:10967/Service1.svc/GetData");
            Stream stream = new MemoryStream(data);

            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(string));
            string result = obj.ReadObject(stream).ToString();

            MessageBox.Show(result);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "")||(textBox1.Text=="0"))
                MessageBox.Show("please enter student ID");

            else
            {

                string url = "http://localhost:10967/Service1.svc/GetStudent/" + textBox1.Text;
                WebClient client = new WebClient();
                byte[] data = client.DownloadData(url);
                Stream stream = new MemoryStream(data);

                DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(string));
                string result = obj.ReadObject(stream).ToString();

                MessageBox.Show(result);
            }
        }

    }
}
