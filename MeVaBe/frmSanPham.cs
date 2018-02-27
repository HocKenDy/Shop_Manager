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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();

        }

        private void HienThiDanhSach()
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
        public static bool ThayDoi = false;

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemSanPham frmThem = new frmThemSanPham();
            frmThem.ShowDialog();
            if (ThayDoi == true)
            {
                SanPham sp = new SanPham();
                sp.MaSP = frmThem.txtMa.Text;
                sp.TenSP = frmThem.txtTen.Text;
                sp.DonGia = int.Parse(frmThem.txtDonGia.Text);
                sp.SoLuong = int.Parse(frmThem.txtSoLuong.Text);
                sp.DvTinh = frmThem.txtDonVi.Text;
                context.SanPhams.InsertOnSubmit(sp);
                context.SubmitChanges();
                HienThiDanhSach();


            }

        }
        public static bool KT = false;
        private void button2_Click(object sender, EventArgs e)
        {

            if (lsvDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
            else
            {
                KT = true;
                ThayDoi = false;
                int index = lsvDanhSach.SelectedIndices[0];
                string ma = lsvDanhSach.Items[index].SubItems[0].Text;
                SanPham sp = context.SanPhams.FirstOrDefault(x => x.MaSP == ma);
                frmThemSanPham frmThem = new frmThemSanPham();
                frmThem.txtMa.Text = sp.MaSP;
                frmThem.txtMa.ReadOnly = true;
                frmThem.txtTen.Text = sp.TenSP;
                frmThem.txtDonGia.Text = sp.DonGia + "";
                frmThem.txtSoLuong.Text = sp.SoLuong + "";
                frmThem.txtDonVi.Text = sp.DvTinh;
                frmThem.ShowDialog();
                if (ThayDoi == true)
                {
                    sp.MaSP = frmThem.txtMa.Text;
                    sp.TenSP = frmThem.txtTen.Text;
                    sp.DonGia = int.Parse(frmThem.txtDonGia.Text);
                    sp.SoLuong = int.Parse(frmThem.txtSoLuong.Text);
                    sp.DvTinh = frmThem.txtDonVi.Text;
                    context.SubmitChanges();
                    HienThiDanhSach();


                }
            }
        }

        private void chbQuantam_CheckedChanged(object sender, EventArgs e)
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
                if (chbQuantam.Checked)
                {

                    if (sp.SoLuong <= 5)
                    {
                        lvi.BackColor = System.Drawing.Color.Yellow;
                    }
                    if (sp.SoLuong < 3)
                    {

                        lvi.BackColor = System.Drawing.Color.Red;
                    }

                }
                else
                {
                    lvi.BackColor = System.Drawing.Color.WhiteSmoke;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {



                if (lsvDanhSach.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm");
                    return;
                }
                else
                {
                    DialogResult drl;
                    drl = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (drl == DialogResult.Yes)
                    {

                        int index = lsvDanhSach.SelectedIndices[0];
                        string ma = lsvDanhSach.Items[index].SubItems[0].Text;
                        SanPham sp = context.SanPhams.FirstOrDefault(x => x.MaSP == ma);
                        if (sp != null)
                        {

                            context.SanPhams.DeleteOnSubmit(sp);
                            context.SubmitChanges();
                            HienThiDanhSach();

                        }
                    }

                }
            }
            catch(Exception ex)
            {

                DialogResult drl;
                drl=   MessageBox.Show("Hiện tại sản phẩm đã được lưu vào phiếu In, Chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel);
            if(drl==DialogResult.OK)
            {
               string ma = lsvDanhSach.Items[lsvDanhSach.SelectedIndices[0]].SubItems[0].Text;
               PhieuNhapHang pn = context.PhieuNhapHangs.FirstOrDefault(x => x.MaSP == ma);
                if(pn!=null)
                {
                    context.PhieuNhapHangs.DeleteOnSubmit(pn);
                    context.SubmitChanges();
                    SanPham sp = context.SanPhams.FirstOrDefault(x => x.MaSP == ma);
                    if (sp != null)
                    {

                        context.SanPhams.DeleteOnSubmit(sp);
                        context.SubmitChanges();
                       

                    }
                   
                }

                HienThiDanhSach();

            }
            }
        }

        private void chkPB_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}
