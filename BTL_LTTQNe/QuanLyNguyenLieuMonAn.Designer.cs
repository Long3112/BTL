namespace BTL_LTTQNe
{
	partial class QuanLyNguyenLieuMonAn
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtsoluong = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtmanguyenlieu = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtmamonan = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnthem = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
			this.groupBox1.Controls.Add(this.txtsoluong);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtmanguyenlieu);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtmamonan);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(378, 223);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập nguyên liệu món ăn";
			// 
			// txtsoluong
			// 
			this.txtsoluong.Location = new System.Drawing.Point(133, 185);
			this.txtsoluong.Name = "txtsoluong";
			this.txtsoluong.Size = new System.Drawing.Size(223, 20);
			this.txtsoluong.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 19);
			this.label4.TabIndex = 4;
			this.label4.Text = "Số lượng";
			// 
			// txtmanguyenlieu
			// 
			this.txtmanguyenlieu.Location = new System.Drawing.Point(133, 107);
			this.txtmanguyenlieu.Name = "txtmanguyenlieu";
			this.txtmanguyenlieu.Size = new System.Drawing.Size(223, 20);
			this.txtmanguyenlieu.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mã Nguyên Liệu";
			// 
			// txtmamonan
			// 
			this.txtmamonan.Location = new System.Drawing.Point(133, 30);
			this.txtmamonan.Name = "txtmamonan";
			this.txtmamonan.Size = new System.Drawing.Size(223, 20);
			this.txtmamonan.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã món ăn";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// btnthem
			// 
			this.btnthem.Location = new System.Drawing.Point(69, 287);
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(102, 42);
			this.btnthem.TabIndex = 16;
			this.btnthem.Text = "Thêm ";
			this.btnthem.UseVisualStyleBackColor = true;
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(408, 58);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(446, 271);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin nguyên liệu";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(22, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(384, 231);
			this.dataGridView1.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(234, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 42);
			this.button1.TabIndex = 18;
			this.button1.Text = "Quay lại";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// QuanLyNguyenLieuMonAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(866, 373);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnthem);
			this.Controls.Add(this.groupBox1);
			this.Name = "QuanLyNguyenLieuMonAn";
			this.Text = "QuanLyNguyenLieuMonAn";
			this.Load += new System.EventHandler(this.QuanLyNguyenLieuMonAm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtmamonan;
		private System.Windows.Forms.TextBox txtsoluong;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtmanguyenlieu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
	}
}