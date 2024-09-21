using main_form.work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form.FormApp.Menu
{
    public partial class FormAddFoodToMenu : UserControl
    {
        private static FormAddFoodToMenu _instance;
        public static FormAddFoodToMenu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormAddFoodToMenu();
                }
                return _instance;
            }
        }
        public FormAddFoodToMenu()
        {
            InitializeComponent();
        }

        private void setUpBorderRadius()
        {
            setUpBR.setUpBorderRadius(this, "pan_State", 20, 20);
        }

        private void FormAddFoodToMenu_Load(object sender, EventArgs e)
        {
            setUpBorderRadius();
            txt_foodName.Focus();
        }
    }
}
