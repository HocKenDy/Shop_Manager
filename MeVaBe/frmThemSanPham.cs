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
    public partial class frmThemSanPham : Form
    {
        public frmThemSanPham()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (frmSanPham.KT != true)
            {

                var dsSP = context.SanPhams.ToList();
                foreach (SanPham sp in dsSP)
                {
                    string ma = txtMa.Text;
                    if (ma == sp.MaSP)
                    {
                        MessageBox.Show("Mã đã tồn tại.Xin kiểm tra lại");
                        txtMa.Clear();
                        txtMa.Focus();
                        return;
                    }
                }
            }

            if (txtMa.Text == "" || txtTen.Text == "" || txtDonGia.Text == "" || txtDonVi.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các ô");
                txtMa.Clear();
                txtTen.Clear();
                txtDonVi.Clear();
                txtDonGia.Clear();
                txtSoLuong.Clear();
                txtMa.Focus();
            }
            else
            {
                MessageBox.Show("Lưu thành công");
                this.Close();
                frmSanPham.ThayDoi = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txtSoLuong.Text.Length != 0)
                {
                    txtSoLuong.Text = txtSoLuong.Text.Remove(txtSoLuong.Text.Length - 1);
                    txtSoLuong.Select(txtSoLuong.Text.Length, 1);
                }


            }
        }

        private void txtDonGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (txtDonGia.Text.Length != 0)
                {
                    txtDonGia.Text = txtDonGia.Text.Remove(txtDonGia.Text.Length - 1);
                    txtDonGia.Select(txtDonGia.Text.Length, 1);
                }


            }
        }
    }
}
