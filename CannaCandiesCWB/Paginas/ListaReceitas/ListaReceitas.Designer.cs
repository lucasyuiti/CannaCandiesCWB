namespace CannaCandiesCWB.Paginas.ListaReceitas
{
    partial class ListaReceitas
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
            gBoxEstoque = new GroupBox();
            button1 = new Button();
            lblFiltroNome = new Label();
            lblFiltro = new Label();
            txtBoxFiltroNome = new TextBox();
            btnPesquisa = new Button();
            lvEstoque = new ListView();
            clnId = new ColumnHeader();
            clnNomeReceita = new ColumnHeader();
            clnValorReceita = new ColumnHeader();
            label2 = new Label();
            lbConectado = new Label();
            label1 = new Label();
            gBoxCriacaoEdicao = new GroupBox();
            panel1 = new Panel();
            btnAdicionarIngrediente = new Button();
            lblQuantidadeIngredientes = new Label();
            txtBoxQuantidadeIngredientes = new TextBox();
            btnDeletarIngrediente = new Button();
            lblNomeReceita = new Label();
            lblValorTotalReceita = new Label();
            btnSalvarIngrediente = new Button();
            txtBoxNomeReceita = new TextBox();
            txtBoxValorTotalReceita = new TextBox();
            label3 = new Label();
            clnIngredientes = new ColumnHeader();
            lblIngredientesReceita = new Label();
            txtBoxIngredientesReceita = new TextBox();
            gBoxEstoque.SuspendLayout();
            gBoxCriacaoEdicao.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxEstoque
            // 
            gBoxEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gBoxEstoque.Controls.Add(button1);
            gBoxEstoque.Controls.Add(lblFiltroNome);
            gBoxEstoque.Controls.Add(lblFiltro);
            gBoxEstoque.Controls.Add(txtBoxFiltroNome);
            gBoxEstoque.Controls.Add(btnPesquisa);
            gBoxEstoque.Controls.Add(lvEstoque);
            gBoxEstoque.Location = new Point(12, 55);
            gBoxEstoque.Name = "gBoxEstoque";
            gBoxEstoque.Size = new Size(899, 548);
            gBoxEstoque.TabIndex = 5;
            gBoxEstoque.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.ForeColor = Color.White;
            button1.Location = new Point(761, 77);
            button1.Name = "button1";
            button1.Size = new Size(132, 34);
            button1.TabIndex = 9;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PesquisarReceita;
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
            btnPesquisa.Location = new Point(1460, 75);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(132, 34);
            btnPesquisa.TabIndex = 7;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // lvEstoque
            // 
            lvEstoque.Columns.AddRange(new ColumnHeader[] { clnId, clnNomeReceita, clnValorReceita, clnIngredientes });
            lvEstoque.FullRowSelect = true;
            lvEstoque.GridLines = true;
            lvEstoque.Location = new Point(6, 115);
            lvEstoque.Name = "lvEstoque";
            lvEstoque.Size = new Size(887, 429);
            lvEstoque.TabIndex = 0;
            lvEstoque.UseCompatibleStateImageBehavior = false;
            lvEstoque.View = View.Details;
            // 
            // clnId
            // 
            clnId.Text = "Id";
            clnId.Width = 40;
            // 
            // clnNomeReceita
            // 
            clnNomeReceita.Text = "Nome";
            clnNomeReceita.Width = 120;
            // 
            // clnValorReceita
            // 
            clnValorReceita.Text = "Valor total da receita";
            clnValorReceita.Width = 200;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 606);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 10;
            label2.Text = "CannaCandiesCWB";
            // 
            // lbConectado
            // 
            lbConectado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbConectado.AutoSize = true;
            lbConectado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbConectado.ForeColor = Color.FromArgb(128, 255, 128);
            lbConectado.Location = new Point(1053, 602);
            lbConectado.Name = "lbConectado";
            lbConectado.Size = new Size(159, 20);
            lbConectado.TabIndex = 9;
            lbConectado.Text = "Conectado ao estoque";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(375, 12);
            label1.Name = "label1";
            label1.Size = new Size(178, 40);
            label1.TabIndex = 11;
            label1.Text = "ListaReceitas";
            // 
            // gBoxCriacaoEdicao
            // 
            gBoxCriacaoEdicao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gBoxCriacaoEdicao.Controls.Add(panel1);
            gBoxCriacaoEdicao.Controls.Add(label3);
            gBoxCriacaoEdicao.Location = new Point(917, 55);
            gBoxCriacaoEdicao.Name = "gBoxCriacaoEdicao";
            gBoxCriacaoEdicao.Size = new Size(295, 548);
            gBoxCriacaoEdicao.TabIndex = 12;
            gBoxCriacaoEdicao.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoScroll = true;
            panel1.Controls.Add(lblIngredientesReceita);
            panel1.Controls.Add(txtBoxIngredientesReceita);
            panel1.Controls.Add(btnAdicionarIngrediente);
            panel1.Controls.Add(lblQuantidadeIngredientes);
            panel1.Controls.Add(txtBoxQuantidadeIngredientes);
            panel1.Controls.Add(btnDeletarIngrediente);
            panel1.Controls.Add(lblNomeReceita);
            panel1.Controls.Add(lblValorTotalReceita);
            panel1.Controls.Add(btnSalvarIngrediente);
            panel1.Controls.Add(txtBoxNomeReceita);
            panel1.Controls.Add(txtBoxValorTotalReceita);
            panel1.Location = new Point(6, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 481);
            panel1.TabIndex = 7;
            // 
            // btnAdicionarIngrediente
            // 
            btnAdicionarIngrediente.BackColor = Color.Yellow;
            btnAdicionarIngrediente.BackgroundImageLayout = ImageLayout.Center;
            btnAdicionarIngrediente.Location = new Point(92, 449);
            btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            btnAdicionarIngrediente.Size = new Size(91, 29);
            btnAdicionarIngrediente.TabIndex = 17;
            btnAdicionarIngrediente.Text = "Adicionar";
            btnAdicionarIngrediente.UseVisualStyleBackColor = false;
            btnAdicionarIngrediente.Click += AdicionarReceita;
            // 
            // lblQuantidadeIngredientes
            // 
            lblQuantidadeIngredientes.AutoSize = true;
            lblQuantidadeIngredientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidadeIngredientes.ForeColor = SystemColors.ButtonFace;
            lblQuantidadeIngredientes.Location = new Point(6, 161);
            lblQuantidadeIngredientes.Name = "lblQuantidadeIngredientes";
            lblQuantidadeIngredientes.Size = new Size(221, 25);
            lblQuantidadeIngredientes.TabIndex = 8;
            lblQuantidadeIngredientes.Text = "Quantidade ingredientes";
            // 
            // txtBoxQuantidadeIngredientes
            // 
            txtBoxQuantidadeIngredientes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxQuantidadeIngredientes.Location = new Point(6, 189);
            txtBoxQuantidadeIngredientes.Name = "txtBoxQuantidadeIngredientes";
            txtBoxQuantidadeIngredientes.Size = new Size(257, 39);
            txtBoxQuantidadeIngredientes.TabIndex = 7;
            // 
            // btnDeletarIngrediente
            // 
            btnDeletarIngrediente.BackColor = Color.Maroon;
            btnDeletarIngrediente.BackgroundImageLayout = ImageLayout.Center;
            btnDeletarIngrediente.ForeColor = Color.White;
            btnDeletarIngrediente.Location = new Point(8, 449);
            btnDeletarIngrediente.Name = "btnDeletarIngrediente";
            btnDeletarIngrediente.Size = new Size(78, 29);
            btnDeletarIngrediente.TabIndex = 6;
            btnDeletarIngrediente.Text = "Deletar";
            btnDeletarIngrediente.UseVisualStyleBackColor = false;
            btnDeletarIngrediente.Click += DeletarReceita;
            // 
            // lblNomeReceita
            // 
            lblNomeReceita.AutoSize = true;
            lblNomeReceita.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeReceita.ForeColor = SystemColors.ButtonFace;
            lblNomeReceita.Location = new Point(3, 0);
            lblNomeReceita.Name = "lblNomeReceita";
            lblNomeReceita.Size = new Size(67, 25);
            lblNomeReceita.TabIndex = 2;
            lblNomeReceita.Text = "Nome:";
            // 
            // lblValorTotalReceita
            // 
            lblValorTotalReceita.AutoSize = true;
            lblValorTotalReceita.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorTotalReceita.ForeColor = SystemColors.ButtonFace;
            lblValorTotalReceita.Location = new Point(6, 81);
            lblValorTotalReceita.Name = "lblValorTotalReceita";
            lblValorTotalReceita.Size = new Size(187, 25);
            lblValorTotalReceita.TabIndex = 4;
            lblValorTotalReceita.Text = "Valor total na receita";
            // 
            // btnSalvarIngrediente
            // 
            btnSalvarIngrediente.BackColor = Color.Green;
            btnSalvarIngrediente.BackgroundImageLayout = ImageLayout.Center;
            btnSalvarIngrediente.Location = new Point(189, 449);
            btnSalvarIngrediente.Name = "btnSalvarIngrediente";
            btnSalvarIngrediente.Size = new Size(91, 29);
            btnSalvarIngrediente.TabIndex = 5;
            btnSalvarIngrediente.Text = "Salvar";
            btnSalvarIngrediente.UseVisualStyleBackColor = false;
            btnSalvarIngrediente.Click += SalvarReceita;
            // 
            // txtBoxNomeReceita
            // 
            txtBoxNomeReceita.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxNomeReceita.Location = new Point(6, 28);
            txtBoxNomeReceita.Name = "txtBoxNomeReceita";
            txtBoxNomeReceita.Size = new Size(257, 39);
            txtBoxNomeReceita.TabIndex = 0;
            // 
            // txtBoxValorTotalReceita
            // 
            txtBoxValorTotalReceita.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxValorTotalReceita.Location = new Point(6, 109);
            txtBoxValorTotalReceita.Name = "txtBoxValorTotalReceita";
            txtBoxValorTotalReceita.Size = new Size(257, 39);
            txtBoxValorTotalReceita.TabIndex = 3;
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
            // clnIngredientes
            // 
            clnIngredientes.Text = "Ingredientes na receita";
            clnIngredientes.Width = 300;
            // 
            // lblIngredientesReceita
            // 
            lblIngredientesReceita.AutoSize = true;
            lblIngredientesReceita.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngredientesReceita.ForeColor = SystemColors.ButtonFace;
            lblIngredientesReceita.Location = new Point(8, 241);
            lblIngredientesReceita.Name = "lblIngredientesReceita";
            lblIngredientesReceita.Size = new Size(205, 25);
            lblIngredientesReceita.TabIndex = 19;
            lblIngredientesReceita.Text = "Ingredientes na receita";
            // 
            // txtBoxIngredientesReceita
            // 
            txtBoxIngredientesReceita.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxIngredientesReceita.Location = new Point(8, 269);
            txtBoxIngredientesReceita.Name = "txtBoxIngredientesReceita";
            txtBoxIngredientesReceita.Size = new Size(257, 39);
            txtBoxIngredientesReceita.TabIndex = 18;
            // 
            // ListaReceitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1224, 631);
            Controls.Add(gBoxCriacaoEdicao);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(gBoxEstoque);
            Controls.Add(lbConectado);
            Name = "ListaReceitas";
            Text = "ListaReceitas";
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

        private GroupBox gBoxEstoque;
        private Label lblFiltroNome;
        private Label lblFiltro;
        private TextBox txtBoxFiltroNome;
        private Button btnPesquisa;
        private ListView lvEstoque;
        private ColumnHeader clnId;
        private ColumnHeader clnNomeReceita;
        private ColumnHeader clnValorReceita;
        private Label label2;
        private Label lbConectado;
        private Label label1;
        private Button button1;
        private GroupBox gBoxCriacaoEdicao;
        private Panel panel1;
        private Button btnAdicionarIngrediente;
        private Label lblQuantidadeIngredientes;
        private TextBox txtBoxQuantidadeIngredientes;
        private Button btnDeletarIngrediente;
        private Label lblNomeReceita;
        private Label lblValorTotalReceita;
        private Button btnSalvarIngrediente;
        private TextBox txtBoxNomeReceita;
        private TextBox txtBoxValorTotalReceita;
        private Label label3;
        private ColumnHeader clnIngredientes;
        private Label lblIngredientesReceita;
        private TextBox txtBoxIngredientesReceita;
    }
}