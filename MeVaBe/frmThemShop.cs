using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeVaBe
{
    public partial class frmThemShop : Form
    {
        public frmThemShop()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (frmShop.KT != true)
            {
                var dsShop = context.KhachHangs.ToList();
                foreach (KhachHang kh in dsShop)
                {
                    int ma = int.Parse(txtMa.Text);
                    if (ma == kh.MaKH)
                    {
                        MessageBox.Show("Mã đã tồn tại vui lòng kiểm tra lại");
                        txtMa.Clear();
                        txtMa.Focus();
                        return;
                    }
                }
            }
            if (txtMa.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtMail.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các ô");
                txtMa.Clear();
                txtTen.Clear();
                txtDiaChi.Clear();
                txtMail.Clear();
                txtSDT.Clear();
                txtMa.Focus();
            }
            else
            {
                MessageBox.Show("Lưu thành công");
                this.Close();
                frmShop.ThayDoi = true;
            }

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back)
            {
                if (txtSDT.Text.Length != 0)
                {
                    txtSDT.Text = txtSDT.Text.Remove(txtSDT.Text.Length - 1);
                    txtSDT.Select(txtSDT.Text.Length, 1);
                }
            }
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }

        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (frmShop.KT == true)
                return;
            if (e.KeyCode == Keys.Back)
            {
                if (txtMa.Text.Length != 0)
                {
                    txtMa.Text = txtMa.Text.Remove(txtMa.Text.Length - 1);
                    txtMa.Select(txtMa.Text.Length, 1);
                }
            }

        }
    }
}
