using BTL_LTTQ_Ne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_LTTQNe
{
    public partial class FormTimkiemMonAn : Form
    {
        ProcessDatabase process = new ProcessDatabase();
        public FormTimkiemMonAn()
        {
            InitializeComponent();
            dataGridView1.DataSource = process.DocBang("select * from MonAn ");
            dataGridView1.Columns[0].HeaderText = "Mã món ăn";
            dataGridView1.Columns[1].HeaderText = "Tên món ăn";
            dataGridView1.Columns[2].HeaderText = "Mã công dụng";
            dataGridView1.Columns[3].HeaderText = "Mã loại";
            dataGridView1.Columns[4].HeaderText = "Cách làm";
            dataGridView1.Columns[5].HeaderText = "Yêu cầu";
            dataGridView1.Columns[6].HeaderText = "Đơn giá";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FormTimkiemMonAn_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();

        }

     

        private void LoadDataIntoComboBox()
        {
            comboBox1.DataSource = process.DocBang("select ten_loai from LoaiMon");
            comboBox1.DisplayMember = "ten_loai";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query1 = "select ma_mon_an,ten_mon_an,ma.ma_cong_dung,ma.ma_loai,cach_lam,yeu_cau,don_gia from MonAn ma join LoaiMon lm on ma.ma_loai=lm.ma_loai join CongDung cd on ma.ma_cong_dung = cd.ma_cong_dung Where  ";

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                query1 += " ten_mon_an = N'" + textBox1.Text + "' AND lm.ten_loai = N'" + comboBox1.Text + "' AND  ten_cong_dung = N'" + textBox2.Text + "'";
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {
                query1 += " ten_mon_an = N'" + textBox1.Text + "' AND lm.ten_loai = N'" + comboBox1.Text + "'";
            }
            else if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                query1 += " lm.ten_loai = N'" + comboBox1.Text + "'";
            }
            else if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {
                query1 += " ten_cong_dung = N'" + textBox2.Text + "' AND lm.ten_loai = N'" + comboBox1.Text + "'";
            }

            dataGridView1.DataSource = process.DocBang(query1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 otherForm = new Form1(1,sender);
            otherForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset();
            dataGridView1.DataSource = process.DocBang("select * from MonAn");
        }

        private void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
