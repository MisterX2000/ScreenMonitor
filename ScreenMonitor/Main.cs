using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenMonitor
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private int screenInd;
        private float screenScale = 3;
        private int refreshInd = 2;
        private readonly int[] refreshList = {10, 50, 100, 250, 500, 1000, 2500, 5000};

        private void frm_main_Load(object sender, EventArgs e)
        {
            ChangeWindow();
            ChangeRate();
        }

        private void tmr_screen_Tick(object sender, EventArgs e)
        {
            pbx_main.Image = GetScreen(Screen.AllScreens[screenInd]);
            GC.Collect();
        }

        private static Bitmap GetScreen(Screen screen)
        {
            var screenshot = new Bitmap(screen.Bounds.Width,
                screen.Bounds.Height);
            // Create a graphics object from the bitmap
            var gfxScreenshot = Graphics.FromImage(screenshot);
            // Take the screenshot from the upper left corner to the right bottom corner
            gfxScreenshot.CopyFromScreen(
                screen.Bounds.X, screen.Bounds.Y,
                0, 0,
                screen.Bounds.Size);

            return screenshot;
        }

        private void ChangeWindow(int index = 0, float scale = 0)
        {
            if (screenInd + index < Screen.AllScreens.Length && screenInd + index >= 0)
                screenInd += index;

            if (screenScale + scale <= 10  && screenScale + scale >= 1)
                screenScale += scale;

            var s = Screen.AllScreens[screenInd].Bounds.Size;
            ClientSize = new Size((int) (s.Width / screenScale), (int) (s.Height / screenScale) + 25);

            tss_monitor.Text = "Monitor: " + screenInd;
            tss_Scale.Text = "Scale: " + screenScale.ToString("F1");
        }

        private void ChangeRate(int index = 0)
        {
            if (refreshInd + index < refreshList.Length && refreshInd + index >= 0)
                refreshInd += index;

            tmr_screen.Interval = refreshList[refreshInd];
            tss_rate.Text = "Rate: " + refreshList[refreshInd];
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    ChangeWindow(1);
                    break;
                case Keys.Left:
                    ChangeWindow(-1);
                    break;
                case Keys.Up:
                    ChangeWindow(0, -.5f);
                    break;
                case Keys.Down:
                    ChangeWindow(0, .5f);
                    break;
                case Keys.PageUp:
                    ChangeRate(1);
                    break;
                case Keys.PageDown:
                    ChangeRate(-1);
                    break;

                case Keys.T:
                    TopMost = !TopMost;
                    tss_top.Visible = TopMost;
                    break;
            }
        }
    }
}
