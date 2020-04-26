using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCache.Bussines;
using PacketParser.Services;
using Shop_Windows.Classes;

namespace Shop_Windows.Customer_Form
{
    public partial class frmShowCustomers : Form
    {
        private async Task LoadGroups()
        {
            try
            {
                var list = await CustomerGroupBussines.GetAllAsync();
                list = list.OrderBy(q => q.Name).ToList();
                CusGroupBindingSource.DataSource = list;
                trvGroup.Nodes.Clear();
                var lst = await CustomerGroupBussines.GetAllAsync();
                lst = lst.Where(q => q.ParentGuid == Guid.Empty).OrderBy(q => q.Name).ToList();
                var node = new TreeNode { Text = "همه گروه ها", Name = Guid.Empty.ToString() };
                trvGroup.Nodes.Add(node);
                foreach (var item in lst)
                {
                    node = new TreeNode { Text = item.Name, Name = item.Guid.ToString() };
                    trvGroup.Nodes.Add(node);
                }
                lst = await CustomerGroupBussines.GetAllAsync();
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

        private Guid _groupGuid = Guid.Empty;
        public Guid GroupGuid { get => _groupGuid; set => _groupGuid = value; }
        private async Task LoadData(string search = null)
        {
            try
            {
                await LoadGroups();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmShowCustomers()
        {
            InitializeComponent();
            cmCustGroup.Renderer = new ToolStripProfessionalRenderer(new ContextMenuSetter());
            cmCustomer.Renderer = new ToolStripProfessionalRenderer(new ContextMenuSetter());
        }

        private async void frmShowCustomerGroups_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void mnuAddCustGroup_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmCustomerGroup();
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
                var frm = new frmCustomerGroup(GroupGuid,false);
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
                var group = await CustomerGroupBussines.GetAsync(Guid.Parse(node.Name));
                if (group != null)
                    GroupGuid = group.Guid;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
