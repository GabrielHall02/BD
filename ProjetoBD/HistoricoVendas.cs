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
    public partial class HistoricoVendas : UserControl
    {
        public HistoricoVendas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoricoVendas_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Ref, Titulo, Price, Qt, Data_Venda FROM Historico_vendas " +
                    "JOIN Produto on Historico_vendas.Ref_Produto = Produto.Ref ", con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand cmd = new SqlCommand("select dbo.get_Faturacao() as Total", con);
                var rd = cmd.ExecuteReader();
                rd.Read();
                string tota = rd["Total"].ToString();
                if (!String.IsNullOrEmpty(tota))
                {
                    int total = (int)rd["Total"];

                    label3.Text = total.ToString()+"€";
                }
                

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-JLR4AMV;Initial Catalog=Livraria;Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Ref_Produto, Titulo, Price, Desconto, Qt,  Data_Venda FROM Historico_vendas " +
                    "JOIN Produto on Historico_vendas.Ref_Produto = Produto.Ref ORDER BY Data_Venda ASC", con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand cmd = new SqlCommand("select dbo.get_Faturacao() as Total", con);
                var rd = cmd.ExecuteReader();
                bool exists = rd.HasRows;
                if (exists)
                {
                    rd.Read();
                    int total = (int)rd["Total"];

                    label3.Text = total.ToString() + "€";
                }
                else
                {
                    label3.Text = 0 + "€";
                }
                

                

            }
        }
    }
}
