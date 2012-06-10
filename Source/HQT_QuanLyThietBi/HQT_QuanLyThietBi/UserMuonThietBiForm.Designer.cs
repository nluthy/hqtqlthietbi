namespace HQT_QuanLyThietBi
{
    partial class UserMuonThietBiForm
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
            this.btnXemThietBi = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachMuon = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cobLoai = new System.Windows.Forms.ComboBox();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBiMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemThietBi
            // 
            this.btnXemThietBi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXemThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemThietBi.ForeColor = System.Drawing.Color.White;
            this.btnXemThietBi.Location = new System.Drawing.Point(913, 115);
            this.btnXemThietBi.Name = "btnXemThietBi";
            this.btnXemThietBi.Size = new System.Drawing.Size(99, 33);
            this.btnXemThietBi.TabIndex = 4;
            this.btnXemThietBi.Text = "Xóa";
            this.btnXemThietBi.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::HQT_QuanLyThietBi.Properties.Resources.ButtonExit;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(937, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 43);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::HQT_QuanLyThietBi.Properties.Resources.ButtonMinimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Location = new System.Drawing.Point(847, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 43);
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToOrderColumns = true;
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThietBi,
            this.Loai});
            this.dgvThietBi.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvThietBi.Location = new System.Drawing.Point(15, 72);
            this.dgvThietBi.MultiSelect = false;
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.ReadOnly = true;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(354, 411);
            this.dgvThietBi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.cobLoai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvThietBi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(33, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 502);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(394, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "MƯỢN THIẾT BỊ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 625);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.dgvDanhSachMuon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(501, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 502);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mượn";
            // 
            // dgvDanhSachMuon
            // 
            this.dgvDanhSachMuon.AllowUserToOrderColumns = true;
            this.dgvDanhSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachMuon.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvDanhSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThietBiMuon,
            this.ThoiGianMuon});
            this.dgvDanhSachMuon.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvDanhSachMuon.Location = new System.Drawing.Point(15, 40);
            this.dgvDanhSachMuon.Name = "dgvDanhSachMuon";
            this.dgvDanhSachMuon.ReadOnly = true;
            this.dgvDanhSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMuon.Size = new System.Drawing.Size(358, 443);
            this.dgvDanhSachMuon.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(426, 299);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 33);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = ">>";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(913, 177);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(99, 33);
            this.btnXacNhan.TabIndex = 20;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại thiết bị";
            // 
            // cobLoai
            // 
            this.cobLoai.FormattingEnabled = true;
            this.cobLoai.Location = new System.Drawing.Point(106, 26);
            this.cobLoai.Name = "cobLoai";
            this.cobLoai.Size = new System.Drawing.Size(121, 24);
            this.cobLoai.TabIndex = 2;
            this.cobLoai.SelectedIndexChanged += new System.EventHandler(this.cobLoai_SelectedIndexChanged);
            // 
            // TenThietBi
            // 
            this.TenThietBi.HeaderText = "Tên thiết bị";
            this.TenThietBi.Name = "TenThietBi";
            // 
            // Loai
            // 
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            // 
            // TenThietBiMuon
            // 
            this.TenThietBiMuon.HeaderText = "Tên thiết bị";
            this.TenThietBiMuon.Name = "TenThietBiMuon";
            // 
            // ThoiGianMuon
            // 
            this.ThoiGianMuon.HeaderText = "Thời gian mượn";
            this.ThoiGianMuon.Name = "ThoiGianMuon";
            // 
            // UserMuonThietBiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXemThietBi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMuonThietBiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMuonThietBiForm";
            this.Load += new System.EventHandler(this.UserMuonThietBiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemThietBi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachMuon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cobLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBiMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianMuon;
    }
}