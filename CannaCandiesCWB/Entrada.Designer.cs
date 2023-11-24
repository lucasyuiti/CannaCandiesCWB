namespace CannaCandiesCWB
{
    partial class Entrada
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
            label2 = new Label();
            BotaoEstoque = new Button();
            BotaoReceitas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(679, 428);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "CannaCandiesCWB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(313, 9);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 1;
            label2.Text = "Titulo do app";
            // 
            // BotaoEstoque
            // 
            BotaoEstoque.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BotaoEstoque.Location = new Point(417, 259);
            BotaoEstoque.Name = "BotaoEstoque";
            BotaoEstoque.Size = new Size(371, 166);
            BotaoEstoque.TabIndex = 2;
            BotaoEstoque.Text = "Gerenciamento de estoque";
            BotaoEstoque.UseVisualStyleBackColor = true;
            // 
            // BotaoReceitas
            // 
            BotaoReceitas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BotaoReceitas.Location = new Point(12, 259);
            BotaoReceitas.Name = "BotaoReceitas";
            BotaoReceitas.Size = new Size(375, 166);
            BotaoReceitas.TabIndex = 3;
            BotaoReceitas.Text = "Gerenciamento de receitas";
            BotaoReceitas.UseVisualStyleBackColor = true;
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(BotaoReceitas);
            Controls.Add(BotaoEstoque);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Entrada";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BotaoEstoque;
        private Button BotaoReceitas;
    }
}