using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT1_VendorMachine
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thông báo", "Mời quý khách nhận vé!", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Hide();
                frmVendor frm1 = new frmVendor();
                frm1.ShowDialog();
                
            }
        }
    }
}
