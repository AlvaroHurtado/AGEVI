namespace AGEVI
{
    partial class frmCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            this.mntCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnSelectFecha = new System.Windows.Forms.Button();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.ptbSans = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSans)).BeginInit();
            this.SuspendLayout();
            // 
            // mntCalendar
            // 
            this.mntCalendar.Location = new System.Drawing.Point(18, 18);
            this.mntCalendar.Name = "mntCalendar";
            this.mntCalendar.TabIndex = 0;
            this.mntCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnSelectFecha
            // 
            this.btnSelectFecha.Location = new System.Drawing.Point(278, 18);
            this.btnSelectFecha.Name = "btnSelectFecha";
            this.btnSelectFecha.Size = new System.Drawing.Size(166, 32);
            this.btnSelectFecha.TabIndex = 1;
            this.btnSelectFecha.Text = "Seleccionar Fecha";
            this.btnSelectFecha.UseVisualStyleBackColor = true;
            this.btnSelectFecha.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Image = ((System.Drawing.Image)(resources.GetObject("lblFechaInicial.Image")));
            this.lblFechaInicial.Location = new System.Drawing.Point(15, 198);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(38, 13);
            this.lblFechaInicial.TabIndex = 2;
            this.lblFechaInicial.Text = "Desde";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Image = ((System.Drawing.Image)(resources.GetObject("lblFechaFinal.Image")));
            this.lblFechaFinal.Location = new System.Drawing.Point(15, 224);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(35, 13);
            this.lblFechaFinal.TabIndex = 3;
            this.lblFechaFinal.Text = "Hasta";
            // 
            // ptbSans
            // 
            this.ptbSans.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbSans.BackgroundImage")));
            this.ptbSans.Image = ((System.Drawing.Image)(resources.GetObject("ptbSans.Image")));
            this.ptbSans.Location = new System.Drawing.Point(504, 22);
            this.ptbSans.Name = "ptbSans";
            this.ptbSans.Size = new System.Drawing.Size(272, 215);
            this.ptbSans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbSans.TabIndex = 4;
            this.ptbSans.TabStop = false;
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(788, 256);
            this.Controls.Add(this.ptbSans);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.btnSelectFecha);
            this.Controls.Add(this.mntCalendar);
            this.Name = "frmCalendario";
            this.Text = "Calendario";
            ((System.ComponentModel.ISupportInitialize)(this.ptbSans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mntCalendar;
        private System.Windows.Forms.Button btnSelectFecha;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.PictureBox ptbSans;
    }
}