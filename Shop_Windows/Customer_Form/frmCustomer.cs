using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCache.Bussines;
using PacketParser;
using PacketParser.Services;
using Shop_Windows.Classes;
using Shop_Windows.Notification_Form;

namespace Shop_Windows.Customer_Form
{
    public partial class frmCustomer : Form
    {
        private CustomerBussines cls;

        private void LoadCombo()
        {
            try
            {
                cmbNahveAshnaei.Items.Clear();
                cmbNahveAshnaei.Items.Add(EnNahveAshnaei.Google.GetDisplay());
                cmbNahveAshnaei.Items.Add(EnNahveAshnaei.SMS.GetDisplay());
                cmbNahveAshnaei.Items.Add(EnNahveAshnaei.OtherSite.GetDisplay());
                cmbNahveAshnaei.Items.Add(EnNahveAshnaei.Tracket.GetDisplay());
                cmbNahveAshnaei.Items.Add(EnNahveAshnaei.Introduction.GetDisplay());
                cmbNahveAshnaei.Items.Add(EnNahveAshnaei.Telegram.GetDisplay());
                cmbNahveAshnaei.Items.Add(EnNahveAshnaei.Instagram.GetDisplay());
                cmbNahveAshnaei.Items.Add(EnNahveAshnaei.Other.GetDisplay());
                cmbNahveAshnaei.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task SetData()
        {
            try
            {
                LoadCombo();
                await LoadGroup();
                txtName.Text = cls?.Name;
                txtDesc.Text = cls?.Description;
                txtAddress.Text = cls?.Address;
                txtNationalCode.Text = cls?.NationalCode;
                txtPostalCode.Text = cls?.PostalCode;
                txtTell1.Text = cls?.Phone1;
                txtTell2.Text = cls?.Phone2;
                if (cls?.NahveAshnaei != null && (short)cls?.NahveAshnaei != 0)
                    cmbNahveAshnaei.SelectedValue = (int)cls?.NahveAshnaei;
                cmbGroup.SelectedValue = cls?.GroupGuid;
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }

        private async Task LoadGroup()
        {
            try
            {
                var list = await CustomerGroupBussines.GetAllAsync();
                CusGroupBindingSource.DataSource = list.OrderBy(q => q.Name).ToList();
                if (list.Count > 0) cmbGroup.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmCustomer()
        {
            InitializeComponent();
            cls = new CustomerBussines();
        }

        public frmCustomer(Guid guid, bool isShowMode)
        {
            InitializeComponent();
            cls = CustomerBussines.Get(guid);
            grpAccount.Enabled = !isShowMode;
            btnFinish.Enabled = !isShowMode;
        }

        private async void frmCustomer_Load(object sender, EventArgs e)
        {
            await SetData();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtName);
        }

        private void txtNationalCode_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtNationalCode);
        }

        private void txtTell1_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtTell1);
        }

        private void txtTell2_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtTell2);
        }

        private void txtDesc_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtDesc);
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtAddress);
        }

        private void txtPostalCode_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtPostalCode);
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtPostalCode);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtAddress);
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtDesc);
        }

        private void txtTell1_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtTell1);
        }

        private void txtTell2_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtTell2);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtName);
        }

        private void txtNationalCode_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtNationalCode);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
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
                if (!await CustomerBussines.CheckName(cls.Guid, txtName.Text.Trim()))
                {
                    frmNotification.PublicInfo.ShowMessage("عنوان وارد شده تکراری است");
                    txtName.Focus();
                    return;
                }
                if (cmbGroup.SelectedValue == null)
                {
                    frmNotification.PublicInfo.ShowMessage("گروه نمی تواند خالی باشد");
                    cmbGroup.Focus();
                    return;
                }

                cls.Name = txtName.Text.Trim();
                cls.Description = txtDesc.Text;
                cls.GroupGuid = (Guid)cmbGroup.SelectedValue;
                cls.Address = txtAddress.Text;
                cls.NahveAshnaei = (EnNahveAshnaei)(cmbNahveAshnaei.SelectedIndex + 1);
                cls.NationalCode = txtPostalCode.Text;
                cls.NationalCode = txtNationalCode.Text;
                cls.Phone1 = txtTell1.Text;
                cls.Phone2 = txtTell2.Text;
                await cls.SaveAsync();
                DialogResult = DialogResult.OK;
                frmLoading.PublicInfo.ShowForm();
                Close();
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }
    }
}
