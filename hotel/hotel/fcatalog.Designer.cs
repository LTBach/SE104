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
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnDelRoom = new System.Windows.Forms.Button();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataCatalog = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataCatalog)).BeginInit();
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
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(45, 55);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(249, 60);
            this.btnAddRoom.TabIndex = 3;
            this.btnAddRoom.Text = "Thêm";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(948, 55);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(249, 62);
            this.btnUpdateRoom.TabIndex = 2;
            this.btnUpdateRoom.Text = "Sửa";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.Location = new System.Drawing.Point(498, 55);
            this.btnDelRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.Size = new System.Drawing.Size(249, 58);
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
            this.groupBox1.Controls.Add(this.btnAddRoom);
            this.groupBox1.Controls.Add(this.btnDelRoom);
            this.groupBox1.Controls.Add(this.dataCatalog);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(405, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1264, 849);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // dataCatalog
            // 
            this.dataCatalog.AutoGenerateColumns = false;
            this.dataCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenphong,
            this.loaiphong,
            this.dongiaTC,
            this.ghichuDataGridViewTextBoxColumn});
            this.dataCatalog.DataSource = this.class1BindingSource5;
            this.dataCatalog.Location = new System.Drawing.Point(0, 144);
            this.dataCatalog.Margin = new System.Windows.Forms.Padding(4);
            this.dataCatalog.Name = "dataCatalog";
            this.dataCatalog.RowHeadersWidth = 51;
            this.dataCatalog.RowTemplate.Height = 29;
            this.dataCatalog.Size = new System.Drawing.Size(1262, 698);
            this.dataCatalog.TabIndex = 0;
            this.dataCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.txtRoomName.Location = new System.Drawing.Point(35, 98);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(290, 44);
            this.txtRoomName.TabIndex = 2;
            this.txtRoomName.TextChanged += new System.EventHandler(this.txtRoomName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Phòng:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(35, 346);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(290, 44);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tình Trạng:";
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Items.AddRange(new object[] {
            ""});
            this.cbbRoomType.Location = new System.Drawing.Point(35, 225);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(290, 46);
            this.cbbRoomType.TabIndex = 10;
            this.cbbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbbRoomType_SelectedIndexChanged);
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            ""});
            this.cbbStatus.Location = new System.Drawing.Point(35, 470);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(290, 46);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(382, 539);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRoomType);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(15, 572);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(382, 139);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Phòng";
            // 
            // btnRoomType
            // 
            this.btnRoomType.Location = new System.Drawing.Point(89, 58);
            this.btnRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomType.Name = "btnRoomType";
            this.btnRoomType.Size = new System.Drawing.Size(178, 58);
            this.btnRoomType.TabIndex = 0;
            this.btnRoomType.Text = "Chỉnh Sửa";
            this.btnRoomType.UseVisualStyleBackColor = true;
            this.btnRoomType.Click += new System.EventHandler(this.btnRoomType_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCusType);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(15, 722);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(382, 139);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loại Khách Hàng";
            // 
            // btnCusType
            // 
            this.btnCusType.Location = new System.Drawing.Point(89, 50);
            this.btnCusType.Margin = new System.Windows.Forms.Padding(4);
            this.btnCusType.Name = "btnCusType";
            this.btnCusType.Size = new System.Drawing.Size(178, 58);
            this.btnCusType.TabIndex = 1;
            this.btnCusType.Text = "Chỉnh Sửa";
            this.btnCusType.UseVisualStyleBackColor = true;
            this.btnCusType.Click += new System.EventHandler(this.btnCusType_Click);
            // 
            // fcatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 884);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fcatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC PHÒNG";
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCatalog)).EndInit();
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
        private Button btnAddRoom;
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
        private DataGridView dataCatalog;
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