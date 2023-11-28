namespace BTL_LTTQNe
{
    partial class FormBaocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnTHNX = new System.Windows.Forms.Button();
            this.btnTKTTMA = new System.Windows.Forms.Button();
            this.btnTKPDB = new System.Windows.Forms.Button();
            this.btnTongTienPDB = new System.Windows.Forms.Button();
            this.cbThangPDB = new System.Windows.Forms.ComboBox();
            this.cbQuyPDB = new System.Windows.Forms.ComboBox();
            this.cbNamPDB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnTHNX);
            this.panel1.Controls.Add(this.btnTKPDB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvThongKe);
            this.panel1.Controls.Add(this.btnTKTTMA);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTongTienPDB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbThangPDB);
            this.panel1.Controls.Add(this.cbNamPDB);
            this.panel1.Controls.Add(this.cbQuyPDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 483);
            this.panel1.TabIndex = 0;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 0);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(821, 340);
            this.dgvThongKe.TabIndex = 0;
            this.dgvThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTHNX
            // 
            this.btnTHNX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHNX.Location = new System.Drawing.Point(556, 381);
            this.btnTHNX.Margin = new System.Windows.Forms.Padding(2);
            this.btnTHNX.Name = "btnTHNX";
            this.btnTHNX.Size = new System.Drawing.Size(107, 80);
            this.btnTHNX.TabIndex = 5;
            this.btnTHNX.Text = "Thống kê nhập xuất nguyên liệu";
            this.btnTHNX.UseVisualStyleBackColor = true;
            this.btnTHNX.Click += new System.EventHandler(this.btnTHNX_Click);
            // 
            // btnTKTTMA
            // 
            this.btnTKTTMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKTTMA.Location = new System.Drawing.Point(287, 381);
            this.btnTKTTMA.Margin = new System.Windows.Forms.Padding(2);
            this.btnTKTTMA.Name = "btnTKTTMA";
            this.btnTKTTMA.Size = new System.Drawing.Size(112, 79);
            this.btnTKTTMA.TabIndex = 4;
            this.btnTKTTMA.Text = "Thống kê thông tin món ăn";
            this.btnTKTTMA.UseVisualStyleBackColor = true;
            this.btnTKTTMA.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTKPDB
            // 
            this.btnTKPDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKPDB.Location = new System.Drawing.Point(423, 381);
            this.btnTKPDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnTKPDB.Name = "btnTKPDB";
            this.btnTKPDB.Size = new System.Drawing.Size(107, 80);
            this.btnTKPDB.TabIndex = 6;
            this.btnTKPDB.Text = "Thống kê phiếu đặt bàn";
            this.btnTKPDB.UseVisualStyleBackColor = true;
            this.btnTKPDB.Click += new System.EventHandler(this.btnTKPDB_Click);
            // 
            // btnTongTienPDB
            // 
            this.btnTongTienPDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongTienPDB.Location = new System.Drawing.Point(151, 380);
            this.btnTongTienPDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnTongTienPDB.Name = "btnTongTienPDB";
            this.btnTongTienPDB.Size = new System.Drawing.Size(107, 80);
            this.btnTongTienPDB.TabIndex = 7;
            this.btnTongTienPDB.Text = "Thống kê tổng tiền phiếu đặt bàn";
            this.btnTongTienPDB.UseVisualStyleBackColor = true;
            this.btnTongTienPDB.Click += new System.EventHandler(this.btnTongTienPDB_Click);
            // 
            // cbThangPDB
            // 
            this.cbThangPDB.FormattingEnabled = true;
            this.cbThangPDB.Location = new System.Drawing.Point(56, 381);
            this.cbThangPDB.Name = "cbThangPDB";
            this.cbThangPDB.Size = new System.Drawing.Size(78, 21);
            this.cbThangPDB.TabIndex = 11;
            // 
            // cbQuyPDB
            // 
            this.cbQuyPDB.FormattingEnabled = true;
            this.cbQuyPDB.Location = new System.Drawing.Point(56, 409);
            this.cbQuyPDB.Name = "cbQuyPDB";
            this.cbQuyPDB.Size = new System.Drawing.Size(78, 21);
            this.cbQuyPDB.TabIndex = 12;
            // 
            // cbNamPDB
            // 
            this.cbNamPDB.FormattingEnabled = true;
            this.cbNamPDB.Location = new System.Drawing.Point(56, 437);
            this.cbNamPDB.Name = "cbNamPDB";
            this.cbNamPDB.Size = new System.Drawing.Size(78, 21);
            this.cbNamPDB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tháng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Năm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(690, 380);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(107, 80);
            this.btnExcel.TabIndex = 17;
            this.btnExcel.Text = "Xuất excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FormBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 483);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBaocao";
            this.Text = "FormBaocao";
            this.Load += new System.EventHandler(this.FormBaocao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnTHNX;
        private System.Windows.Forms.Button btnTKTTMA;
        private System.Windows.Forms.Button btnTKPDB;
        private System.Windows.Forms.Button btnTongTienPDB;
        private System.Windows.Forms.ComboBox cbThangPDB;
        private System.Windows.Forms.ComboBox cbQuyPDB;
        private System.Windows.Forms.ComboBox cbNamPDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcel;
    }
}