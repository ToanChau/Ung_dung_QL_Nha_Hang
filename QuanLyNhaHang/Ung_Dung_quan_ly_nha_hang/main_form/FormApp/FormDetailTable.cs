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
    public partial class FormDetailTable : UserControl
    {
        private static FormDetailTable _instance;
        public static FormDetailTable Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormDetailTable();
                }
                return _instance;
            }
        }
        public FormDetailTable()
        {
            InitializeComponent();
        }
    }
}
