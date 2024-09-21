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
    public partial class FormMenuDetail : UserControl
    {
        private static FormMenuDetail _instance;
        public static FormMenuDetail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormMenuDetail();
                }
                return _instance;
            }
        }
        public FormMenuDetail()
        {
            InitializeComponent();
        }

        private void setUpBorderRadius()
        {
            setUpBR.setUpBorderRadius(this, "txt_find", 60, 60);
            setUpBR.setUpBorderRadius(this, "btn_foodAdd", 60, 60);
        }

        private void FormMenuDetail_Load(object sender, EventArgs e)
        {
            setUpBorderRadius();
        }
    }
}
