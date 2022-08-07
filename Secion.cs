using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;//

namespace ZapateriaSuperShoes
{
    public partial class Secion : Form
    {
        public Secion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection cn = new SqlConnection("Data Source=ELPEQUE/SQLEXPRESS;Initial Catalog=SuperShoes;Integrated Security=True"))
            
               // Carrito carito = new Carrito();
                //Final de la compra //

              //  SqlCommand cmd = new SqlCommand("insert into Pagos(,id_zapatos,envio,metodo_pago,Ciudad)values('','2010','','paypal','Bogota')",cn);
                 ///// cmd.ExecuteNonQuery();


                //Codigo confrimacion usuarios
                string var_usuario = txt_usuario.Text;
                String var_contrasena = txt_contrasena.Text;

                try
                {
                    switch (var_usuario)
                    {
                        case "David Lopez":
                            MessageBox.Show("Escribiste David lopez, puedes pasar");
                            switch (var_contrasena)
                            {
                                case "1234":
                                    MessageBox.Show("Pago Realizado Correctamente");
                                    break;
                                default:
                                    MessageBox.Show("Contraseña incorrecta, Pago no efectuado");
                                    break;

                            }
                            break;

                        case "Evelyn Molina":
                            MessageBox.Show("Correcto puedes pasar");
                            switch (var_contrasena)
                            {
                                case "54321":
                                    MessageBox.Show("Pago Realizado Correctamente");
                                    break;
                                default:
                                    MessageBox.Show("Contraseña incorrecta");
                                    break;
                            }
                            break;
                        default:
                            MessageBox.Show("El nombre de usuario o contraseña es incorrecto");
                            break;

                    }
                }
                catch (Exception x)
                {

                    MessageBox.Show("Error: " + x);
                }
            


        }


        private void bt_volver_Click(object sender, EventArgs e)
        {
            //codigo volver formulario anterior 
            Form Formulario = new SuperShop();
            Formulario.Show();
            this.Hide();

        }
            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
        
    }
}
