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

        private int iD;
        public int ID
        {
            get { return ID; }
            set
            {
                iD = ID;
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
            pan_background.Click += UserControl_Click;
            lab_foodName.Click += UserControl_Click;
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
