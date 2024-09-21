namespace main_form.FormApp.UserController
{
    partial class PanelDishes2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelDishes2));
            pan_background = new Panel();
            lab_foodPrice = new Label();
            lab_nameFood = new Label();
            pic_imageFood = new PictureBox();
            pan_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_imageFood).BeginInit();
            SuspendLayout();
            // 
            // pan_background
            // 
            pan_background.BackColor = Color.DarkSlateGray;
            pan_background.Controls.Add(lab_foodPrice);
            pan_background.Controls.Add(lab_nameFood);
            pan_background.Controls.Add(pic_imageFood);
            pan_background.Cursor = Cursors.Hand;
            pan_background.Location = new Point(3, 3);
            pan_background.Name = "pan_background";
            pan_background.Size = new Size(241, 340);
            pan_background.TabIndex = 14;
            // 
            // lab_foodPrice
            // 
            lab_foodPrice.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_foodPrice.ForeColor = Color.White;
            lab_foodPrice.Location = new Point(4, 292);
            lab_foodPrice.Name = "lab_foodPrice";
            lab_foodPrice.Size = new Size(235, 43);
            lab_foodPrice.TabIndex = 1;
            lab_foodPrice.Text = "giá món ăn";
            lab_foodPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lab_nameFood
            // 
            lab_nameFood.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_nameFood.ForeColor = Color.White;
            lab_nameFood.Location = new Point(3, 249);
            lab_nameFood.Name = "lab_nameFood";
            lab_nameFood.Size = new Size(235, 43);
            lab_nameFood.TabIndex = 1;
            lab_nameFood.Text = "Tên món ăn";
            lab_nameFood.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pic_imageFood
            // 
            pic_imageFood.ErrorImage = (Image)resources.GetObject("pic_imageFood.ErrorImage");
            pic_imageFood.Image = (Image)resources.GetObject("pic_imageFood.Image");
            pic_imageFood.InitialImage = (Image)resources.GetObject("pic_imageFood.InitialImage");
            pic_imageFood.Location = new Point(0, 0);
            pic_imageFood.Name = "pic_imageFood";
            pic_imageFood.Size = new Size(241, 246);
            pic_imageFood.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_imageFood.TabIndex = 0;
            pic_imageFood.TabStop = false;
            // 
            // PanelDishes2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(pan_background);
            Name = "PanelDishes2";
            Size = new Size(248, 346);
            pan_background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_imageFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_background;
        private Label lab_foodPrice;
        private Label lab_nameFood;
        private PictureBox pic_imageFood;
    }
}
