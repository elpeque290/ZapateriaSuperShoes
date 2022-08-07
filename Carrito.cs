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
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Formulario = new Carrito();
            Formulario.Show();
            this.Hide();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {

        }

        private void lb_precio_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            //codigo volver formulario anterior 
            Form Formulario = new SuperShop();
            Formulario.Show();
            this.Hide();
        }

        private void lb_modeloFC_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Secion from1 = new Secion();
            from1.Show();
            this.Hide();

        }
    }
}
