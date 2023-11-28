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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_LTTQNe
{

    public partial class QuanLyPhieuDatBan : Form
    {
        ProcessDatabase processsData = new ProcessDatabase();

        public QuanLyPhieuDatBan()
        {
           
            InitializeComponent();
            LoadDataIntoComboBox();
            LoadDataIntoComboBox1();
            LoadDataIntoComboBox2();
        }
        public void LoadDataGridView()
        {
            dataGridView1.DataSource = processsData.DocBang("select * from PhieuDatBan ");
        }
        private void LoadDataIntoComboBox()
        {
            comboBoxTenMonAn.DataSource = processsData.DocBang("select ten_mon_an from MonAn");
            comboBoxTenMonAn.DisplayMember = "ten_mon_an";

        }
        private void LoadDataIntoComboBox1()
        {
            comboBoxKhachHang.DataSource = processsData.DocBang("select ma_nhan_vien from NhanVien");
            comboBoxKhachHang.DisplayMember = "ma_nhan_vien";
        }
        private void LoadDataIntoComboBox2()
        {
            comboBoxNhanVien.DataSource = processsData.DocBang("select ma_khach from KhachHang");
            comboBoxNhanVien.DisplayMember = "ma_khach";
        }





        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyPhieuDatBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaPhieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBoxKhachHang.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBoxNhanVien.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtpNgayDatBan.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dtpNgayDung.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtTongTien.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO PhieuDatBan (ma_phieu, ma_khach, ma_nhan_vien, ngay_dat, ngay_dung, tong_tien) VALUES"
                + "(N'" + txtMaPhieu.Text + "'," +
                   "N'" + comboBoxKhachHang.Text + "'," +
                   "N'" + comboBoxNhanVien.Text + "'," +
                   "N'" + dtpNgayDatBan.Text + "'," +
                   "N'" + dtpNgayDung.Text + "'," +
                   "N'" + txtTongTien.Text + "')";
                ChiTietPhieuDatBan otherForm = new ChiTietPhieuDatBan();
                otherForm.Show();
                this.Hide();
                processsData.RunSQL(sql);
                LoadDataGridView();

            }
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thực hiện thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa phiếu đặt bàn này?", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql2 = "delete from PhieuDatBan where ma_phieu=N'" + txtMaPhieu.Text + "'";
                processsData.RunSQL(sql2);

                LoadDataGridView();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql3 = "update PhieuDatBan set "+
                
                "ma_khach=N'" + comboBoxKhachHang.Text + "'," +
                "ma_nhan_vien=N'" + comboBoxNhanVien.Text + "'," +
                "ngay_dat=N'" + dtpNgayDatBan.Text + "'," +
                "ngay_dung=N'" + dtpNgayDung.Text + "'," +
                "tong_tien=N'" + txtTongTien.Text+"'"
                +"where ma_phieu='"+txtMaPhieu.Text+"'";

     
            processsData.RunSQL(sql3);

            LoadDataGridView();
        }
    }
}
