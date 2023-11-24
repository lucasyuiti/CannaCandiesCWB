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
            // EstoqueIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1224, 643);
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
    }
}