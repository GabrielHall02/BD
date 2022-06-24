using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBD
{
    public partial class cliente : UserControl
    {
        public cliente()
        {
            InitializeComponent();
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
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    cmd.Parameters.AddWithValue("@NIF", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Nome", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Type", 1);
                    rd.Close();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted with success");

                }
                else
                    MessageBox.Show("Nome é obrigatório");
            }
            else
            {
                MessageBox.Show("NIF já está atribuido a uma Cliente");
            }


            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g6;Persist Security Info=True;User ID=p8g6;Password=1710358134@BD");

            con.Open();


            var myCommand = new SqlCommand("SELECT NIF From Utilizador WHERE NIF = @NIF AND Tipo=1", con);

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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p8g6;Persist Security Info=True;User ID=p8g6;Password=1710358134@BD");

            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Utilizador WHERE NIF = @NIF", con);
            var myCommand = new SqlCommand("SELECT NIF From Utilizador WHERE NIF = @NIF AND Tipo=1", con);

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
    }
}
