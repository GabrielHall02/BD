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
    public partial class fornecedor : UserControl
    {
        public fornecedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g6;Persist Security Info=True;User ID=p8g6;Password=1710358134@BD");

            con.Open();

           
            var myCommand = new SqlCommand("SELECT NIF From Utilizador WHERE NIF = @NIF Tipo=2", con);

            myCommand.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
            var rd = myCommand.ExecuteReader();

            bool exists = rd.HasRows;
            if (exists)
            {
                rd.Close();
                if (String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("No value was changed");
                }
                if (!String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox2.Text))
                { 
                    SqlCommand cmd = new SqlCommand("UPDATE  Utilizador set Endereco=@Address WHERE NIF = @NIF", con);
                    cmd.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                    MessageBox.Show("Updated with success");
                    cmd.ExecuteNonQuery();
                }
                if (String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox2.Text))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE  Utilizador set Nome=@Nome WHERE NIF = @NIF", con);
                    cmd.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Nome", textBox2.Text);
                    MessageBox.Show("Updated with success");
                    cmd.ExecuteNonQuery();
                }
                if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox2.Text))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE  Utilizador set Nome=@Nome, Endereco=@Address WHERE NIF = @NIF", con);
                    cmd.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Nome", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                    MessageBox.Show("Updated with success");
                    cmd.ExecuteNonQuery();
                }
                
            }
            else
            {
                MessageBox.Show("NIF não existe");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g6;Persist Security Info=True;User ID=p8g6;Password=1710358134@BD");

            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Utilizador VALUES(@NIF,@Nome,@Address,@Type)", con);
            var myCommand = new SqlCommand("SELECT NIF From Utilizador WHERE NIF = @NIF", con);

            myCommand.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
            var rd = myCommand.ExecuteReader();

            bool exists = rd.HasRows;
            if (!exists)
            {
                if (!String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox2.Text))
                {
                    cmd.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Nome", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Type", 2);
                    rd.Close();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted with success");

                }
                else
                    MessageBox.Show("Endereço e Nome são obrigatórios");
            }
            else
            {
                MessageBox.Show("NIF já está atribuido a uma Fornecedor");
            }


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g6;Persist Security Info=True;User ID=p8g6;Password=1710358134@BD");

            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Utilizador WHERE NIF = @NIF", con);
            var myCommand = new SqlCommand("SELECT NIF From Utilizador WHERE NIF = @NIF AND Tipo=2", con);

            myCommand.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
            var rd = myCommand.ExecuteReader();

            bool exists = rd.HasRows;
            if (exists)
            {
                cmd.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
                rd.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted with success");
            }
            else
            {
                MessageBox.Show("NIF não existe");
            }


            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
