using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityCache.Bussines;
using PacketParser.Services;

namespace Shop_Windows.Customer_Form
{
    public partial class frmShowCustomerGroups : Form
    {
        private async Task LoadData(string search = "")
        {
            try
            {
                var list = await CustomerGroupBussines.GetAllAsync();
                CusGroupBindingSource.DataSource = list;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmShowCustomerGroups()
        {
            InitializeComponent();
        }

        private async void frmShowCustomerGroups_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
