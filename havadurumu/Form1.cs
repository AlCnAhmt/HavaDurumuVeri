using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();

            string api = "c597844cd32fceaf801a0cfee7d7b835";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=london&mode=xml&lang=uk&units=metric&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var hissedilensicaklik = hava.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            var durum = hava.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            var basinc = hava.Descendants("pressure").ElementAt(0).Attribute("value").Value;
            label4.Text = sicaklik.ToString();
            label7.Text = ruzgar + "m/s";
            label9.Text = "%" + nem;
            label12.Text = hissedilensicaklik.ToString();
            label3.Text = durum;
            label10.Text = basinc + "hPa";


            if (durum.Contains("clear") == true)
            {
                Sunny.Visible = true;
            }

            else if (durum.Contains("clouds") == true)
            {
                Sunny.Visible = false;
                cloudyPicture.Visible = true;
            }

            if (durum.Contains("clouds") == true)
            {
                cloudyPicture.Visible = true;
            }

            else if (durum.Contains("rainy") == true)
            {
                cloudyPicture.Visible = false;
                rainyPicture.Visible = true;
            }
            if (durum.Contains("moonlight") == true)
            {
                clearNight.Visible = true;
            }

            else if (durum.Contains("windy") == true)
            {
                clearNight.Visible = false;
                windy.Visible = true;
            }
            if (durum.Contains("snow") == true)
            {
                snowyPicture.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {


        }



        private void label6_Click(object sender, EventArgs e)
        {




        }

       
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void windy_Click(object sender, EventArgs e)
        {

        }
    }
}
