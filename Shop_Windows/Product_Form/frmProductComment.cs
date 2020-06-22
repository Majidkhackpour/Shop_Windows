using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advertise.Email_Form;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Product_Form
{
    public partial class frmProductComment : Form
    {
        public Guid PrdGuid { get; set; }
        private async Task LoadData(string search = "")
        {
            try
            {
                var list = await PrdCommentBussines.GetAllAsync(PrdGuid, search);
                ProductBindingSource.DataSource = list.ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmProductComment(Guid prdGuid)
        {
            InitializeComponent();
            PrdGuid = prdGuid;
            cmProduct.Renderer = new ToolStripProfessionalRenderer(new ContextMenuSetter());
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

        private async void frmProductComment_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadData();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmProductComment_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        Close();
                        break;
                }
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["Radif"].Value = e.RowIndex + 1;
        }

        private async void DGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var comm = await PrdCommentBussines.GetAsync(guid);
                if (comm == null) return;
                txtDesc.Text = comm.Comment;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var rec = DGrid[dgEmail.Index, DGrid.CurrentRow.Index].Value.ToString();
                var frm = new frmSendEmail(rec);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
