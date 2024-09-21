namespace main_form
{
    partial class FormPayBill
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayBill));
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_SumBill = new Guna.UI2.WinForms.Guna2TextBox();
            btn_orderAddFood = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lab_NameTable = new Label();
            listView_InforFood = new ListView();
            Number = new ColumnHeader();
            NameFood = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            btn_orderAlterFood = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btn_orderChangeTable = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            btn_payBill = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            btn_orderAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            btn_orderAlterFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            btn_orderChangeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            btn_payBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(50, 485);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(163, 43);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "Tổng tiền:";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_SumBill
            // 
            txt_SumBill.BorderRadius = 10;
            txt_SumBill.CustomizableEdges = customizableEdges3;
            txt_SumBill.DefaultText = "";
            txt_SumBill.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_SumBill.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_SumBill.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_SumBill.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_SumBill.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SumBill.Font = new Font("Segoe UI", 9F);
            txt_SumBill.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_SumBill.Location = new Point(219, 480);
            txt_SumBill.Margin = new Padding(3, 4, 3, 4);
            txt_SumBill.Name = "txt_SumBill";
            txt_SumBill.PasswordChar = '\0';
            txt_SumBill.PlaceholderText = "";
            txt_SumBill.SelectedText = "";
            txt_SumBill.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_SumBill.Size = new Size(609, 55);
            txt_SumBill.TabIndex = 8;
            // 
            // btn_orderAddFood
            // 
            btn_orderAddFood.BackColor = Color.CornflowerBlue;
            btn_orderAddFood.Controls.Add(label1);
            btn_orderAddFood.Controls.Add(pictureBox1);
            btn_orderAddFood.Cursor = Cursors.Hand;
            btn_orderAddFood.Location = new Point(50, 556);
            btn_orderAddFood.Name = "btn_orderAddFood";
            btn_orderAddFood.Size = new Size(778, 62);
            btn_orderAddFood.TabIndex = 7;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(333, 1);
            label1.Name = "label1";
            label1.Size = new Size(212, 60);
            label1.TabIndex = 1;
            label1.Text = "Thêm món";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(233, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lab_NameTable
            // 
            lab_NameTable.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_NameTable.ForeColor = Color.White;
            lab_NameTable.Location = new Point(220, 3);
            lab_NameTable.Name = "lab_NameTable";
            lab_NameTable.Size = new Size(460, 156);
            lab_NameTable.TabIndex = 6;
            lab_NameTable.Text = "Bàn 3";
            lab_NameTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView_InforFood
            // 
            listView_InforFood.Columns.AddRange(new ColumnHeader[] { Number, NameFood, columnHeader1 });
            listView_InforFood.Location = new Point(50, 141);
            listView_InforFood.Name = "listView_InforFood";
            listView_InforFood.Size = new Size(778, 322);
            listView_InforFood.TabIndex = 10;
            listView_InforFood.UseCompatibleStateImageBehavior = false;
            listView_InforFood.View = View.Details;
            // 
            // Number
            // 
            Number.Text = "STT";
            // 
            // NameFood
            // 
            NameFood.Text = "Tên món ăn";
            NameFood.TextAlign = HorizontalAlignment.Center;
            NameFood.Width = 500;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Giá";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            columnHeader1.Width = 200;
            // 
            // btn_orderAlterFood
            // 
            btn_orderAlterFood.BackColor = Color.CornflowerBlue;
            btn_orderAlterFood.Controls.Add(label2);
            btn_orderAlterFood.Controls.Add(pictureBox2);
            btn_orderAlterFood.Cursor = Cursors.Hand;
            btn_orderAlterFood.Location = new Point(50, 636);
            btn_orderAlterFood.Name = "btn_orderAlterFood";
            btn_orderAlterFood.Size = new Size(778, 62);
            btn_orderAlterFood.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(333, 1);
            label2.Name = "label2";
            label2.Size = new Size(212, 60);
            label2.TabIndex = 1;
            label2.Text = "Chỉnh sửa";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(233, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btn_orderChangeTable
            // 
            btn_orderChangeTable.BackColor = Color.CornflowerBlue;
            btn_orderChangeTable.Controls.Add(label3);
            btn_orderChangeTable.Controls.Add(pictureBox3);
            btn_orderChangeTable.Cursor = Cursors.Hand;
            btn_orderChangeTable.Location = new Point(50, 716);
            btn_orderChangeTable.Name = "btn_orderChangeTable";
            btn_orderChangeTable.Size = new Size(778, 62);
            btn_orderChangeTable.TabIndex = 7;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(348, 2);
            label3.Name = "label3";
            label3.Size = new Size(212, 59);
            label3.TabIndex = 1;
            label3.Text = "Chuyển bàn";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(233, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // btn_payBill
            // 
            btn_payBill.BackColor = Color.CornflowerBlue;
            btn_payBill.Controls.Add(label4);
            btn_payBill.Controls.Add(pictureBox4);
            btn_payBill.Cursor = Cursors.Hand;
            btn_payBill.Location = new Point(50, 799);
            btn_payBill.Name = "btn_payBill";
            btn_payBill.Size = new Size(778, 132);
            btn_payBill.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(299, 2);
            label4.Name = "label4";
            label4.Size = new Size(281, 128);
            label4.TabIndex = 1;
            label4.Text = "Thanh toán";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = (Image)resources.GetObject("pictureBox4.ErrorImage");
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(141, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(131, 131);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // FormPayBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(listView_InforFood);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(txt_SumBill);
            Controls.Add(btn_payBill);
            Controls.Add(btn_orderChangeTable);
            Controls.Add(btn_orderAlterFood);
            Controls.Add(btn_orderAddFood);
            Controls.Add(lab_NameTable);
            Name = "FormPayBill";
            Size = new Size(875, 953);
            Load += FormPayBill_Load;
            btn_orderAddFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            btn_orderAlterFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            btn_orderChangeTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            btn_payBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_SumBill;
        private Panel btn_orderAddFood;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lab_NameTable;
        private ListView listView_InforFood;
        private ColumnHeader Number;
        private ColumnHeader NameFood;
        private ColumnHeader columnHeader1;
        private Panel btn_orderAlterFood;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel btn_orderChangeTable;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel btn_payBill;
        private Label label4;
        private PictureBox pictureBox4;
    }
}
