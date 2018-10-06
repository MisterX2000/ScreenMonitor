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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pbx_main = new System.Windows.Forms.PictureBox();
            this.tmr_screen = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tss_screen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_scale = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_rate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_top = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).BeginInit();
            this.statusStrip.SuspendLayout();
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_screen,
            this.tss_scale,
            this.tss_rate,
            this.tss_top});
            this.statusStrip.Location = new System.Drawing.Point(0, 239);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            this.toolTip.SetToolTip(this.statusStrip, "Up: Scale window up\r\nDown: Scale window down\r\nLeft: Next screen\r\nRight: Previous " +
        "screen\r\n\r\nPageUp: Higher refresh rate (slower)\r\nPageDown: Lower refresh rate (fa" +
        "ster)\r\nT: Toggle TopMost");
            // 
            // tss_screen
            // 
            this.tss_screen.Name = "tss_screen";
            this.tss_screen.Size = new System.Drawing.Size(42, 17);
            this.tss_screen.Text = "Screen";
            // 
            // tss_scale
            // 
            this.tss_scale.Name = "tss_scale";
            this.tss_scale.Size = new System.Drawing.Size(34, 17);
            this.tss_scale.Text = "Scale";
            // 
            // tss_rate
            // 
            this.tss_rate.Name = "tss_rate";
            this.tss_rate.Size = new System.Drawing.Size(30, 17);
            this.tss_rate.Text = "Rate";
            // 
            // tss_top
            // 
            this.tss_top.Name = "tss_top";
            this.tss_top.Size = new System.Drawing.Size(54, 17);
            this.tss_top.Text = "TopMost";
            this.tss_top.Visible = false;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 15000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pbx_main);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.Text = "ScreenMonitor";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_main)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_main;
        private System.Windows.Forms.Timer tmr_screen;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tss_scale;
        private System.Windows.Forms.ToolStripStatusLabel tss_screen;
        private System.Windows.Forms.ToolStripStatusLabel tss_top;
        private System.Windows.Forms.ToolStripStatusLabel tss_rate;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

