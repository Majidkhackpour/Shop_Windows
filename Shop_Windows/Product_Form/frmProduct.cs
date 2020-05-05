using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCache.Bussines;
using PacketParser.Services;
using Shop_Windows.Classes;
using Shop_Windows.Notification_Form;

namespace Shop_Windows.Product_Form
{
    public partial class frmProduct : Form
    {
        private ProductBussines cls;
        List<string> ImageAddressList = new List<string>();
        private string _pictureNameForClick = null;
        private PictureBox _orGpicBox;
        private PictureBox _fakepicBox;
        private string _picNameJari = "";
        private List<ProductPicturesBussines> _listIlages = new List<ProductPicturesBussines>();
        private async Task LoadGroup()
        {
            try
            {
                var list = await ProductGroupBussines.GetAllAsync();
                GroupBindingSource.DataSource = list.OrderBy(q => q.Name).ToList();
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
                await LoadGroup();
                txtName.Text = cls?.Name;
                cmbGroup.SelectedValue = cls?.GroupGuid;
                txtAbad.Text = cls?.Abad;
                txtPrice.Text = cls?.Price.ToString();
                txtKind.Text = cls?.Kind;
                txtColor.Text = cls?.Color;
                txtCode.Text = cls?.HalfCode;
                ImageAddressList = cls?.ImageList.Select(q => q.Path).ToList();
                if (cls != null && cls.GroupGuid != Guid.Empty)
                {
                    var group = await ProductGroupBussines.GetAsync(cls.GroupGuid);
                    lblCode.Text = group.Code;
                }

                if (cls?.Guid == Guid.Empty)
                    await NextCode();
                if (cls?.GroupGuid == Guid.Empty && GroupBindingSource.Count > 0)
                    cmbGroup.SelectedIndex = 0;

                ImageAddressList.Clear();
                if (cls?.ImageList != null && cls?.ImageList.Count != 0)
                    foreach (var image in cls?.ImageList)
                        ImageAddressList.Add(image.Path);
                txtName.Focus();
                Make_Picture_Boxes(ImageAddressList);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async Task NextCode()
        {
            try
            {
                var prd = await ProductBussines.NextCode();
                txtCode.Text = prd;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmProduct()
        {
            InitializeComponent();
            cls = new ProductBussines();
        }
        public frmProduct(Guid guid, bool isShowMode)
        {
            InitializeComponent();
            cls = ProductBussines.Get(guid);
            grpAccount.Enabled = !isShowMode;
            btnFinish.Enabled = !isShowMode;
        }
        private void Make_Picture_Boxes(List<string> lst)
        {
            try
            {
                if (lst == null || lst.Count == 0)
                    return;
                fPanel.AutoScroll = true;
                for (var i = fPanel.Controls.Count - 1; i >= 0; i--)
                    fPanel.Controls[i].Dispose();
                for (var i = 0; i < lst.Count; i++)
                {
                    var picbox = new PictureBox();
                    this.Controls.Add(picbox);
                    picbox.Size = new Size(62, 63);
                    picbox.Load(lst[i]);
                    picbox.Name = "pic" + i;
                    picbox.Cursor = Cursors.Hand;
                    picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picbox.Click += picbox_Click;
                    fPanel.Controls.Add(picbox);
                }
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }
        private void picbox_Click(object sender, EventArgs e)
        {
            try
            {
                var imageLocation = ((PictureBox)sender).ImageLocation;
                _picNameJari = ((PictureBox)sender).Name;
                if (_picNameJari == _pictureNameForClick)
                {
                    ((PictureBox)sender).BackColor = Color.Transparent;
                    ((PictureBox)sender).Padding = new Padding(-1);
                    _pictureNameForClick = null;
                    ImageAddressList.Add(imageLocation);
                    _orGpicBox = null;
                    return;
                }

                ((PictureBox)sender).BackColor = Color.Red;
                ((PictureBox)sender).Padding = new Padding(1);
                _pictureNameForClick = ((PictureBox)sender).Name;
                ImageAddressList.Remove(imageLocation);
                _orGpicBox = (PictureBox)sender;
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2:txtName);
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtCode);
        }

        private void txtAbad_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtAbad);
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtPrice);
        }

        private void txtKind_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtKind);
        }

        private void txtColor_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtColor);
        }

        private void txtDesc_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txt2: txtDesc);
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtDesc);
        }

        private void txtColor_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtColor);
        }

        private void txtKind_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtKind);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtPrice);
        }

        private void txtAbad_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtAbad);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtName);
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txt2: txtCode);
        }

        private async void frmProduct_Load(object sender, EventArgs e)
        {
            await SetData();
        }

        private async void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroup.SelectedValue == null) return;
                var group = await ProductGroupBussines.GetAsync((Guid)cmbGroup.SelectedValue);
                lblCode.Text = group.Code;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void btnInsImage_Click(object sender, EventArgs e)
        {
            try
            {
                var t = new Thread(() =>
                {
                    var ofd = new OpenFileDialog { Multiselect = true, RestoreDirectory = true };
                    if (ofd.ShowDialog() != DialogResult.OK) return;
                    foreach (var name in ofd.FileNames)
                        ImageAddressList.Add(name);
                });

                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
                Make_Picture_Boxes(ImageAddressList);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            try
            {
                Make_Picture_Boxes(ImageAddressList);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmProduct_KeyDown(object sender, KeyEventArgs e)
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
                    case Keys.F8:
                        if (_orGpicBox != null)
                        {
                            ShowBigSizePic(_orGpicBox);
                            _fakepicBox = _orGpicBox;
                            _orGpicBox = null;
                        }
                        else
                        {
                            ShowNormalSizePic(_fakepicBox);
                            _orGpicBox = _fakepicBox;
                        }

                        break;
                }
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }
        private static void ShowBigSizePic(PictureBox pic)
        {
            try
            {
                pic.Size = new Size(190, 212);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private static void ShowNormalSizePic(PictureBox pic)
        {
            try
            {
                pic.Size = new Size(62, 63);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (cls.Guid == Guid.Empty)
                        cls.Guid = Guid.NewGuid();

                    if (string.IsNullOrEmpty(txtName.Text))
                    {
                        frmNotification.PublicInfo.ShowMessage("عنوان کالا نمی تواند خالی باشد");
                        txtName.Focus();
                        return;
                    }

                    if (string.IsNullOrEmpty(txtCode.Text))
                    {
                        frmNotification.PublicInfo.ShowMessage("کد کالا نمی تواند خالی باشد");
                        txtCode.Focus();
                        return;
                    }

                    if (!await ProductBussines.CheckName(cls.Guid, txtName.Text.Trim()))
                    {
                        frmNotification.PublicInfo.ShowMessage("عنوان وارد شده تکراری است");
                        txtName.Focus();
                        return;
                    }

                    cls.Name = txtName.Text.Trim();
                    cls.Description = txtDesc.Text;
                    cls.GroupGuid = (Guid)cmbGroup.SelectedValue;
                    cls.Code = lblCode.Text + txtCode.Text;
                    cls.Abad = txtAbad.Text;
                    cls.Color = txtColor.Text;
                    cls.HalfCode = txtCode.Text;
                    cls.Kind = txtKind.Text;
                    cls.Price = txtPrice.Text.ParseToDecimal();
                    foreach (var item in ImageAddressList)
                    {
                        var img = new ProductPicturesBussines()
                        {
                            Guid = Guid.NewGuid(),
                            Path = item,
                            Modified = DateTime.Now,
                            PrdGuid = cls.Guid
                        };
                        _listIlages.Add(img);
                    }

                    cls.ImageList = _listIlages;

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
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
