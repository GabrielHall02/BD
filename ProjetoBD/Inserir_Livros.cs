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
    public partial class Inserir_Livros : UserControl
    {
        public Inserir_Livros()
        {
            InitializeComponent();
        }

        private int getIdFromNomeEditora(string Nome)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Identificador From Editora WHERE Nome = '" + Nome + "'", con);
            var res = cmd.ExecuteReader();
            res.Read();
            int id = (int)res["Identificador"];
           
            return id;
        }

        private int getIdFromNomeAutor(string Nome)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Identificador From Autor WHERE Nome = '" + Nome + "'", con);
            var res = cmd.ExecuteReader();
            res.Read();
            int id = (int)res["Identificador"];
            res.Close();
           
            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Livro (Ref, Titulo, Price, Iva, ID_Editora, ID_Autor, Tipo_Produto) " +
                "Values (@Ref, @Titulo, @Price, @Iva, @ID_Editora, @ID_Autor, @Tipo_Produto)", con);

            cmd.Parameters.AddWithValue("@Ref", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Titulo", textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Iva", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@ID_Editora", getIdFromNomeEditora(textBox5.Text));
            cmd.Parameters.AddWithValue("@ID_Autor", getIdFromNomeAutor(textBox6.Text));
            cmd.Parameters.AddWithValue("@Tipo_Produto", 1);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Inserted with success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("Update Livro set Titulo=@Titulo, Price=@Price, Iva=@Iva, ID_Editora=@ID_Editora, ID_Autor=@ID_Autor, Tipo_Produto=@Tipo_Produto WHERE Ref=@Ref", con);
            var myCommand = new SqlCommand("SELECT Ref From Livro WHERE Ref = @Ref", con);

            myCommand.Parameters.AddWithValue("@Ref", int.Parse(textBox1.Text));
            var rd = myCommand.ExecuteReader();

            bool bookExists = rd.HasRows;
            if (bookExists)
            {
                cmd.Parameters.AddWithValue("@Ref", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Titulo", textBox2.Text);
                cmd.Parameters.AddWithValue("@Price", double.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Iva", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@ID_Editora", getIdFromNomeEditora(textBox5.Text));
                cmd.Parameters.AddWithValue("@ID_Autor", getIdFromNomeAutor(textBox6.Text));
                cmd.Parameters.AddWithValue("@Tipo_Produto", 1);
                rd.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated with success");
            }
            else
            {
                MessageBox.Show("ISBN nao existe");
            }


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Livro WHERE Ref=@Ref", con);
            var myCommand = new SqlCommand("SELECT Ref From Livro WHERE Ref = @Ref", con);
            SqlCommand com = new SqlCommand("Delete From Produto where Ref = @Ref",con);

            myCommand.Parameters.AddWithValue("@Ref", int.Parse(textBox1.Text));
            var rd = myCommand.ExecuteReader();

            bool bookExists = rd.HasRows;
            if (bookExists)
            {
                cmd.Parameters.AddWithValue("@Ref", int.Parse(textBox1.Text));
                rd.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted with success");
            }
            else
            {
                MessageBox.Show("ISBN nao existe");
            }


            con.Close();
        }
    }
}
