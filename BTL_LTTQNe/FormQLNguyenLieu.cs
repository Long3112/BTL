using BTL_LTTQ_Ne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQNe
{
    public partial class FormQLNguyenLieu : Form
    {
        ProcessDatabase process = new ProcessDatabase();
        public FormQLNguyenLieu()
        {
            InitializeComponent();
            dataGridView1.DataSource = process.DocBang("select * from NguyenLieu ");
            dataGridView1.Columns[0].HeaderText = "Mã Ng.L";
            dataGridView1.Columns[1].HeaderText = "Tên Ng.L";
            dataGridView1.Columns[2].HeaderText = "Đơn vị";
            dataGridView1.Columns[3].HeaderText = "Số lượng";
            dataGridView1.Columns[4].HeaderText = "Đ/G nhập";
            dataGridView1.Columns[5].HeaderText = "Đ/G bán";
            dataGridView1.Columns[6].HeaderText = "Công dụng";
            dataGridView1.Columns[7].HeaderText = "Yêu cầu";
            dataGridView1.Columns[8].HeaderText = "Ngày nhập";
            dataGridView1.Columns[9].HeaderText = "Chống chỉ định";
            txtMaNgL.Enabled = false;
            txtTenNgL.Enabled = false;
            txtSL.Enabled = false;
            txtCongDung.Enabled = false;
            txtChongChiDinh.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            //txtGiaBan.Enabled = false;
            cmbDonViTinh.Enabled = false;
            txtYeuCau.Enabled = false;
            dtpNgayNhap.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Reset();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            try
            {
                
                txtMaNgL.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                txtTenNgL.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtSL.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                cmbDonViTinh.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txtDonGiaNhap.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                //txtGiaBan.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                txtCongDung.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                txtYeuCau.Text= dataGridView1[7, e.RowIndex].Value.ToString();
                dtpNgayNhap.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                txtChongChiDinh.Text= dataGridView1[9, e.RowIndex].Value.ToString();
                
                
         
            }
            catch (Exception ex)
            {
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {       
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;


                groupBox1.Text = "CẬP NHẬT";

                btnThem.Enabled = false;
                btnXoa.Enabled = true;

                txtMaNgL.Enabled = true;
                txtTenNgL.Enabled = true;
                txtSL.Enabled = true;
                txtCongDung.Enabled = true;
                txtChongChiDinh.Enabled = true;
                txtDonGiaNhap.Enabled = true;
                //txtGiaBan.Enabled = true;
                cmbDonViTinh.Enabled = true;
                txtYeuCau.Enabled = true;
                dtpNgayNhap.Enabled = true;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nguyên liệu này?", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                DataGridViewRow row = dataGridView1.CurrentRow;

                string maNguyenLieu = row.Cells["ma_nguyen_lieu"].Value.ToString();

                string sql = $"DELETE FROM NguyenLieu WHERE ma_nguyen_lieu = '{maNguyenLieu}'";


                ProcessDatabase db = new ProcessDatabase();
                db.CapNhat(sql);


                DataTable dt = db.DocBang("SELECT * FROM NguyenLieu");
                dataGridView1.DataSource = dt;

                txtMaNgL.Enabled = false;
                txtTenNgL.Enabled = false;
                txtSL.Enabled = false;
                txtCongDung.Enabled = false;
                txtChongChiDinh.Enabled = false;
                txtDonGiaNhap.Enabled = false;
                //txtGiaBan.Enabled = false;
                cmbDonViTinh.Enabled = false;
                txtYeuCau.Enabled = false;
                dtpNgayNhap.Enabled = false;

                Reset();

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Reset();

            groupBox1.Text = "Thêm nguyên liệu";
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaNgL.Enabled = true;
            txtTenNgL.Enabled = true;
            txtSL.Enabled = true;
            txtCongDung.Enabled = true;
            txtChongChiDinh.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            //txtGiaBan.Enabled = true;
            cmbDonViTinh.Enabled = true;
            txtYeuCau.Enabled = true;
            dtpNgayNhap.Enabled=true;

            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                int kt = 1;
                if (txtMaNgL.TextLength == 0 || txtTenNgL.TextLength == 0 || cmbDonViTinh.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập vào gia trị hợp lệ");
                    kt = 0;
                }
                if (kt == 1)
                {
                    string maNguyenLieu = txtMaNgL.Text;

                    // Kiểm tra xem mã nguyên liệu đã tồn tại trong cơ sở dữ liệu hay chưa
                    string sqlCheck = $"SELECT COUNT(*) FROM NguyenLieu WHERE ma_nguyen_lieu = '{maNguyenLieu}'";
                    ProcessDatabase dbCheck = new ProcessDatabase();
                    DataTable dtCheck = dbCheck.DocBang(sqlCheck);
                    if (dtCheck.Rows[0][0].ToString() != "0")
                    {
                        MessageBox.Show("Mã nguyên liệu đã tồn tại. Vui lòng nhập lại!");
                        return;
                    }
                    else
                    {
                        //string maNguyenLieu = txtMaNgL.Text;
                        string tenNguyenLieu = txtTenNgL.Text;
                        string donViTinh = cmbDonViTinh.Text;
                        int soLuong = int.Parse(txtSL.Text);
                        double donGiaNhap = double.Parse(txtDonGiaNhap.Text);
                        //double donGiaBan = double.Parse(txtGiaBan.Text);
                        string congDung = txtCongDung.Text;
                        string yeuCau = txtYeuCau.Text;
                        string chongChiDinh = txtChongChiDinh.Text;
                        DateTime ngayNhap= dtpNgayNhap.Value;

                        string sql = $"INSERT INTO NguyenLieu (ma_nguyen_lieu, ten_nguyen_lieu, so_luong, don_gia_nhap, don_vi_tinh, cong_dung, yeu_cau, chong_chi_dinh, ngay_nhap)  VALUES (N'{maNguyenLieu}', N'{tenNguyenLieu}', N'{soLuong}', N'{donGiaNhap}', N'{donViTinh}', N'{congDung}', N'{yeuCau}', N'{chongChiDinh}', N'{ngayNhap}')";


                        ProcessDatabase db = new ProcessDatabase();
                        db.CapNhat(sql);

                        DataTable dt = db.DocBang("SELECT * FROM NguyenLieu");
                        dataGridView1.DataSource = dt;

                        Reset();
                    }
                    
                }     
            }
            else
            {
                txtMaNgL.Enabled = false;
                string tenNguyenLieu = txtTenNgL.Text;
                string donViTinh = cmbDonViTinh.Text;
                int soLuong = int.Parse(txtSL.Text);
                double donGiaNhap = double.Parse(txtDonGiaNhap.Text);
                //double donGiaBan = double.Parse(txtGiaBan.Text);
                string congDung = txtCongDung.Text;
                string yeuCau = txtYeuCau.Text;
                string chongChiDinh = txtChongChiDinh.Text;
                DateTime ngayNhap= dtpNgayNhap.Value;


                string sql = $"UPDATE NguyenLieu SET ten_nguyen_lieu = N'{tenNguyenLieu}',don_vi_tinh=  N'{donViTinh}',so_luong=N'{soLuong}',don_gia_nhap='{donGiaNhap}',cong_dung=N'{congDung}',yeu_cau=N'{yeuCau}',chong_chi_dinh=N'{chongChiDinh}', ngay_nhap= N'{ngayNhap}'  WHERE ma_nguyen_lieu = '{txtMaNgL.Text}'";

                ProcessDatabase db = new ProcessDatabase();
                db.CapNhat(sql);


                DataTable dt = db.DocBang("SELECT * FROM NguyenLieu");
                dataGridView1.DataSource = dt;

                //btnThem.Enabled = true;
                Reset();
                
            }
        
            groupBox1.Text="";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
                groupBox1.Text = "";

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;

                Reset();

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {           
                Form1 otherForm = new Form1();
                otherForm.Show();
                this.Hide();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Reset()
        {
            txtMaNgL.Text = "";
            txtTenNgL.Text = "";
            txtSL.Text = "";
            cmbDonViTinh.Text = "";
            txtDonGiaNhap.Text = "";
            //txtGiaBan.Text = "";
            txtCongDung.Text = "";
            txtYeuCau.Text = "";
            txtChongChiDinh.Text = "";
            

            txtMaNgL.Enabled = false;
            txtTenNgL.Enabled = false;
            txtSL.Enabled = false;
            txtCongDung.Enabled = false;
            txtChongChiDinh.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            //txtGiaBan.Enabled = false;
            cmbDonViTinh.Enabled = false;
            txtYeuCau.Enabled = false;
            dtpNgayNhap.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
        }
    }
}
