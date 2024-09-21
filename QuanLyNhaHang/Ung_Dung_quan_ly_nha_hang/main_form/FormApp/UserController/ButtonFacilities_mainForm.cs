using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form.FormApp.UserController
{
    public partial class ButtonFacilities_mainForm : UserControl
    {
        private string nameFacilities;
        [Category("Custom Properties")]
        public string NameFacilitie
        {
            get { return nameFacilities; }
            set
            {
                nameFacilities = value;
                lab_Name.Text = nameFacilities;
            }
        }

        private Image imageFacilities;
        [Category("Custom Properties")]
        public Image ImageFacilities
        {
            get { return imageFacilities; }
            set
            {
                imageFacilities = value;
                pic_facilities.Image = imageFacilities;
            }
        }

        private Color colorFacilities;
        [Category("Custom Properties")]
        public Color ColorFacilities
        {
            get { return colorFacilities; }
            set
            {
                colorFacilities = value;
                panel1.BackColor = colorFacilities;
            }
        }
        public ButtonFacilities_mainForm()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;

            nameFacilities = lab_Name.Text;
            imageFacilities = pic_facilities.Image;
            colorFacilities = panel1.BackColor;
        }
    }
}
