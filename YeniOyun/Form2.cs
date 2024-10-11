using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace YeniOyun
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool mouseDown;
        private Point lastLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location; // Son tıklama noktasını kaydet
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Formun konumunu güncelle
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                // Formun yeniden çizilmesini sağlayarak görüntüde sorun oluşmasını engelle
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_MouseDown(panel1, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1_MouseMove(panel1, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1_MouseUp(panel1, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.lolvvv.com/") { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.leagueofgraphs.com/summoner/tr/Sett%20Me%20Free-TR1") { UseShellExecute = true });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Process.Start(new ProcessStartInfo("https://github.com/chanser45") { UseShellExecute = true });
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Process.Start(new ProcessStartInfo("https://www.leagueofgraphs.com/summoner/tr/Sett%20Me%20Free-TR1") { UseShellExecute = true });
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Kendi e-posta adresinizi belirtin
            string email = "itsberkayari@gmail.com"; // Kendi e-posta adresinizi buraya yazın
            string subject = ""; // İsteğe bağlı konu
            string body = ""; // İsteğe bağlı içerik

            // Mailto bağlantısını oluşturun
            string mailtoLink = $"mailto:{email}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";

            // Varsayılan e-posta istemcisinde mailto bağlantısını aç
            Process.Start(new ProcessStartInfo(mailtoLink) { UseShellExecute = true });
        }
    }
}
