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
	public partial class QuanLyNguyenLieuMonAn : Form
	{
		string stringcon = @"Data Source=DESKTOP-3GCI6TQ\SQLEXPRESS;Initial Catalog=Food_Ind_Management;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		ProcessDatabase Process = new ProcessDatabase();
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		public QuanLyNguyenLieuMonAn()
		{
			InitializeComponent();
		}
		void loaddata()
		{
			cmd = con.CreateCommand();
			cmd.CommandText = "Select * from NguyenLieuMonAn";
			adapter.SelectCommand = cmd;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;

		}
		private void QuanLyNguyenLieuMonAm_Load(object sender, EventArgs e)
		{
			con = new SqlConnection(stringcon);
			con.Open();
			loaddata();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			int i;
			i = dataGridView1.CurrentRow.Index;
			txtmamonan.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
			txtmanguyenlieu.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
			txtsoluong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
		

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}


		private void btnthem_Click(object sender, EventArgs e)
		{
			try
			{
				cmd = con.CreateCommand();
				cmd.CommandText = "INSERT INTO NguyenLieuMonAn (ma_mon_an, ma_nguyen_lieu, so_luong) VALUES (N'" + txtmamonan.Text + "', N'" + txtmanguyenlieu.Text + "', N'" + txtsoluong.Text + "')";
				cmd.ExecuteNonQuery();
				loaddata();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thực hiện thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 otherForm = new Form1();
			otherForm.Show();
			this.Hide();
		}
	}
}
