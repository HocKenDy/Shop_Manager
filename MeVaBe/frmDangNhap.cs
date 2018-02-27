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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        public static string TDN = null;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var dsDN = context.DangNhaps.ToList();
            bool kq = dsDN.Exists(x => (x.TenDangNhap == txtTenDangNhap.Text && x.MatKhau == txtMatKhau.Text));
            if(kq)
            {
                frmMain.check = true;
                MessageBox.Show("Đăng nhập thành công");
                TDN = txtTenDangNhap.Text;
                this.Close();

            }
            else
            {

            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Focus();
            }
            
        }
    }
}
