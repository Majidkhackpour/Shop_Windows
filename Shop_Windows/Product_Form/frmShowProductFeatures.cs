using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advertise.Notification_Form;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Product_Form
{
    public partial class frmShowProductFeatures : Form
    {
        private async Task LoadData(string search = "")
        {
            try
            {
                var liat = await FeatureBussines.GetAllAsync(search);
                ProductBindingSource.DataSource = liat.OrderBy(q => q.Title).ToSortableBindingList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmShowProductFeatures()
        {
            InitializeComponent();
            cmProduct.Renderer = new ToolStripProfessionalRenderer(new ContextMenuSetter());
        }

        private async void frmShowProductFeatures_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["Radif"].Value = e.RowIndex + 1;
        }

        private async void mnuInsAdv_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmProductFeatures();
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadData();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmProductFeatures(guid, false);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                if (MessageBox.Show($@"آیا از حذف {DGrid[dgName.Index, DGrid.CurrentRow.Index].Value} اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No) return;
                var prd = await FeatureBussines.GetAsync(guid);
                var res = await prd.RemoveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }
                frmLoading.PublicInfo.ShowForm();
                await LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuView_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmProductFeatures(guid, true);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
