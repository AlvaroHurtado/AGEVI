namespace AGEVI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegosMóbilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegosPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegosConsolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.bibliotecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.frCalendario_load);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bibliotecToolStripMenuItem
            // 
            this.bibliotecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegosMóbilesToolStripMenuItem,
            this.juegosPCToolStripMenuItem,
            this.juegosConsolasToolStripMenuItem});
            this.bibliotecToolStripMenuItem.Name = "bibliotecToolStripMenuItem";
            this.bibliotecToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bibliotecToolStripMenuItem.Text = "Biblioteca";
            this.bibliotecToolStripMenuItem.Click += new System.EventHandler(this.bibliotecToolStripMenuItem_Click);
            // 
            // juegosMóbilesToolStripMenuItem
            // 
            this.juegosMóbilesToolStripMenuItem.Name = "juegosMóbilesToolStripMenuItem";
            this.juegosMóbilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.juegosMóbilesToolStripMenuItem.Text = "Juegos Móbiles";
            // 
            // juegosPCToolStripMenuItem
            // 
            this.juegosPCToolStripMenuItem.Name = "juegosPCToolStripMenuItem";
            this.juegosPCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.juegosPCToolStripMenuItem.Text = "Juegos PC";
            // 
            // juegosConsolasToolStripMenuItem
            // 
            this.juegosConsolasToolStripMenuItem.Name = "juegosConsolasToolStripMenuItem";
            this.juegosConsolasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.juegosConsolasToolStripMenuItem.Text = "Juegos Consolas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Forma Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegosMóbilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegosPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegosConsolasToolStripMenuItem;
    }
}