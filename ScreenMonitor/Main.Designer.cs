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
            this.ssp_main = new System.Windows.Forms.StatusStrip();
            this.tss_monitor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_Scale = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_top = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).BeginInit();
            this.ssp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbx_main
            // 
            this.pbx_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_main.Location = new System.Drawing.Point(0, 0);
            this.pbx_main.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_main.Name = "pbx_main";
            this.pbx_main.Size = new System.Drawing.Size(284, 236);
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
            // ssp_main
            // 
            this.ssp_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_monitor,
            this.tss_Scale,
            this.tss_top});
            this.ssp_main.Location = new System.Drawing.Point(0, 239);
            this.ssp_main.Name = "ssp_main";
            this.ssp_main.Size = new System.Drawing.Size(284, 22);
            this.ssp_main.TabIndex = 1;
            this.ssp_main.Text = "statusStrip1";
            // 
            // tss_monitor
            // 
            this.tss_monitor.Name = "tss_monitor";
            this.tss_monitor.Size = new System.Drawing.Size(50, 17);
            this.tss_monitor.Text = "Monitor";
            // 
            // tss_Scale
            // 
            this.tss_Scale.Name = "tss_Scale";
            this.tss_Scale.Size = new System.Drawing.Size(34, 17);
            this.tss_Scale.Text = "Scale";
            // 
            // tss_top
            // 
            this.tss_top.Name = "tss_top";
            this.tss_top.Size = new System.Drawing.Size(54, 17);
            this.tss_top.Text = "TopMost";
            this.tss_top.Visible = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ssp_main);
            this.Controls.Add(this.pbx_main);
            this.Name = "frm_main";
            this.Text = "ScreenMonitor";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).EndInit();
            this.ssp_main.ResumeLayout(false);
            this.ssp_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_main;
        private System.Windows.Forms.Timer tmr_screen;
        private System.Windows.Forms.StatusStrip ssp_main;
        private System.Windows.Forms.ToolStripStatusLabel tss_Scale;
        private System.Windows.Forms.ToolStripStatusLabel tss_monitor;
        private System.Windows.Forms.ToolStripStatusLabel tss_top;
    }
}

