namespace QL_TTB2.View
{
    partial class frmQLTHIETBI
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
            this.errId_Type = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errQty_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.cbbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.errId_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDSThietBi = new System.Windows.Forms.DataGridView();
            this.Id_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errFunction_Group = new System.Windows.Forms.ErrorProvider(this.components);
            this.errStatus_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errRoom = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId_Type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFunction_Device = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId_Device = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName_Device = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).BeginInit();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFunction_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRoom)).BeginInit();
            this.grpThongTinTaiKhoan.SuspendLayout();
            this.SuspendLayout();
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
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(12, 9);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(419, 61);
            this.lbl_QLTaiKhoan.TabIndex = 28;
            this.lbl_QLTaiKhoan.Text = "Quản Lý Thiết Bị";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(671, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(61, 37);
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
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.cbbLoaiTimKiem);
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.grp_TimKiem.Location = new System.Drawing.Point(27, 185);
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
            this.cbbLoaiTimKiem.Location = new System.Drawing.Point(384, 28);
            this.cbbLoaiTimKiem.Name = "cbbLoaiTimKiem";
            this.cbbLoaiTimKiem.Size = new System.Drawing.Size(192, 24);
            this.cbbLoaiTimKiem.TabIndex = 4;
            // 
            // errId_Device
            // 
            this.errId_Device.ContainerControl = this;
            // 
            // errPrice
            // 
            this.errPrice.ContainerControl = this;
            // 
            // dgvDSThietBi
            // 
            this.dgvDSThietBi.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvDSThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Device,
            this.Name_Device,
            this.Price,
            this.Function_Device,
            this.Room,
            this.Id_Type,
            this.Status_Device});
            this.dgvDSThietBi.Location = new System.Drawing.Point(9, 277);
            this.dgvDSThietBi.Name = "dgvDSThietBi";
            this.dgvDSThietBi.RowHeadersWidth = 51;
            this.dgvDSThietBi.Size = new System.Drawing.Size(727, 172);
            this.dgvDSThietBi.TabIndex = 31;
            // 
            // Id_Device
            // 
            this.Id_Device.DataPropertyName = "Id_Device";
            this.Id_Device.HeaderText = "Mã Thiết Bị";
            this.Id_Device.MinimumWidth = 6;
            this.Id_Device.Name = "Id_Device";
            this.Id_Device.Width = 90;
            // 
            // Name_Device
            // 
            this.Name_Device.DataPropertyName = "Name_Device";
            this.Name_Device.HeaderText = "Tên Thiết Bị";
            this.Name_Device.MinimumWidth = 6;
            this.Name_Device.Name = "Name_Device";
            this.Name_Device.ReadOnly = true;
            this.Name_Device.Width = 150;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn Gía";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Function_Device
            // 
            this.Function_Device.DataPropertyName = "Function_Device";
            this.Function_Device.HeaderText = "Chức Năng";
            this.Function_Device.MinimumWidth = 6;
            this.Function_Device.Name = "Function_Device";
            this.Function_Device.Width = 120;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Thuộc Phòng";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            // 
            // Id_Type
            // 
            this.Id_Type.DataPropertyName = "Id_Type";
            this.Id_Type.HeaderText = "Mã Loại TB";
            this.Id_Type.MinimumWidth = 6;
            this.Id_Type.Name = "Id_Type";
            // 
            // Status_Device
            // 
            this.Status_Device.DataPropertyName = "Status_Device";
            this.Status_Device.HeaderText = "Trạng Thái";
            this.Status_Device.MinimumWidth = 6;
            this.Status_Device.Name = "Status_Device";
            this.Status_Device.Width = 120;
            // 
            // errFunction_Group
            // 
            this.errFunction_Group.ContainerControl = this;
            // 
            // errStatus_Device
            // 
            this.errStatus_Device.ContainerControl = this;
            // 
            // errRoom
            // 
            this.errRoom.ContainerControl = this;
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
            this.grpThongTinTaiKhoan.Controls.Add(this.txtStatus);
            this.grpThongTinTaiKhoan.Controls.Add(this.label6);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Type);
            this.grpThongTinTaiKhoan.Controls.Add(this.label5);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtRoom);
            this.grpThongTinTaiKhoan.Controls.Add(this.label4);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtFunction_Device);
            this.grpThongTinTaiKhoan.Controls.Add(this.label3);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtPrice);
            this.grpThongTinTaiKhoan.Controls.Add(this.label2);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Device);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtName_Device);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(23, 97);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(851, 374);
            this.grpThongTinTaiKhoan.TabIndex = 29;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(703, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Cập Nhật";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(703, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Thêm ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(598, 56);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(384, 161);
            this.txtStatus.MaxLength = 20;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(139, 20);
            this.txtStatus.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Trạng Thái";
            // 
            // txtId_Type
            // 
            this.txtId_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Type.Location = new System.Drawing.Point(384, 119);
            this.txtId_Type.MaxLength = 20;
            this.txtId_Type.Name = "txtId_Type";
            this.txtId_Type.Size = new System.Drawing.Size(139, 20);
            this.txtId_Type.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã Loại TB";
            // 
            // txtRoom
            // 
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(384, 73);
            this.txtRoom.MaxLength = 20;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(139, 20);
            this.txtRoom.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Thuộc Phòng";
            // 
            // txtFunction_Device
            // 
            this.txtFunction_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFunction_Device.Location = new System.Drawing.Point(384, 29);
            this.txtFunction_Device.MaxLength = 20;
            this.txtFunction_Device.Name = "txtFunction_Device";
            this.txtFunction_Device.Size = new System.Drawing.Size(139, 20);
            this.txtFunction_Device.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Chức Năng";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(104, 119);
            this.txtPrice.MaxLength = 20;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 20);
            this.txtPrice.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Đơn Gía";
            // 
            // txtId_Device
            // 
            this.txtId_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Device.Location = new System.Drawing.Point(104, 35);
            this.txtId_Device.MaxLength = 20;
            this.txtId_Device.Name = "txtId_Device";
            this.txtId_Device.Size = new System.Drawing.Size(140, 20);
            this.txtId_Device.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Thiết Bị";
            // 
            // txtName_Device
            // 
            this.txtName_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Device.Location = new System.Drawing.Point(104, 79);
            this.txtName_Device.MaxLength = 20;
            this.txtName_Device.Name = "txtName_Device";
            this.txtName_Device.Size = new System.Drawing.Size(140, 20);
            this.txtName_Device.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(4, 84);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(72, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên Thiết Bị";
            // 
            // frmQLTHIETBI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 558);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.Name = "frmQLTHIETBI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errId_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).EndInit();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFunction_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRoom)).EndInit();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errId_Type;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.ComboBox cbbLoaiTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Device;
        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFunction_Device;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_Device;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName_Device;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errName_Device;
        private System.Windows.Forms.ErrorProvider errQty_Device;
        private System.Windows.Forms.ErrorProvider errId_Device;
        private System.Windows.Forms.ErrorProvider errPrice;
        private System.Windows.Forms.ErrorProvider errFunction_Group;
        private System.Windows.Forms.ErrorProvider errStatus_Device;
        private System.Windows.Forms.ErrorProvider errRoom;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLamMoi;
    }
}