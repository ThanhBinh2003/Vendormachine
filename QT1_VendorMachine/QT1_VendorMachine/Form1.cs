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
    public partial class frmVendor : Form
    {
        public frmVendor()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }
    }
}
