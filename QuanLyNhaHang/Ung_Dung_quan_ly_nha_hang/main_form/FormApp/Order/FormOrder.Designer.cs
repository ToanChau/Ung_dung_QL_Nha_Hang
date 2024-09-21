namespace main_form
{
    using main_form.Draw;
    partial class FormOrder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SplPCon_Order = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)SplPCon_Order).BeginInit();
            SplPCon_Order.SuspendLayout();
            SuspendLayout();
            // 
            // SplPCon_Order
            // 
            SplPCon_Order.Dock = DockStyle.Fill;
            SplPCon_Order.IsSplitterFixed = true;
            SplPCon_Order.Location = new Point(0, 0);
            SplPCon_Order.Name = "SplPCon_Order";
            // 
            // SplPCon_Order.Panel1
            // 
            SplPCon_Order.Panel1.ImeMode = ImeMode.NoControl;
            SplPCon_Order.Size = new Size(1924, 1055);
            SplPCon_Order.SplitterDistance = 782;
            SplPCon_Order.TabIndex = 0;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1924, 1055);
            Controls.Add(SplPCon_Order);
            Name = "FormOrder";
            Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)SplPCon_Order).EndInit();
            SplPCon_Order.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        DrawPanel dpanel = new DrawPanel();
        private SplitContainer SplPCon_Order;
    }
}