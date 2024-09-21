using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using main_form.FormApp;
using main_form.FormApp.Pay;
using main_form.work;
using QRCoder;

namespace main_form
{
    public partial class FormOrder : Form
    {
        PanelWork pw = new PanelWork();
        public FormOrder()
        {
            InitializeComponent();
            setUpOrder();
        }

        private void setUpOrder()
        {
            UserControlWork uw = new UserControlWork();
            uw.OpenPanelForUserCtrl(Formtables.Instance, SplPCon_Order.Panel1);
            uw.OpenPanelForUserCtrl(FormPayQR.Instance, SplPCon_Order.Panel2);
        }
    }
}
