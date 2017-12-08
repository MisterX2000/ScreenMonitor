namespace ScreenMonitor
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbx_main = new System.Windows.Forms.PictureBox();
            this.tmr_screen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_main
            // 
            this.pbx_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_main.Location = new System.Drawing.Point(0, 0);
            this.pbx_main.Name = "pbx_main";
            this.pbx_main.Size = new System.Drawing.Size(284, 261);
            this.pbx_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_main.TabIndex = 0;
            this.pbx_main.TabStop = false;
            // 
            // tmr_screen
            // 
            this.tmr_screen.Enabled = true;
            this.tmr_screen.Interval = 10;
            this.tmr_screen.Tick += new System.EventHandler(this.tmr_screen_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbx_main);
            this.Name = "frm_main";
            this.Text = "ScreenMonitor";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_main;
        private System.Windows.Forms.Timer tmr_screen;
    }
}

