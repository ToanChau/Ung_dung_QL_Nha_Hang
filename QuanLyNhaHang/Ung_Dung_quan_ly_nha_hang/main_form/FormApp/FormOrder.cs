using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using main_form.work;

namespace main_form
{
    public partial class FormOrder : Form
    {
        PanelWork pw = new PanelWork();
        UserControlWork uw = new UserControlWork();
        public FormOrder()
        {
            InitializeComponent();
            setUpOrder();
        }

        private void setUpOrder()
        {
            uw.OpenPanelForUserCtrl(Formtables.Instance, pan_table);
            uw.OpenPanelForUserCtrl(FormDetailTable.Instance, pan_detail);
        }

    }
}
