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
            lab_openTable = new Label();
            pbox_openTable = new PictureBox();
            btn_orderTable = new Panel();
            lab_order = new Label();
            pbox_order = new PictureBox();
            btn_openTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox_openTable).BeginInit();
            btn_orderTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox_order).BeginInit();
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
            btn_openTable.Controls.Add(lab_openTable);
            btn_openTable.Controls.Add(pbox_openTable);
            btn_openTable.Cursor = Cursors.Hand;
            btn_openTable.Location = new Point(164, 174);
            btn_openTable.Name = "btn_openTable";
            btn_openTable.Size = new Size(591, 87);
            btn_openTable.TabIndex = 5;
            btn_openTable.Click += openTable_click;
            // 
            // lab_openTable
            // 
            lab_openTable.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_openTable.ForeColor = Color.White;
            lab_openTable.Location = new Point(246, 1);
            lab_openTable.Name = "lab_openTable";
            lab_openTable.Size = new Size(212, 85);
            lab_openTable.TabIndex = 5;
            lab_openTable.Text = "Mở bàn";
            lab_openTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbox_openTable
            // 
            pbox_openTable.ErrorImage = (Image)resources.GetObject("pbox_openTable.ErrorImage");
            pbox_openTable.Image = (Image)resources.GetObject("pbox_openTable.Image");
            pbox_openTable.InitialImage = (Image)resources.GetObject("pbox_openTable.InitialImage");
            pbox_openTable.Location = new Point(132, 1);
            pbox_openTable.Name = "pbox_openTable";
            pbox_openTable.Size = new Size(111, 84);
            pbox_openTable.SizeMode = PictureBoxSizeMode.Zoom;
            pbox_openTable.TabIndex = 4;
            pbox_openTable.TabStop = false;
            // 
            // btn_orderTable
            // 
            btn_orderTable.BackColor = Color.CornflowerBlue;
            btn_orderTable.Controls.Add(lab_order);
            btn_orderTable.Controls.Add(pbox_order);
            btn_orderTable.Cursor = Cursors.Hand;
            btn_orderTable.Location = new Point(164, 372);
            btn_orderTable.Name = "btn_orderTable";
            btn_orderTable.Size = new Size(591, 87);
            btn_orderTable.TabIndex = 5;
            // 
            // lab_order
            // 
            lab_order.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_order.ForeColor = Color.White;
            lab_order.Location = new Point(247, 1);
            lab_order.Name = "lab_order";
            lab_order.Size = new Size(212, 85);
            lab_order.TabIndex = 5;
            lab_order.Text = "Đặt bàn";
            lab_order.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbox_order
            // 
            pbox_order.ErrorImage = (Image)resources.GetObject("pbox_order.ErrorImage");
            pbox_order.Image = (Image)resources.GetObject("pbox_order.Image");
            pbox_order.InitialImage = (Image)resources.GetObject("pbox_order.InitialImage");
            pbox_order.Location = new Point(131, 1);
            pbox_order.Name = "pbox_order";
            pbox_order.Size = new Size(113, 84);
            pbox_order.SizeMode = PictureBoxSizeMode.Zoom;
            pbox_order.TabIndex = 4;
            pbox_order.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pbox_openTable).EndInit();
            btn_orderTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbox_order).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lab_NameTable;
        private Panel btn_openTable;
        private Label lab_openTable;
        private PictureBox pbox_openTable;
        private Panel btn_orderTable;
        private Label lab_order;
        private PictureBox pbox_order;
    }
}
