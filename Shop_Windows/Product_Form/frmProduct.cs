using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advertise.Notification_Form;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Product_Form
{
    public partial class frmProduct : Form
    {
        private ProductBussines cls;
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
        private async Task LoadPrdGroups()
        {
            try
            {
                prdGroupsBindingSource.DataSource = cls?.GroupList.ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task LoadFeatures()
        {
            try
            {
                var list = await FeatureBussines.GetAllAsync();
                FeaturesBindingSource.DataSource = list.OrderBy(q => q.Title).ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task LoadPrdFeatures()
        {
            try
            {
                txtValue.Text = "";
                prdFeaturesBindingSource.DataSource = cls?.FeatureList.ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task LoadPrdImages()
        {
            try
            {
                txtImageTitle.Text = "";
                prdImagesBindingSource.DataSource = cls?.ImageList.ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task LoadPrdTags()
        {
            try
            {
                txtTag.Text = "";
                prdTagsBindingSource.DataSource = cls?.TagsList.ToList();
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
                await LoadData();
                txtName.Text = cls?.Name;
                txtCode.Text = cls?.Code;
                txtShortDesc.Text = cls?.ShortDesc;
                txtDesc.Text = cls?.Description;
                txtPrice.Text = cls?.Price.ToString();
                if (cls != null && !string.IsNullOrEmpty(cls.ImageName))
                    picImage.Image =
                        Image.FromFile(Application.StartupPath + "\\Images\\ProductImages\\" + cls?.ImageName);

                if (cls?.Guid == Guid.Empty)
                    await NextCode();

                txtName.Focus();
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

        private string LoadFromFile()
        {
            try
            {
                var fd = new OpenFileDialog
                {
                    Multiselect = false,
                    InitialDirectory = Application.StartupPath + "\\Images\\ProductImages"
                };
                var thumb = Application.StartupPath + "\\Images\\ProductImages\\Thumb";
                if (!Directory.Exists(thumb))
                    Directory.CreateDirectory(thumb);
                if (!Directory.Exists(fd.InitialDirectory))
                    Directory.CreateDirectory(fd.InitialDirectory);
                fd.Filter = @"*.JPG;*.GIF;*.PNG|*.JPG;*.GIF;*.PNG";
                if (fd.ShowDialog() != DialogResult.OK) return null;
                var ss = Guid.NewGuid() + Path.GetExtension(fd.FileName);
                File.Copy(fd.FileName, Application.StartupPath + "\\Images\\ProductImages\\" + ss);
                var img = new ImageResizer();
                img.Resize(fd.FileName,
                    Application.StartupPath + "\\Images\\ProductImages\\Thumb\\" + ss);
                //File.Copy(fd.FileName, Application.StartupPath + "\\Images\\ProductImages\\Thumb\\" + ss);

                return ss;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        private async Task LoadData()
        {
            try
            {
                await LoadGroup();
                await LoadPrdGroups();
                await LoadFeatures();
                await LoadPrdFeatures();
                await LoadPrdImages();
                await LoadPrdTags();
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
            tabControl1.SelectedTab = tabBase;
        }
        public frmProduct(Guid guid, bool isShowMode)
        {
            InitializeComponent();
            cls = ProductBussines.Get(guid);
            grpAccount.Enabled = !isShowMode;
            btnFinish.Enabled = !isShowMode;
            groupPanel1.Enabled = !isShowMode;
            groupPanel3.Enabled = !isShowMode;
            groupPanel4.Enabled = !isShowMode;
            groupPanel5.Enabled = !isShowMode;
            tabControl1.SelectedTab = tabBase;
        }
        private async void frmProduct_Load(object sender, EventArgs e)
        {
            await SetData();
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

                    cls.Code = txtCode.Text.Trim();
                    cls.Name = txtName.Text.Trim();
                    cls.Description = txtDesc.Text;
                    cls.Price = txtPrice.Text.ParseToDecimal();
                    cls.ShortDesc = txtShortDesc.Text;
                    if (string.IsNullOrEmpty(cls.ImageName)) cls.ImageName = "No.png";
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

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtCode);
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtPrice);
        }

        private void txtDesc_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtDesc);
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtName);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtName);
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtCode);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtPrice);
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtDesc);
        }

        private async void btnAddToGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGroup.SelectedValue == null) return;
                var groupGuid = (Guid)cmbGroup.SelectedValue;
                foreach (var item in cls.GroupList)
                    if (groupGuid == item.GroupGuid) return;
                cls.GroupList.Add(new PrdSelectedGroupBussines()
                {
                    Guid = Guid.NewGuid(),
                    Modified = DateTime.Now,
                    GroupGuid = groupGuid
                });
                await LoadPrdGroups();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void btnDeleteFromGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var groupGuid = (Guid)DGrid[dgGroupGuid.Index, DGrid.CurrentRow.Index].Value;
                var index = cls.GroupList.FindIndex(q => q.Guid == groupGuid);
                cls.GroupList.RemoveAt(index);
                await LoadPrdGroups();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["GroupRadif"].Value = e.RowIndex + 1;
        }

        private void txtValue_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtValue);
        }

        private void txtValue_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtValue);
        }

        private async void btnInsertToFeatures_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFeatures.SelectedValue == null) return;
                if (string.IsNullOrEmpty(txtValue.Text)) return;
                var featureGuid = (Guid)cmbFeatures.SelectedValue;
                cls.FeatureList.Add(new PrdFeatureBussines()
                {
                    Guid = Guid.NewGuid(),
                    Modified = DateTime.Now,
                    FeatureGuid = featureGuid,
                    Value = txtValue.Text
                });
                await LoadPrdFeatures();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void btnDeleteFromFeatures_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgridFeatures.RowCount <= 0) return;
                if (DgridFeatures.CurrentRow == null) return;
                var featureGuid = (Guid)DgridFeatures[dgFeatureGuid.Index, DgridFeatures.CurrentRow.Index].Value;
                var index = cls.FeatureList.FindIndex(q => q.Guid == featureGuid);
                cls.FeatureList.RemoveAt(index);
                await LoadPrdFeatures();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void DgridFeatures_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DgridFeatures.Rows[e.RowIndex].Cells["FeatureRadif"].Value = e.RowIndex + 1;
        }

        private void btnInsPic_Click(object sender, EventArgs e)
        {
            try
            {
                cls.ImageName = LoadFromFile();
                picImage.Image = Image.FromFile(Application.StartupPath + "\\Images\\ProductImages\\" + cls.ImageName);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void txtImageTitle_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtImageTitle);
        }

        private void txtImageTitle_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtImageTitle);
        }

        private async void btnInsImage_Click(object sender, EventArgs e)
        {
            try
            {
                var img = LoadFromFile();
                if (string.IsNullOrEmpty(img)) return;
                if (string.IsNullOrEmpty(txtImageTitle.Text)) return;
                cls.ImageList.Add(new ProductPicturesBussines()
                {
                    Guid = Guid.NewGuid(),
                    Modified = DateTime.Now,
                    ImageName = img,
                    Title = txtImageTitle.Text
                });
                await LoadPrdImages();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void btnDeleteImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGridImages.RowCount <= 0) return;
                if (DGridImages.CurrentRow == null) return;
                var imageGuid = (Guid)DGridImages[dgImageGuid.Index, DGridImages.CurrentRow.Index].Value;
                var index = cls.ImageList.FindIndex(q => q.Guid == imageGuid);
                cls.ImageList.RemoveAt(index);
                await LoadPrdImages();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void DGridImages_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGridImages.Rows[e.RowIndex].Cells["ImageRadif"].Value = e.RowIndex + 1;
        }

        private void txtShortDesc_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtShortDesc);
        }

        private void txtShortDesc_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtShortDesc);
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtTag_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtTag);
        }

        private void txtTag_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtTag);
        }

        private async void btnInsTag_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTag.Text)) return;
                foreach (var item in cls.TagsList)
                    if (txtTag.Text.Trim() == item.Tag) return;
                cls.TagsList.Add(new PrdTagBussines()
                {
                    Guid = Guid.NewGuid(),
                    Modified = DateTime.Now,
                    Tag = txtTag.Text
                });
                await LoadPrdTags();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void btnDelTag_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGridTags.RowCount <= 0) return;
                if (DGridTags.CurrentRow == null) return;
                var tagGuid = (Guid)DGridTags[dgTagGuid.Index, DGridTags.CurrentRow.Index].Value;
                var index = cls.TagsList.FindIndex(q => q.Guid == tagGuid);
                cls.TagsList.RemoveAt(index);
                await LoadPrdTags();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void DGridTags_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGridTags.Rows[e.RowIndex].Cells["TagRadif"].Value = e.RowIndex + 1;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtSetter.Three_Ziro(txtPrice);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
