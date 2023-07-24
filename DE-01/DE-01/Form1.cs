using DE_01.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_01
{
   

        public partial class frmSV : Form
        {
            Model1 model = new Model1();
            public frmSV()
            {
                InitializeComponent();
            }
        List<SinhVien> sinhvien = new List<SinhVien>();


        private void btThoat_Click(object sender, EventArgs e)
            {
                var ask = MessageBox.Show("Ban co muon xoa du lieu ?", "Delete", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            private void btThem_Click(object sender, EventArgs e)
            {   
                var find = model.SINHH_VIENs.FirstOrDefault(s => s.MaSV == txtMASV.Text);
                if (find == null)
                {
                SINHH_VIEN sv = new SINHH_VIEN()
                    {
                        MaSV = txtMASV.Text,
                        HoTenSV = txtHoTenSV.Text,
                        NgaySinh = dtNgaySinh.Value,
                        MaLop = ((LOPP)cboLOP.SelectedItem)?.MaLop
                    };
                    model.SINHH_VIENs.Add(sv);
                    model.SaveChanges();
                }

                List<SINHH_VIEN> ls = model.SINHH_VIENs.ToList();
                BindList(ls);
            }


            private void BindList(List<SinhVien> sinhViens)
            {
            listView1.Items.Clear();
                foreach (SinhVien items in sinhViens)
                {
                    var list = new ListViewItem(items.MaSV);
                    list.SubItems.Add(items.HoTenSV);
                    list.SubItems.Add(items.ngaysinh.ToString("dd/MM/yyyy"));
                    string tenlop = items.LOPP!= null ? items.LOPP.TenLop : "";
                    list.SubItems.Add(tenlop);
                listView1.Items.Add(list);
                }
            }

            private void frmSV_Load(object sender, EventArgs e)
            {
                List<SinhVien> listSV = model.SINHH_VIENs.ToList();
                List<Lop> listLOP = model.Lops.ToList();
                FillTenLopCombobox(listLOP);
                BindList(listSV);
            }

            private void FillTenLopCombobox(List<Lop> lops)
            {
                this.cboLOP.DataSource = lops;
                this.cboLOP.DisplayMember = "TenLop";
                this.cboLOP.ValueMember = "MaLop";
            }
            private void btnSua_Click(object sender, EventArgs e)
            {
                string maSV = txtMASV.Text;
                string TenSV = txtHoTenSV.Text;
                DateTime Ngaysinh = dtNgaySinh.Value;
                string malop = ((LOPP)cboLOP.SelectedItem)?.MaLop;


                SinhVien existingSV = model.SINHH_VIENs.FirstOrDefault(sp => sp.MaSV == maSV);

                if (existingSV != null)
                {

                    existingSV.HoTenSV = TenSV;
                    existingSV.ngaysinh = Ngaysinh;
                    existingSV.MaLop = malop;
                    model.SaveChanges();
                    List<SinhVien> ls = model.SINHH_VIENs.ToList();
                    BindList(ls);

                    txtMASV.Text = "";
                    txtHoTenSV.Text = "";
                    dtNgaySinh.Value = DateTime.Now;
                    cboLOP.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Khong tim thay ma san pham trong danh sach.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btThem_Click_1(object sender, EventArgs e)
        {

        }

        private void frmSV_Load_1(object sender, EventArgs e)
        {

        }
    }
}
