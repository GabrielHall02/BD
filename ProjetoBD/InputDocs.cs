using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoBD
{
    public partial class InputDocs : UserControl
    {
        public InputDocs()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Criar Documento novo do tipo fatura de venda
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT into Documento(Tipo, Data, NIF) Values (@Tipo, @Data, @NIF)", con);

            cmd.Parameters.AddWithValue("@NIF", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@Data", DateTime.Now);
            cmd.Parameters.AddWithValue("@Tipo", 1); //Compra
            cmd.ExecuteNonQuery();


            //FacVenda deve passar a estar show() e bring to front
            facVenda1.Show();
            facVenda1.BringToFront();
        }

        private void InputDocs_Load(object sender, EventArgs e)
        {
            facVenda1.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(maskedTextBox1.Text))
            {
                facVenda1.Show();
                facVenda1.BringToFront();

                //Criar Documento novo do tipo fatura de venda
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT into Documento(Tipo, Data, NIF) Values (@Tipo, @Data, @NIF)", con);

                cmd.Parameters.AddWithValue("@NIF", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@Data", DateTime.Now);
                cmd.Parameters.AddWithValue("@Tipo", 2); //Compra
                cmd.ExecuteNonQuery();


            }
            else
            {
                MessageBox.Show("Obrigatório preencher NIF");
            }
        }
    }
}
