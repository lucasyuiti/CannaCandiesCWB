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
            DbStatus = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            label1 = new Label();
            label2 = new Label();
            DbStatus.SuspendLayout();
            SuspendLayout();
            // 
            // DbStatus
            // 
            DbStatus.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            DbStatus.Location = new Point(0, 621);
            DbStatus.Name = "DbStatus";
            DbStatus.Size = new Size(1224, 22);
            DbStatus.TabIndex = 0;
            DbStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(1065, 586);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 1;
            label1.Text = "Conectado ao estoque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1115, 606);
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
            Controls.Add(label1);
            Controls.Add(DbStatus);
            Name = "EstoqueIngredientes";
            Text = "EstoqueIngredientes";
            FormClosing += FechandoEstoque;
            Load += EstoqueLoad;
            DbStatus.ResumeLayout(false);
            DbStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip DbStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label1;
        private Label label2;
    }
}