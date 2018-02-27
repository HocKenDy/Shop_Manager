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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiDau();
            lblThoiGian.Text = DateTime.Now.ToString("HH:mm:ss");
            int gio = DateTime.Now.Hour;
            if(gio<=8)
            {
                lblLoiChuc.Text = "Buổi sáng tốt lành";
                lblLoiChuc.BackColor = System.Drawing.Color.Aqua;
            }
            else if(gio<=12)
            {
                lblLoiChuc.Text = "Buổi trưa vui vẻ";
                lblLoiChuc.BackColor = System.Drawing.Color.Green;
            }
            else if(gio<=17)
            {
                lblLoiChuc.Text = "Buổi chiều vui vẻ";
                lblLoiChuc.BackColor = System.Drawing.Color.Yellow;
            }
            else if(gio>=21 && gio<23)
            {
                lblLoiChuc.Text = "Khuya rồi ngủ nào";
                lblLoiChuc.BackColor = System.Drawing.Color.Tomato;
            }
            timer1.Start();
        }

        private void HienThiDau()
        {

            cmbMatHang.Enabled = false;
            lsvDanhSach.Enabled = false;
            menuDm.Enabled = false;
            menuTg.Enabled = false;
            menuBc.Enabled = false;
            menuNdDangXuat.Enabled = false;
            menuNdDoiMatKhau.Enabled = false;
            menuNdThemNguoiDung.Enabled = false;
            lblXinChao.Enabled = false;
            cmbMatHang.Items.Add("Sữa");
        }
        public static bool check = false;
        private void menuNdDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.ShowDialog();
            if (check == true)
            {
                menuNdDangNhap.Enabled = false;
                cmbMatHang.Enabled = true;
                lsvDanhSach.Enabled = true;
                menuDm.Enabled = true;
                menuTg.Enabled = true;
                menuBc.Enabled = true;
                menuNdDangXuat.Enabled = true;
                menuNdDoiMatKhau.Enabled = true;
                menuNdThemNguoiDung.Enabled = true;
                HienLoiChao();
                this.Show();
            }
        
        }

        private void HienLoiChao()
        {
            string loichao="";
            lblXinChao.Enabled = true;
            lblXinChao.BackColor = System.Drawing.Color.Aqua;
            loichao = frmDangNhap.TDN;
            lblXinChao.Text += loichao;
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dtr = new DialogResult();
            dtr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dtr != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void menuDmMatHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSanPham frmSP = new frmSanPham();
            frmSP.ShowDialog();
            this.Show();

        }

        private void menuDmNhaCungCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShop frmShp = new frmShop();
            frmShp.ShowDialog();
            this.Show();
        }

        private void cmbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dsSP = context.SanPhams.ToList();
            lsvDanhSach.Items.Clear();
            foreach (SanPham sp in dsSP)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSP);
                lvi.SubItems.Add(sp.TenSP);
                lvi.SubItems.Add(sp.DonGia + "");
                lvi.SubItems.Add(sp.SoLuong + "");
                lsvDanhSach.Items.Add(lvi);
                lvi.BackColor = System.Drawing.Color.WhiteSmoke;
            }

        }

        private void nhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.ShowDialog();
            this.Show();
        }

        private void menuNdDoiMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông báo");
            return;
            //this.Hide();
            //frmDoiMatKhau frmDoi = new frmDoiMatKhau();
            //frmDoi.ShowDialog();
            //this.Show();
        }

        private void menuBcNhapHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhieuNhap frm = new frmPhieuNhap();
            frm.ShowDialog();
            this.Show();
        }

        private void menuNdDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static bool Add = false;
        private void menuNdThemNguoiDung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa cập nhật", "Thông báo");
            return;
            //frmThemNguoiDung frmThem = new frmThemNguoiDung();
            //frmThem.ShowDialog();

            //if(Add==true)
            //{
            //    DangNhap dn = new DangNhap();
            
            //    dn.TenDangNhap = frmThem.txtTenDangNhap.Text;
            //    dn.MatKhau = frmThem.txtMatKhau.Text;
            //    context.DangNhaps.InsertOnSubmit(dn);
            //    context.SubmitChanges();
            //    MessageBox.Show("Thêm thành công","Thông báo");
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString();
        }
    }
}
