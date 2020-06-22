using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Settings_Form
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private async Task SetData()
        {
            try
            {
                txtEmail.Text = SettingsBussines.Email;
                txtHeaderText.Text = SettingsBussines.FirstBlockText;
                txtPassword.Text = SettingsBussines.EmailPassword;
                txtSiteTell.Text = SettingsBussines.TellForSite;
                txtSiteDomain.Text = SettingsBussines.SiteDomain;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void txtEmail_Enter(object sender, System.EventArgs e)
        {
            txtSetter.Focus(txtEmail);
        }

        private void txtPassword_Enter(object sender, System.EventArgs e)
        {
            txtSetter.Focus(txtPassword);
        }

        private void txtHeaderText_Enter(object sender, System.EventArgs e)
        {
            txtSetter.Focus(txtHeaderText);
        }

        private void txtSiteTell_Enter(object sender, System.EventArgs e)
        {
            txtSetter.Focus(txtSiteTell);
        }

        private void txtSiteDomain_Enter(object sender, System.EventArgs e)
        {
            txtSetter.Focus(txtSiteDomain);
        }

        private void txtSiteDomain_Leave(object sender, System.EventArgs e)
        {
            txtSetter.Follow(txtSiteDomain);
        }

        private void txtSiteTell_Leave(object sender, System.EventArgs e)
        {
            txtSetter.Follow(txtSiteTell);
        }

        private void txtHeaderText_Leave(object sender, System.EventArgs e)
        {
            txtSetter.Follow(txtHeaderText);
        }

        private void txtPassword_Leave(object sender, System.EventArgs e)
        {
            txtSetter.Follow(txtPassword);
        }

        private void txtEmail_Leave(object sender, System.EventArgs e)
        {
            txtSetter.Follow(txtEmail);
        }

        private async  void frmSettings_Load(object sender, EventArgs e)
        {
            await SetData();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsBussines.Email = txtEmail.Text;
                SettingsBussines.FirstBlockText = txtHeaderText.Text;
                SettingsBussines.EmailPassword = txtPassword.Text;
                SettingsBussines.TellForSite = txtSiteTell.Text;
                SettingsBussines.SiteDomain = txtSiteDomain.Text;

                MessageBox.Show("تنظیمات برنامه با موفقیت ذخیره شد");
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (!btnFinish.Focused)
                            SendKeys.Send("{Tab}");
                        break;
                    case Keys.F5:
                        btnFinish.PerformClick();
                        break;
                }
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }
    }
}
