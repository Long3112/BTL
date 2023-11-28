namespace BTL_LTTQNe
{
    partial class Form1
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
            this.panelBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQLNL = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnPDB = new System.Windows.Forms.Button();
            this.btnQLMA = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelBar.Controls.Add(this.button2);
            this.panelBar.Controls.Add(this.btnQLNL);
            this.panelBar.Controls.Add(this.btnBaoCao);
            this.panelBar.Controls.Add(this.btnPDB);
            this.panelBar.Controls.Add(this.btnQLMA);
            this.panelBar.Controls.Add(this.panel1);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(193, 561);
            this.panelBar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 55);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(75, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "NHÓM_11";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 54);
            this.panel3.TabIndex = 6;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MintCream;
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(193, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(852, 55);
            this.panelTop.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(260, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hệ thống quản lý nguyên liệu và món ăn";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(193, 55);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(852, 506);
            this.panelDesktop.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BTL_LTTQNe.Properties.Resources.ManagementTools_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::BTL_LTTQNe.Properties.Resources.Search;
            this.button1.Location = new System.Drawing.Point(794, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 55);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::BTL_LTTQNe.Properties.Resources.Close;
            this.button2.Location = new System.Drawing.Point(0, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 65);
            this.button2.TabIndex = 8;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQLNL
            // 
            this.btnQLNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNL.FlatAppearance.BorderSize = 0;
            this.btnQLNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNL.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQLNL.Image = global::BTL_LTTQNe.Properties.Resources.Them;
            this.btnQLNL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNL.Location = new System.Drawing.Point(0, 250);
            this.btnQLNL.Name = "btnQLNL";
            this.btnQLNL.Size = new System.Drawing.Size(193, 65);
            this.btnQLNL.TabIndex = 7;
            this.btnQLNL.Text = "Quản lý nguyên liệu";
            this.btnQLNL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNL.UseVisualStyleBackColor = true;
            this.btnQLNL.Click += new System.EventHandler(this.btnQLNL_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoCao.Image = global::BTL_LTTQNe.Properties.Resources.Baocao;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 185);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(193, 65);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Xem thống kê";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnPDB
            // 
            this.btnPDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPDB.FlatAppearance.BorderSize = 0;
            this.btnPDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDB.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPDB.Image = global::BTL_LTTQNe.Properties.Resources.Them;
            this.btnPDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDB.Location = new System.Drawing.Point(0, 120);
            this.btnPDB.Name = "btnPDB";
            this.btnPDB.Size = new System.Drawing.Size(193, 65);
            this.btnPDB.TabIndex = 5;
            this.btnPDB.Text = "Thêm phiếu đặt bàn";
            this.btnPDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDB.UseVisualStyleBackColor = true;
            this.btnPDB.Click += new System.EventHandler(this.btnPDB_Click);
            // 
            // btnQLMA
            // 
            this.btnQLMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLMA.FlatAppearance.BorderSize = 0;
            this.btnQLMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLMA.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQLMA.Image = global::BTL_LTTQNe.Properties.Resources.Them;
            this.btnQLMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLMA.Location = new System.Drawing.Point(0, 55);
            this.btnQLMA.Name = "btnQLMA";
            this.btnQLMA.Size = new System.Drawing.Size(193, 65);
            this.btnQLMA.TabIndex = 2;
            this.btnQLMA.Text = "Quản lý món ăn";
            this.btnQLMA.UseVisualStyleBackColor = true;
            this.btnQLMA.Click += new System.EventHandler(this.btnQLMA_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::BTL_LTTQNe.Properties.Resources.Contacts;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 31);
            this.panel4.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1045, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.Button btnQLMA;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPDB;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnQLNL;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

