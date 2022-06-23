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
    public partial class FacVenda : UserControl
    {
        public FacVenda()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True");
            con.Open();
            
            SqlCommand getType = new SqlCommand("select dbo.get_ProdType(@Prod_Ref) AS Tipo", con);
            getType.Parameters.AddWithValue("@Prod_Ref", textBox1.Text);
            var res = getType.ExecuteReader();
            res.Read();
            int tipo = (int)res["Tipo"];
            res.Close();
            if (tipo == 1)
            {
                //Get Book price
                SqlCommand getPrice = new SqlCommand("select dbo.get_Price(@Book_Ref) AS Price", con);
                getPrice.Parameters.AddWithValue("@Book_Ref", textBox1.Text);
                var resu = getPrice.ExecuteReader();
                resu.Read();
                decimal price = (decimal)resu["Price"];
                resu.Close();

                //Get last doc ID
                SqlCommand getDoc = new SqlCommand("select dbo.get_LastDoc() AS ID", con);
                var resul = getDoc.ExecuteReader();
                resul.Read();
                int doc_ID = (int)resul["ID"];
                resul.Close();


                //Create line
                SqlCommand cmd = new SqlCommand("Insert into Linha_Fatura(n_linha,ID_Fac,Ref_Item,Price,Desconto,Quantity) " +
                "VALUES(@n_linha,@ID,@Ref,@Price,@Des,@Qt)", con);

                cmd.Parameters.AddWithValue("@n_linha", 999);
                cmd.Parameters.AddWithValue("@ID", doc_ID);
                cmd.Parameters.AddWithValue("@Ref", textBox1.Text);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Des", int.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@Qt", int.Parse(textBox2.Text));
                cmd.ExecuteNonQuery();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT n_linha as Linha,Ref_Item,Price,Desconto,Quantity FROM Linha_Fatura where ID_Fac = "+doc_ID, con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;

                
            }
            

            //Get Pacote price


            //MessageBox.Show("Prod type = " + tipo.ToString());
        }
    }
}
