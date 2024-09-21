namespace main_form.FormApp.Pay
{
    partial class FormPayCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayCard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges43 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges44 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges45 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges46 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges47 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges48 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges49 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges50 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_payBill = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lab_NameTable = new Label();
            txt_month = new Guna.UI2.WinForms.Guna2TextBox();
            txt_money = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_nameCusCard = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lab_payResult = new Label();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_year = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_sumBill = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_payBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_payBill
            // 
            btn_payBill.BackColor = Color.CornflowerBlue;
            btn_payBill.Controls.Add(label1);
            btn_payBill.Controls.Add(pictureBox1);
            btn_payBill.Cursor = Cursors.Hand;
            btn_payBill.Location = new Point(70, 486);
            btn_payBill.Name = "btn_payBill";
            btn_payBill.Size = new Size(766, 109);
            btn_payBill.TabIndex = 34;
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
            lab_NameTable.Location = new Point(226, 0);
            lab_NameTable.Name = "lab_NameTable";
            lab_NameTable.Size = new Size(460, 156);
            lab_NameTable.TabIndex = 27;
            lab_NameTable.Text = "Bàn 3";
            lab_NameTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_month
            // 
            txt_month.BorderRadius = 10;
            txt_month.CustomizableEdges = customizableEdges41;
            txt_month.DefaultText = "";
            txt_month.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_month.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_month.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_month.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_month.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_month.Font = new Font("Segoe UI", 9F);
            txt_month.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_month.Location = new Point(227, 318);
            txt_month.Margin = new Padding(3, 4, 3, 4);
            txt_month.Name = "txt_month";
            txt_month.PasswordChar = '\0';
            txt_month.PlaceholderText = "";
            txt_month.SelectedText = "";
            txt_month.ShadowDecoration.CustomizableEdges = customizableEdges42;
            txt_month.Size = new Size(242, 55);
            txt_month.TabIndex = 28;
            // 
            // txt_money
            // 
            txt_money.BorderRadius = 10;
            txt_money.CustomizableEdges = customizableEdges43;
            txt_money.DefaultText = "";
            txt_money.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_money.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_money.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_money.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_money.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_money.Font = new Font("Segoe UI", 9F);
            txt_money.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_money.Location = new Point(226, 239);
            txt_money.Margin = new Padding(3, 4, 3, 4);
            txt_money.Name = "txt_money";
            txt_money.PasswordChar = '\0';
            txt_money.PlaceholderText = "";
            txt_money.SelectedText = "";
            txt_money.ShadowDecoration.CustomizableEdges = customizableEdges44;
            txt_money.Size = new Size(609, 55);
            txt_money.TabIndex = 29;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.AutoSize = false;
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.White;
            guna2HtmlLabel3.Location = new Point(111, 323);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(100, 43);
            guna2HtmlLabel3.TabIndex = 31;
            guna2HtmlLabel3.Text = "Tháng:";
            guna2HtmlLabel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_nameCusCard
            // 
            txt_nameCusCard.BorderRadius = 10;
            txt_nameCusCard.CustomizableEdges = customizableEdges45;
            txt_nameCusCard.DefaultText = "";
            txt_nameCusCard.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_nameCusCard.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_nameCusCard.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_nameCusCard.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_nameCusCard.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_nameCusCard.Font = new Font("Segoe UI", 9F);
            txt_nameCusCard.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_nameCusCard.Location = new Point(226, 160);
            txt_nameCusCard.Margin = new Padding(3, 4, 3, 4);
            txt_nameCusCard.Name = "txt_nameCusCard";
            txt_nameCusCard.PasswordChar = '\0';
            txt_nameCusCard.PlaceholderText = "";
            txt_nameCusCard.SelectedText = "";
            txt_nameCusCard.ShadowDecoration.CustomizableEdges = customizableEdges46;
            txt_nameCusCard.Size = new Size(609, 55);
            txt_nameCusCard.TabIndex = 30;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(93, 239);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(126, 43);
            guna2HtmlLabel2.TabIndex = 32;
            guna2HtmlLabel2.Text = "Số tiền:";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(46, 174);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(165, 36);
            guna2HtmlLabel1.TabIndex = 33;
            guna2HtmlLabel1.Text = "Tên Chủ thẻ:";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.TopCenter;
            // 
            // lab_payResult
            // 
            lab_payResult.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_payResult.ForeColor = Color.White;
            lab_payResult.Location = new Point(164, 631);
            lab_payResult.Name = "lab_payResult";
            lab_payResult.Size = new Size(620, 93);
            lab_payResult.TabIndex = 35;
            lab_payResult.Text = "Kết quả thanh toán";
            lab_payResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.AutoSize = false;
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.White;
            guna2HtmlLabel4.Location = new Point(511, 323);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(77, 43);
            guna2HtmlLabel4.TabIndex = 36;
            guna2HtmlLabel4.Text = "năm:";
            guna2HtmlLabel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_year
            // 
            txt_year.BorderRadius = 10;
            txt_year.CustomizableEdges = customizableEdges47;
            txt_year.DefaultText = "";
            txt_year.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_year.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_year.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_year.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_year.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_year.Font = new Font("Segoe UI", 9F);
            txt_year.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_year.Location = new Point(594, 318);
            txt_year.Margin = new Padding(3, 4, 3, 4);
            txt_year.Name = "txt_year";
            txt_year.PasswordChar = '\0';
            txt_year.PlaceholderText = "";
            txt_year.SelectedText = "";
            txt_year.ShadowDecoration.CustomizableEdges = customizableEdges48;
            txt_year.Size = new Size(242, 55);
            txt_year.TabIndex = 28;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.AutoSize = false;
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.ForeColor = Color.White;
            guna2HtmlLabel5.Location = new Point(56, 402);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(163, 43);
            guna2HtmlLabel5.TabIndex = 32;
            guna2HtmlLabel5.Text = "Tổng tiền:";
            guna2HtmlLabel5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_sumBill
            // 
            txt_sumBill.BorderRadius = 10;
            txt_sumBill.CustomizableEdges = customizableEdges49;
            txt_sumBill.DefaultText = "";
            txt_sumBill.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_sumBill.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_sumBill.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_sumBill.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_sumBill.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_sumBill.Font = new Font("Segoe UI", 9F);
            txt_sumBill.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_sumBill.Location = new Point(226, 396);
            txt_sumBill.Margin = new Padding(3, 4, 3, 4);
            txt_sumBill.Name = "txt_sumBill";
            txt_sumBill.PasswordChar = '\0';
            txt_sumBill.PlaceholderText = "";
            txt_sumBill.SelectedText = "";
            txt_sumBill.ShadowDecoration.CustomizableEdges = customizableEdges50;
            txt_sumBill.Size = new Size(609, 55);
            txt_sumBill.TabIndex = 29;
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.AutoSize = false;
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel6.ForeColor = Color.White;
            guna2HtmlLabel6.Location = new Point(480, 322);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(29, 51);
            guna2HtmlLabel6.TabIndex = 37;
            guna2HtmlLabel6.Text = "/";
            guna2HtmlLabel6.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FormPayCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(guna2HtmlLabel6);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(btn_payBill);
            Controls.Add(lab_NameTable);
            Controls.Add(txt_year);
            Controls.Add(txt_month);
            Controls.Add(txt_sumBill);
            Controls.Add(txt_money);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(txt_nameCusCard);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(lab_payResult);
            Name = "FormPayCard";
            Size = new Size(912, 953);
            Load += FormPayCard_Load;
            btn_payBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel btn_payBill;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lab_NameTable;
        private Guna.UI2.WinForms.Guna2TextBox txt_month;
        private Guna.UI2.WinForms.Guna2TextBox txt_money;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_nameCusCard;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label lab_payResult;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txt_year;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_sumBill;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
    }
}
