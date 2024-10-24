namespace main_form.FormApp.Home
{
    partial class FormEmpty
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 254);
            label1.Name = "label1";
            label1.Size = new Size(720, 184);
            label1.TabIndex = 0;
            label1.Text = "Chào mừng đến với nhà hàng Hôm nay bạn muốn ăn gì?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEmpty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(label1);
            Name = "FormEmpty";
            Size = new Size(1531, 1001);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}
