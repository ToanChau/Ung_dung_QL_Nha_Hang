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
    public partial class FormPayCash : UserControl
    {
        private static FormPayCash _instance;
        public static FormPayCash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormPayCash();
                }
                return _instance;
            }
        }

        public FormPayCash()
        {
            InitializeComponent();
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "btn_pay", 90, 90);
        }

        private void FormFinalPay_Load(object sender, EventArgs e)
        {
            setUpBorderR();
        }
    }
}
