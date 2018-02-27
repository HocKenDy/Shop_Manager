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
    public partial class frmSoLuong : Form
    {
        public frmSoLuong()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text=="")
            {
                MessageBox.Show("bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            else
            {

            frmPhieuNhap.ThayDoi = true;
            this.Close();
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

    }
}
