namespace HQT_QuanLyThietBi
{
    partial class ChonThoiGianForm
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
            this.dap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonXong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dap.Location = new System.Drawing.Point(23, 40);
            this.dap.Name = "dateTimePicker1";
            this.dap.Size = new System.Drawing.Size(200, 20);
            this.dap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn thời gian";
            // 
            // btnChonXong
            // 
            this.btnChonXong.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChonXong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonXong.ForeColor = System.Drawing.Color.White;
            this.btnChonXong.Location = new System.Drawing.Point(89, 93);
            this.btnChonXong.Name = "btnChonXong";
            this.btnChonXong.Size = new System.Drawing.Size(75, 23);
            this.btnChonXong.TabIndex = 2;
            this.btnChonXong.Text = "Chọn xong";
            this.btnChonXong.UseVisualStyleBackColor = false;
            this.btnChonXong.Click += new System.EventHandler(this.btnChonXong_Click);
            // 
            // ChonThoiGianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(245, 128);
            this.Controls.Add(this.btnChonXong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChonThoiGianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChonThoiGianForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonXong;
    }
}