namespace QL_TTB2.View
{
    partial class frmQLChucVu
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
            this.components = new System.ComponentModel.Container();
            this.errRoom = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.dgvDSThietBi = new System.Windows.Forms.DataGridView();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.cbbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtId_Device = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName_Device = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.errStatus_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errId_Type = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errQty_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_QLQuyen = new System.Windows.Forms.Label();
            this.errId_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errFunction_Group = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errRoom)).BeginInit();
            this.grpThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).BeginInit();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFunction_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // errRoom
            // 
            this.errRoom.ContainerControl = this;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(706, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Cập Nhật";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Thêm ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(601, 36);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.Controls.Add(this.button4);
            this.grpThongTinTaiKhoan.Controls.Add(this.dgvDSThietBi);
            this.grpThongTinTaiKhoan.Controls.Add(this.grp_TimKiem);
            this.grpThongTinTaiKhoan.Controls.Add(this.button3);
            this.grpThongTinTaiKhoan.Controls.Add(this.button2);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Device);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtName_Device);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(12, 49);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(795, 389);
            this.grpThongTinTaiKhoan.TabIndex = 31;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin";
            // 
            // dgvDSThietBi
            // 
            this.dgvDSThietBi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Device,
            this.MaCV});
            this.dgvDSThietBi.Location = new System.Drawing.Point(125, 193);
            this.dgvDSThietBi.Name = "dgvDSThietBi";
            this.dgvDSThietBi.RowHeadersWidth = 51;
            this.dgvDSThietBi.Size = new System.Drawing.Size(551, 172);
            this.dgvDSThietBi.TabIndex = 31;
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.cbbLoaiTimKiem);
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.grp_TimKiem.Location = new System.Drawing.Point(25, 118);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(751, 58);
            this.grp_TimKiem.TabIndex = 30;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // cbbLoaiTimKiem
            // 
            this.cbbLoaiTimKiem.FormattingEnabled = true;
            this.cbbLoaiTimKiem.Items.AddRange(new object[] {
            "Mã Thiết Bị",
            "Tên Thiết Bị",
            "Mã Loại Thiết Bị",
            "Phòng Học"});
            this.cbbLoaiTimKiem.Location = new System.Drawing.Point(384, 25);
            this.cbbLoaiTimKiem.Name = "cbbLoaiTimKiem";
            this.cbbLoaiTimKiem.Size = new System.Drawing.Size(192, 24);
            this.cbbLoaiTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Azure;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(664, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(61, 36);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(8, 28);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(292, 22);
            this.txtTimKiem.TabIndex = 0;
            // 
            // txtId_Device
            // 
            this.txtId_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Device.Location = new System.Drawing.Point(220, 39);
            this.txtId_Device.MaxLength = 20;
            this.txtId_Device.Name = "txtId_Device";
            this.txtId_Device.Size = new System.Drawing.Size(241, 20);
            this.txtId_Device.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Quyền";
            // 
            // txtName_Device
            // 
            this.txtName_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Device.Location = new System.Drawing.Point(220, 79);
            this.txtName_Device.MaxLength = 20;
            this.txtName_Device.Name = "txtName_Device";
            this.txtName_Device.Size = new System.Drawing.Size(241, 20);
            this.txtName_Device.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(111, 84);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên Quyền";
            // 
            // errStatus_Device
            // 
            this.errStatus_Device.ContainerControl = this;
            // 
            // errId_Type
            // 
            this.errId_Type.ContainerControl = this;
            // 
            // errName_Device
            // 
            this.errName_Device.ContainerControl = this;
            // 
            // errQty_Device
            // 
            this.errQty_Device.ContainerControl = this;
            // 
            // lbl_QLQuyen
            // 
            this.lbl_QLQuyen.AutoSize = true;
            this.lbl_QLQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLQuyen.Location = new System.Drawing.Point(257, 9);
            this.lbl_QLQuyen.Name = "lbl_QLQuyen";
            this.lbl_QLQuyen.Size = new System.Drawing.Size(249, 37);
            this.lbl_QLQuyen.TabIndex = 30;
            this.lbl_QLQuyen.Text = "Quản Lý Quyền ";
            // 
            // errId_Device
            // 
            this.errId_Device.ContainerControl = this;
            // 
            // errPrice
            // 
            this.errPrice.ContainerControl = this;
            // 
            // errFunction_Group
            // 
            this.errFunction_Group.ContainerControl = this;
            // 
            // Id_Device
            // 
            this.Id_Device.DataPropertyName = "Id_Device";
            this.Id_Device.HeaderText = "Mã Quyền";
            this.Id_Device.MinimumWidth = 6;
            this.Id_Device.Name = "Id_Device";
            this.Id_Device.Width = 250;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "Name_Device";
            this.MaCV.HeaderText = "Tên quyền";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            this.MaCV.Width = 250;
            // 
            // frmQLChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.Controls.Add(this.lbl_QLQuyen);
            this.Name = "frmQLChucVu";
            this.Text = "Màn hình quản lý Quyền";
            ((System.ComponentModel.ISupportInitialize)(this.errRoom)).EndInit();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).EndInit();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFunction_Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errRoom;
        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvDSThietBi;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.ComboBox cbbLoaiTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtId_Device;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName_Device;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lbl_QLQuyen;
        private System.Windows.Forms.ErrorProvider errStatus_Device;
        private System.Windows.Forms.ErrorProvider errId_Type;
        private System.Windows.Forms.ErrorProvider errName_Device;
        private System.Windows.Forms.ErrorProvider errQty_Device;
        private System.Windows.Forms.ErrorProvider errId_Device;
        private System.Windows.Forms.ErrorProvider errPrice;
        private System.Windows.Forms.ErrorProvider errFunction_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
    }
}