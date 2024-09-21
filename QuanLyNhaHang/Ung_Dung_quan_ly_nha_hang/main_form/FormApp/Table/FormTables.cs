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
        public Formtables()
        {
            InitializeComponent();
        }
    }
}
