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
            btn_openTable.Location = new Point(164, 217);
            btn_openTable.Name = "btn_openTable";
            btn_openTable.Size = new Size(591, 87);
            btn_openTable.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(248, 1);
            label1.Name = "label1";
            label1.Size = new Size(212, 85);
            label1.TabIndex = 1;
            label1.Text = "Mở bàn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(100, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_orderTable
            // 
            btn_orderTable.BackColor = Color.CornflowerBlue;
            btn_orderTable.Controls.Add(label2);
            btn_orderTable.Controls.Add(pictureBox2);
            btn_orderTable.Location = new Point(164, 372);
            btn_orderTable.Name = "btn_orderTable";
            btn_orderTable.Size = new Size(591, 87);
            btn_orderTable.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(248, 1);
            label2.Name = "label2";
            label2.Size = new Size(212, 85);
            label2.TabIndex = 1;
            label2.Text = "Đặt bàn";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(100, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 84);
            pictureBox2.TabIndex = 0;
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
