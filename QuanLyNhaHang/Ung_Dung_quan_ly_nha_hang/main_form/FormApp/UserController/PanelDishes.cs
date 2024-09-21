using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form.work
{
    public partial class PanelDishes : UserControl
    {
        private string nameFoodText;
        [Category("Custom Properties")]
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
                picbox_foodImage.Image = imageFood;
            }
        }
       
        private Color panelFoodColor;
        [Category("Custom Properties")]
        public Color PanelFoodColor
        {
            get { return panelFoodColor; }
            set
            {
                panelFoodColor = value;
                pan_background.BackColor = value;
            }
        } 
        public PanelDishes()
        {
            InitializeComponent();
            //màu background
            this.BackColor = Color.Transparent;
            
            //set up các thuộc tính cơ bản
            nameFoodText = "name food";
            priceFoodText = "price food";
            imageFood = picbox_foodImage.Image;
            panelFoodColor = pan_background.BackColor;

            //vẽ border radius
            setUpBorderR();
        }

        private void setUpBorderR()
        {
            setUpBR.setUpBorderRadius(this, "pan_background", 30, 30);
        }
    }
}
