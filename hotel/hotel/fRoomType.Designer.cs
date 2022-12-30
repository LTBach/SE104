namespace hotel
{
    partial class fRoomType
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
            this.dsRoomType = new System.Windows.Forms.GroupBox();
            this.dataRoomType = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditRoomType = new System.Windows.Forms.Button();
            this.btnDelRoomType = new System.Windows.Forms.Button();
            this.btnAddRoomType = new System.Windows.Forms.Button();
            this.dsRoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoomType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsRoomType
            // 
            this.dsRoomType.Controls.Add(this.dataRoomType);
            this.dsRoomType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dsRoomType.Location = new System.Drawing.Point(14, 160);
            this.dsRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.dsRoomType.Name = "dsRoomType";
            this.dsRoomType.Padding = new System.Windows.Forms.Padding(4);
            this.dsRoomType.Size = new System.Drawing.Size(972, 394);
            this.dsRoomType.TabIndex = 0;
            this.dsRoomType.TabStop = false;
            this.dsRoomType.Text = "Danh Sách Loại Phòng";
            // 
            // dataRoomType
            // 
            this.dataRoomType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRoomType.Location = new System.Drawing.Point(0, 46);
            this.dataRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.dataRoomType.Name = "dataRoomType";
            this.dataRoomType.RowHeadersWidth = 51;
            this.dataRoomType.RowTemplate.Height = 29;
            this.dataRoomType.Size = new System.Drawing.Size(972, 348);
            this.dataRoomType.TabIndex = 0;
            this.dataRoomType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRoomType_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditRoomType);
            this.groupBox1.Controls.Add(this.btnDelRoomType);
            this.groupBox1.Controls.Add(this.btnAddRoomType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(972, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEditRoomType
            // 
            this.btnEditRoomType.Location = new System.Drawing.Point(718, 58);
            this.btnEditRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRoomType.Name = "btnEditRoomType";
            this.btnEditRoomType.Size = new System.Drawing.Size(208, 58);
            this.btnEditRoomType.TabIndex = 2;
            this.btnEditRoomType.Text = "Sửa";
            this.btnEditRoomType.UseVisualStyleBackColor = true;
            this.btnEditRoomType.Click += new System.EventHandler(this.btnEditRoomType_Click);
            // 
            // btnDelRoomType
            // 
            this.btnDelRoomType.Location = new System.Drawing.Point(392, 58);
            this.btnDelRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelRoomType.Name = "btnDelRoomType";
            this.btnDelRoomType.Size = new System.Drawing.Size(208, 58);
            this.btnDelRoomType.TabIndex = 1;
            this.btnDelRoomType.Text = "Xóa";
            this.btnDelRoomType.UseVisualStyleBackColor = true;
            this.btnDelRoomType.Click += new System.EventHandler(this.btnDelRoomType_Click);
            // 
            // btnAddRoomType
            // 
            this.btnAddRoomType.Location = new System.Drawing.Point(66, 58);
            this.btnAddRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Size = new System.Drawing.Size(208, 58);
            this.btnAddRoomType.TabIndex = 0;
            this.btnAddRoomType.Text = "Thêm";
            this.btnAddRoomType.UseVisualStyleBackColor = true;
            this.btnAddRoomType.Click += new System.EventHandler(this.btnAddRoomType_Click);
            // 
            // fRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dsRoomType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI PHÒNG";
            this.dsRoomType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRoomType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox dsRoomType;
        private DataGridView dataRoomType;
        private GroupBox groupBox1;
        private Button btnEditRoomType;
        private Button btnDelRoomType;
        private Button btnAddRoomType;
    }
}