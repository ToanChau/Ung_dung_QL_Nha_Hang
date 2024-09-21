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
    public partial class FormOptionPay : UserControl
    {
        private static FormOptionPay _instance;
        public static FormOptionPay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormOptionPay();
                }
                return _instance;
            }
        }
        public FormOptionPay()
        {
            InitializeComponent();
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "btn_pay", 70, 70);
        }

        private void FormOptionPay_Load(object sender, EventArgs e)
        {
            setUpBorderR();
        }
    }
}
