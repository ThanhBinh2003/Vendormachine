using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;

namespace QT1_VendorMachine
{
    public partial class Form2 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter dt;
        int price = 0;
      
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtTongTien.ReadOnly = true;
            txtDes.Focus();
            string sql = @"Data Source=DESKTOP-GDR5V36;Initial Catalog=SE_QT1;Integrated Security=True";
            cn = new SqlConnection(sql);
            cn.Open();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "" && txtDes.Text != "" )
            {
                if (txtDes.Text == "Ha Noi")
                {
                    price = 100;
                }
                else if (txtDes.Text == "Ho Chi Minh")
                {
                    price = 50;
                }
                else
                {
                    price = 80;
                }
                price = price * int.Parse(txtSoLuong.Text);
                txtTongTien.Text = price.ToString() + " ngàn VND";
            }
            else
            {
                MessageBox.Show("Eror", "Bạn chưa nhập đủ!"); 
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //check 
            if(btnXacNhan.Enabled == true)
            {
                if (txtDes.Text == "")
                {
                    MessageBox.Show("Error", "Bạn chưa nhập đích đến!", MessageBoxButtons.OK);
                }
                else if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Error", "Bạn chưa nhập số lượng!", MessageBoxButtons.OK);
                }
                else if (cboMethod.Text == "")
                {
                    MessageBox.Show("Error", "Bạn chưa chọn phương thức thanh toán", MessageBoxButtons.OK);
                }
            }
            
            if(cboMethod.Text == "Thanh toán bằng thẻ ngân hàng")
            {
                this.Hide();
                Form4 frm4 = new Form4();
                frm4.ShowDialog();
                frm4 = null;
                this.Show();
            }
            else if(cboMethod.Text == "Thanh toán bằng QR code momo")
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
                frm3 = null;
                this.Show();
            }

            //store 
            string sql = "insert into ticket values (N'" + cboMethod.Text + "','" + txtDes.Text + "','" + dteGo.Value.ToString() + "','" + txtSoLuong.Text + "','" + Convert.ToString(price) + "')";
            cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
        }

        private void txtTongTien_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "" && txtDes.Text != "")
            {
                int price = 0;
                if (txtDes.Text.ToLower() == "ha noi")
                {
                    price = 100;
                }
                else if (txtDes.Text.ToLower() == "ho chi minh")
                {
                    price = 50;
                }
                else
                {
                    price = 80;
                }
                price = price * int.Parse(txtSoLuong.Text);
                txtTongTien.Text = price.ToString() + " ngàn VND";
            }
            else
            {
                MessageBox.Show("Eror", "Bạn chưa nhập đủ!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDes.Clear();
            txtSoLuong.Clear();
            txtTongTien.Clear();
            cboMethod.Text = "";
        }
    }
}
