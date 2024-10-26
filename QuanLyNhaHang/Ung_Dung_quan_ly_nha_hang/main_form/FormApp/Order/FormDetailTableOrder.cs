using main_form.FormApp;
using main_form.OOP;
using main_form.work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form
{
    public partial class FormDetailTableOrder : UserControl
    {
        private static FormDetailTableOrder _instance;
        public static FormDetailTableOrder Instance
        {
            get
            {
                if (_instance == null)
                {   
                    _instance = new FormDetailTableOrder();
                }
                return _instance;
            }
        }
        public FormDetailTableOrder()
        {
            InitializeComponent();
        }

        FormOrder f;
        tableInfor tbl;
        public FormDetailTableOrder(FormOrder f, tableInfor tbl)
        {
            InitializeComponent();
            this.f = f;
            this.tbl = tbl;
        }

        private void FormDetailTableOrder_Load(object sender, EventArgs e)
        {
            setUpButton();
            lab_openTable.Click += openTable_click;
            pbox_openTable.Click += openTable_click;
        }

        private void setUpButton()
        {
            setUpBR.setUpBorderRadius(this, "btn", 90, 90);

        }

        private void openTable_click(object sender, EventArgs e)
        {
            UserControlWork uw = new UserControlWork();
            uw.OpenPanelForUserCtrl(new FormOpenTableDetail(f, tbl), f.SplPCon_Order.Panel2);
        }
    }
}
