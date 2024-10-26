using Guna.UI2.WinForms;
using main_form.OOP;
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
    public partial class FormOpenTableDetail : UserControl
    {
        private static FormOpenTableDetail _instance;
        public static FormOpenTableDetail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormOpenTableDetail();
                }
                return _instance;
            }
        }

        public FormOpenTableDetail()
        {
            InitializeComponent();
        }

        FormOrder f;
        tableInfor tbl;

        public FormOpenTableDetail(FormOrder f, tableInfor tbl)
        {
            InitializeComponent();
            this.f = f;
            this.tbl = tbl;
            lab_NameTable.Text = tbl.Name;
        }

        private void FormOpenTableDetail_Load(object sender, EventArgs e)
        {
            setUpBorderRadius();
        }

        private void setUpBorderRadius()
        {
            setUpBR.setUpBorderRadius(this);
        }
    }
}
