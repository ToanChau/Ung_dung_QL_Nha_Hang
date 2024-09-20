using Guna.UI2.WinForms;
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

        private void FormOpenTableDetail_Load(object sender, EventArgs e)
        {
            setUpBorderRadius();
        }

        private void setUpBorderRadius()
        {
            foreach (Control i in this.Controls)
            {
                if (i is Guna2TextBox && i.Name.Contains("txt"))
                {
                    BorderRadiusPaint.paintBR(i, 20, 20);              
                }
                else if(i is Panel && i.Name.Contains("btn"))
                {
                    BorderRadiusPaint.paintBR(i);
                }
            }
        }
    }
}
