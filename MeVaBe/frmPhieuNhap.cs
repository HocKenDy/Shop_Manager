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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        bool isFineshed = false;
        CSDLShopMeVaBeDataContext context = new CSDLShopMeVaBeDataContext();
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            
            var dsNV = context.NhanViens.ToList();
            cmbNhanVien.DataSource = dsNV;
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
            isFineshed = true;
            flpCheck.Controls.Clear();
            var dsSP = context.SanPhams.ToList();
            for (int i = 0; i < dsSP.Count; ++i)
            {
                CheckBox chk = new CheckBox();
                chk.Text = dsSP[i].TenSP;
                chk.Tag = dsSP[i].MaSP;
                chk.Width = 200;
                chk.Height = 30;
                chk.BackColor = System.Drawing.Color.Aqua;
                flpCheck.Controls.Add(chk);
                chk.CheckedChanged += chk_CheckedChanged;
            }

        }
        public static bool ThayDoi = false;
   
        void chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if(chk.Checked==true)
            {
               frmSoLuong frm = new frmSoLuong();
                frm.ShowDialog();
              if(ThayDoi==true)
              {
                  var SP = context.SanPhams.FirstOrDefault(x => x.MaSP==chk.Tag);
                  string ma = SP.MaSP;
                  HienThiDanhSach(ma, frm);
              }

            }
        }

        private void HienThiDanhSach(SanPham SP)
        {
            throw new NotImplementedException();
        }
        int soluong = 0;
       
        private void HienThiDanhSach(string ma,frmSoLuong frm)
        {
             
            soluong++;
           
            int sl=int.Parse(frm.txtSoLuong.Text);
            
            SanPham sp = context.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            ListViewItem lvi = new ListViewItem((soluong) + "");
            int? thanhtien=sp.DonGia*sl;
            lvi.SubItems.Add(sp.TenSP);
            lvi.SubItems.Add(sp.DvTinh);
            lvi.SubItems.Add(sl + "");
            lvi.SubItems.Add(sp.DonGia + "");
            lvi.SubItems.Add(thanhtien + "");
            lsvDanhSach.Items.Add(lvi);
         
        }
      
        private void chkTatCa_CheckedChanged(object sender, EventArgs e)
        {

        }
        string matest= null;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int stttam = 0;
            if(lsvDanhSach.SelectedIndices.Count==0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo");
                return;
            }
            else
            {
                stttam = int.Parse(lsvDanhSach.Items[lsvDanhSach.SelectedIndices[0]].Text);
                lsvDanhSach.Items.RemoveAt(lsvDanhSach.SelectedIndices[0]);
               
            }
            for(int i=0;i<lsvDanhSach.Items.Count;++i)
            {
                int stt=int.Parse(lsvDanhSach.Items[i].SubItems[0].Text);
                if(stt>stttam)
                {
                    stt--;
                    lsvDanhSach.Items[i].SubItems[0].Text = stt + "";
                }
            }
        }
        int mangoai = 1;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dsPNH = context.PhieuNhapHangs.ToList();
            foreach(PhieuNhapHang pnh in dsPNH)
            {
                context.PhieuNhapHangs.DeleteOnSubmit(pnh);
                context.SubmitChanges();
            }
            for(int i=0;i<lsvDanhSach.Items.Count;i++)
            {
              //  int mapn = int.Parse(lsvDanhSach.Items[i].SubItems[0].Text);
                string tensp = lsvDanhSach.Items[i].SubItems[1].Text;
                string dvt = lsvDanhSach.Items[i].SubItems[2].Text;
                int sl = int.Parse(lsvDanhSach.Items[i].SubItems[3].Text);
                int dongia = int.Parse(lsvDanhSach.Items[i].SubItems[4].Text);
                int thanhtien = int.Parse(lsvDanhSach.Items[i].SubItems[5].Text);
                DateTime ngaynhap = dtpNgayNhap.Value;
            
                SanPham sp = context.SanPhams.FirstOrDefault(x => x.TenSP == tensp);
                string ma = sp.MaSP;
                if(sp!=null)
                {
                    sp.SoLuong+= sl;
                    context.SubmitChanges();
                }
                int manv = (int)cmbNhanVien.SelectedValue;
                PhieuNhapHang pnh = new PhieuNhapHang();
                pnh.MaPN = mangoai;
                pnh.MaSP = ma;
                pnh.TenSP = tensp;
                pnh.SoLuong = sl;
                pnh.DonGia = dongia;
                pnh.NgayNhap = ngaynhap;
                pnh.ThanhTien = thanhtien;
                pnh.DVT = dvt;
                context.PhieuNhapHangs.InsertOnSubmit(pnh);
                context.SubmitChanges();
                mangoai++;
                
            }
            frmInPhieuNhap frmIn = new frmInPhieuNhap();
            frmIn.ShowDialog();
        }
    }
}
