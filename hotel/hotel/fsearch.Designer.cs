namespace hotel
{
    partial class fsearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1BindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.class1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(401, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1169, 849);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phongDataGridViewTextBoxColumn,
            this.TenPhong,
            this.TenLoaiPhong,
            this.dongiaTC,
            this.tinhtrangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.class1BindingSource5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 804);
            this.dataGridView1.TabIndex = 0;
            // 
            // phongDataGridViewTextBoxColumn
            // 
            this.phongDataGridViewTextBoxColumn.DataPropertyName = "maphong";
            this.phongDataGridViewTextBoxColumn.HeaderText = "Mã Phòng";
            this.phongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phongDataGridViewTextBoxColumn.Name = "phongDataGridViewTextBoxColumn";
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "Tenphong";
            this.TenPhong.HeaderText = "Phòng";
            this.TenPhong.MinimumWidth = 8;
            this.TenPhong.Name = "TenPhong";
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            this.TenLoaiPhong.HeaderText = "Loại Phòng";
            this.TenLoaiPhong.MinimumWidth = 8;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // dongiaTC
            // 
            this.dongiaTC.DataPropertyName = "DonGiaTC";
            this.dongiaTC.HeaderText = "Đơn Giá";
            this.dongiaTC.MinimumWidth = 8;
            this.dongiaTC.Name = "dongiaTC";
            // 
            // tinhtrangDataGridViewTextBoxColumn
            // 
            this.tinhtrangDataGridViewTextBoxColumn.DataPropertyName = "tinhtrang";
            this.tinhtrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhtrangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tinhtrangDataGridViewTextBoxColumn.Name = "tinhtrangDataGridViewTextBoxColumn";
            // 
            // class1BindingSource5
            // 
            this.class1BindingSource5.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // class1BindingSource4
            // 
            this.class1BindingSource4.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // class1BindingSource3
            // 
            this.class1BindingSource3.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // class1BindingSource2
            // 
            this.class1BindingSource2.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtRoomId);
            this.groupBox3.Controls.Add(this.btn_reserve);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(11, 612);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(382, 251);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đặt Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Phòng:";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(50, 86);
            this.txtRoomId.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(248, 44);
            this.txtRoomId.TabIndex = 4;
            // 
            // btn_reserve
            // 
            this.btn_reserve.Location = new System.Drawing.Point(50, 168);
            this.btn_reserve.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(249, 60);
            this.btn_reserve.TabIndex = 3;
            this.btn_reserve.Text = "Đặt Phòng";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbStatus);
            this.groupBox2.Controls.Add(this.cbbRoomType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRoomName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(11, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(382, 590);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tìm Kiếm";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            ""});
            this.cbbStatus.Location = new System.Drawing.Point(35, 457);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(290, 46);
            this.cbbStatus.TabIndex = 14;
            this.cbbStatus.SelectedIndexChanged += new System.EventHandler(this.cbbStatus_SelectedIndexChanged);
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Items.AddRange(new object[] {
            ""});
            this.cbbRoomType.Location = new System.Drawing.Point(35, 219);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(290, 46);
            this.cbbRoomType.TabIndex = 10;
            this.cbbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbbRoomType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tình Trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(35, 338);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(290, 44);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Phòng:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(35, 102);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(290, 44);
            this.txtRoomName.TabIndex = 2;
            this.txtRoomName.TextChanged += new System.EventHandler(this.txtRoomName_TextChanged);
            // 
            // class1BindingSource1
            // 
            this.class1BindingSource1.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // fsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 875);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fsearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fsearch_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox txtRoomId;
        private Button btn_reserve;
        private GroupBox groupBox2;
        private ComboBox cbbRoomType;
        private Label label5;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private Label label2;
        private TextBox txtRoomName;
        private BindingSource class1BindingSource;
        private DataGridView dataGridView1;
        private BindingSource class1BindingSource2;
        private BindingSource class1BindingSource1;
        private ComboBox cbbStatus;
        private DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private BindingSource class1BindingSource3;
        private BindingSource class1BindingSource4;
        private BindingSource class1BindingSource5;
        private DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TenPhong;
        private DataGridViewTextBoxColumn TenLoaiPhong;
        private DataGridViewTextBoxColumn dongiaTC;
        private DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
    }
}