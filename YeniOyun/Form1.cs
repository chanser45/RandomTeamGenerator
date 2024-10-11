
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace YeniOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }






        private int dragIndex; // Sürüklenen öðenin indeksi
        private string draggedItem; // Sürüklenen öðenin deðeri

        private List<string> isimListesi = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            ;
            string girilenIsimler = textBox1.Text.Trim();
            label1.Text = "";


            if (!string.IsNullOrEmpty(girilenIsimler))
            {
                var yeniIsimler = girilenIsimler.Split(new[] { ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(i => i.Trim());

                isimListesi.AddRange(yeniIsimler);
                listBox1.Items.AddRange(yeniIsimler.ToArray());
                textBox1.Clear();
                textBox1.Focus();

            }
            else
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {

                    label1.Text = ("Gruplarý oluþturmak için 10 isim eklemelisiniz.");

                }

            }




            if (isimListesi.Count != 10)
            {
                label1.Text = "Gruplarý oluþturmak için 10 isim eklemelisiniz.";
                return;

            }
            else { label1.Text = "Takýmlar Hazýr!"; }

            var rastgele = new Random();
            var karisikListe = isimListesi.OrderBy(x => rastgele.Next()).ToList();


            listBox1.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(karisikListe[i]);

            }


            listBox2.Items.Clear();
            for (int i = 5; i < 10; i++)
            {
                listBox2.Items.Add(karisikListe[i]);

            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isimListesi.Clear();
            textBox1.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "";

            label1.Text = "Tüm isimler ve gruplar sýfýrlandý.";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text))
            {
                pictureBox5.Visible = true;

            }
            else { pictureBox5.Visible = false; }



        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Form2'nin bir örneðini oluþtur
            Form2 form2 = new Form2();

            // Form2'yi modal olarak göster (diðer form ile etkileþimi engeller)
            form2.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }






        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.StringFormat) ? DragDropEffects.Move : DragDropEffects.None;
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = e.Data.GetDataPresent(DataFormats.StringFormat) ? DragDropEffects.Move : DragDropEffects.None;

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {

            // Sadece listBox1'de 2 veya daha fazla öðe varsa sürüklemeye izin ver
            if (listBox1.Items.Count > 1 && listBox1.SelectedItem != null)
            {
                dragIndex = listBox1.IndexFromPoint(e.X, e.Y);
                if (dragIndex >= 0)
                {
                    draggedItem = listBox1.Items[dragIndex].ToString();
                    listBox1.DoDragDrop(draggedItem, DragDropEffects.Move);
                }

            }
            else if (listBox2.Items.Count == 9)
            {
                label1.Text = "Takýmlarda en az 1 oyuncu olmak zorunda.";
            }

            else label1.Text = "10 oyuncu ekledikten sonra sürükleyerek takýmlarý düzenleyebilirsiniz.";
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox2.Items.Count > 1 && listBox2.SelectedItem != null)
            {

                dragIndex = listBox2.IndexFromPoint(e.X, e.Y);
                if (dragIndex >= 0)
                {
                    draggedItem = listBox2.Items[dragIndex].ToString();
                    listBox2.DoDragDrop(draggedItem, DragDropEffects.Move);
                }

            }
            else if (listBox1.Items.Count == 9)
            {
                label1.Text = "Takýmlarda en az 1 oyuncu olmak zorunda.";
            }
            else label1.Text = "10 oyuncu ekledikten sonra sürükleyerek takýmlarý düzenleyebilirsiniz.";
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {

            if (listBox1.Items.Count > 1 || listBox2.Items.Count > 1) // listBox2'de en az 2 öðe varsa izin ver
            {
                Point point = listBox1.PointToClient(new Point(e.X, e.Y));
                int dropIndex = listBox1.IndexFromPoint(point);
                if (dropIndex < 0) dropIndex = listBox1.Items.Count - 1;

                if (listBox1.Items.Contains(draggedItem))
                {
                    listBox1.Items.RemoveAt(dragIndex);
                    listBox1.Items.Insert(dropIndex, draggedItem);
                }
                else
                {
                    listBox2.Items.Remove(draggedItem);
                    listBox1.Items.Insert(dropIndex, draggedItem);
                }

            }

        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (listBox2.Items.Count > 1 || listBox1.Items.Count > 1) // listBox1'de en az 2 öðe varsa izin ver
            {

                Point point = listBox2.PointToClient(new Point(e.X, e.Y));
                int dropIndex = listBox2.IndexFromPoint(point);
                if (dropIndex < 0) dropIndex = listBox2.Items.Count - 1;

                if (listBox2.Items.Contains(draggedItem))
                {
                    listBox2.Items.RemoveAt(dragIndex);
                    listBox2.Items.Insert(dropIndex, draggedItem);
                }
                else
                {
                    listBox1.Items.Remove(draggedItem);
                    listBox2.Items.Insert(dropIndex, draggedItem);
                }

            }
        }



        private bool mouseDown;
        private Point lastLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location; // Son týklama noktasýný kaydet

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Formun konumunu güncelle
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                // Formun yeniden çizilmesini saðlayarak görüntüde sorun oluþmasýný engelle
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            panel1_MouseDown(panel1, e);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            panel1_MouseMove(panel1, e);
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            panel1_MouseUp(panel1, e);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}