namespace hotel
{
    partial class fbill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelRental = new System.Windows.Forms.Button();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateBill = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPayBill = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.dataBill = new System.Windows.Forms.DataGridView();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.hoaDonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelRental);
            this.groupBox1.Controls.Add(this.btnAddRental);
            this.groupBox1.Controls.Add(this.txtRoomName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(460, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng Thanh Toán";
            // 
            // btnDelRental
            // 
            this.btnDelRental.Location = new System.Drawing.Point(248, 135);
            this.btnDelRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelRental.Name = "btnDelRental";
            this.btnDelRental.Size = new System.Drawing.Size(168, 51);
            this.btnDelRental.TabIndex = 3;
            this.btnDelRental.Text = "Xóa";
            this.btnDelRental.UseVisualStyleBackColor = true;
            this.btnDelRental.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnAddRental
            // 
            this.btnAddRental.Location = new System.Drawing.Point(31, 135);
            this.btnAddRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(156, 51);
            this.btnAddRental.TabIndex = 2;
            this.btnAddRental.Text = "Thêm";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(196, 55);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(218, 44);
            this.txtRoomName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateBill);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPayer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(501, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(831, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hóa Đơn";
            // 
            // dateBill
            // 
            this.dateBill.Location = new System.Drawing.Point(366, 160);
            this.dateBill.Margin = new System.Windows.Forms.Padding(4);
            this.dateBill.Name = "dateBill";
            this.dateBill.Size = new System.Drawing.Size(453, 44);
            this.dateBill.TabIndex = 6;
            this.dateBill.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Lập Hóa Đơn:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(366, 104);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(453, 44);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ:";
            // 
            // txtPayer
            // 
            this.txtPayer.Location = new System.Drawing.Point(366, 46);
            this.txtPayer.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayer.Name = "txtPayer";
            this.txtPayer.Size = new System.Drawing.Size(453, 44);
            this.txtPayer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách Hàng/ Cơ Quan:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPayBill);
            this.groupBox3.Controls.Add(this.lbTotalPrice);
            this.groupBox3.Controls.Add(this.dataBill);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(15, 220);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1318, 642);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phiếu Thuê:";
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(1097, 584);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(187, 51);
            this.btnPayBill.TabIndex = 10;
            this.btnPayBill.Text = "Thanh Toán";
            this.btnPayBill.UseVisualStyleBackColor = true;
            this.btnPayBill.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(139, 597);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(32, 38);
            this.lbTotalPrice.TabIndex = 9;
            this.lbTotalPrice.Text = "0";
            // 
            // dataBill
            // 
            this.dataBill.AutoGenerateColumns = false;
            this.dataBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phong,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataBill.DataSource = this.hoaDonBindingSource2;
            this.dataBill.Location = new System.Drawing.Point(0, 70);
            this.dataBill.Name = "dataBill";
            this.dataBill.RowHeadersWidth = 62;
            this.dataBill.RowTemplate.Height = 33;
            this.dataBill.Size = new System.Drawing.Size(1317, 508);
            this.dataBill.TabIndex = 8;
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "TenPhong";
            this.Phong.HeaderText = "Phòng";
            this.Phong.MinimumWidth = 8;
            this.Phong.Name = "Phong";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SoNgayThue";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số Ngày Thuê";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn4.HeaderText = "Thành Tiền";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // hoaDonBindingSource2
            // 
            this.hoaDonBindingSource2.DataSource = typeof(hotel.HoaDon);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 597);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trị Giá:";
            // 
            // hoaDonBindingSource1
            // 
            this.hoaDonBindingSource1.DataSource = typeof(hotel.HoaDon);
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(hotel.HoaDon);
            // 
            // fbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 865);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "fbill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnDelRental;
        private Button btnAddRental;
        private TextBox txtRoomName;
        private GroupBox groupBox2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtPayer;
        private Label label2;
        private GroupBox groupBox3;
        private BindingSource class1BindingSource;
        private DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn songaythueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private DateTimePicker dateBill;
        private Label label4;
        private Label label5;
        private BindingSource hoaDonBindingSource;
        private DataGridViewTextBoxColumn dpnGiaDataGridViewTextBoxColumn;
        private BindingSource hoaDonBindingSource1;
        private DataGridView dataBill;
        private BindingSource hoaDonBindingSource2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnPayBill;
        private Label lbTotalPrice;
        private DataGridViewTextBoxColumn Phong;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}