namespace ProjetoBD
{
    partial class invetario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Editora = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.livrariaDataSet = new ProjetoBD.LivrariaDataSet();
            this.livrariaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroTableAdapter = new ProjetoBD.LivrariaDataSetTableAdapters.LivroTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtrar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // Editora
            // 
            this.Editora.Location = new System.Drawing.Point(171, 115);
            this.Editora.Name = "Editora";
            this.Editora.Size = new System.Drawing.Size(332, 26);
            this.Editora.TabIndex = 4;
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(646, 116);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(332, 26);
            this.Autor.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 299);
            this.dataGridView1.TabIndex = 7;
            // 
            // livrariaDataSet
            // 
            this.livrariaDataSet.DataSetName = "LivrariaDataSet";
            this.livrariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrariaDataSetBindingSource
            // 
            this.livrariaDataSetBindingSource.DataSource = this.livrariaDataSet;
            this.livrariaDataSetBindingSource.Position = 0;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.livrariaDataSetBindingSource;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "ISBN";
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(171, 169);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(332, 26);
            this.Titulo.TabIndex = 10;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(646, 166);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(332, 26);
            this.ISBN.TabIndex = 11;
            // 
            // invetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Editora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "invetario";
            this.Size = new System.Drawing.Size(1250, 584);
            this.Load += new System.EventHandler(this.invetario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Editora;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LivrariaDataSet livrariaDataSet;
        private System.Windows.Forms.BindingSource livrariaDataSetBindingSource;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private LivrariaDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.TextBox ISBN;
    }
}
