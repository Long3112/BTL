using BTL_LTTQ_Ne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQNe
{
    public partial class ChiTietPhieuDatBan : Form
    {
        ProcessDatabase processssData = new ProcessDatabase();

        public ChiTietPhieuDatBan()
        {
            InitializeComponent();
            Loaddataintocb1();
            
        }
        public void LoadDataGridView2()
        {
            dataGridView2.DataSource = processssData.DocBang("select * from ChiTietPhieuDatBan ");
           
        }

        private void ChiTietPhieuDatBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView2();
        }

        private void Loaddataintocb()
        {
            cbMMA.DataSource = processssData.DocBang("select ten_mon_an from MonAn");
            cbMMA.DisplayMember = "ten_mon_an";
        }

        private void Loaddataintocb1()
        {
            cbml.DataSource = processssData.DocBang(" select DISTINCT(ma_loai) from MonAn");
            cbml.DisplayMember = "ma_loai"; 
            cbml.SelectedIndex = 0;
        }

    /*    private void btnThem1_Click(object sender, EventArgs e)
        {
            string sql1 = "INSERT INTO ChiTietPhieuDatBan (ma_phieu, ma_mon_an, ma_loai, so_luong, giam_gia, thanh_tien) VALUES"
              + "(N'" + txtMaPhieu.Text + "'," +
                 "N'" + txtMaMonAn.Text + "'," +
                 "N'" + txtMaLoai.Text + "'," +
                 "N'" + txtSoLuong.Text + "'," +
                 "N'" + txtGiamGia.Text + "'," +
                 "N'" + txtThanhTien.Text + "')";
            processssData.RunSQL(sql1);
            LoadDataGridView2();
        }*/

        private void btnQuayLai1_Click(object sender, EventArgs e)
        {
            Form1 otherForm = new Form1();
            otherForm.Show();
            this.Hide();
        }

        private void cbml_SelectedIndexChanged(object sender, EventArgs e)
        {
           cbMMA.Items.Clear();
           updatecbma();
        }

        private void updatecbma()
        {
            cbMMA.Items.Clear();

            if (cbml.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cbml.SelectedItem;
                string selectValue = selectedRow["ma_loai"].ToString();
                string sql = "SELECT ma_mon_an FROM MonAn WHERE ma_loai = @MaLoai";

                SqlParameter parameter = new SqlParameter("@MaLoai", selectValue);
                DataTable dt = processssData.DocBang2(sql, new SqlParameter[] { parameter });

                foreach (DataRow dr in dt.Rows)
                {
                    cbMMA.Items.Add(dr["ma_mon_an"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giá trị trong ComboBox 1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
