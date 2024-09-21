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
    public partial class FormChangeInforCustomer : UserControl
    {
        private static FormChangeInforCustomer instance;
        public static FormChangeInforCustomer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormChangeInforCustomer();
                }
                return instance;
            }
        }
        public FormChangeInforCustomer()
        {
            InitializeComponent();
        }

        private void FormChangeInforCustomer_Load(object sender, EventArgs e)
        {
            setUpBorderR();
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "btn_change", 90, 90);
        }
    }
}
