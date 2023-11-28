using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using BTL_LTTQ_Ne;

namespace BTL_LTTQNe
{
	public partial class QuanLyMonAn : Form
	{
		string stringcon = @"Data Source=DESKTOP-3GCI6TQ\SQLEXPRESS;Initial Catalog=Food_Ind_Management;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adapter = new SqlDataAdapter();	
		DataTable table = new DataTable();
		void loaddata()
		{
			cmd = con.CreateCommand();
			cmd.CommandText ="Select * from MonAn";
			adapter.SelectCommand = cmd;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;	
			
		}

		public QuanLyMonAn()
		{
			InitializeComponent();

		}
		private void QuanLyMonAn_Load(object sender, EventArgs e)
		{
			con = new SqlConnection(stringcon);
			con.Open();
			loaddata();
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

	

		private void txtcongdung_TextChanged(object sender, EventArgs e)
		{

		}

		
		
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}
		private void btnthem_Click(object sender, EventArgs e)
		{
			
			try
			{
					cmd = con.CreateCommand();
					cmd.CommandText = "INSERT INTO MonAn (ma_mon_an, ten_mon_an, ma_cong_dung, ma_loai, cach_lam, yeu_cau) VALUES (N'" + txtmamonan.Text + "', N'" + txttenmonan.Text + "', N'" + txtcongdung.Text + "', N'" + txtloai.Text + "', N'" + txtcachlam.Text + "', N'" + txtyeucau.Text + "')";
					cmd.ExecuteNonQuery();
					loaddata();
				QuanLyNguyenLieuMonAn quanLyNguyenLieuForm = new QuanLyNguyenLieuMonAn();
				quanLyNguyenLieuForm.Show();
				this.Hide();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thực hiện thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			
		}
		private void btntinhdongia_Click(object sender, EventArgs e)
		{

		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			
			DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa món ăn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
	
				cmd = con.CreateCommand();
				cmd.CommandText = "delete from MonAn where ma_mon_an= '" + txtmamonan.Text + "'";
				cmd.ExecuteNonQuery();
				loaddata();
			}
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			
			DialogResult result = MessageBox.Show("Bạn có chắc với thay đổi này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)	
			{
			
				cmd = con.CreateCommand();
				cmd.CommandText = "update MonAn set ten_mon_an = N'" + txttenmonan.Text + "', ma_cong_dung=N'" + txtcongdung.Text + "', ma_loai=N'" + txtloai.Text + "', cach_lam=N'" + txtcachlam.Text + "', yeu_cau=N'" + txtyeucau.Text + "' where ma_mon_an='" + txtmamonan.Text + "'";
				cmd.ExecuteNonQuery();
				loaddata();
			}
		}

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmamonan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttenmonan.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtcongdung.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtloai.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtcachlam.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtyeucau.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

        }
    }
}
