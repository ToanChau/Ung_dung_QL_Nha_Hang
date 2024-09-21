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

namespace main_form
{
    public partial class FormPayBill : UserControl
    {
        private static FormPayBill _instance;
        public static FormPayBill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormPayBill();
                }
                return _instance;
            }
        }
        public FormPayBill()
        {
            InitializeComponent();
        }

        private void FormPayBill_Load(object sender, EventArgs e)
        {
            setUpBorderR();
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "btn_pay", 90, 90);
            setUpBR.setUpBorderRadius(this, "btn_order", 20, 20);

        }
    }
}
