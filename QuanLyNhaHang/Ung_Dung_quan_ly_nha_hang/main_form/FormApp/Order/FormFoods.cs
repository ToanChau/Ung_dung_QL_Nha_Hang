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

namespace main_form.FormApp
{
    public partial class FormFoods : UserControl
    {
        private static FormFoods _instance;
        public static FormFoods Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormFoods();
                }
                return _instance;
            }
        }
        public FormFoods()
        {
            InitializeComponent();
        }

        private void FormFoods_Load(object sender, EventArgs e)
        {
            setUpBorderRadius();
        }
        private void setUpBorderRadius()
        {
            setUpBR.setUpBorderRadius(this, "btn", 60, 60);
            setUpBR.setUpBorderRadius(this, "txt_find", 60, 60);
        }

        private void txt_findFood_Click(object sender, EventArgs e)
        {
            txt_foodFindName.Focus();
        }

        private void btn_FindFoodIcon_MouseHover(object sender, EventArgs e)
        {
            btn_FindFoodIcon.BackColor = Color.Gainsboro;
        }

        private void btn_FindFoodIcon_MouseLeave(object sender, EventArgs e)
        {
            btn_FindFoodIcon.BackColor = Color.WhiteSmoke;
        }
    }
}
