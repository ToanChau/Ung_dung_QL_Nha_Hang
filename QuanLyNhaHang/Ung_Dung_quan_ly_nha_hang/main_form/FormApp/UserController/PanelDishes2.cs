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
        public PanelDishes2()
        {
            InitializeComponent();

            nameFoodText = "name food";
            priceFoodText = "price food";
            imageFood = pic_imageFood.Image;
            setUpBorderR();
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "pan_background", 30, 30);
        }
    }
}
