using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advertise.Notification_Form;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Product_Form
{
    public partial class frmShowProducts : Form
    {
        private async Task LoadGroups()
        {
            try
            {
                var list = await ProductGroupBussines.GetAllAsync();
                list = list.OrderBy(q => q.Name).ToList();
                PrdGroupBindingSource.DataSource = list;
                trvGroup.Nodes.Clear();
                var lst = await ProductGroupBussines.GetAllAsync();
                lst = lst.Where(q => q.ParentGuid == Guid.Empty).OrderBy(q => q.Name).ToList();
                var node = new TreeNode { Text = "همه گروه ها", Name = Guid.Empty.ToString() };
                trvGroup.Nodes.Add(node);
                foreach (var item in lst)
                {
                    node = new TreeNode { Text = item.Name, Name = item.Guid.ToString() };
                    trvGroup.Nodes.Add(node);
                }
                lst = await ProductGroupBussines.GetAllAsync();
                lst = lst.Where(q => q.ParentGuid != Guid.Empty).OrderBy(q => q.Name).ToList();
                foreach (var item in lst)
                {
                    foreach (TreeNode n in trvGroup.Nodes)
                    {
                        if (item.ParentGuid.ToString() != n.Name) continue;
                        node = new TreeNode { Text = item.Name, Name = item.Guid.ToString() };
                        n.Nodes.Add(node);
                    }
                }
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }
        private async Task LoadProducts(string search = null)
        {
            try
            {
                var liat = await ProductBussines.GetAllAsync(search);
                ProductBindingSource.DataSource = liat.OrderBy(q => q.Name).ToSortableBindingList();
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }

        private Guid _groupGuid = Guid.Empty;
        public Guid GroupGuid { get => _groupGuid; set => _groupGuid = value; }

        private async Task LoadData()
        {
            try
            {
                await LoadGroups();
                await LoadProducts();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmShowProducts()
        {
            InitializeComponent();
            cmPrdGroup.Renderer = new ToolStripProfessionalRenderer(new ContextMenuSetter());
            cmProduct.Renderer = new ToolStripProfessionalRenderer(new ContextMenuSetter());
        }

        private async void frmShowProducts_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void mnuAddCustGroup_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmProductGroup();
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadGroups();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuEditCustGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (trvGroup.SelectedNode == null) return;
                if (trvGroup.SelectedNode.Text == "همه گروه ها") return;
                var frm = new frmProductGroup(GroupGuid, false);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadGroups();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void trvGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var node = trvGroup.SelectedNode;
                if (node.Text == "همه گروه ها") return;
                var group = await ProductGroupBussines.GetAsync(Guid.Parse(node.Name));
                if (group != null)
                    GroupGuid = group.Guid;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuDeleteCustGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (trvGroup.SelectedNode == null) return;
                if (trvGroup.SelectedNode.Text == "همه گروه ها") return;
                var counter = await ProductGroupBussines.ChildCount(GroupGuid);
                if (await ProductGroupBussines.ChildCount(GroupGuid) > 0)
                {
                    frmNotification.PublicInfo.ShowMessage(
                        $"گروه {trvGroup.SelectedNode.Text} بدلیل داشتن {counter} زیرگروه فعال، قادر به حذف نیست");
                    return;
                }

                var childes = await ProductBussines.GetAllByGroupAsync(GroupGuid);
                if (childes != null && childes.Count > 0)
                {
                    frmNotification.PublicInfo.ShowMessage(
                        $"گروه {trvGroup.SelectedNode.Text} بدلیل داشتن {childes.Count} مشتری فعال، قادر به حذف نیست");
                    return;
                }
                if (MessageBox.Show($@"آیا از حذف گروه {trvGroup.SelectedNode.Text} اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No) return;
                var prdGroup = await ProductGroupBussines.GetAsync(GroupGuid);
                var res = await prdGroup.RemoveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }
                frmLoading.PublicInfo.ShowForm();
                await LoadGroups();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuViwCustGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (trvGroup.SelectedNode == null) return;
                if (trvGroup.SelectedNode.Text == "همه گروه ها") return;
                var frm = new frmProductGroup(GroupGuid, true);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadGroups();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuInsAdv_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmProduct();
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadProducts();
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
                var frm = new frmProduct(guid, false);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadProducts(txtSearch.Text);
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
                var prd = await ProductBussines.GetAsync(guid);
                var res = await prd.RemoveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }
                frmLoading.PublicInfo.ShowForm();
                await LoadProducts(txtSearch.Text);
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
                await LoadProducts(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["Radif"].Value = e.RowIndex + 1;
        }

        private async void mnuView_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmProduct(guid, true);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadProducts(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuComment_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmProductComment(guid);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
