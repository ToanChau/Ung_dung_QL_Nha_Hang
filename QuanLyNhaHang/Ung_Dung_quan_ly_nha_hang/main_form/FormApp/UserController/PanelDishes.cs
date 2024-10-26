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
    public partial class panelDishes : UserControl
    {
        private string nameFoodText;
        [Category("Behavior")]
        public string NameFoodText
        {
            get { return nameFoodText; }
            set
            {
                nameFoodText = value;
                lab_foodName.Text = value;
            }
        }

        private string priceFoodText;
        [Category("Behavior")]
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
        [Category("Behavior")]
        public Image ImageFood
        {
            get { return imageFood; }
            set
            {
                imageFood = value;
                picbox_foodImage.Image = value;
            }
        }

        private Color panelFoodColor;
        [Category("Behavior")]
        public Color PanelFoodColor
        {
            get { return panelFoodColor; }
            set
            {
                panelFoodColor = value;
                pan_background.BackColor = value;
            }
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set
            {
                iD = value ;
            }
        }


        public panelDishes()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;

            //set up các thuộc tính cơ bản
            nameFoodText = "name food";
            priceFoodText = "price food";
            imageFood = picbox_foodImage.Image;
            panelFoodColor = pan_background.BackColor;
        }
        //private void setUpBorderR()
        //{
        //    setUpBR.setUpBorderRadius(this, "pan_background", 30, 30);
        //}

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
