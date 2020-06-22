using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Slider_Form
{
    public partial class frmShowSlider : Form
    {
        private async Task LoadData(string search = null)
        {
            try
            {
                var liat = await SliderBussines.GetAllAsync(search);
                SliderBindingSource.DataSource = liat.ToList();
            }
            catch (Exception e)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(e);
            }
        }
        public frmShowSlider()
        {
            InitializeComponent();
            cmCustomer.Renderer = new ToolStripProfessionalRenderer(new ContextMenuSetter());
        }

        private async void frmShowSlider_Load(object sender, EventArgs e)
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
                var frm = new frmSliderMain();
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
