namespace hotel
{
    partial class fListRental
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataListRental = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelListRental = new System.Windows.Forms.Button();
            this.btnEditListRental = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RoomName = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListRental)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataListRental);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(11, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Thuê";
            // 
            // dataListRental
            // 
            this.dataListRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListRental.Location = new System.Drawing.Point(-6, 37);
            this.dataListRental.Name = "dataListRental";
            this.dataListRental.RowHeadersWidth = 51;
            this.dataListRental.RowTemplate.Height = 29;
            this.dataListRental.Size = new System.Drawing.Size(981, 387);
            this.dataListRental.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddRental);
            this.groupBox2.Controls.Add(this.btnDelListRental);
            this.groupBox2.Controls.Add(this.btnEditListRental);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(314, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnDelListRental
            // 
            this.btnDelListRental.Location = new System.Drawing.Point(480, 37);
            this.btnDelListRental.Name = "btnDelListRental";
            this.btnDelListRental.Size = new System.Drawing.Size(179, 55);
            this.btnDelListRental.TabIndex = 1;
            this.btnDelListRental.Text = "Xóa";
            this.btnDelListRental.UseVisualStyleBackColor = true;
            // 
            // btnEditListRental
            // 
            this.btnEditListRental.Location = new System.Drawing.Point(255, 37);
            this.btnEditListRental.Name = "btnEditListRental";
            this.btnEditListRental.Size = new System.Drawing.Size(179, 55);
            this.btnEditListRental.TabIndex = 0;
            this.btnEditListRental.Text = "Sửa";
            this.btnEditListRental.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RoomName);
            this.groupBox3.Controls.Add(this.txtRoomName);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // RoomName
            // 
            this.RoomName.AutoSize = true;
            this.RoomName.Location = new System.Drawing.Point(18, 57);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(126, 31);
            this.RoomName.TabIndex = 1;
            this.RoomName.Text = "Tên Phòng:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(161, 50);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(95, 38);
            this.txtRoomName.TabIndex = 0;
            this.txtRoomName.UseWaitCursor = true;
            this.txtRoomName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddRental
            // 
            this.btnAddRental.Location = new System.Drawing.Point(35, 37);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(179, 55);
            this.btnAddRental.TabIndex = 2;
            this.btnAddRental.Text = "Thêm";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // fListRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fListRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH PHIẾU THUÊ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListRental)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataListRental;
        private GroupBox groupBox2;
        private Button btnDelListRental;
        private Button btnEditListRental;
        private GroupBox groupBox3;
        private Label RoomName;
        private TextBox txtRoomName;
        private Button btnAddRental;
    }
}