using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketParser.Services;

namespace Shop_Windows.Slider_Form
{
    public partial class frmSliderMain : Form
    {
        public frmSliderMain()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtName);
        }

        private void txtURL_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtURL);
        }

        private void txtStartDate_Enter(object sender, EventArgs e)
        {
            txtSetter.FocusMsk(txtStartDate);
        }

        private void txtEndDate_Enter(object sender, EventArgs e)
        {
            txtSetter.FocusMsk(txtEndDate);
        }

        private void txtEndDate_Leave(object sender, EventArgs e)
        {
            txtSetter.FollowMsk(txtEndDate);
        }

        private void txtStartDate_Leave(object sender, EventArgs e)
        {
            txtSetter.FollowMsk(txtStartDate);
        }

        private void txtURL_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtURL);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtName);
        }
    }
}
