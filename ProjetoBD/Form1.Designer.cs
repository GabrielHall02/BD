namespace ProjetoBD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linha_FaturaTableAdapter1 = new ProjetoBD.LivrariaDataSetTableAdapters.Linha_FaturaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.welcome1 = new ProjetoBD.welcome();
            this.inserir_editora1 = new ProjetoBD.inserir_editora();
            this.inserir_Livros1 = new ProjetoBD.Inserir_Livros();
            this.inserir_autor1 = new ProjetoBD.inserir_autor();
            this.invetario1 = new ProjetoBD.invetario();
            this.fornecedor1 = new ProjetoBD.fornecedor();
            this.cliente1 = new ProjetoBD.cliente();
            this.inputDocs1 = new ProjetoBD.InputDocs();
            this.historicoVendas1 = new ProjetoBD.HistoricoVendas();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linha_FaturaTableAdapter1
            // 
            this.linha_FaturaTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 845);
            this.panel1.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 488);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 35);
            this.button8.TabIndex = 27;
            this.button8.Text = "Histórico Vendas";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 434);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 35);
            this.button7.TabIndex = 26;
            this.button7.Text = "Inserir Documeto";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 379);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 35);
            this.button6.TabIndex = 25;
            this.button6.Text = "Inserir Cliente";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "Inserir Fornecedor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Inventário";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 575);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inserir Autor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 37);
            this.button5.TabIndex = 1;
            this.button5.Text = "Inserir Editora";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 41);
            this.button4.TabIndex = 0;
            this.button4.Text = "Inserir Livro";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // welcome1
            // 
            this.welcome1.Location = new System.Drawing.Point(194, 0);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(1253, 923);
            this.welcome1.TabIndex = 20;
            this.welcome1.Load += new System.EventHandler(this.welcome1_Load);
            // 
            // inserir_editora1
            // 
            this.inserir_editora1.Location = new System.Drawing.Point(197, 0);
            this.inserir_editora1.Name = "inserir_editora1";
            this.inserir_editora1.Size = new System.Drawing.Size(1256, 1041);
            this.inserir_editora1.TabIndex = 19;
            // 
            // inserir_Livros1
            // 
            this.inserir_Livros1.Location = new System.Drawing.Point(197, 0);
            this.inserir_Livros1.Name = "inserir_Livros1";
            this.inserir_Livros1.Size = new System.Drawing.Size(1259, 1007);
            this.inserir_Livros1.TabIndex = 19;
            // 
            // inserir_autor1
            // 
            this.inserir_autor1.Location = new System.Drawing.Point(197, 0);
            this.inserir_autor1.Name = "inserir_autor1";
            this.inserir_autor1.Size = new System.Drawing.Size(1256, 745);
            this.inserir_autor1.TabIndex = 21;
            // 
            // invetario1
            // 
            this.invetario1.Location = new System.Drawing.Point(197, 0);
            this.invetario1.Name = "invetario1";
            this.invetario1.Size = new System.Drawing.Size(1256, 745);
            this.invetario1.TabIndex = 22;
            // 
            // fornecedor1
            // 
            this.fornecedor1.Location = new System.Drawing.Point(197, 0);
            this.fornecedor1.Name = "fornecedor1";
            this.fornecedor1.Size = new System.Drawing.Size(1256, 575);
            this.fornecedor1.TabIndex = 23;
            // 
            // cliente1
            // 
            this.cliente1.Location = new System.Drawing.Point(206, 0);
            this.cliente1.Name = "cliente1";
            this.cliente1.Size = new System.Drawing.Size(1247, 578);
            this.cliente1.TabIndex = 24;
            // 
            // inputDocs1
            // 
            this.inputDocs1.Location = new System.Drawing.Point(197, 0);
            this.inputDocs1.Name = "inputDocs1";
            this.inputDocs1.Size = new System.Drawing.Size(1256, 715);
            this.inputDocs1.TabIndex = 25;
            // 
            // historicoVendas1
            // 
            this.historicoVendas1.Location = new System.Drawing.Point(206, 0);
            this.historicoVendas1.Name = "historicoVendas1";
            this.historicoVendas1.Size = new System.Drawing.Size(1782, 800);
            this.historicoVendas1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 845);
            this.Controls.Add(this.welcome1);
            this.Controls.Add(this.inserir_editora1);
            this.Controls.Add(this.inserir_Livros1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inserir_autor1);
            this.Controls.Add(this.invetario1);
            this.Controls.Add(this.fornecedor1);
            this.Controls.Add(this.cliente1);
            this.Controls.Add(this.inputDocs1);
            this.Controls.Add(this.historicoVendas1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LivrariaDataSetTableAdapters.Linha_FaturaTableAdapter linha_FaturaTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private Inserir_Livros inserir_Livros1;
        private welcome welcome1;
        private inserir_editora inserir_editora1;
        private System.Windows.Forms.Button button1;
        private inserir_autor inserir_autor1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private invetario invetario1;
        private System.Windows.Forms.Button button3;
        private fornecedor fornecedor1;
        private System.Windows.Forms.Button button6;
        private cliente cliente1;
        private System.Windows.Forms.Button button7;
        private InputDocs inputDocs1;
        private System.Windows.Forms.Button button8;
        private HistoricoVendas historicoVendas1;
    }
}

