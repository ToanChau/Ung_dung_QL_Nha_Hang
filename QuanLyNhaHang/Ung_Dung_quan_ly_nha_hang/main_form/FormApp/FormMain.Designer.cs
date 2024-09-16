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
            flowLayoutPanel2 = new FlowLayoutPanel();
            img_Menu = new PictureBox();
            label3 = new Label();
            lab_Menu = new Label();
            pan_order = new Panel();
            pan_function = new Panel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            img_User = new PictureBox();
            lab_NameUser = new Label();
            lab_Log = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            img_Account = new PictureBox();
            label7 = new Label();
            lab_Account = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            img_Staff = new PictureBox();
            label5 = new Label();
            lab_Staff = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            img_Home = new PictureBox();
            label2 = new Label();
            lab_Home = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Menu).BeginInit();
            pan_function.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_User).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Account).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Staff).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AllowDrop = true;
            flowLayoutPanel2.Controls.Add(img_Menu);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(lab_Menu);
            flowLayoutPanel2.Cursor = Cursors.Hand;
            flowLayoutPanel2.ImeMode = ImeMode.NoControl;
            flowLayoutPanel2.Location = new Point(3, 308);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(342, 95);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.MouseLeave += Change_MouseLeave;
            flowLayoutPanel2.MouseHover += Change_MouseHover;
            // 
            // img_Menu
            // 
            img_Menu.Image = Properties.Resources.menu;
            img_Menu.InitialImage = Properties.Resources.staff;
            img_Menu.Location = new Point(3, 3);
            img_Menu.Name = "img_Menu";
            img_Menu.Size = new Size(97, 95);
            img_Menu.TabIndex = 0;
            img_Menu.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 0);
            label3.Name = "label3";
            label3.Size = new Size(29, 60);
            label3.TabIndex = 2;
            label3.Text = " ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lab_Menu
            // 
            lab_Menu.BackColor = Color.Transparent;
            lab_Menu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_Menu.ForeColor = Color.White;
            lab_Menu.Location = new Point(141, 0);
            lab_Menu.Name = "lab_Menu";
            lab_Menu.Size = new Size(161, 95);
            lab_Menu.TabIndex = 1;
            lab_Menu.Text = "Thực đơn";
            lab_Menu.TextAlign = ContentAlignment.MiddleCenter;
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
            pan_function.Controls.Add(flowLayoutPanel6);
            pan_function.Controls.Add(flowLayoutPanel4);
            pan_function.Controls.Add(flowLayoutPanel3);
            pan_function.Controls.Add(flowLayoutPanel2);
            pan_function.Controls.Add(flowLayoutPanel1);
            pan_function.Controls.Add(pictureBox2);
            pan_function.Controls.Add(pictureBox1);
            pan_function.Location = new Point(1, 0);
            pan_function.Name = "pan_function";
            pan_function.Size = new Size(348, 995);
            pan_function.TabIndex = 1;
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
            img_User.Image = Properties.Resources.Acounting;
            img_User.InitialImage = Properties.Resources.staff;
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
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AllowDrop = true;
            flowLayoutPanel4.Controls.Add(img_Account);
            flowLayoutPanel4.Controls.Add(label7);
            flowLayoutPanel4.Controls.Add(lab_Account);
            flowLayoutPanel4.Cursor = Cursors.Hand;
            flowLayoutPanel4.ImeMode = ImeMode.NoControl;
            flowLayoutPanel4.Location = new Point(3, 507);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(342, 95);
            flowLayoutPanel4.TabIndex = 1;
            flowLayoutPanel4.MouseLeave += Change_MouseLeave;
            flowLayoutPanel4.MouseHover += Change_MouseHover;
            // 
            // img_Account
            // 
            img_Account.Image = Properties.Resources.Acounting;
            img_Account.InitialImage = Properties.Resources.staff;
            img_Account.Location = new Point(3, 3);
            img_Account.Name = "img_Account";
            img_Account.Size = new Size(97, 95);
            img_Account.SizeMode = PictureBoxSizeMode.Zoom;
            img_Account.TabIndex = 0;
            img_Account.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(106, 0);
            label7.Name = "label7";
            label7.Size = new Size(29, 60);
            label7.TabIndex = 2;
            label7.Text = " ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lab_Account
            // 
            lab_Account.BackColor = Color.Transparent;
            lab_Account.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_Account.ForeColor = Color.White;
            lab_Account.Location = new Point(141, 0);
            lab_Account.Name = "lab_Account";
            lab_Account.Size = new Size(161, 95);
            lab_Account.TabIndex = 1;
            lab_Account.Text = "Thống kê";
            lab_Account.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AllowDrop = true;
            flowLayoutPanel3.Controls.Add(img_Staff);
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(lab_Staff);
            flowLayoutPanel3.Cursor = Cursors.Hand;
            flowLayoutPanel3.ImeMode = ImeMode.NoControl;
            flowLayoutPanel3.Location = new Point(3, 409);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(342, 95);
            flowLayoutPanel3.TabIndex = 1;
            flowLayoutPanel3.MouseLeave += Change_MouseLeave;
            flowLayoutPanel3.MouseHover += Change_MouseHover;
            // 
            // img_Staff
            // 
            img_Staff.Image = Properties.Resources.staff1;
            img_Staff.InitialImage = Properties.Resources.staff;
            img_Staff.Location = new Point(3, 3);
            img_Staff.Name = "img_Staff";
            img_Staff.Size = new Size(97, 95);
            img_Staff.SizeMode = PictureBoxSizeMode.Zoom;
            img_Staff.TabIndex = 0;
            img_Staff.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 60);
            label5.TabIndex = 2;
            label5.Text = " ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lab_Staff
            // 
            lab_Staff.BackColor = Color.Transparent;
            lab_Staff.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_Staff.ForeColor = Color.White;
            lab_Staff.Location = new Point(141, 0);
            lab_Staff.Name = "lab_Staff";
            lab_Staff.Size = new Size(161, 95);
            lab_Staff.TabIndex = 1;
            lab_Staff.Text = "Nhân viên";
            lab_Staff.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.Controls.Add(img_Home);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(lab_Home);
            flowLayoutPanel1.Cursor = Cursors.Hand;
            flowLayoutPanel1.ImeMode = ImeMode.NoControl;
            flowLayoutPanel1.Location = new Point(3, 207);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(342, 95);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.MouseLeave += Change_MouseLeave;
            flowLayoutPanel1.MouseHover += Change_MouseHover;
            // 
            // img_Home
            // 
            img_Home.BackgroundImageLayout = ImageLayout.None;
            img_Home.Cursor = Cursors.Hand;
            img_Home.Image = Properties.Resources.Home;
            img_Home.ImageLocation = "";
            img_Home.InitialImage = Properties.Resources.staff;
            img_Home.Location = new Point(3, 3);
            img_Home.Name = "img_Home";
            img_Home.Size = new Size(97, 95);
            img_Home.SizeMode = PictureBoxSizeMode.Zoom;
            img_Home.TabIndex = 0;
            img_Home.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 60);
            label2.TabIndex = 2;
            label2.Text = " ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lab_Home
            // 
            lab_Home.BackColor = Color.Transparent;
            lab_Home.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_Home.ForeColor = Color.White;
            lab_Home.Location = new Point(141, 0);
            lab_Home.Name = "lab_Home";
            lab_Home.Size = new Size(161, 95);
            lab_Home.TabIndex = 1;
            lab_Home.Text = "Trang chủ";
            lab_Home.TextAlign = ContentAlignment.MiddleCenter;
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
            pictureBox1.Image = Properties.Resources.staff;
            pictureBox1.InitialImage = Properties.Resources.staff;
            pictureBox1.Location = new Point(97, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 97);
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
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Menu).EndInit();
            pan_function.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_User).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Account).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Staff).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Home).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pan_order;
        private Panel pan_function;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox img_Home;
        private Label lab_Home;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox img_Account;
        private Label label7;
        private Label lab_Account;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox img_Staff;
        private Label label5;
        private Label lab_Staff;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox img_Menu;
        private Label label3;
        private Label lab_Menu;
        private FlowLayoutPanel flowLayoutPanel6;
        private PictureBox img_User;
        private Label lab_NameUser;
        private Label lab_Log;
        private PictureBox pictureBox2;
    }
}
