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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inserir_editora1.Hide();
            inserir_Livros1.Show();
            inserir_Livros1.BringToFront();
            welcome1.Hide();
            inserir_autor1.Hide();
            fornecedor1.Hide();
            cliente1.Hide();
            inputDocs1.Hide();
            historicoVendas1.Hide();
        }

        private void inserir_Livros1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            inserir_Livros1.Hide();
            inserir_editora1.Show();
            inserir_editora1.BringToFront();
            welcome1.Hide();
            inserir_autor1.Hide();
            fornecedor1.Hide();
            cliente1.Hide();
            inputDocs1.Hide();
            historicoVendas1.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inserir_autor1.Show();
            inserir_autor1.BringToFront();
            inserir_Livros1.Hide();
            inserir_editora1.Hide();
            welcome1.Hide();
            fornecedor1.Hide();
            cliente1.Hide();
            inputDocs1.Hide();
            historicoVendas1.Hide();
        }

        private void welcome1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            invetario1.Show();
            invetario1.BringToFront();
            inserir_autor1.Hide();
            inserir_Livros1.Hide();
            inserir_editora1.Hide();
            welcome1.Hide();
            fornecedor1.Hide();
            cliente1.Hide();
            inputDocs1.Hide();
            historicoVendas1.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fornecedor1.Show();
            fornecedor1.BringToFront();
            inserir_autor1.Hide();
            inserir_Livros1.Hide();
            inserir_editora1.Hide();
            welcome1.Hide();
            invetario1.Hide();
            cliente1.Hide();
            inputDocs1.Hide();
            historicoVendas1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cliente1.Show();
            cliente1.BringToFront();
            inserir_autor1.Hide();
            inserir_Livros1.Hide();
            inserir_editora1.Hide();
            welcome1.Hide();
            invetario1.Hide();
            fornecedor1.Hide();
            inputDocs1.Hide();
            historicoVendas1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputDocs1.Show();
            inputDocs1.BringToFront();
            inserir_autor1.Hide();
            inserir_Livros1.Hide();
            inserir_editora1.Hide();
            welcome1.Hide();
            invetario1.Hide();
            fornecedor1.Hide();
            cliente1.Hide();
            historicoVendas1.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            historicoVendas1.Show();
            historicoVendas1.BringToFront();
            inputDocs1.Hide();
            inserir_autor1.Hide();
            inserir_Livros1.Hide();
            inserir_editora1.Hide();
            welcome1.Hide();
            invetario1.Hide();
            fornecedor1.Hide();
            cliente1.Hide();
        }
    }
}
