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

        private Color colorChange;
        public Color ColorChange  // Thuộc tính để lưu màu hover từ form cha
        {
            get { return colorChange; }
            set { colorChange = value; }
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set
            {
                iD = ID;
            }
        }

        public ButtonFacilities_mainForm()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;

            nameFacilities = lab_Name.Text;
            imageFacilities = pic_facilities.Image;
            colorFacilities = panel1.BackColor;

            //panel1.Click += UserControl_Click;
            //pic_facilities.Click += UserControl_Click;
            //lab_Name.Click += UserControl_Click;

            panel1.Click += UserControl_Click;
            pic_facilities.Click += UserControl_Click;
            lab_Name.Click += UserControl_Click;

            this.MouseHover += UserControl_Hover;
            panel1.MouseHover += UserControl_Hover;
            pic_facilities.MouseHover += UserControl_Hover;
            lab_Name.MouseHover += UserControl_Hover;

            this.MouseLeave += UserControl_Leave;
            panel1.MouseLeave += UserControl_Leave;
            pic_facilities.MouseLeave += UserControl_Leave;
            lab_Name.MouseLeave += UserControl_Leave;

        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            // Kích hoạt sự kiện Click của UserControl
            this.OnClick(e);  // Kích hoạt sự kiện Click mặc định của UserControl
        }

        private void UserControl_Hover(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void UserControl_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
