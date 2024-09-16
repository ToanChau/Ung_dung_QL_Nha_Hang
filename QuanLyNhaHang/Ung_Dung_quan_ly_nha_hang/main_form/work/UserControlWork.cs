using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_form.work
{
    public class UserControlWork
    {
        public void OpenPanelForUserCtrl(UserControl uctrl, Panel panel)
        {
            try
            {
                if (panel == null) throw new Exception("Panel not avaible");
                if (!panel.Controls.Contains(uctrl))
                {
                    panel.Controls.Clear();
                    panel.Controls.Add(uctrl);
                    uctrl.Dock = DockStyle.Fill;
                    uctrl.BringToFront();
                }
                else uctrl.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errol");
            }
        }
    }
}
