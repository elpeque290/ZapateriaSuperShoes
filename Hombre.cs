using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapateriaSuperShoes
{
    public partial class Hombre : Form
    {
        public Hombre()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codigo volver formulario anterior 
            Form Formulario = new SuperShop();
            Formulario.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Carrito obj = new Carrito();


            //zapato nike Hombre
            if (rb_nikeH.Checked == true)
            {
                rb_nikeH.Text = "Nike Black Hombre";
                int precioNikeH = 520000;

                obj.lb_usuario.Text = rb_nikeH.Text;
                obj.txt_talla.Text = nd_nikeH.Text;
                obj.lb_precio.Text = precioNikeH.ToString();
            }


            //zapato Balenciaga Hombre
            if (rb_balenciagaH.Checked == true)
            {
                rb_nikeH.Text = "Nike Black Hombre";
                int precioBalenciagaH = 900000;

                obj.lb_usuario.Text = rb_balenciagaH.Text;
                obj.txt_talla.Text = nd_balenciagaH.Text;
                obj.lb_precio.Text = precioBalenciagaH.ToString();
            }

            //zapato NewBalance Hombre
            if (rb_newbalanceH.Checked == true)
            {
                rb_nikeH.Text = "NewBalance white Hombre";
                int precioNewbalance1H = 300000;

                obj.lb_usuario.Text = rb_newbalanceH.Text;
                obj.txt_talla.Text = nd_newbalanceH.Text;
                obj.lb_precio.Text = precioNewbalance1H.ToString();
            }

            //zapato Adidas Hombre
            if (rb_adidasH.Checked == true)
            {
                rb_nikeH.Text = "Adidas ";
                int precioAdidasH = 170000;

                obj.lb_usuario.Text = rb_adidasH.Text;
                obj.txt_talla.Text = nd_adidasH.Text;
                obj.lb_precio.Text = precioAdidasH.ToString();
            }

            //zapato NewBalance 2 Hombre
            if (rb_newbalance2H.Checked == true)
            {
                rb_nikeH.Text = "Adidas ";
                int precioNewbalance2H = 170000;

                obj.lb_usuario.Text = rb_newbalance2H.Text;
                obj.txt_talla.Text = nd_newbalance2H.Text;
                obj.lb_precio.Text = precioNewbalance2H.ToString();
            }


            //codigo abrir y cerrar formulario
            obj.Show();
            this.Hide();
        }
    }
}
