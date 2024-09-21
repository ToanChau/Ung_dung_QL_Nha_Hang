using System.Windows.Forms;
using main_form.Draw;
using main_form.FormApp.Menu;
using main_form.work;

namespace main_form
{
    public partial class Form_Main : Form
    {
        PanelWork pw = new PanelWork();
        DrawPanel dpanel = new DrawPanel();

        public Form_Main()
        {
            InitializeComponent();
            setUpPanel();
        }

        private void setUpPanel()
        {
            UserControlWork uw = new UserControlWork();
            //vẽ radius
            pan_function.Paint += dpanel.DrawRight;

            //pw.CurrentChildForm = new FormOrder();
            //pw.OpenChildForm(pw.CurrentChildForm, pan_order);

            uw.OpenPanelForUserCtrl(FormAddFoodToMenu.Instance, pan_order);


            //setUpHoverPanel(Fpanel_Home);
            //setUpHoverPanel(Fpanel_Menu);
            //setUpHoverPanel(Fpanel_Staff);
            //setUpHoverPanel(Fpanel_Account);
        }

        //private void setUpHoverPanel(Panel p)
        //{
        //    foreach (Control c in p.Controls)
        //    {
        //        if (c != null)
        //        {
        //            c.MouseHover += new EventHandler(Change_MouseHover(p));
        //            c.MouseLeave += new EventHandler(Change_MouseLeave(p));
        //        }
        //    }
        //}

        //private void changeColorPanel(Panel panel, Color color)
        //{
        //    panel.BackColor = color;
        //}

        private void Change_MouseHover(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.Blue;
        }

        private void Change_MouseLeave(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.BackColor = Color.SteelBlue;
        }
    }
}
