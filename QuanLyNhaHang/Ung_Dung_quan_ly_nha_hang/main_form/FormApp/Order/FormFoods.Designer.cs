namespace main_form.FormApp
{
    partial class FormFoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoods));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lab_NameTable = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelDishes1 = new UserController.panelDishes();
            panelDishes2 = new UserController.panelDishes();
            panelDishes3 = new UserController.panelDishes();
            txt_findFood = new Panel();
            btn_FindFoodIcon = new PictureBox();
            txt_foodFindName = new Guna.UI2.WinForms.Guna2TextBox();
            btn_addFood = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelDishes4 = new UserController.panelDishes();
            flowLayoutPanel1.SuspendLayout();
            txt_findFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_FindFoodIcon).BeginInit();
            btn_addFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lab_NameTable
            // 
            lab_NameTable.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_NameTable.ForeColor = Color.White;
            lab_NameTable.Location = new Point(189, 4);
            lab_NameTable.Name = "lab_NameTable";
            lab_NameTable.Size = new Size(460, 156);
            lab_NameTable.TabIndex = 5;
            lab_NameTable.Text = "Bàn 3";
            lab_NameTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(panelDishes1);
            flowLayoutPanel1.Controls.Add(panelDishes2);
            flowLayoutPanel1.Controls.Add(panelDishes3);
            flowLayoutPanel1.Controls.Add(panelDishes4);
            flowLayoutPanel1.Location = new Point(77, 296);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(741, 452);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // panelDishes1
            // 
            panelDishes1.AutoSize = true;
            panelDishes1.BackColor = Color.Transparent;
            panelDishes1.ID = 0;
            panelDishes1.ImageFood = null;
            panelDishes1.Location = new Point(3, 3);
            panelDishes1.Name = "panelDishes1";
            panelDishes1.NameFoodText = "name food";
            panelDishes1.PanelFoodColor = Color.LightSkyBlue;
            panelDishes1.PriceFoodText = "price food";
            panelDishes1.Size = new Size(732, 111);
            panelDishes1.TabIndex = 0;
            // 
            // panelDishes2
            // 
            panelDishes2.AutoSize = true;
            panelDishes2.BackColor = Color.Transparent;
            panelDishes2.ID = 0;
            panelDishes2.ImageFood = null;
            panelDishes2.Location = new Point(3, 120);
            panelDishes2.Name = "panelDishes2";
            panelDishes2.NameFoodText = "name food";
            panelDishes2.PanelFoodColor = Color.LightSkyBlue;
            panelDishes2.PriceFoodText = "price food";
            panelDishes2.Size = new Size(732, 111);
            panelDishes2.TabIndex = 1;
            // 
            // panelDishes3
            // 
            panelDishes3.AutoSize = true;
            panelDishes3.BackColor = Color.Transparent;
            panelDishes3.ID = 0;
            panelDishes3.ImageFood = null;
            panelDishes3.Location = new Point(3, 237);
            panelDishes3.Name = "panelDishes3";
            panelDishes3.NameFoodText = "name food";
            panelDishes3.PanelFoodColor = Color.LightSkyBlue;
            panelDishes3.PriceFoodText = "price food";
            panelDishes3.Size = new Size(732, 111);
            panelDishes3.TabIndex = 2;
            // 
            // txt_findFood
            // 
            txt_findFood.BackColor = Color.White;
            txt_findFood.Controls.Add(btn_FindFoodIcon);
            txt_findFood.Controls.Add(txt_foodFindName);
            txt_findFood.Cursor = Cursors.IBeam;
            txt_findFood.Location = new Point(78, 163);
            txt_findFood.Name = "txt_findFood";
            txt_findFood.Size = new Size(741, 86);
            txt_findFood.TabIndex = 10;
            txt_findFood.Click += txt_findFood_Click;
            // 
            // btn_FindFoodIcon
            // 
            btn_FindFoodIcon.BackColor = Color.WhiteSmoke;
            btn_FindFoodIcon.Cursor = Cursors.Hand;
            btn_FindFoodIcon.ErrorImage = (Image)resources.GetObject("btn_FindFoodIcon.ErrorImage");
            btn_FindFoodIcon.Image = (Image)resources.GetObject("btn_FindFoodIcon.Image");
            btn_FindFoodIcon.InitialImage = (Image)resources.GetObject("btn_FindFoodIcon.InitialImage");
            btn_FindFoodIcon.Location = new Point(655, 0);
            btn_FindFoodIcon.Name = "btn_FindFoodIcon";
            btn_FindFoodIcon.Size = new Size(86, 86);
            btn_FindFoodIcon.SizeMode = PictureBoxSizeMode.Zoom;
            btn_FindFoodIcon.TabIndex = 9;
            btn_FindFoodIcon.TabStop = false;
            btn_FindFoodIcon.MouseLeave += btn_FindFoodIcon_MouseLeave;
            btn_FindFoodIcon.MouseHover += btn_FindFoodIcon_MouseHover;
            // 
            // txt_foodFindName
            // 
            txt_foodFindName.BorderThickness = 0;
            txt_foodFindName.CustomizableEdges = customizableEdges1;
            txt_foodFindName.DefaultText = "";
            txt_foodFindName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_foodFindName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_foodFindName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_foodFindName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_foodFindName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_foodFindName.Font = new Font("Segoe UI", 14F);
            txt_foodFindName.ForeColor = Color.Black;
            txt_foodFindName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_foodFindName.Location = new Point(32, 2);
            txt_foodFindName.Margin = new Padding(8, 9, 8, 9);
            txt_foodFindName.Name = "txt_foodFindName";
            txt_foodFindName.PasswordChar = '\0';
            txt_foodFindName.PlaceholderText = "";
            txt_foodFindName.SelectedText = "";
            txt_foodFindName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_foodFindName.Size = new Size(623, 83);
            txt_foodFindName.TabIndex = 10;
            // 
            // btn_addFood
            // 
            btn_addFood.BackColor = Color.CornflowerBlue;
            btn_addFood.Controls.Add(label1);
            btn_addFood.Controls.Add(pictureBox1);
            btn_addFood.Cursor = Cursors.Hand;
            btn_addFood.Location = new Point(77, 797);
            btn_addFood.Name = "btn_addFood";
            btn_addFood.Size = new Size(741, 86);
            btn_addFood.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(329, 1);
            label1.Name = "label1";
            label1.Size = new Size(278, 84);
            label1.TabIndex = 1;
            label1.Text = "Thêm món";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(204, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelDishes4
            // 
            panelDishes4.AutoSize = true;
            panelDishes4.BackColor = Color.Transparent;
            panelDishes4.ID = 0;
            panelDishes4.ImageFood = null;
            panelDishes4.Location = new Point(3, 354);
            panelDishes4.Name = "panelDishes4";
            panelDishes4.NameFoodText = "name food";
            panelDishes4.PanelFoodColor = Color.LightSkyBlue;
            panelDishes4.PriceFoodText = "price food";
            panelDishes4.Size = new Size(732, 111);
            panelDishes4.TabIndex = 3;
            // 
            // FormFoods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(btn_addFood);
            Controls.Add(txt_findFood);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lab_NameTable);
            Name = "FormFoods";
            Size = new Size(908, 914);
            Load += FormFoods_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            txt_findFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_FindFoodIcon).EndInit();
            btn_addFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lab_NameTable;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel txt_findFood;
        private PictureBox btn_FindFoodIcon;
        private Guna.UI2.WinForms.Guna2TextBox txt_foodFindName;

        private Panel btn_addFood;
        private Label label1;
        private PictureBox pictureBox1;
        private UserController.panelDishes panelDishes1;
        private UserController.panelDishes panelDishes2;
        private UserController.panelDishes panelDishes3;
        private UserController.panelDishes panelDishes4;
    }
}
