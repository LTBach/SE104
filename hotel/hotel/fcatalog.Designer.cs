namespace hotel
{
    partial class fcatalog
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
            this.btn_add_room = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnDelRoom = new System.Windows.Forms.Button();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1BindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRoomType = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCusType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add_room
            // 
            this.btn_add_room.Location = new System.Drawing.Point(36, 44);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Size = new System.Drawing.Size(199, 48);
            this.btn_add_room.TabIndex = 3;
            this.btn_add_room.Text = "Thêm";
            this.btn_add_room.UseVisualStyleBackColor = true;
            this.btn_add_room.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(758, 44);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(199, 50);
            this.btnUpdateRoom.TabIndex = 2;
            this.btnUpdateRoom.Text = "Sửa";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.Location = new System.Drawing.Point(398, 44);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.Size = new System.Drawing.Size(199, 46);
            this.btnDelRoom.TabIndex = 1;
            this.btnDelRoom.Text = "Xóa";
            this.btnDelRoom.UseVisualStyleBackColor = true;
            this.btnDelRoom.Click += new System.EventHandler(this.btnDelRoom_Click);
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateRoom);
            this.groupBox1.Controls.Add(this.btn_add_room);
            this.groupBox1.Controls.Add(this.btnDelRoom);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(324, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 679);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenphong,
            this.loaiphong,
            this.dongiaTC,
            this.ghichuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.class1BindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 558);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Phòng";
            this.tenphong.MinimumWidth = 8;
            this.tenphong.Name = "tenphong";
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "tenloaiphong";
            this.loaiphong.HeaderText = "Loại Phòng";
            this.loaiphong.MinimumWidth = 8;
            this.loaiphong.Name = "loaiphong";
            // 
            // dongiaTC
            // 
            this.dongiaTC.DataPropertyName = "dongiaTC";
            this.dongiaTC.HeaderText = "Đơn Giá";
            this.dongiaTC.MinimumWidth = 8;
            this.dongiaTC.Name = "dongiaTC";
            // 
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "ghichu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            // 
            // class1BindingSource5
            // 
            this.class1BindingSource5.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // class1BindingSource4
            // 
            this.class1BindingSource4.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // class1BindingSource2
            // 
            this.class1BindingSource2.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // class1BindingSource1
            // 
            this.class1BindingSource1.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // class1BindingSource3
            // 
            this.class1BindingSource3.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(28, 78);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(233, 38);
            this.txtRoomName.TabIndex = 2;
            this.txtRoomName.TextChanged += new System.EventHandler(this.txtRoomName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Phòng:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(28, 277);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(233, 38);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tình Trạng:";
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Items.AddRange(new object[] {
            ""});
            this.cbbRoomType.Location = new System.Drawing.Point(28, 180);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(233, 39);
            this.cbbRoomType.TabIndex = 10;
            this.cbbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbbRoomType_SelectedIndexChanged);
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            ""});
            this.cbbStatus.Location = new System.Drawing.Point(28, 376);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(233, 39);
            this.cbbStatus.TabIndex = 14;
            this.cbbStatus.SelectedIndexChanged += new System.EventHandler(this.cbbStatus_SelectedIndexChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 431);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRoomType);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 111);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Phòng";
            // 
            // btnRoomType
            // 
            this.btnRoomType.Location = new System.Drawing.Point(71, 46);
            this.btnRoomType.Name = "btnRoomType";
            this.btnRoomType.Size = new System.Drawing.Size(142, 46);
            this.btnRoomType.TabIndex = 0;
            this.btnRoomType.Text = "Chỉnh Sửa";
            this.btnRoomType.UseVisualStyleBackColor = true;
            this.btnRoomType.Click += new System.EventHandler(this.btnRoomType_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCusType);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(12, 578);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 111);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loại Khách Hàng";
            // 
            // btnCusType
            // 
            this.btnCusType.Location = new System.Drawing.Point(71, 40);
            this.btnCusType.Name = "btnCusType";
            this.btnCusType.Size = new System.Drawing.Size(142, 46);
            this.btnCusType.TabIndex = 1;
            this.btnCusType.Text = "Chỉnh Sửa";
            this.btnCusType.UseVisualStyleBackColor = true;
            this.btnCusType.Click += new System.EventHandler(this.btnCusType_Click);
            // 
            // fcatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 707);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "fcatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC PHÒNG";
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnDelRoom;
        private Button btn_add_room;
        private Button btnUpdateRoom;
        private BindingSource class1BindingSource;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn sophongDataGridViewTextBoxColumn;
        private BindingSource class1BindingSource1;
        private BindingSource class1BindingSource2;
        private DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
        private BindingSource class1BindingSource4;
        private BindingSource class1BindingSource3;
        private DataGridView dataGridView1;
        private BindingSource class1BindingSource5;
        private DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenphong;
        private DataGridViewTextBoxColumn loaiphong;
        private DataGridViewTextBoxColumn dongiaTC;
        private DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
        private TextBox txtRoomName;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private Label label5;
        private ComboBox cbbRoomType;
        private ComboBox cbbStatus;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnRoomType;
        private GroupBox groupBox4;
        private Button btnCusType;
    }
}