﻿namespace CannaCandiesCWB.Paginas.EstoqueIngredientes
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
            SuspendLayout();
            // 
            // lbConectado
            // 
            lbConectado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbConectado.AutoSize = true;
            lbConectado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbConectado.ForeColor = Color.FromArgb(128, 255, 128);
            lbConectado.Location = new Point(1065, 599);
            lbConectado.Name = "lbConectado";
            lbConectado.Size = new Size(159, 20);
            lbConectado.TabIndex = 1;
            lbConectado.Text = "Conectado ao estoque";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1115, 619);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "CannaCandiesCWB";
            // 
            // EstoqueIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1224, 643);
            Controls.Add(label2);
            Controls.Add(lbConectado);
            Name = "EstoqueIngredientes";
            Text = "EstoqueIngredientes";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label lbConectado;
    }
}