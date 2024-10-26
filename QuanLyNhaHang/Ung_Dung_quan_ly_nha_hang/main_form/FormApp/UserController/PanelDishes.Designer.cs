namespace main_form.FormApp.UserController
{
    partial class panelDishes
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
            pan_background = new Panel();
            lab_foodPrice = new Label();
            lab_foodName = new Label();
            picbox_foodImage = new PictureBox();
            pan_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox_foodImage).BeginInit();
            SuspendLayout();
            // 
            // pan_background
            // 
            pan_background.BackColor = Color.LightSkyBlue;
            pan_background.Controls.Add(lab_foodPrice);
            pan_background.Controls.Add(lab_foodName);
            pan_background.Controls.Add(picbox_foodImage);
            pan_background.Cursor = Cursors.Hand;
            pan_background.Location = new Point(0, 0);
            pan_background.Name = "pan_background";
            pan_background.Size = new Size(715, 108);
            pan_background.TabIndex = 14;
            // 
            // lab_foodPrice
            // 
            lab_foodPrice.BackColor = Color.Transparent;
            lab_foodPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_foodPrice.ForeColor = Color.White;
            lab_foodPrice.Location = new Point(135, 56);
            lab_foodPrice.Name = "lab_foodPrice";
            lab_foodPrice.Size = new Size(407, 47);
            lab_foodPrice.TabIndex = 12;
            lab_foodPrice.Text = "prices";
            lab_foodPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lab_foodName
            // 
            lab_foodName.BackColor = Color.Transparent;
            lab_foodName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_foodName.ForeColor = Color.White;
            lab_foodName.Location = new Point(135, 3);
            lab_foodName.Name = "lab_foodName";
            lab_foodName.Size = new Size(407, 53);
            lab_foodName.TabIndex = 11;
            lab_foodName.Text = "Name dishes";
            lab_foodName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picbox_foodImage
            // 
            picbox_foodImage.ErrorImage = null;
            picbox_foodImage.InitialImage = null;
            picbox_foodImage.Location = new Point(3, 0);
            picbox_foodImage.Name = "picbox_foodImage";
            picbox_foodImage.Size = new Size(131, 103);
            picbox_foodImage.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_foodImage.TabIndex = 10;
            picbox_foodImage.TabStop = false;
            // 
            // panelDishes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSkyBlue;
            Controls.Add(pan_background);
            Name = "panelDishes";
            Size = new Size(719, 114);
            pan_background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picbox_foodImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_background;
        private Label lab_foodPrice;
        private Label lab_foodName;
        private PictureBox picbox_foodImage;
    }
}
