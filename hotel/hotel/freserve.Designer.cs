namespace hotel
{
    partial class freserve
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
            this.btn_del_custome = new System.Windows.Forms.Button();
            this.btn_add_customer = new System.Windows.Forms.Button();
            this.cbbCustomerType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNational_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPeopleNum = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.lbRoomName = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenKHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_del_custome);
            this.groupBox1.Controls.Add(this.btn_add_customer);
            this.groupBox1.Controls.Add(this.cbbCustomerType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNational_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(600, 636);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_del_custome
            // 
            this.btn_del_custome.Location = new System.Drawing.Point(320, 561);
            this.btn_del_custome.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del_custome.Name = "btn_del_custome";
            this.btn_del_custome.Size = new System.Drawing.Size(229, 64);
            this.btn_del_custome.TabIndex = 9;
            this.btn_del_custome.Text = "Xóa";
            this.btn_del_custome.UseVisualStyleBackColor = true;
            this.btn_del_custome.Click += new System.EventHandler(this.btn_del_custome_Click);
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.Location = new System.Drawing.Point(24, 561);
            this.btn_add_customer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.Size = new System.Drawing.Size(229, 64);
            this.btn_add_customer.TabIndex = 8;
            this.btn_add_customer.Text = "Thêm";
            this.btn_add_customer.UseVisualStyleBackColor = true;
            this.btn_add_customer.Click += new System.EventHandler(this.btn_add_customer_Click);
            // 
            // cbbCustomerType
            // 
            this.cbbCustomerType.FormattingEnabled = true;
            this.cbbCustomerType.Location = new System.Drawing.Point(24, 480);
            this.cbbCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCustomerType.Name = "cbbCustomerType";
            this.cbbCustomerType.Size = new System.Drawing.Size(524, 46);
            this.cbbCustomerType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại Khách Hàng:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(24, 346);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(524, 44);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa Chỉ:";
            // 
            // txtNational_ID
            // 
            this.txtNational_ID.Location = new System.Drawing.Point(24, 219);
            this.txtNational_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtNational_ID.Name = "txtNational_ID";
            this.txtNational_ID.Size = new System.Drawing.Size(524, 44);
            this.txtNational_ID.TabIndex = 3;
            this.txtNational_ID.TextChanged += new System.EventHandler(this.txtNational_ID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "CMND\\CCCD:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(524, 44);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPeopleNum);
            this.groupBox2.Controls.Add(this.lbPrice);
            this.groupBox2.Controls.Add(this.lbRoomType);
            this.groupBox2.Controls.Add(this.lbRoomName);
            this.groupBox2.Controls.Add(this.btnReserve);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(14, 645);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(600, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phòng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbPeopleNum
            // 
            this.lbPeopleNum.AutoSize = true;
            this.lbPeopleNum.Location = new System.Drawing.Point(264, 226);
            this.lbPeopleNum.Name = "lbPeopleNum";
            this.lbPeopleNum.Size = new System.Drawing.Size(0, 38);
            this.lbPeopleNum.TabIndex = 14;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(264, 174);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(0, 38);
            this.lbPrice.TabIndex = 13;
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Location = new System.Drawing.Point(264, 116);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(0, 38);
            this.lbRoomType.TabIndex = 12;
            // 
            // lbRoomName
            // 
            this.lbRoomName.AutoSize = true;
            this.lbRoomName.Location = new System.Drawing.Point(264, 65);
            this.lbRoomName.Name = "lbRoomName";
            this.lbRoomName.Size = new System.Drawing.Size(0, 38);
            this.lbRoomName.TabIndex = 11;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(406, 226);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(186, 104);
            this.btnReserve.TabIndex = 10;
            this.btnReserve.Text = "Nhận Phòng";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 38);
            this.label9.TabIndex = 4;
            this.label9.Text = "Đơn Giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 38);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số Người Thuê:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 38);
            this.label7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Phòng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(636, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1268, 974);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu Thuê Phòng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(319, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(459, 44);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenKHDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.khachHangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 831);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tenKHDataGridViewTextBoxColumn1
            // 
            this.tenKHDataGridViewTextBoxColumn1.DataPropertyName = "tenKH";
            this.tenKHDataGridViewTextBoxColumn1.HeaderText = "Khách Hàng";
            this.tenKHDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tenKHDataGridViewTextBoxColumn1.Name = "tenKHDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "loaiKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Loại Khách";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cmnd";
            this.dataGridViewTextBoxColumn2.HeaderText = "CMND/CCCD";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "diachi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(hotel.PhieuThue.KhachHang);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 38);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày Bắt Đầu Thuê:";
            // 
            // freserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 979);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "freserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_add_customer;
        private ComboBox cbbCustomerType;
        private Label label4;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtNational_ID;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private GroupBox groupBox3;
        private Label label10;
        private DataGridViewTextBoxColumn loaiKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cmndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private BindingSource class1BindingSource;
        private Button btnReserve;
        private BindingSource khachHangBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button btn_del_custome;
        private Label lbRoomType;
        private Label lbRoomName;
        private Label lbPeopleNum;
        private Label lbPrice;
        private DateTimePicker dateTimePicker1;
    }
}