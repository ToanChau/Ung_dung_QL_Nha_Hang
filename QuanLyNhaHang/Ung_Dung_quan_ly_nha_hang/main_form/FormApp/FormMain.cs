using System.Windows.Forms;
using main_form.Draw;
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
            pan_function.Paint += dpanel.DrawRight;
            pw.CurrentChildForm = new FormOrder();
            pw.OpenChildForm(pw.CurrentChildForm, pan_order);

            //FormFunction ffunction = new FormFunction();
            //pw.ShowFormInPanel(ffunction, pan_funtion);

            //FormOrder foder = new FormOrder();
            //pw.ShowFormInPanel(foder, pan_order);
        }

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
