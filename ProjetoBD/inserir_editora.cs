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
    public partial class inserir_editora : UserControl
    {
        public inserir_editora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g6;Persist Security Info=True;User ID=p8g6;Password=1710358134@BD");

            con.Open();

            SqlCommand cmd = new SqlCommand("exec insert_editora @Name = @Nome", con);

            cmd.Parameters.AddWithValue("@Nome", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted with success");

            con.Close();
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=carlosserver\sqlserver;Initial Catalog=Livraria;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE  Editora set Nome=@Nome WHERE Identificador = @ID", con);
            var myCommand = new SqlCommand("SELECT Identificador From Editora WHERE Identificador = @ID", con);

            myCommand.Parameters.AddWithValue("@ID", getIdFromNome(textBox2.Text));
            var rd = myCommand.ExecuteReader();

            bool exists = rd.HasRows;
            if (exists)
            {
                cmd.Parameters.AddWithValue("@ID", getIdFromNome(textBox2.Text));
                cmd.Parameters.AddWithValue("@Nome", textBox2.Text);
                rd.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated with success");
            }
            else
            {
                MessageBox.Show("Identificador não existe");
            }


            con.Close();
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g6;Persist Security Info=True;User ID=p8g6;Password=1710358134@BD");

            con.Open();

            SqlCommand cmd = new SqlCommand("exec delete_editora @Name = @Nome", con);

            cmd.Parameters.AddWithValue("@Nome", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted with success");



            con.Close();
        }
    }
}
