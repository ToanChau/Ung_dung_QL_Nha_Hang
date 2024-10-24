﻿using System.Windows.Forms;
using main_form.Draw;
using main_form.FormApp.Menu;
using main_form.FormApp.UserController;
using main_form.work;

namespace main_form
{
    public partial class Form_Main : Form
    {
        PanelWork pw = new PanelWork();
        DrawPanel dpanel = new DrawPanel();

        public Form_Main()
        {
            InitializeComponent();
            setUpPanel();
        }

        private void setUpPanel()
        {
            UserControlWork uw = new UserControlWork();
            //vẽ radius
            pan_function.Paint += dpanel.DrawRight;

            pw.CurrentChildForm = new FormOrder();
            pw.OpenChildForm(pw.CurrentChildForm, pan_order);
        }

        private void Change_MouseHover(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.BackColor = Color.Aqua;
        }

        private void Change_MouseLeave(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.BackColor = Color.Transparent;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            pw.CurrentChildForm = new FormOrder();
            pw.OpenChildForm(pw.CurrentChildForm, pan_order);
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
                       
        }
    }
}
