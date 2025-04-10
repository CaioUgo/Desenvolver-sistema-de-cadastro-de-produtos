namespace Desenvolver_sistema_de_cadastro_de_produtos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCadastro = new Button();
            ListadeProdutosData = new DataGridView();
            lblNome = new Label();
            txtNome = new TextBox();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            label3 = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            label4 = new Label();
            cBoxCatego = new ComboBox();
            lblcatego = new Label();
            ((System.ComponentModel.ISupportInitialize)ListadeProdutosData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 59);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(176, 141);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(132, 28);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "Cadastrar produto";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // ListadeProdutosData
            // 
            ListadeProdutosData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListadeProdutosData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ListadeProdutosData.BackgroundColor = SystemColors.GradientInactiveCaption;
            ListadeProdutosData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListadeProdutosData.Location = new Point(468, 12);
            ListadeProdutosData.Name = "ListadeProdutosData";
            ListadeProdutosData.Size = new Size(424, 486);
            ListadeProdutosData.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 22);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(106, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome do produto:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(234, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(12, 95);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(234, 23);
            txtCategoria.TabIndex = 7;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(12, 77);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 114);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(296, 40);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(137, 23);
            txtPreco.TabIndex = 10;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(296, 22);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 9;
            lblPreco.Text = "Preço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 59);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // cBoxCatego
            // 
            cBoxCatego.FormattingEnabled = true;
            cBoxCatego.Location = new Point(12, 286);
            cBoxCatego.Name = "cBoxCatego";
            cBoxCatego.Size = new Size(151, 23);
            cBoxCatego.TabIndex = 11;
            // 
            // lblcatego
            // 
            lblcatego.AutoSize = true;
            lblcatego.Location = new Point(12, 268);
            lblcatego.Name = "lblcatego";
            lblcatego.Size = new Size(66, 15);
            lblcatego.TabIndex = 12;
            lblcatego.Text = "Categorias:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 510);
            Controls.Add(lblcatego);
            Controls.Add(cBoxCatego);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(label4);
            Controls.Add(txtCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(ListadeProdutosData);
            Controls.Add(btnCadastro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ListadeProdutosData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCadastro;
        private DataGridView ListadeProdutosData;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCategoria;
        private Label lblCategoria;
        private Label label3;
        private TextBox txtPreco;
        private Label lblPreco;
        private Label label4;
        private ComboBox cBoxCatego;
        private Label lblcatego;
    }
}
