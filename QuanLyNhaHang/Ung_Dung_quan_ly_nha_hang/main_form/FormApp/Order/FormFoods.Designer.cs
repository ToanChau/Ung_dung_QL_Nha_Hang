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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lab_NameTable = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelDishes1 = new work.PanelDishes();
            panelDishes2 = new work.PanelDishes();
            panelDishes3 = new work.PanelDishes();
            txt_findFood = new Panel();
            btn_FindFoodIcon = new PictureBox();
            txt_foodFindName = new Guna.UI2.WinForms.Guna2TextBox();
            btn_addFood = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            flowLayoutPanel1.Location = new Point(77, 296);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(741, 452);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // panelDishes1
            // 
            panelDishes1.AutoSize = true;
            panelDishes1.BackColor = Color.Transparent;
            panelDishes1.ImageFood = (Image)resources.GetObject("panelDishes1.ImageFood");
            panelDishes1.Location = new Point(3, 3);
            panelDishes1.Name = "panelDishes1";
            panelDishes1.NameFoodText = "name food";
            panelDishes1.PanelFoodColor = Color.LightSkyBlue;
            panelDishes1.PriceFoodText = "price food";
            panelDishes1.Size = new Size(689, 127);
            panelDishes1.TabIndex = 11;
            // 
            // panelDishes2
            // 
            panelDishes2.AutoSize = true;
            panelDishes2.BackColor = Color.Transparent;
            panelDishes2.ImageFood = (Image)resources.GetObject("panelDishes2.ImageFood");
            panelDishes2.Location = new Point(3, 136);
            panelDishes2.Name = "panelDishes2";
            panelDishes2.NameFoodText = "name food";
            panelDishes2.PanelFoodColor = Color.RoyalBlue;
            panelDishes2.PriceFoodText = "price food";
            panelDishes2.Size = new Size(689, 127);
            panelDishes2.TabIndex = 11;
            // 
            // panelDishes3
            // 
            panelDishes3.AutoSize = true;
            panelDishes3.BackColor = Color.Transparent;
            panelDishes3.ImageFood = (Image)resources.GetObject("panelDishes3.ImageFood");
            panelDishes3.Location = new Point(3, 269);
            panelDishes3.Name = "panelDishes3";
            panelDishes3.NameFoodText = "name food";
            panelDishes3.PanelFoodColor = Color.LightSkyBlue;
            panelDishes3.PriceFoodText = "price food";
            panelDishes3.Size = new Size(689, 127);
            panelDishes3.TabIndex = 11;
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
            txt_foodFindName.CustomizableEdges = customizableEdges3;
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
            txt_foodFindName.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
        private work.PanelDishes panelDishes1;
        private work.PanelDishes panelDishes2;
        private work.PanelDishes panelDishes3;
        private Panel btn_addFood;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
