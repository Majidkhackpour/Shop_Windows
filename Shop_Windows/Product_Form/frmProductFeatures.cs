using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advertise.Notification_Form;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Product_Form
{
    public partial class frmProductFeatures : Form
    {
        private FeatureBussines cls;
        public frmProductFeatures()
        {
            InitializeComponent();
            cls = new FeatureBussines();
        }
        public frmProductFeatures(Guid guid, bool isShowMode)
        {
            InitializeComponent();
            cls = FeatureBussines.Get(guid);
            grpAccount.Enabled = !isShowMode;
            btnFinish.Enabled = !isShowMode;
        }
        private async Task SetData()
        {
            try
            {
                txtName.Text = cls?.Title;
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }

        private async void frmProductFeatures_Load(object sender, EventArgs e)
        {
            await SetData();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtName);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls.Guid == Guid.Empty)
                    cls.Guid = Guid.NewGuid();

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("عنوان ویژگی نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }
               

                cls.Title = txtName.Text.Trim();
               
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

        private void frmProductFeatures_KeyDown(object sender, KeyEventArgs e)
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
    }
}
