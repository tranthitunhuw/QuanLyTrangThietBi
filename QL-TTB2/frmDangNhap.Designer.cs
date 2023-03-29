using System.Windows.Forms;

namespace QL_TTB2
{
    partial class frmDangNhap
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
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbND = new System.Windows.Forms.RadioButton();
            this.rdbQTV = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkNhoMK = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(33, 317);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(94, 23);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(193, 317);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbND);
            this.panel1.Controls.Add(this.rdbQTV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 312);
            this.panel1.TabIndex = 10;
            // 
            // rdbND
            // 
            this.rdbND.AutoSize = true;
            this.rdbND.Location = new System.Drawing.Point(181, 279);
            this.rdbND.Name = "rdbND";
            this.rdbND.Size = new System.Drawing.Size(80, 17);
            this.rdbND.TabIndex = 11;
            this.rdbND.TabStop = true;
            this.rdbND.Text = "Người dùng";
            this.rdbND.UseVisualStyleBackColor = true;
            // 
            // rdbQTV
            // 
            this.rdbQTV.AutoSize = true;
            this.rdbQTV.Location = new System.Drawing.Point(36, 279);
            this.rdbQTV.Name = "rdbQTV";
            this.rdbQTV.Size = new System.Drawing.Size(85, 17);
            this.rdbQTV.TabIndex = 10;
            this.rdbQTV.TabStop = true;
            this.rdbQTV.Text = "Quản trị viên";
            this.rdbQTV.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::QL_TTB2.Properties.Resources.username_2;
            this.pictureBox1.Location = new System.Drawing.Point(29, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.chkNhoMK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbMatKhau);
            this.groupBox1.Controls.Add(this.txbTaiKhoan);
            this.groupBox1.Location = new System.Drawing.Point(21, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(8, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 2);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 2);
            this.panel2.TabIndex = 12;
            // 
            // chkNhoMK
            // 
            this.chkNhoMK.AutoSize = true;
            this.chkNhoMK.Location = new System.Drawing.Point(105, 107);
            this.chkNhoMK.Name = "chkNhoMK";
            this.chkNhoMK.Size = new System.Drawing.Size(93, 17);
            this.chkNhoMK.TabIndex = 11;
            this.chkNhoMK.Text = "Nhớ mật khẩu";
            this.chkNhoMK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khấu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tài khoản:";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(105, 68);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '*';
            this.txbMatKhau.Size = new System.Drawing.Size(161, 20);
            this.txbMatKhau.TabIndex = 8;
            this.txbMatKhau.Text = "Mật khẩu";
            this.txbMatKhau.Click += new System.EventHandler(this.txbMatKhau_Click);
            this.txbMatKhau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbMatKhau_MouseClick);
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Location = new System.Drawing.Point(105, 31);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(161, 20);
            this.txbTaiKhoan.TabIndex = 7;
            this.txbTaiKhoan.Text = "Tên tài khoản";
            this.txbTaiKhoan.Click += new System.EventHandler(this.txbTaiKhoan_Click);
            this.txbTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbTaiKhoan_MouseClick);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "frmDangNhap";
            this.Text = "Màn hình đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.CheckBox chkNhoMK;
        private System.Windows.Forms.TextBox txbTaiKhoan;

        

     /*   private void btnDangNhap_Click_1(object sender, System.EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txbTaiKhoan.Text;
            thongbao += "\n\rMật khẩu là:";
            thongbao += this.txbMatKhau.Text;
            if (this.chkNhoMK.Checked == true)
                thongbao += "\n\rBạn có ghi nhớ.";
            MessageBox.Show(thongbao, "Thông báo");
            //// 
            ///
            if((this.txbTaiKhoan.Text == "") || (this.txbMatKhau.Text == ""))
             MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            else
            {
                if ((this.txbTaiKhoan.Text == "admin") && (this.txbMatKhau.Text == "123456"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txbTaiKhoan.Clear();
                    this.txbMatKhau.Clear(); this.txbTaiKhoan.Focus();
                }
            }
        }*/

        /*private void btnThoat_Click(object sender, System.EventArgs e)
        {
            
            ////
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
            ////
            /////
           

        }*/

        private RadioButton rdbND;
        private RadioButton rdbQTV;
        private Panel panel3;
        private Panel panel2;
    }
}
