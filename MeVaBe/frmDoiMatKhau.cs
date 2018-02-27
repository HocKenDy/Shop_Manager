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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
           string ten=frmDangNhap.TDN;
          
          
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang trong quá trình bảo trì", "Thông báo");
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            txtMatKhauMoi.Enabled = false;
            txtXacNhan.Enabled = false;
            txtTenDangNhap.ReadOnly = true;
            return;
            txtTenDangNhap.Text = ten;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtXacNhan.UseSystemPasswordChar = true;

        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            DangNhap dn = context.DangNhaps.FirstOrDefault(x => x.TenDangNhap == ten);
            if(txtMatKhau.Text=="" || txtMatKhauMoi.Text=="" || txtXacNhan.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                txtMatKhau.Clear();
                txtMatKhauMoi.Clear();
                txtXacNhan.Clear();
                txtMatKhau.Focus();
                return;
            }
            else if(txtMatKhau.Text!=dn.MatKhau)
            {
                MessageBox.Show("Mật khẩu không hợp lệ");
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }
            else if(txtMatKhauMoi.Text!=txtXacNhan.Text)
            {
                txtMatKhauMoi.Clear();
                txtMatKhauMoi.Focus();
                txtXacNhan.Clear();
            }
            else
            {
                DangNhap dn1 = context.DangNhaps.FirstOrDefault(x => x.TenDangNhap == ten);
             
                if(dn1!=null)
                {
                    dn1.TenDangNhap = txtTenDangNhap.Text;
                    dn1.MatKhau = txtMatKhauMoi.Text;
                    context.SubmitChanges();
                    MessageBox.Show("Xin lỗi chức năng này đang trong quá trình bảo trì", "Thông báo");
                    
                    this.Close();
                }
                
            }
            
        }
    }
}
