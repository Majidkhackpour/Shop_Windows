using System;
using System.Windows.Forms;
using PacketParser.Services;
using Shop_Windows.Customer_Form;

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
            if (MessageBox.Show("آیا مایلبد از برنامه خارج شوید؟", "خروج", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var t1 = new ToolTip();
            t1.SetToolTip(picExit, "خروج");
            t1.SetToolTip(picCustGroup, "گروه مشتریان");
        }

        private void lblCustGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadNewForm(new frmShowCustomerGroups());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
