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

namespace main_form.FormApp.UserController
{
    public partial class PanelDishes2 : UserControl
    {
        private string nameFoodText;
        [Category("Custom Properties")]
        public string NameFoodText
        {
            get { return nameFoodText; }
            set
            {
                nameFoodText = value;
                lab_nameFood.Text = value;
            }
        }

        private string priceFoodText;
        [Category("Custom Properties")]
        public string PriceFoodText
        {
            get { return priceFoodText; }
            set
            {
                priceFoodText = value;
                lab_foodPrice.Text = value;
            }
        }

        private Image imageFood;
        [Category("Custom Properties")]
        public Image ImageFood
        {
            get { return imageFood; }
            set
            {
                imageFood = value;
                pic_imageFood.Image = imageFood;
            }
        }

        private int iD;
        public int ID
        {
            get { return ID; }
            set
            {
                iD = ID;
            }
        }
        public PanelDishes2()
        {
            InitializeComponent();

            nameFoodText = "name food";
            priceFoodText = "price food";
            imageFood = pic_imageFood.Image;
            setUpBorderR();

            pan_background.Click += UserControl_Click;
            lab_nameFood.Click += UserControl_Click;
            lab_foodPrice.Click += UserControl_Click;

            this.MouseHover += UserControl_Hover;
            pan_background.MouseHover += UserControl_Hover;

            this.MouseLeave += UserControl_Leave;
            pan_background.MouseLeave += UserControl_Leave;
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "pan_background", 30, 30);
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
