using System.Windows.Forms;
using main_form.Draw;
using main_form.FormApp.Menu;
using main_form.FormApp.UserController;
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

        private void Change_MouseHover(object sender, EventArgs e)
        {
            ButtonFacilities_mainForm btn = (ButtonFacilities_mainForm)sender;
            btn.BackColor = Color.Blue;
        }

        private void Change_MouseLeave(object sender, EventArgs e)
        {
            ButtonFacilities_mainForm btn = (ButtonFacilities_mainForm)sender;
            btn.BackColor = Color.Transparent;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("h", "j");
        }
    }
}
