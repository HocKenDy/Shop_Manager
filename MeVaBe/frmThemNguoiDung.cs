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
    public partial class frmThemNguoiDung : Form
    {
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void btnThem_Click(object sender, EventArgs e)
        {
            var dsDN = context.DangNhaps.ToList();
            foreach(DangNhap dn in dsDN)
            {
                if(dn.TenDangNhap==txtTenDangNhap.Text)
                {
                    MessageBox.Show("Tài khoản đã tồn tại, xin kiểm tra lại");
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtXacNhan.Clear();
                    return;
                }
            }
    
            
            if(txtMatKhau.Text!=txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                txtMatKhau.Clear();
                txtXacNhan.Clear();
                txtMatKhau.Focus();
            }
            else
            {
                frmMain.Add = true;
            }
        }
    }
}
