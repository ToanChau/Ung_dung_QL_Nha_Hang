using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace main_form.work
{
    public static class BorderRadiusPaint
    {
        //tao border radius
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public static IntPtr radius90(int x, int y)
        {
            return CreateRoundRectRgn(0, 0, x, y, 90, 90);
        }

        //90 độ
        public static void paintBR(Control control)
        {
            IntPtr bradius;
            bradius = radius90(control.Width, control.Height);
            if (bradius != IntPtr.Zero)
            {
                control.Region = Region.FromHrgn(bradius);
            }
        }

        //chọn góc tự do
        public static void paintBR(Control control, int x, int y)
        {
            IntPtr bradius;
            bradius = CreateRoundRectRgn(0, 0, control.Width, control.Height, x, y);
            if (bradius != IntPtr.Zero)
            {
                control.Region = Region.FromHrgn(bradius);
            }
        }
    }
}
