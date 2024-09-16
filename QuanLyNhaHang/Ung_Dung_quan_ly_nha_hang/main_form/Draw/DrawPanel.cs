using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form.Draw
{
    public class DrawPanel
    {
        public void DrawLeft(object sender, PaintEventArgs e)
        {
            Panel pnl =  (Panel)sender;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            int radius = 20; // Bán kính góc bo
            Rectangle bounds = new Rectangle(0, 0, pnl.Width, pnl.Height);

            // Tạo bo tròn cho góc trên bên trái
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90); // Góc trên trái
            path.AddLine(radius, 0, bounds.Width, 0); // Đường thẳng trên cùng
            path.AddLine(bounds.Width, 0, bounds.Width, bounds.Height); // Đường thẳng bên phải
            path.AddLine(bounds.Width, bounds.Height, 0, bounds.Height); // Đường thẳng dưới cùng
            path.AddLine(0, bounds.Height, 0, radius); // Đường thẳng bên trái dưới góc bo

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ nền cho Panel
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRegion(new SolidBrush(pnl.BackColor), pnl.Region);
        }

        public void DrawRight(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;

            if (panel != null)
            {
                // Bán kính bo tròn góc
                int radius = 70;

                // Tạo đối tượng GraphicsPath để vẽ đường bo tròn
                GraphicsPath path = new GraphicsPath();

                // Vẽ phần khung của panel không bo góc bên trái
                path.AddLine(0, 0, panel.Width - radius, 0); // Đường thẳng từ trên trái tới gần góc trên phải
                path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Bo tròn góc trên phải

                path.AddLine(panel.Width, radius, panel.Width, panel.Height - radius); // Đường thẳng từ góc trên phải xuống góc dưới phải
                path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Bo tròn góc dưới phải

                path.AddLine(panel.Width - radius, panel.Height, 0, panel.Height); // Đường thẳng từ dưới phải tới dưới trái

                // Đóng đường vẽ
                path.CloseAllFigures();

                // Gán hình dạng cho Panel
                panel.Region = new Region(path);

                // Tùy chọn: Nếu bạn muốn vẽ thêm một đường viền cho Panel
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.Black, 2)) // Tạo bút vẽ viền màu đen, độ dày 2
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        public void Draw4point(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;

            if (panel != null)
            {
                // Bán kính bo tròn góc
                int radius = 30;

                // Tạo đối tượng GraphicsPath để vẽ đường bo tròn
                GraphicsPath paths = new GraphicsPath();

                // Vẽ 4 góc bo tròn
                paths.AddArc(0, 0, radius, radius, 180, 90); // Góc trên-trái
                paths.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Góc trên-phải
                paths.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Góc dưới-phải
                paths.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Góc dưới-trái

                // Đóng đường vẽ
                paths.CloseAllFigures();

                // Gán hình dạng cho Panel
                panel.Region = new Region(paths);

                // Tùy chọn: Nếu bạn muốn vẽ thêm một đường viền cho Panel
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.Black, 2)) // Tạo bút vẽ viền màu đen, độ dày 2
                {
                    e.Graphics.DrawPath(pen, paths);
                }
            }
        }
    }
}
