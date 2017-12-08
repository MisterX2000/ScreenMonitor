using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private int screenScale = 4;

        private void frm_main_Load(object sender, EventArgs e)
        {
            ChangeWindow();
        }

        private void tmr_screen_Tick(object sender, EventArgs e)
        {
            pbx_main.Image = GetScreen(Screen.AllScreens[screenInd]);
            ChangeWindow();
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

        private void ChangeWindow()
        {
            var s = Screen.AllScreens[screenInd].Bounds.Size;
            this.ClientSize = new Size(s.Width / screenScale, s.Height / screenScale);
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (screenInd < Screen.AllScreens.Length - 1)
                        screenInd += 1;
                    break;
                case Keys.Left:
                    if (screenInd > 0)
                        screenInd -= 1;
                    break;
                case Keys.Up:
                    if (screenScale > 1)
                    {
                        screenScale -= 1;
                        ChangeWindow();
                    }
                    break;
                case Keys.Down:
                    if (screenScale < 10)
                    {
                        screenScale += 1;
                        ChangeWindow();
                    }
                    break;
            }
        }
    }
}
