using BTL_LTTQ_Ne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTL_LTTQNe
{
    public partial class FormTimKiem : Form
    {
        ProcessDatabase process = new ProcessDatabase();
        public FormTimKiem()
        {
            InitializeComponent();
            dataGridView1.DataSource = process.DocBang("select * from NguyenLieu");
            dataGridView1.Columns[0].HeaderText = "Mã nguyên liệu";
            dataGridView1.Columns[1].HeaderText = "Tên guyên liệu";
            dataGridView1.Columns[2].HeaderText = "Đơn vị tính";
            dataGridView1.Columns[3].HeaderText = "Số lg";
            dataGridView1.Columns[4].HeaderText = "Đơn giá nhập";
            dataGridView1.Columns[5].HeaderText = "Đơn giá bán";
            dataGridView1.Columns[6].HeaderText = "Công dụng";
            dataGridView1.Columns[7].HeaderText = "Yêu cầu";
            dataGridView1.Columns[8].HeaderText = "Ngay nhap";
			dataGridView1.Columns[9].HeaderText = "Chống chỉ định";

		}

		private void FormTimKiem_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            
            
		}

        private void button1_Click(object sender, EventArgs e)
        {
		}

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NguyenLieu WHERE";
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) &&!string.IsNullOrEmpty(textBox3.Text))
            {
                query += " ten_nguyen_lieu = N'" + textBox1.Text + "' AND cong_dung = N'" + textBox2.Text + "'" + "' AND chong_chi_dinh = N'" + textBox3.Text + "'";
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += " ten_nguyen_lieu = N'" + textBox1.Text + "'";
            }
            else if (!string.IsNullOrEmpty(textBox1.Text)&& !string.IsNullOrEmpty(textBox3.Text))
            {
                query += " ten_nguyen_lieu = N'" + textBox1.Text + "'"+ " chong_chi_dinh = N'" + textBox3.Text + "'";
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                query += " ten_nguyen_lieu = N'" + textBox1.Text + "'" + " cong_dung = N'" + textBox2.Text + "'";
            }
            else if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                query += " cong_dung = N'" + textBox2.Text + "'" + " chong_chi_dinh = N'" + textBox3.Text + "'";
            }
            else if (!string.IsNullOrEmpty(textBox2.Text))
            {
                query += " cong_dung = N'" + textBox2.Text + "'";
            }
            else if (!string.IsNullOrEmpty(textBox3.Text))
            {
                query += " chong_chi_dinh = N'" + textBox3.Text + "'";
            }
            else
            {
                // Không có giá trị nào được điền vào textbox
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dataGridView1.DataSource = process.DocBang(query);

        }

        private void button4_Click(object sender, EventArgs e)
		{
            reset();
            dataGridView1.DataSource = process.DocBang("select * from NguyenLieu");
        }

        private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        Form1 form1 = new Form1();
           private void button5_Click(object sender, EventArgs e)
        {
            Form1 otherForm = new Form1(2,sender);
            otherForm.Show();
            this.Hide();
        }
    }
}
