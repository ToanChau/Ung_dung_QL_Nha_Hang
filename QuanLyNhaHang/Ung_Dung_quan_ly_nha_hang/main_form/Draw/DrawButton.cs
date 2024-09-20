using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_form.Draw
{
    public class DrawButton
    {
        public void draw2Head(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            // Set up the rounded rectangle shape
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 30, 30, 180, 90); // Top-left corner
            path.AddArc(btn.Width - 30, 0, 30, 30, 270, 90); // Top-right corner
            path.AddArc(btn.Width - 30, btn.Height - 30, 30, 30, 0, 90); // Bottom-right corner
            path.AddArc(0, btn.Height - 30, 30, 30, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the button's region to the rounded rectangle
            btn.Region = new Region(path);

            // Draw button background
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(Color.FromArgb(57, 106, 130)), path); // Change color if needed

            // Draw text and icon
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // Draw the icon if available
            if (btn.Image != null)
            {
                e.Graphics.DrawImage(btn.Image, new Point(10, btn.Height / 2 - btn.Image.Height / 2));
            }
        }
    }
}
