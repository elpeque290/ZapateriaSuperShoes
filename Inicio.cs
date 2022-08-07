using System;
using System.Windows.Forms;

namespace ZapateriaSuperShoes
{

    public partial class SuperShop : Form
        {

            public SuperShop()
            {
                InitializeComponent();
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void pictureBox4_Click(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
        {

            //codigo abrir y cerrar formularios
            Form Formulario = new Hombre();
            Formulario.Show();
            this.Hide();

        }

            private void button3_Click(object sender, EventArgs e)
            {
                //codigo abrir y cerrar formularios
                Form Formulario = new Mujer();
                Formulario.Show();
                this.Hide();
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Permite abrir link desde un click
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.instagram.com/elpeque._/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Permite abrir link desde un click
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Permite abrir link desde un click
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=573124707153");
        }
    }
  
}


