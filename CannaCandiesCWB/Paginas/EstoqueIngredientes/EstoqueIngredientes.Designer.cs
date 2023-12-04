namespace CannaCandiesCWB.Paginas.EstoqueIngredientes
{
    partial class EstoqueIngredientes
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
            lbConectado = new Label();
            label2 = new Label();
            label1 = new Label();
            gBoxEstoque = new GroupBox();
            lblFiltroNome = new Label();
            lblFiltro = new Label();
            txtBoxFiltroNome = new TextBox();
            btnPesquisa = new Button();
            lvEstoque = new ListView();
            clnId = new ColumnHeader();
            clnNome = new ColumnHeader();
            clnQuantidadeEstoque = new ColumnHeader();
            clnUnidadeEstoque = new ColumnHeader();
            clnValorUnidade = new ColumnHeader();
            clnQuantidadeCompra = new ColumnHeader();
            clnUnidadeCompra = new ColumnHeader();
            clnValorCompra = new ColumnHeader();
            gBoxCriacaoEdicao = new GroupBox();
            panel1 = new Panel();
            btnAdicionarIngrediente = new Button();
            label8 = new Label();
            txtBoxIngredienteSelecionadoValorCompra = new TextBox();
            label7 = new Label();
            txtBoxIngredienteSelecionadoUnidadeCompra = new TextBox();
            label6 = new Label();
            txtBoxIngredienteSelecionadoQuantidadeCompra = new TextBox();
            label5 = new Label();
            txtBoxIngredienteSelecionadoValorUnidade = new TextBox();
            label4 = new Label();
            txtBoxIngredienteSelecionadoUnidadeEstoque = new TextBox();
            btnDeletarIngrediente = new Button();
            lblIngredienteSelecionadoNome = new Label();
            lblIngredienteSelecionadoQuantidadeEstoque = new Label();
            btnSalvarIngrediente = new Button();
            txtBoxIngredienteSelecionadoNome = new TextBox();
            txtBoxIngredienteSelecionadoQuantidadeEstoque = new TextBox();
            label3 = new Label();
            gBoxEstoque.SuspendLayout();
            gBoxCriacaoEdicao.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbConectado
            // 
            lbConectado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbConectado.AutoSize = true;
            lbConectado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbConectado.ForeColor = Color.FromArgb(128, 255, 128);
            lbConectado.Location = new Point(1053, 603);
            lbConectado.Name = "lbConectado";
            lbConectado.Size = new Size(159, 20);
            lbConectado.TabIndex = 1;
            lbConectado.Text = "Conectado ao estoque";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 607);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "CannaCandiesCWB";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(322, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 40);
            label1.TabIndex = 3;
            label1.Text = "Estoque de ingredientes";
            // 
            // gBoxEstoque
            // 
            gBoxEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gBoxEstoque.Controls.Add(lblFiltroNome);
            gBoxEstoque.Controls.Add(lblFiltro);
            gBoxEstoque.Controls.Add(txtBoxFiltroNome);
            gBoxEstoque.Controls.Add(btnPesquisa);
            gBoxEstoque.Controls.Add(lvEstoque);
            gBoxEstoque.Location = new Point(12, 52);
            gBoxEstoque.Name = "gBoxEstoque";
            gBoxEstoque.Size = new Size(899, 548);
            gBoxEstoque.TabIndex = 4;
            gBoxEstoque.TabStop = false;
            // 
            // lblFiltroNome
            // 
            lblFiltroNome.AutoSize = true;
            lblFiltroNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiltroNome.ForeColor = SystemColors.ButtonFace;
            lblFiltroNome.Location = new Point(6, 52);
            lblFiltroNome.Name = "lblFiltroNome";
            lblFiltroNome.Size = new Size(53, 21);
            lblFiltroNome.TabIndex = 8;
            lblFiltroNome.Text = "Nome";
            // 
            // lblFiltro
            // 
            lblFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiltro.ForeColor = SystemColors.ButtonFace;
            lblFiltro.Location = new Point(424, 21);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(59, 30);
            lblFiltro.TabIndex = 7;
            lblFiltro.Text = "Filtro";
            // 
            // txtBoxFiltroNome
            // 
            txtBoxFiltroNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFiltroNome.Location = new Point(6, 76);
            txtBoxFiltroNome.Name = "txtBoxFiltroNome";
            txtBoxFiltroNome.Size = new Size(749, 33);
            txtBoxFiltroNome.TabIndex = 7;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisa.BackColor = Color.Green;
            btnPesquisa.BackgroundImageLayout = ImageLayout.Center;
            btnPesquisa.ForeColor = Color.White;
            btnPesquisa.Location = new Point(761, 75);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(132, 34);
            btnPesquisa.TabIndex = 7;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = false;
            btnPesquisa.Click += PesquisarIngrediente;
            // 
            // lvEstoque
            // 
            lvEstoque.Columns.AddRange(new ColumnHeader[] { clnId, clnNome, clnQuantidadeEstoque, clnUnidadeEstoque, clnValorUnidade, clnQuantidadeCompra, clnUnidadeCompra, clnValorCompra });
            lvEstoque.FullRowSelect = true;
            lvEstoque.GridLines = true;
            lvEstoque.Location = new Point(6, 115);
            lvEstoque.Name = "lvEstoque";
            lvEstoque.Size = new Size(887, 429);
            lvEstoque.TabIndex = 0;
            lvEstoque.UseCompatibleStateImageBehavior = false;
            lvEstoque.View = View.Details;
            lvEstoque.SelectedIndexChanged += CarregarIngredienteSelecionado;
            // 
            // clnId
            // 
            clnId.Text = "Id";
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Text = "Nome";
            clnNome.Width = 120;
            // 
            // clnQuantidadeEstoque
            // 
            clnQuantidadeEstoque.Text = "Quantidade em estoque";
            clnQuantidadeEstoque.TextAlign = HorizontalAlignment.Right;
            clnQuantidadeEstoque.Width = 140;
            // 
            // clnUnidadeEstoque
            // 
            clnUnidadeEstoque.Text = "Unidade do estoque";
            clnUnidadeEstoque.Width = 120;
            // 
            // clnValorUnidade
            // 
            clnValorUnidade.Text = "Valor por unidade";
            clnValorUnidade.Width = 110;
            // 
            // clnQuantidadeCompra
            // 
            clnQuantidadeCompra.Text = "Quantidade por compra";
            clnQuantidadeCompra.TextAlign = HorizontalAlignment.Right;
            clnQuantidadeCompra.Width = 140;
            // 
            // clnUnidadeCompra
            // 
            clnUnidadeCompra.Text = "Unidade de compra";
            clnUnidadeCompra.Width = 120;
            // 
            // clnValorCompra
            // 
            clnValorCompra.Text = "Valor por Compra";
            clnValorCompra.Width = 110;
            // 
            // gBoxCriacaoEdicao
            // 
            gBoxCriacaoEdicao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gBoxCriacaoEdicao.Controls.Add(panel1);
            gBoxCriacaoEdicao.Controls.Add(label3);
            gBoxCriacaoEdicao.Location = new Point(917, 52);
            gBoxCriacaoEdicao.Name = "gBoxCriacaoEdicao";
            gBoxCriacaoEdicao.Size = new Size(295, 548);
            gBoxCriacaoEdicao.TabIndex = 5;
            gBoxCriacaoEdicao.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnAdicionarIngrediente);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtBoxIngredienteSelecionadoValorCompra);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtBoxIngredienteSelecionadoUnidadeCompra);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBoxIngredienteSelecionadoQuantidadeCompra);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtBoxIngredienteSelecionadoValorUnidade);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtBoxIngredienteSelecionadoUnidadeEstoque);
            panel1.Controls.Add(btnDeletarIngrediente);
            panel1.Controls.Add(lblIngredienteSelecionadoNome);
            panel1.Controls.Add(lblIngredienteSelecionadoQuantidadeEstoque);
            panel1.Controls.Add(btnSalvarIngrediente);
            panel1.Controls.Add(txtBoxIngredienteSelecionadoNome);
            panel1.Controls.Add(txtBoxIngredienteSelecionadoQuantidadeEstoque);
            panel1.Location = new Point(6, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 481);
            panel1.TabIndex = 7;
            // 
            // btnAdicionarIngrediente
            // 
            btnAdicionarIngrediente.BackColor = Color.Yellow;
            btnAdicionarIngrediente.BackgroundImageLayout = ImageLayout.Center;
            btnAdicionarIngrediente.Location = new Point(75, 561);
            btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            btnAdicionarIngrediente.Size = new Size(91, 29);
            btnAdicionarIngrediente.TabIndex = 17;
            btnAdicionarIngrediente.Text = "Adicionar";
            btnAdicionarIngrediente.UseVisualStyleBackColor = false;
            btnAdicionarIngrediente.Click += AdicionarIngrediente;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(6, 484);
            label8.Name = "label8";
            label8.Size = new Size(151, 25);
            label8.TabIndex = 16;
            label8.Text = "Valor da compra";
            // 
            // txtBoxIngredienteSelecionadoValorCompra
            // 
            txtBoxIngredienteSelecionadoValorCompra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIngredienteSelecionadoValorCompra.Location = new Point(6, 512);
            txtBoxIngredienteSelecionadoValorCompra.Name = "txtBoxIngredienteSelecionadoValorCompra";
            txtBoxIngredienteSelecionadoValorCompra.Size = new Size(257, 39);
            txtBoxIngredienteSelecionadoValorCompra.TabIndex = 15;
            txtBoxIngredienteSelecionadoValorCompra.TextChanged += PreencherValorCompra;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(6, 406);
            label7.Name = "label7";
            label7.Size = new Size(186, 25);
            label7.TabIndex = 14;
            label7.Text = "Unidade por compra";
            // 
            // txtBoxIngredienteSelecionadoUnidadeCompra
            // 
            txtBoxIngredienteSelecionadoUnidadeCompra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIngredienteSelecionadoUnidadeCompra.Location = new Point(6, 434);
            txtBoxIngredienteSelecionadoUnidadeCompra.Name = "txtBoxIngredienteSelecionadoUnidadeCompra";
            txtBoxIngredienteSelecionadoUnidadeCompra.Size = new Size(257, 39);
            txtBoxIngredienteSelecionadoUnidadeCompra.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(6, 325);
            label6.Name = "label6";
            label6.Size = new Size(214, 25);
            label6.TabIndex = 12;
            label6.Text = "Quantidade por compra";
            // 
            // txtBoxIngredienteSelecionadoQuantidadeCompra
            // 
            txtBoxIngredienteSelecionadoQuantidadeCompra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIngredienteSelecionadoQuantidadeCompra.Location = new Point(6, 353);
            txtBoxIngredienteSelecionadoQuantidadeCompra.Name = "txtBoxIngredienteSelecionadoQuantidadeCompra";
            txtBoxIngredienteSelecionadoQuantidadeCompra.Size = new Size(257, 39);
            txtBoxIngredienteSelecionadoQuantidadeCompra.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(6, 244);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 10;
            label5.Text = "Valor por unidade";
            // 
            // txtBoxIngredienteSelecionadoValorUnidade
            // 
            txtBoxIngredienteSelecionadoValorUnidade.Enabled = false;
            txtBoxIngredienteSelecionadoValorUnidade.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIngredienteSelecionadoValorUnidade.Location = new Point(6, 272);
            txtBoxIngredienteSelecionadoValorUnidade.Name = "txtBoxIngredienteSelecionadoValorUnidade";
            txtBoxIngredienteSelecionadoValorUnidade.Size = new Size(257, 39);
            txtBoxIngredienteSelecionadoValorUnidade.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(6, 161);
            label4.Name = "label4";
            label4.Size = new Size(186, 25);
            label4.TabIndex = 8;
            label4.Text = "Unidade em estoque";
            // 
            // txtBoxIngredienteSelecionadoUnidadeEstoque
            // 
            txtBoxIngredienteSelecionadoUnidadeEstoque.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIngredienteSelecionadoUnidadeEstoque.Location = new Point(6, 189);
            txtBoxIngredienteSelecionadoUnidadeEstoque.Name = "txtBoxIngredienteSelecionadoUnidadeEstoque";
            txtBoxIngredienteSelecionadoUnidadeEstoque.Size = new Size(257, 39);
            txtBoxIngredienteSelecionadoUnidadeEstoque.TabIndex = 7;
            // 
            // btnDeletarIngrediente
            // 
            btnDeletarIngrediente.BackColor = Color.Maroon;
            btnDeletarIngrediente.BackgroundImageLayout = ImageLayout.Center;
            btnDeletarIngrediente.ForeColor = Color.White;
            btnDeletarIngrediente.Location = new Point(6, 561);
            btnDeletarIngrediente.Name = "btnDeletarIngrediente";
            btnDeletarIngrediente.Size = new Size(62, 29);
            btnDeletarIngrediente.TabIndex = 6;
            btnDeletarIngrediente.Text = "Deletar";
            btnDeletarIngrediente.UseVisualStyleBackColor = false;
            btnDeletarIngrediente.Click += DeletarIngrediente;
            // 
            // lblIngredienteSelecionadoNome
            // 
            lblIngredienteSelecionadoNome.AutoSize = true;
            lblIngredienteSelecionadoNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngredienteSelecionadoNome.ForeColor = SystemColors.ButtonFace;
            lblIngredienteSelecionadoNome.Location = new Point(3, 0);
            lblIngredienteSelecionadoNome.Name = "lblIngredienteSelecionadoNome";
            lblIngredienteSelecionadoNome.Size = new Size(67, 25);
            lblIngredienteSelecionadoNome.TabIndex = 2;
            lblIngredienteSelecionadoNome.Text = "Nome:";
            // 
            // lblIngredienteSelecionadoQuantidadeEstoque
            // 
            lblIngredienteSelecionadoQuantidadeEstoque.AutoSize = true;
            lblIngredienteSelecionadoQuantidadeEstoque.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngredienteSelecionadoQuantidadeEstoque.ForeColor = SystemColors.ButtonFace;
            lblIngredienteSelecionadoQuantidadeEstoque.Location = new Point(6, 81);
            lblIngredienteSelecionadoQuantidadeEstoque.Name = "lblIngredienteSelecionadoQuantidadeEstoque";
            lblIngredienteSelecionadoQuantidadeEstoque.Size = new Size(214, 25);
            lblIngredienteSelecionadoQuantidadeEstoque.TabIndex = 4;
            lblIngredienteSelecionadoQuantidadeEstoque.Text = "Quantidade em estoque";
            // 
            // btnSalvarIngrediente
            // 
            btnSalvarIngrediente.BackColor = Color.Green;
            btnSalvarIngrediente.BackgroundImageLayout = ImageLayout.Center;
            btnSalvarIngrediente.Location = new Point(172, 561);
            btnSalvarIngrediente.Name = "btnSalvarIngrediente";
            btnSalvarIngrediente.Size = new Size(91, 29);
            btnSalvarIngrediente.TabIndex = 5;
            btnSalvarIngrediente.Text = "Salvar";
            btnSalvarIngrediente.UseVisualStyleBackColor = false;
            btnSalvarIngrediente.Click += AtualizarIngrediente;
            // 
            // txtBoxIngredienteSelecionadoNome
            // 
            txtBoxIngredienteSelecionadoNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIngredienteSelecionadoNome.Location = new Point(6, 28);
            txtBoxIngredienteSelecionadoNome.Name = "txtBoxIngredienteSelecionadoNome";
            txtBoxIngredienteSelecionadoNome.Size = new Size(257, 39);
            txtBoxIngredienteSelecionadoNome.TabIndex = 0;
            // 
            // txtBoxIngredienteSelecionadoQuantidadeEstoque
            // 
            txtBoxIngredienteSelecionadoQuantidadeEstoque.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIngredienteSelecionadoQuantidadeEstoque.Location = new Point(6, 109);
            txtBoxIngredienteSelecionadoQuantidadeEstoque.Name = "txtBoxIngredienteSelecionadoQuantidadeEstoque";
            txtBoxIngredienteSelecionadoQuantidadeEstoque.Size = new Size(257, 39);
            txtBoxIngredienteSelecionadoQuantidadeEstoque.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(83, 19);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 1;
            label3.Text = "Ingrediente";
            // 
            // EstoqueIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1224, 631);
            Controls.Add(gBoxCriacaoEdicao);
            Controls.Add(gBoxEstoque);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lbConectado);
            Name = "EstoqueIngredientes";
            Text = "Estoque";
            Load += OnLoad;
            gBoxEstoque.ResumeLayout(false);
            gBoxEstoque.PerformLayout();
            gBoxCriacaoEdicao.ResumeLayout(false);
            gBoxCriacaoEdicao.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label lbConectado;
        private GroupBox gBoxEstoque;
        private ListView lvEstoque;
        private GroupBox gBoxCriacaoEdicao;
        private Label label3;
        private TextBox txtBoxIngredienteSelecionadoNome;
        private Button btnSalvarIngrediente;
        private Label lblIngredienteSelecionadoQuantidadeEstoque;
        private TextBox txtBoxIngredienteSelecionadoQuantidadeEstoque;
        private Label lblIngredienteSelecionadoNome;
        private Button btnDeletarIngrediente;
        private ColumnHeader clnId;
        private ColumnHeader clnNome;
        private ColumnHeader clnQuantidadeEstoque;
        private ColumnHeader clnUnidadeEstoque;
        private ColumnHeader clnValorUnidade;
        private ColumnHeader clnQuantidadeCompra;
        private ColumnHeader clnUnidadeCompra;
        private ColumnHeader clnValorCompra;
        private Button btnPesquisa;
        private Label lblFiltroNome;
        private Label lblFiltro;
        private TextBox txtBoxFiltroNome;
        private Panel panel1;
        private Label label4;
        private TextBox txtBoxIngredienteSelecionadoUnidadeEstoque;
        private TextBox txtBoxIngredienteSelecionadoValorCompra;
        private Label label7;
        private TextBox txtBoxIngredienteSelecionadoUnidadeCompra;
        private Label label6;
        private TextBox txtBoxIngredienteSelecionadoQuantidadeCompra;
        private Label label5;
        private TextBox txtBoxIngredienteSelecionadoValorUnidade;
        private Label label8;
        private Button btnAdicionarIngrediente;
    }
}