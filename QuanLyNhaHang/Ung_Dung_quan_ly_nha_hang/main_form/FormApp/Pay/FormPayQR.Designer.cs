namespace main_form.FormApp.Pay
{
    partial class FormPayQR
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayQR));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_payBill = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lab_NameTable = new Label();
            txt_nameCusCard = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lab_payResult = new Label();
            lab_timeDownCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            picb_QRCode = new PictureBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_payBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_QRCode).BeginInit();
            SuspendLayout();
            // 
            // btn_payBill
            // 
            btn_payBill.BackColor = Color.CornflowerBlue;
            btn_payBill.Controls.Add(label1);
            btn_payBill.Controls.Add(pictureBox1);
            btn_payBill.Cursor = Cursors.Hand;
            btn_payBill.Location = new Point(86, 619);
            btn_payBill.Name = "btn_payBill";
            btn_payBill.Size = new Size(766, 109);
            btn_payBill.TabIndex = 39;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(323, 1);
            label1.Name = "label1";
            label1.Size = new Size(265, 106);
            label1.TabIndex = 1;
            label1.Text = "Thanh toán";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(186, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lab_NameTable
            // 
            lab_NameTable.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_NameTable.ForeColor = Color.White;
            lab_NameTable.Location = new Point(241, 0);
            lab_NameTable.Name = "lab_NameTable";
            lab_NameTable.Size = new Size(460, 156);
            lab_NameTable.TabIndex = 36;
            lab_NameTable.Text = "Bàn 3";
            lab_NameTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_nameCusCard
            // 
            txt_nameCusCard.BorderRadius = 10;
            txt_nameCusCard.CustomizableEdges = customizableEdges3;
            txt_nameCusCard.DefaultText = "";
            txt_nameCusCard.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_nameCusCard.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_nameCusCard.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_nameCusCard.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_nameCusCard.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_nameCusCard.Font = new Font("Segoe UI", 9F);
            txt_nameCusCard.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_nameCusCard.Location = new Point(241, 160);
            txt_nameCusCard.Margin = new Padding(3, 4, 3, 4);
            txt_nameCusCard.Name = "txt_nameCusCard";
            txt_nameCusCard.PasswordChar = '\0';
            txt_nameCusCard.PlaceholderText = "";
            txt_nameCusCard.SelectedText = "";
            txt_nameCusCard.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_nameCusCard.Size = new Size(609, 55);
            txt_nameCusCard.TabIndex = 37;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(70, 170);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(165, 36);
            guna2HtmlLabel1.TabIndex = 38;
            guna2HtmlLabel1.Text = "Tổng tiền:";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.TopCenter;
            // 
            // lab_payResult
            // 
            lab_payResult.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_payResult.ForeColor = Color.White;
            lab_payResult.Location = new Point(180, 764);
            lab_payResult.Name = "lab_payResult";
            lab_payResult.Size = new Size(620, 93);
            lab_payResult.TabIndex = 40;
            lab_payResult.Text = "Kết quả thanh toán";
            lab_payResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lab_timeDownCount
            // 
            lab_timeDownCount.AutoSize = false;
            lab_timeDownCount.BackColor = Color.Transparent;
            lab_timeDownCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_timeDownCount.ForeColor = Color.White;
            lab_timeDownCount.Location = new Point(198, 431);
            lab_timeDownCount.Name = "lab_timeDownCount";
            lab_timeDownCount.Size = new Size(68, 32);
            lab_timeDownCount.TabIndex = 41;
            lab_timeDownCount.Text = "90s";
            lab_timeDownCount.TextAlignment = ContentAlignment.BottomCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // picb_QRCode
            // 
            picb_QRCode.Location = new Point(409, 280);
            picb_QRCode.Name = "picb_QRCode";
            picb_QRCode.Size = new Size(346, 283);
            picb_QRCode.SizeMode = PictureBoxSizeMode.Zoom;
            picb_QRCode.TabIndex = 42;
            picb_QRCode.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(142, 280);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(178, 118);
            guna2HtmlLabel2.TabIndex = 38;
            guna2HtmlLabel2.Text = "Thời gian hiệu lực của mã QR code";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.TopCenter;
            // 
            // FormPayQR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(picb_QRCode);
            Controls.Add(lab_timeDownCount);
            Controls.Add(btn_payBill);
            Controls.Add(lab_NameTable);
            Controls.Add(txt_nameCusCard);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(lab_payResult);
            Name = "FormPayQR";
            Size = new Size(912, 953);
            Load += FormPayQR_Load;
            btn_payBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_QRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel btn_payBill;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lab_NameTable;
        private Guna.UI2.WinForms.Guna2TextBox txt_nameCusCard;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label lab_payResult;
        private Guna.UI2.WinForms.Guna2HtmlLabel lab_timeDownCount;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picb_QRCode;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
