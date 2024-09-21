namespace main_form.FormApp
{
    partial class FormOptionPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptionPay));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            columnHeader1 = new ColumnHeader();
            Number = new ColumnHeader();
            listView_InforFood = new ListView();
            NameFood = new ColumnHeader();
            lab_NameTable = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txt_SumBill = new Guna.UI2.WinForms.Guna2TextBox();
            btn_payCash = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_discount = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_additionFee = new Guna.UI2.WinForms.Guna2TextBox();
            btn_payCard = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_Bill = new Guna.UI2.WinForms.Guna2TextBox();
            btn_payQR = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            btn_payCash.SuspendLayout();
            btn_payCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            btn_payQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Giá";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 200;
            // 
            // Number
            // 
            Number.Text = "STT";
            // 
            // listView_InforFood
            // 
            listView_InforFood.Columns.AddRange(new ColumnHeader[] { Number, NameFood, columnHeader1 });
            listView_InforFood.Location = new Point(76, 142);
            listView_InforFood.Name = "listView_InforFood";
            listView_InforFood.Size = new Size(778, 322);
            listView_InforFood.TabIndex = 18;
            listView_InforFood.UseCompatibleStateImageBehavior = false;
            listView_InforFood.View = View.Details;
            // 
            // NameFood
            // 
            NameFood.Text = "Tên món ăn";
            NameFood.TextAlign = HorizontalAlignment.Center;
            NameFood.Width = 500;
            // 
            // lab_NameTable
            // 
            lab_NameTable.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_NameTable.ForeColor = Color.White;
            lab_NameTable.Location = new Point(246, 4);
            lab_NameTable.Name = "lab_NameTable";
            lab_NameTable.Size = new Size(460, 156);
            lab_NameTable.TabIndex = 11;
            lab_NameTable.Text = "Bàn 3";
            lab_NameTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 3);
            label1.Name = "label1";
            label1.Size = new Size(127, 63);
            label1.TabIndex = 1;
            label1.Text = "Tiền mặt";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(23, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_SumBill
            // 
            txt_SumBill.BorderRadius = 10;
            txt_SumBill.CustomizableEdges = customizableEdges1;
            txt_SumBill.DefaultText = "";
            txt_SumBill.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_SumBill.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_SumBill.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_SumBill.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_SumBill.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SumBill.Font = new Font("Segoe UI", 9F);
            txt_SumBill.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SumBill.Location = new Point(245, 481);
            txt_SumBill.Margin = new Padding(3, 4, 3, 4);
            txt_SumBill.Name = "txt_SumBill";
            txt_SumBill.PasswordChar = '\0';
            txt_SumBill.PlaceholderText = "";
            txt_SumBill.SelectedText = "";
            txt_SumBill.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_SumBill.Size = new Size(609, 55);
            txt_SumBill.TabIndex = 16;
            // 
            // btn_payCash
            // 
            btn_payCash.BackColor = Color.LightGreen;
            btn_payCash.Controls.Add(label1);
            btn_payCash.Controls.Add(pictureBox1);
            btn_payCash.Cursor = Cursors.Hand;
            btn_payCash.Location = new Point(71, 821);
            btn_payCash.Name = "btn_payCash";
            btn_payCash.Size = new Size(246, 73);
            btn_payCash.TabIndex = 15;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(108, 488);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(131, 43);
            guna2HtmlLabel1.TabIndex = 17;
            guna2HtmlLabel1.Text = "Tổng:";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(75, 566);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(163, 43);
            guna2HtmlLabel2.TabIndex = 17;
            guna2HtmlLabel2.Text = "Giảm giá:";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_discount
            // 
            txt_discount.BorderRadius = 10;
            txt_discount.CustomizableEdges = customizableEdges3;
            txt_discount.DefaultText = "";
            txt_discount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_discount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_discount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_discount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_discount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_discount.Font = new Font("Segoe UI", 9F);
            txt_discount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_discount.Location = new Point(245, 560);
            txt_discount.Margin = new Padding(3, 4, 3, 4);
            txt_discount.Name = "txt_discount";
            txt_discount.PasswordChar = '\0';
            txt_discount.PlaceholderText = "";
            txt_discount.SelectedText = "";
            txt_discount.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_discount.Size = new Size(609, 55);
            txt_discount.TabIndex = 16;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.AutoSize = false;
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.White;
            guna2HtmlLabel3.Location = new Point(90, 644);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(147, 43);
            guna2HtmlLabel3.TabIndex = 17;
            guna2HtmlLabel3.Text = "Phụ thu:";
            guna2HtmlLabel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_additionFee
            // 
            txt_additionFee.BorderRadius = 10;
            txt_additionFee.CustomizableEdges = customizableEdges5;
            txt_additionFee.DefaultText = "";
            txt_additionFee.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_additionFee.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_additionFee.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_additionFee.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_additionFee.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_additionFee.Font = new Font("Segoe UI", 9F);
            txt_additionFee.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_additionFee.Location = new Point(246, 639);
            txt_additionFee.Margin = new Padding(3, 4, 3, 4);
            txt_additionFee.Name = "txt_additionFee";
            txt_additionFee.PasswordChar = '\0';
            txt_additionFee.PlaceholderText = "";
            txt_additionFee.SelectedText = "";
            txt_additionFee.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txt_additionFee.Size = new Size(609, 55);
            txt_additionFee.TabIndex = 16;
            // 
            // btn_payCard
            // 
            btn_payCard.BackColor = Color.LightGreen;
            btn_payCard.Controls.Add(label2);
            btn_payCard.Controls.Add(pictureBox2);
            btn_payCard.Cursor = Cursors.Hand;
            btn_payCard.Location = new Point(347, 821);
            btn_payCard.Name = "btn_payCard";
            btn_payCard.Size = new Size(246, 73);
            btn_payCard.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(134, 4);
            label2.Name = "label2";
            label2.Size = new Size(90, 63);
            label2.TabIndex = 1;
            label2.Text = "Thẻ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(53, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.AutoSize = false;
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.White;
            guna2HtmlLabel4.Location = new Point(63, 722);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(163, 43);
            guna2HtmlLabel4.TabIndex = 17;
            guna2HtmlLabel4.Text = "Thành tiền:";
            guna2HtmlLabel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_Bill
            // 
            txt_Bill.BorderRadius = 10;
            txt_Bill.CustomizableEdges = customizableEdges7;
            txt_Bill.DefaultText = "";
            txt_Bill.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Bill.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Bill.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Bill.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Bill.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Bill.Font = new Font("Segoe UI", 9F);
            txt_Bill.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Bill.Location = new Point(246, 718);
            txt_Bill.Margin = new Padding(3, 4, 3, 4);
            txt_Bill.Name = "txt_Bill";
            txt_Bill.PasswordChar = '\0';
            txt_Bill.PlaceholderText = "";
            txt_Bill.SelectedText = "";
            txt_Bill.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txt_Bill.Size = new Size(609, 55);
            txt_Bill.TabIndex = 16;
            // 
            // btn_payQR
            // 
            btn_payQR.BackColor = Color.LightGreen;
            btn_payQR.Controls.Add(label3);
            btn_payQR.Controls.Add(pictureBox3);
            btn_payQR.Cursor = Cursors.Hand;
            btn_payQR.Location = new Point(623, 822);
            btn_payQR.Name = "btn_payQR";
            btn_payQR.Size = new Size(246, 73);
            btn_payQR.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(142, 5);
            label3.Name = "label3";
            label3.Size = new Size(75, 63);
            label3.TabIndex = 1;
            label3.Text = "QR";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(64, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // FormOptionPay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(listView_InforFood);
            Controls.Add(lab_NameTable);
            Controls.Add(txt_Bill);
            Controls.Add(txt_additionFee);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(txt_discount);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(txt_SumBill);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(btn_payQR);
            Controls.Add(btn_payCard);
            Controls.Add(btn_payCash);
            Controls.Add(guna2HtmlLabel1);
            Name = "FormOptionPay";
            Size = new Size(912, 953);
            Load += FormOptionPay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            btn_payCash.ResumeLayout(false);
            btn_payCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            btn_payQR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ColumnHeader columnHeader1;
        private ColumnHeader Number;
        private ListView listView_InforFood;
        private ColumnHeader NameFood;
        private Label lab_NameTable;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_SumBill;
        private Panel btn_payCash;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_discount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_additionFee;
        private Panel btn_payCard;
        private Label label2;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txt_Bill;
        private Panel btn_payQR;
        private Label label3;
        private PictureBox pictureBox3;
    }
}
