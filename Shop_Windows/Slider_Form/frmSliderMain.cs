using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advertise.Notification_Form;
using EntityCache.Bussines;
using PacketParser;
using PacketParser.Services;

namespace Shop_Windows.Slider_Form
{
    public partial class frmSliderMain : Form
    {
        private SliderBussines cls;
        private async Task SetData()
        {
            try
            {
                txtName.Text = cls?.Title;
                txtURL.Text = cls?.URL;
                txtStartDate.Text = cls?.StartDateSh;
                txtEndDate.Text = cls?.EndDateSh;
                chbActive.Checked = cls?.IsActive ?? false;
                if (cls != null && !string.IsNullOrEmpty(cls.ImageName))
                    picImage.Image =
                        Image.FromFile(Application.StartupPath + "\\Images\\Slider\\" + cls?.ImageName);
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }
        private string LoadFromFile()
        {
            try
            {
                var fd = new OpenFileDialog
                {
                    Multiselect = false,
                    InitialDirectory = Application.StartupPath + "\\Images\\Slider"
                };
                if (!Directory.Exists(fd.InitialDirectory))
                    Directory.CreateDirectory(fd.InitialDirectory);
                fd.Filter = @"*.JPG;*.GIF;*.PNG|*.JPG;*.GIF;*.PNG";
                if (fd.ShowDialog() != DialogResult.OK) return null;
                var ss = Guid.NewGuid() + Path.GetExtension(fd.FileName);
                File.Copy(fd.FileName, Application.StartupPath + "\\Images\\Slider\\" + ss);
                
                return ss;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public frmSliderMain()
        {
            InitializeComponent();
            cls = new SliderBussines();
        }
        public frmSliderMain(Guid guid, bool isShowMode)
        {
            InitializeComponent();
            cls = SliderBussines.Get(guid);
            grpAccount.Enabled = !isShowMode;
            btnFinish.Enabled = !isShowMode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtName);
        }

        private void txtURL_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtURL);
        }

        private void txtStartDate_Enter(object sender, EventArgs e)
        {
            txtSetter.FocusMsk(txtStartDate);
        }

        private void txtEndDate_Enter(object sender, EventArgs e)
        {
            txtSetter.FocusMsk(txtEndDate);
        }

        private void txtEndDate_Leave(object sender, EventArgs e)
        {
            txtSetter.FollowMsk(txtEndDate);
        }

        private void txtStartDate_Leave(object sender, EventArgs e)
        {
            txtSetter.FollowMsk(txtStartDate);
        }

        private void txtURL_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtURL);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtName);
        }

        private async void frmSliderMain_Load(object sender, EventArgs e)
        {
            await SetData();
        }

        private void frmSliderMain_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (!btnFinish.Focused && !btnCancel.Focused)
                            SendKeys.Send("{Tab}");
                        break;
                    case Keys.F5:
                        btnFinish.PerformClick();
                        break;
                    case Keys.Escape:
                        btnCancel.PerformClick();
                        break;
                }
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls.Guid == Guid.Empty)
                    cls.Guid = Guid.NewGuid();

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("عنوان نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }
                

                cls.Title = txtName.Text.Trim();
                cls.URL = txtURL.Text;
                cls.StartDate = Calendar.ShamsiToMiladi(txtStartDate.Text);
                cls.EndDate = Calendar.ShamsiToMiladi(txtEndDate.Text);
                cls.IsActive = chbActive.Checked;

                var res = await cls.SaveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }
                DialogResult = DialogResult.OK;
                frmLoading.PublicInfo.ShowForm();
                Close();
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }

        private void btnInsPic_Click(object sender, EventArgs e)
        {
            try
            {
                cls.ImageName = LoadFromFile();
                picImage.Image = Image.FromFile(Application.StartupPath + "\\Images\\Slider\\" + cls.ImageName);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
