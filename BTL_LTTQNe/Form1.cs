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
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int i, object sender)
        {
            InitializeComponent();
            if (i == 1)
            {
                OpenChildForm(new FormTimKiem(), sender,"Tìm kiếm");
            }
            if (i == 2)
            {
                OpenChildForm(new FormTimkiemMonAn(), sender, "Tìm kiếm");
            }
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableBtn(); // tat mau nut khac khi an
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(27, 110, 59);
                    // mau nut khi nhan
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableBtn()
        {
            foreach(Control previous in panelBar.Controls) // duyet qua tat ca cac control trong panel
            {
                if(previous.GetType() == typeof(Button)) // neu control do la button
                {
                    previous.BackColor = Color.FromArgb(60, 179, 113);
                    previous.ForeColor = Color.White;
                    previous.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            {

            }
        }

        public void OpenChildForm(Form childForm, object btnSender,string title)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // fill form vao panel
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = title;
        }


        private void btnQLMA_Click(object sender, EventArgs e)
        {
            string title = "Quản lý món ăn";
            ActiveButton(sender);
            QuanLyMonAn form = new QuanLyMonAn();
            OpenChildForm(new QuanLyMonAn(), sender,title);
        }

        private void btnPDB_Click(object sender, EventArgs e)
        {
            string title = "Quản lý phiếu đặt bàn";
            ActiveButton(sender);
            OpenChildForm(new QuanLyPhieuDatBan(), sender, title);

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string title = "Báo cáo";
            ActiveButton(sender);
            OpenChildForm(new FormBaocao(), sender, title);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string title = "Tìm kiếm";
            OpenChildForm(new FormTimKiem(), sender, title);
        }

        private void btnQLNL_Click(object sender, EventArgs e)
        {
            string title = "Quản lý nguyên liệu";
            ActiveButton(sender);
            OpenChildForm(new FormQLNguyenLieu(), sender, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
