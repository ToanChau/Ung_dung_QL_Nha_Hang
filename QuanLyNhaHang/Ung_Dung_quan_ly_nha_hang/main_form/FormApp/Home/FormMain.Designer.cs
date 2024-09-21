namespace main_form
{
    using main_form;
    using main_form.Draw;

    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            pan_order = new Panel();
            pan_function = new Panel();
            btn_Accounting = new FormApp.UserController.ButtonFacilities_mainForm();
            btn_Staff = new FormApp.UserController.ButtonFacilities_mainForm();
            btn_Menu = new FormApp.UserController.ButtonFacilities_mainForm();
            btn_Home = new FormApp.UserController.ButtonFacilities_mainForm();
            flowLayoutPanel6 = new FlowLayoutPanel();
            img_User = new PictureBox();
            lab_NameUser = new Label();
            lab_Log = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pan_function.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_User).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pan_order
            // 
            pan_order.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan_order.BackColor = Color.LightSkyBlue;
            pan_order.Location = new Point(348, 0);
            pan_order.Name = "pan_order";
            pan_order.Size = new Size(702, 1052);
            pan_order.TabIndex = 0;
            // 
            // pan_function
            // 
            pan_function.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pan_function.BackColor = Color.SteelBlue;
            pan_function.Controls.Add(btn_Accounting);
            pan_function.Controls.Add(btn_Staff);
            pan_function.Controls.Add(btn_Menu);
            pan_function.Controls.Add(btn_Home);
            pan_function.Controls.Add(flowLayoutPanel6);
            pan_function.Controls.Add(pictureBox2);
            pan_function.Controls.Add(pictureBox1);
            pan_function.Location = new Point(1, 0);
            pan_function.Name = "pan_function";
            pan_function.Size = new Size(348, 995);
            pan_function.TabIndex = 1;
            // 
            // btn_Accounting
            // 
            btn_Accounting.AutoSize = true;
            btn_Accounting.BackColor = Color.Transparent;
            btn_Accounting.ColorFacilities = Color.Transparent;
            btn_Accounting.Cursor = Cursors.Hand;
            btn_Accounting.ImageFacilities = (Image)resources.GetObject("btn_Accounting.ImageFacilities");
            btn_Accounting.Location = new Point(19, 544);
            btn_Accounting.Name = "btn_Accounting";
            btn_Accounting.NameFacilitie = "Thống kê";
            btn_Accounting.Size = new Size(329, 100);
            btn_Accounting.TabIndex = 2;
            btn_Accounting.MouseLeave += Change_MouseLeave;
            btn_Accounting.MouseHover += Change_MouseHover;
            // 
            // btn_Staff
            // 
            btn_Staff.AutoSize = true;
            btn_Staff.BackColor = Color.Transparent;
            btn_Staff.ColorFacilities = Color.Transparent;
            btn_Staff.Cursor = Cursors.Hand;
            btn_Staff.ImageFacilities = (Image)resources.GetObject("btn_Staff.ImageFacilities");
            btn_Staff.Location = new Point(19, 438);
            btn_Staff.Name = "btn_Staff";
            btn_Staff.NameFacilitie = "Nhân viên";
            btn_Staff.Size = new Size(329, 100);
            btn_Staff.TabIndex = 2;
            btn_Staff.MouseLeave += Change_MouseLeave;
            btn_Staff.MouseHover += Change_MouseHover;
            // 
            // btn_Menu
            // 
            btn_Menu.AutoSize = true;
            btn_Menu.BackColor = Color.Transparent;
            btn_Menu.ColorFacilities = Color.Transparent;
            btn_Menu.Cursor = Cursors.Hand;
            btn_Menu.ImageFacilities = (Image)resources.GetObject("btn_Menu.ImageFacilities");
            btn_Menu.Location = new Point(16, 332);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.NameFacilitie = "Thực đơn";
            btn_Menu.Size = new Size(329, 100);
            btn_Menu.TabIndex = 2;
            btn_Menu.MouseLeave += Change_MouseLeave;
            btn_Menu.MouseHover += Change_MouseHover;
            // 
            // btn_Home
            // 
            btn_Home.AutoSize = true;
            btn_Home.BackColor = Color.Transparent;
            btn_Home.ColorFacilities = Color.Transparent;
            btn_Home.Cursor = Cursors.Hand;
            btn_Home.ImageFacilities = (Image)resources.GetObject("btn_Home.ImageFacilities");
            btn_Home.Location = new Point(16, 226);
            btn_Home.Name = "btn_Home";
            btn_Home.NameFacilitie = "Trang chủ";
            btn_Home.Size = new Size(329, 100);
            btn_Home.TabIndex = 2;
            btn_Home.Click += btn_Home_Click;
            btn_Home.MouseLeave += Change_MouseLeave;
            btn_Home.MouseHover += Change_MouseHover;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AllowDrop = true;
            flowLayoutPanel6.Controls.Add(img_User);
            flowLayoutPanel6.Controls.Add(lab_NameUser);
            flowLayoutPanel6.Controls.Add(lab_Log);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.ImeMode = ImeMode.NoControl;
            flowLayoutPanel6.Location = new Point(3, 857);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(342, 95);
            flowLayoutPanel6.TabIndex = 1;
            // 
            // img_User
            // 
            img_User.ErrorImage = (Image)resources.GetObject("img_User.ErrorImage");
            img_User.Image = (Image)resources.GetObject("img_User.Image");
            img_User.InitialImage = (Image)resources.GetObject("img_User.InitialImage");
            img_User.Location = new Point(3, 3);
            img_User.Name = "img_User";
            img_User.Size = new Size(97, 95);
            img_User.SizeMode = PictureBoxSizeMode.Zoom;
            img_User.TabIndex = 0;
            img_User.TabStop = false;
            // 
            // lab_NameUser
            // 
            lab_NameUser.BackColor = Color.Transparent;
            lab_NameUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_NameUser.ForeColor = Color.White;
            lab_NameUser.Location = new Point(106, 0);
            lab_NameUser.Name = "lab_NameUser";
            lab_NameUser.Size = new Size(232, 41);
            lab_NameUser.TabIndex = 1;
            lab_NameUser.Text = "Name user";
            lab_NameUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lab_Log
            // 
            lab_Log.BackColor = Color.Transparent;
            lab_Log.Cursor = Cursors.Hand;
            lab_Log.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_Log.ForeColor = Color.White;
            lab_Log.Location = new Point(106, 41);
            lab_Log.Name = "lab_Log";
            lab_Log.Size = new Size(232, 46);
            lab_Log.TabIndex = 1;
            lab_Log.Text = "Đăng xuất";
            lab_Log.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.VNFlat;
            pictureBox2.InitialImage = Properties.Resources.staff;
            pictureBox2.Location = new Point(109, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(72, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1050, 1055);
            Controls.Add(pan_function);
            Controls.Add(pan_order);
            MaximizeBox = false;
            Name = "Form_Main";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            pan_function.ResumeLayout(false);
            pan_function.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_User).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pan_order;
        private Panel pan_function;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel6;
        private PictureBox img_User;
        private Label lab_NameUser;
        private Label lab_Log;
        private PictureBox pictureBox2;
        private FormApp.UserController.ButtonFacilities_mainForm btn_Accounting;
        private FormApp.UserController.ButtonFacilities_mainForm btn_Staff;
        private FormApp.UserController.ButtonFacilities_mainForm btn_Menu;
        private FormApp.UserController.ButtonFacilities_mainForm btn_Home;
    }
}
