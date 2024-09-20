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

        private void FormDetailTableOrder_Load(object sender, EventArgs e)
        {
            setUpButton();
        }

        private void setUpButton()
        {
            foreach (Control i in  this.Controls)
            {
                if(i is Panel panel && i.Name.Contains("btn"))
                {
                    BorderRadiusPaint.paintBR(i);
                }
            }

        }
    }
}
