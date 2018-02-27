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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            var dsNV = context.NhanViens.ToList();
            lsvDanhSach.Items.Clear();
            foreach (NhanVien nv in dsNV)
            {
                ListViewItem lvi = new ListViewItem(nv.MaNV+"");
                lvi.SubItems.Add(nv.TenNV);
                lvi.SubItems.Add(nv.NgaySinh+"");
                lvi.SubItems.Add(nv.DiaChi);
                lvi.SubItems.Add(nv.SoDienThoai);
                lsvDanhSach.Items.Add(lvi);

            }
        }
        public static bool ThayDoi = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNV frmThem = new frmThemNV();
            frmThem.ShowDialog();
            if (ThayDoi == true)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = int.Parse(frmThem.txtMa.Text);
                nv.TenNV = frmThem.txtTen.Text;
                nv.NgaySinh = frmThem.dtpNgaySinh.Value;
                nv.DiaChi = frmThem.txtDiaChi.Text;
                nv.SoDienThoai = frmThem.txtSDT.Text;
                context.NhanViens.InsertOnSubmit(nv);
                context.SubmitChanges();
                HienThiDanhSach();

            }

        }
        public static bool Kt = false;
        private void Sửa_Click(object sender, EventArgs e)
        {
            if(lsvDanhSach.SelectedIndices.Count==0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa");
                return;
            }
            else
            {
                Kt = true;
                ThayDoi = false;
                int index = lsvDanhSach.SelectedIndices[0];
                int ma = int.Parse(lsvDanhSach.Items[index].SubItems[0].Text);
                NhanVien nv = context.NhanViens.FirstOrDefault(x => x.MaNV == ma);
                frmThemNV frmThem = new frmThemNV();
                frmThem.txtMa.Text = nv.MaNV+"";
                frmThem.txtMa.ReadOnly = true;
                frmThem.txtTen.Text = nv.TenNV;
                frmThem.dtpNgaySinh.Text = nv.NgaySinh+ "";
                frmThem.txtDiaChi.Text = nv.DiaChi;
                frmThem.txtSDT.Text=nv.SoDienThoai;
                frmThem.ShowDialog();
                if (ThayDoi == true)
                {
                    nv.MaNV = int.Parse(frmThem.txtMa.Text);
                    nv.TenNV = frmThem.txtTen.Text;
                    nv.NgaySinh = frmThem.dtpNgaySinh.Value;
                    nv.DiaChi = frmThem.txtDiaChi.Text;
                    nv.SoDienThoai = frmThem.txtSDT.Text;
                    context.SubmitChanges();
                    HienThiDanhSach();


                }
            }
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân  viên cần xóa");
                return;
            }
            else
            {
                DialogResult drl;
                drl = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân viên này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (drl == DialogResult.Yes)
                {

                    int index = lsvDanhSach.SelectedIndices[0];
                    int ma = int.Parse(lsvDanhSach.Items[index].SubItems[0].Text);
                    NhanVien kh = context.NhanViens.FirstOrDefault(x => x.MaNV == ma);
                    if (kh != null)
                    {
                        context.NhanViens.DeleteOnSubmit(kh);
                        context.SubmitChanges();
                        HienThiDanhSach();

                    }
                }

            }
        }
    }
}
