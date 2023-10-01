namespace OrdenesRepasoParcial1.Presentacion
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOrdenRetiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOrdenRetiroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.nuevaOrdenRetiroToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 25);
            // 
            // nuevaOrdenRetiroToolStripMenuItem
            // 
            this.nuevaOrdenRetiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenRetiroToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.nuevaOrdenRetiroToolStripMenuItem.Name = "nuevaOrdenRetiroToolStripMenuItem";
            this.nuevaOrdenRetiroToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.nuevaOrdenRetiroToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaOrdenRetiroToolStripMenuItem1
            // 
            this.nuevaOrdenRetiroToolStripMenuItem1.Name = "nuevaOrdenRetiroToolStripMenuItem1";
            this.nuevaOrdenRetiroToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.nuevaOrdenRetiroToolStripMenuItem1.Text = "Nueva Orden Retiro";
            this.nuevaOrdenRetiroToolStripMenuItem1.Click += new System.EventHandler(this.nuevaOrdenRetiroToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteStockToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // reporteStockToolStripMenuItem
            // 
            this.reporteStockToolStripMenuItem.Name = "reporteStockToolStripMenuItem";
            this.reporteStockToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.reporteStockToolStripMenuItem.Text = "Reporte Stock";
            this.reporteStockToolStripMenuItem.Click += new System.EventHandler(this.reporteStockToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Pricipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenRetiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenRetiroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}