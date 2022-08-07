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
    public partial class Mujer : Form
    {
        public Mujer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carrito obj = new Carrito();


            //zapato nike mujer
            if (rb_nikeM.Checked == true)
            {
                rb_nikeM.Text = "Nike Pink Mujer";
                int precioNikeM = 250000;

                obj.lb_usuario.Text = rb_nikeM.Text;
                obj.txt_talla.Text = nd_nikeM.Text;
                obj.lb_precio.Text = precioNikeM.ToString();
            }
        

            //zapatos adidas mujer
            if (rb_adidasM.Checked == true)
            {
                rb_adidasM.Text = "Adidas Flowers Mujer";
                int precioAdidasM = 320000;

                obj.lb_usuario.Text = rb_adidasM.Text;
                obj.txt_talla.Text = nd_adidasM.Text;
                obj.lb_precio.Text = precioAdidasM.ToString();
            }

            //zapatos balenciaga 
            if (rb_balenciagaM.Checked == true)
            {
                rb_balenciagaM.Text = "Balenciaga Mujer";
                int precioBalenciagaM = 500000;

                obj.lb_usuario.Text = rb_balenciagaM.Text;
                obj.txt_talla.Text = nd_balenciagaM.Text;
                obj.lb_precio.Text = precioBalenciagaM.ToString();
            }

            //zapatos New Balance 
            if (rb_newbalanceM.Checked == true)
            {
                rb_newbalanceM.Text = "NewBalance Mujer";
                int precioNewBalanceM = 250000;

                obj.lb_usuario.Text = rb_newbalanceM.Text;
                obj.txt_talla.Text = nd_newbalanceM.Text;
                obj.lb_precio.Text = precioNewBalanceM.ToString();
            }

            //zapatos Gucci
            if (rb_newbalanceM.Checked == true)
            {
                rb_newbalanceM.Text = "Gucci Mujer";
                int precioGucciM = 800000;

                obj.lb_usuario.Text = rb_gucciM.Text;
                obj.txt_talla.Text = nd_gucciM.Text;
                obj.lb_precio.Text = precioGucciM.ToString();
            }

            // Ninguna seleccion
            
           

            //codigo abrir y cerrar formularios

            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //codigo volver formulario anterior 
            Form Formulario = new SuperShop();
            Formulario.Show();
            this.Hide();
        }

        private void sl_nike_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
