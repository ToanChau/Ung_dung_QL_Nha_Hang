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
            btn_Ingridients = new Label();
            btn_Accounting = new Label();
            btn_Staff = new Label();
            btn_Menu = new Label();
            btn_Home = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            img_User = new PictureBox();
            lab_NameUser = new Label();
            lab_Log = new Label();
            pan_function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_User).BeginInit();
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
            pan_function.Controls.Add(btn_Ingridients);
            pan_function.Controls.Add(btn_Accounting);
            pan_function.Controls.Add(btn_Staff);
            pan_function.Controls.Add(btn_Menu);
            pan_function.Controls.Add(btn_Home);
            pan_function.Controls.Add(pictureBox1);
            pan_function.Location = new Point(1, 0);
            pan_function.Name = "pan_function";
            pan_function.Size = new Size(348, 995);
            pan_function.TabIndex = 1;
            // 
            // btn_Ingridients
            // 
            btn_Ingridients.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Ingridients.ForeColor = SystemColors.ControlText;
            btn_Ingridients.Image = Properties.Resources.Home;
            btn_Ingridients.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Ingridients.Location = new Point(3, 383);
            btn_Ingridients.Name = "btn_Ingridients";
            btn_Ingridients.RightToLeft = RightToLeft.No;
            btn_Ingridients.Size = new Size(342, 93);
            btn_Ingridients.TabIndex = 1;
            btn_Ingridients.Text = "Nguyên liệu";
            btn_Ingridients.TextAlign = ContentAlignment.MiddleRight;
            btn_Ingridients.UseMnemonic = false;
            // 
            // btn_Accounting
            // 
            btn_Accounting.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Accounting.ForeColor = SystemColors.ControlText;
            btn_Accounting.Image = Properties.Resources.Acounting;
            btn_Accounting.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Accounting.Location = new Point(3, 573);
            btn_Accounting.Name = "btn_Accounting";
            btn_Accounting.RightToLeft = RightToLeft.No;
            btn_Accounting.Size = new Size(342, 93);
            btn_Accounting.TabIndex = 1;
            btn_Accounting.Text = "Thống kê";
            btn_Accounting.TextAlign = ContentAlignment.MiddleRight;
            btn_Accounting.UseMnemonic = false;
            // 
            // btn_Staff
            // 
            btn_Staff.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Staff.ForeColor = SystemColors.ControlText;
            btn_Staff.Image = Properties.Resources.staff;
            btn_Staff.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Staff.Location = new Point(3, 478);
            btn_Staff.Name = "btn_Staff";
            btn_Staff.RightToLeft = RightToLeft.No;
            btn_Staff.Size = new Size(342, 93);
            btn_Staff.TabIndex = 1;
            btn_Staff.Text = "Nhân viên";
            btn_Staff.TextAlign = ContentAlignment.MiddleRight;
            btn_Staff.UseMnemonic = false;
            // 
            // btn_Menu
            // 
            btn_Menu.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Menu.ForeColor = SystemColors.ControlText;
            btn_Menu.Image = Properties.Resources.menu;
            btn_Menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Menu.Location = new Point(4, 287);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.RightToLeft = RightToLeft.No;
            btn_Menu.Size = new Size(342, 93);
            btn_Menu.TabIndex = 1;
            btn_Menu.Text = "Thực đơn";
            btn_Menu.TextAlign = ContentAlignment.MiddleRight;
            btn_Menu.UseMnemonic = false;
            // 
            // btn_Home
            // 
            btn_Home.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Home.ForeColor = SystemColors.ControlText;
            btn_Home.Image = Properties.Resources.Home;
            btn_Home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Home.Location = new Point(3, 192);
            btn_Home.Name = "btn_Home";
            btn_Home.RightToLeft = RightToLeft.No;
            btn_Home.Size = new Size(342, 93);
            btn_Home.TabIndex = 1;
            btn_Home.Text = "Trang chủ";
            btn_Home.TextAlign = ContentAlignment.MiddleRight;
            btn_Home.UseMnemonic = false;
            btn_Home.Click += btn_Home_Click_1;
            btn_Home.MouseLeave += btn_Home_MouseLeave;
            btn_Home.MouseHover += btn_Home_MouseHover;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_User).EndInit();
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
        private Label btn_Home;
        private Label btn_Accounting;
        private Label btn_Staff;
        private Label btn_Menu;
        private Label btn_Ingridients;
    }
}
