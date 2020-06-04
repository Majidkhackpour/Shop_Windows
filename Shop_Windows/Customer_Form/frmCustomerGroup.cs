using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advertise.Notification_Form;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Customer_Form
{
    public partial class frmCustomerGroup : Form
    {
        private CustomerGroupBussines cls;
        public frmCustomerGroup()
        {
            InitializeComponent();
            cls = new CustomerGroupBussines();
        }
        private async Task LoadData()
        {
            try
            {
                var a = new CustomerGroupBussines()
                {
                    Guid = Guid.Empty,
                    Name = "[هیچکدام]",
                    ParentGuid = Guid.Empty,
                    Description = ""
                };
                var list = await CustomerGroupBussines.GetAllAsync();
                list = list.Where(q => q.ParentGuid == Guid.Empty).ToList();
                list.Add(a);
                ParentBindingSource.DataSource = list.OrderBy(q => q.Name).ToList();
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }
        private async Task SetData()
        {
            try
            {
                await LoadData();
                txtName.Text = cls?.Name;
                txtDesc.Text = cls?.Description;
                if (cls?.Guid != Guid.Empty)
                    cmbParent.SelectedValue = cls?.ParentGuid ?? Guid.Empty;
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }
        public frmCustomerGroup(Guid guid, bool isShowMode)
        {
            InitializeComponent();
            cls = CustomerGroupBussines.Get(guid);
            grpAccount.Enabled = !isShowMode;
            btnFinish.Enabled = !isShowMode;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus( txtName);
        }

        private void txtDesc_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus( txtDesc);
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow( txtDesc);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow( txtName);
        }

        private async void frmCustomerGroup_Load(object sender, EventArgs e)
        {
            await SetData();
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
                    frmNotification.PublicInfo.ShowMessage("عنوان گروه نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }
                if (!await CustomerGroupBussines.CheckName(cls.Guid, txtName.Text.Trim()))
                {
                    frmNotification.PublicInfo.ShowMessage("عنوان وارد شده تکراری است");
                    txtName.Focus();
                    return;
                }

                cls.Name = txtName.Text.Trim();
                cls.Description = txtDesc.Text;
                cls.ParentGuid = (Guid)cmbParent.SelectedValue;
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

        private void frmCustomerGroup_KeyDown(object sender, KeyEventArgs e)
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
