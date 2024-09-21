namespace main_form
{
    partial class FormDetailTableOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailTableOrder));
            lab_NameTable = new Label();
            btn_openTable = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_orderTable = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btn_openTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            btn_orderTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lab_NameTable
            // 
            lab_NameTable.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_NameTable.ForeColor = Color.White;
            lab_NameTable.Location = new Point(238, 11);
            lab_NameTable.Name = "lab_NameTable";
            lab_NameTable.Size = new Size(460, 156);
            lab_NameTable.TabIndex = 0;
            lab_NameTable.Text = "Bàn 3";
            lab_NameTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_openTable
            // 
            btn_openTable.BackColor = Color.CornflowerBlue;
            btn_openTable.Controls.Add(label1);
            btn_openTable.Controls.Add(pictureBox1);
            btn_openTable.Cursor = Cursors.Hand;
            btn_openTable.Location = new Point(164, 174);
            btn_openTable.Name = "btn_openTable";
            btn_openTable.Size = new Size(591, 87);
            btn_openTable.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(246, 1);
            label1.Name = "label1";
            label1.Size = new Size(212, 85);
            label1.TabIndex = 5;
            label1.Text = "Mở bàn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(132, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_orderTable
            // 
            btn_orderTable.BackColor = Color.CornflowerBlue;
            btn_orderTable.Controls.Add(label2);
            btn_orderTable.Controls.Add(pictureBox2);
            btn_orderTable.Cursor = Cursors.Hand;
            btn_orderTable.Location = new Point(164, 372);
            btn_orderTable.Name = "btn_orderTable";
            btn_orderTable.Size = new Size(591, 87);
            btn_orderTable.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(247, 1);
            label2.Name = "label2";
            label2.Size = new Size(212, 85);
            label2.TabIndex = 5;
            label2.Text = "Đặt bàn";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(131, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FormDetailTableOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(btn_orderTable);
            Controls.Add(btn_openTable);
            Controls.Add(lab_NameTable);
            Name = "FormDetailTableOrder";
            Size = new Size(1091, 1866);
            Load += FormDetailTableOrder_Load;
            btn_openTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            btn_orderTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lab_NameTable;
        private Panel btn_openTable;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel btn_orderTable;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
