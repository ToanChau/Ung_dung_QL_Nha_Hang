using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form.work
{
    public class PanelWork
    {
        private Form currentChildForm = null;

        public Form CurrentChildForm { get => currentChildForm; set => currentChildForm = value; }

        public void OpenChildForm(Form childForm, Panel panelContent)
        {

            if (CurrentChildForm != null && CurrentChildForm.GetType() == childForm.GetType())
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                panelContent.Controls.Clear();
                childForm.Dock = DockStyle.Fill;
                panelContent.Controls.Add(childForm);
                panelContent.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                return;
            }

            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }

            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Clear();
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            return;
        }

        public void ShowFormInPanel(Form formToShow, Panel panelContainer)
        {
            // Đặt Form thành không có viền để khi nhúng vào Panel không hiển thị thanh tiêu đề
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;

            // Đặt Form vừa với Panel
            formToShow.Dock = DockStyle.Fill;

            // Thêm Form vào Panel
            panelContainer.Controls.Clear();  // Xóa các điều khiển trước đó trong Panel
            panelContainer.Controls.Add(formToShow);

            // Hiển thị Form
            formToShow.Show();
        }
    }
}
