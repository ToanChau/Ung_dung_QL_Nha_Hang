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

namespace main_form.FormApp.Pay
{
    public partial class FormPayCard : UserControl
    {
        private static FormPayCard _instance;
        public static FormPayCard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormPayCard();
                }
                return _instance;
            }
        }
        public FormPayCard()
        {
            InitializeComponent();
        }

        private void FormPayCard_Load(object sender, EventArgs e)
        {
            setUpBorderR();
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "btn_pay", 90, 90);
        }
    }
}
