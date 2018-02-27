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
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void frmShop_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();

        }

        private void HienThiDanhSach()
        {
            var dsKH = context.KhachHangs.ToList();
            lsvDanhSach.Items.Clear();
            foreach (KhachHang kh in dsKH)
            {
                ListViewItem lvi = new ListViewItem(kh.MaKH + "");
                lvi.SubItems.Add(kh.TenKH);
                lvi.SubItems.Add(kh.DiaChi);
                lvi.SubItems.Add(kh.Email);
                lvi.SubItems.Add(kh.SoDienThoai);
                lsvDanhSach.Items.Add(lvi);

            }
        }
        public static bool ThayDoi = false;
        private void button1_Click(object sender, EventArgs e)
        {
            frmThemShop frmThem= new frmThemShop();
            frmThem.ShowDialog();
            if (ThayDoi == true)
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = int.Parse(frmThem.txtMa.Text);
                kh.TenKH = frmThem.txtTen.Text;
                kh.DiaChi = frmThem.txtDiaChi.Text;
                kh.Email = frmThem.txtMail.Text;
                kh.SoDienThoai = frmThem.txtSDT.Text;
                context.KhachHangs.InsertOnSubmit(kh);
                context.SubmitChanges();
                HienThiDanhSach();

            }
        }
        public static bool KT = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Shop");
                return;
            }
            else
            {
                KT = true;
                ThayDoi = false;
                int index = lsvDanhSach.SelectedIndices[0];
                int ma =int.Parse( lsvDanhSach.Items[index].SubItems[0].Text);
                KhachHang kh = context.KhachHangs.FirstOrDefault(x => x.MaKH == ma);
                frmThemShop frmThem = new frmThemShop();
                frmThem.txtMa.ReadOnly = true;
                frmThem.txtTen.Focus();
                frmThem.txtMa.Text = kh.MaKH+"";
                frmThem.txtTen.Text = kh.TenKH;
                frmThem.txtDiaChi.Text = kh.DiaChi;
                frmThem.txtMail.Text = kh.Email;
                frmThem.txtSDT.Text = kh.SoDienThoai;
                frmThem.ShowDialog();
                if (ThayDoi == true)
                {
                    kh.MaKH = int.Parse(frmThem.txtMa.Text);
                    kh.TenKH = frmThem.txtTen.Text;
                    kh.DiaChi = frmThem.txtDiaChi.Text;
                    kh.Email = frmThem.txtMail.Text;
                    kh.SoDienThoai = frmThem.txtSDT.Text;
                    context.SubmitChanges();
                    HienThiDanhSach();


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Shop");
                return;
            }
            else
            {
                DialogResult drl;
                drl = MessageBox.Show("Bạn có chắc chắn muốn xóa Shop này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (drl == DialogResult.Yes)
                {

                    int index = lsvDanhSach.SelectedIndices[0];
                    int ma = int.Parse(lsvDanhSach.Items[index].SubItems[0].Text);
                    KhachHang kh = context.KhachHangs.FirstOrDefault(x => x.MaKH == ma);
                    if (kh != null)
                    {
                        context.KhachHangs.DeleteOnSubmit(kh);
                        context.SubmitChanges();
                        HienThiDanhSach();

                    }
                }

            }
        }
    }
}
