using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_form.work
{
    public static class setUpBR
    {
        //combo radius
        public static void setUpBorderRadius(UserControl uf)
        {
            foreach (Control i in uf.Controls)
            {
                if (i is Guna2TextBox && i.Name.Contains("txt"))
                {
                    BorderRadiusPaint.paintBR(i, 20, 20);
                }
                else if (i is Panel && i.Name.Contains("btn"))
                {
                    BorderRadiusPaint.paintBR(i);
                }
            }
        }

        public static void setUpBorderRadius(UserControl frm, string name, int radiusLeft, int radiusRight)
        {
            foreach (Control i in frm.Controls)
            {
                switch(i)
                {
                    case Guna2TextBox:
                    case TextBox:
                    case Panel:
                    case Label:
                    {
                        if(i.Name.Contains(name))
                        {
                            BorderRadiusPaint.paintBR(i, radiusLeft, radiusRight);
                        }
                        break;
                    }
                    default:
                        break;
                        
                }  
            }
        }
    }
}
