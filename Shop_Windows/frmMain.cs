using System;
using System.Windows.Forms;
using Advertise.DivarRobot_Form;
using EntityCache.Bussines;
using PacketParser.Services;
using Shop_Windows.Classes;
using Shop_Windows.Customer_Form;
using Shop_Windows.Product_Form;
using Shop_Windows.Settings_Form;
using Shop_Windows.Slider_Form;

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

        private async void lblDivarCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var all = await DivarCategoryBussines.GetAllAsync();
                if (all.Count > 0)
                {
                    if (MessageBox.Show($@"تعداد {all.Count} دسته بندی موجود است. 
                                            درصورت ادامه، دسته بندی فعلی حذف و دسته بندی جدید جایگزین می شود 
                                            آیا ادامه میدهید؟", @"هشدار", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                var div = await DivarAdv.GetInstance();
                await div.GetCategory();
                Utility.CloseAllChromeWindows();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void lblSimcard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadNewForm(new frmShowSimcard());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void lblProductFeatures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadNewForm(new frmShowProductFeatures());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void lblSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadNewForm(new frmSettings());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void lblSlider_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadNewForm(new frmShowSlider());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
