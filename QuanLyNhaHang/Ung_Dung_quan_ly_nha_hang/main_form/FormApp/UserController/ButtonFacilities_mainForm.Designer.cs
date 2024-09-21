namespace main_form.FormApp.UserController
{
    partial class ButtonFacilities_mainForm
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
            lab_Name = new Label();
            pic_facilities = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic_facilities).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lab_Name
            // 
            lab_Name.BackColor = Color.Transparent;
            lab_Name.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_Name.ForeColor = Color.White;
            lab_Name.Location = new Point(133, 4);
            lab_Name.Name = "lab_Name";
            lab_Name.Size = new Size(161, 90);
            lab_Name.TabIndex = 1;
            lab_Name.Text = "Trang chủ";
            lab_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pic_facilities
            // 
            pic_facilities.BackgroundImageLayout = ImageLayout.None;
            pic_facilities.Image = Properties.Resources.Home;
            pic_facilities.ImageLocation = "";
            pic_facilities.InitialImage = Properties.Resources.staff;
            pic_facilities.Location = new Point(29, 3);
            pic_facilities.Name = "pic_facilities";
            pic_facilities.Size = new Size(97, 89);
            pic_facilities.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_facilities.TabIndex = 0;
            pic_facilities.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(pic_facilities);
            panel1.Controls.Add(lab_Name);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 95);
            panel1.TabIndex = 3;
            // 
            // ButtonFacilities_mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "ButtonFacilities_mainForm";
            Size = new Size(329, 100);
            ((System.ComponentModel.ISupportInitialize)pic_facilities).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_Name;
        private PictureBox pic_facilities;
        private Panel panel1;
    }
}
