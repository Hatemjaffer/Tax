using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Grad_Tax.Pages;

namespace Grad_Tax
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoadPage(XtraUserControl Page)
        {
            try
            {
                fluentDesignFormContainer1.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(Page);
            }
            catch
            {
            }
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            var pages = new Page_Model();
            lb_state1.Caption = accordionControlElement7.Text;
            LoadPage(pages);
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            var pages = new Page_Mangment();
            lb_state1.Caption = accordionControlElement8.Text;
            LoadPage(pages);
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            var pages = new Page_department();
            lb_state1.Caption = accordionControlElement9.Text;
            LoadPage(pages);
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            var pages = new Page_Osol_Main();
            lb_state1.Caption = accordionControlElement10.Text;
            LoadPage(pages);
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            var pages = new Page_Osol_sup();
            lb_state1.Caption = accordionControlElement11.Text;
            LoadPage(pages);
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            var pages = new Page_Emp();
            lb_state1.Caption = accordionControlElement12.Text;
            LoadPage(pages);
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            var pages = new Page_Users();
            lb_state1.Caption = accordionControlElement13.Text;
            LoadPage(pages);
        }
    }
}
