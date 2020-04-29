using System;
using System.Windows.Forms;
using PacketParser.Services;
using Shop_Windows.Customer_Form;
using Shop_Windows.Product_Form;

namespace Shop_Windows
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void LoadNewForm(Form frm)
        {
            try
            {
                frm.TopLevel = false;
                frm.AutoScroll = true;
                frm.Dock = DockStyle.Fill;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(frm);
                pnlContent.AutoScroll = true;
                frm.Show();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"آیا مایلید از برنامه خارج شوید؟", @"خروج", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var t1 = new ToolTip();
            t1.SetToolTip(picExit, "خروج");
            t1.SetToolTip(picCustGroup, "گروه مشتریان");
            t1.SetToolTip(picProduct, "گروه کالاها");
        }

        private void lblCustGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadNewForm(new frmShowCustomers());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void picCustGroup_Click(object sender, EventArgs e)
        {
            lblCustGroup_LinkClicked(null, null);
        }

        private void lblProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadNewForm(new frmShowProducts());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            lblProduct_LinkClicked(null, null);
        }
    }
}
