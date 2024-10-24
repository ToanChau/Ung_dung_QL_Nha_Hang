using main_form.FormApp;
using main_form.OOP;
using main_form.work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form
{
    public partial class Formtables : UserControl
    {
        private static Formtables _instance;
        public static Formtables Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Formtables();
                }
                return _instance;
            }
        }
        FormOrder f;

        UserControlWork work = new UserControlWork();

        public Formtables()
        { }

        public Formtables(FormOrder f)
        {
            InitializeComponent();
            this.f = f;

        }

        private void btn_table3_Click(object sender, EventArgs e)
        {
            work.OpenPanelForUserCtrl(new FormOpenTableDetail(), f.SplPCon_Order.Panel2);
        }

        private void btn_table2_Click(object sender, EventArgs e)
        {
            tableInfor table = new tableInfor();
            table.Id = 2;
            table.Name = "Bàn 2";
            work.OpenPanelForUserCtrl(new FormOpenTableDetail(table), f.SplPCon_Order.Panel2);

        }
    }
}
