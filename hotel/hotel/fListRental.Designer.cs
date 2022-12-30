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
            this.btnAddRental = new System.Windows.Forms.Button();
            this.btnDelListRental = new System.Windows.Forms.Button();
            this.btnEditListRental = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListRental)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataListRental);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1654, 975);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Thuê";
            // 
            // dataListRental
            // 
            this.dataListRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListRental.Location = new System.Drawing.Point(-8, 46);
            this.dataListRental.Margin = new System.Windows.Forms.Padding(4);
            this.dataListRental.Name = "dataListRental";
            this.dataListRental.RowHeadersWidth = 51;
            this.dataListRental.RowTemplate.Height = 29;
            this.dataListRental.Size = new System.Drawing.Size(1654, 921);
            this.dataListRental.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddRental);
            this.groupBox2.Controls.Add(this.btnDelListRental);
            this.groupBox2.Controls.Add(this.btnEditListRental);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(14, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1654, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnAddRental
            // 
            this.btnAddRental.Location = new System.Drawing.Point(44, 46);
            this.btnAddRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(224, 69);
            this.btnAddRental.TabIndex = 2;
            this.btnAddRental.Text = "Thêm";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnDelListRental
            // 
            this.btnDelListRental.Location = new System.Drawing.Point(561, 46);
            this.btnDelListRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelListRental.Name = "btnDelListRental";
            this.btnDelListRental.Size = new System.Drawing.Size(224, 69);
            this.btnDelListRental.TabIndex = 1;
            this.btnDelListRental.Text = "Xóa";
            this.btnDelListRental.UseVisualStyleBackColor = true;
            this.btnDelListRental.Click += new System.EventHandler(this.btnDelListRental_Click);
            // 
            // btnEditListRental
            // 
            this.btnEditListRental.Location = new System.Drawing.Point(1040, 46);
            this.btnEditListRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditListRental.Name = "btnEditListRental";
            this.btnEditListRental.Size = new System.Drawing.Size(224, 69);
            this.btnEditListRental.TabIndex = 0;
            this.btnEditListRental.Text = "Sửa";
            this.btnEditListRental.UseVisualStyleBackColor = true;
            // 
            // fListRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 1166);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fListRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH PHIẾU THUÊ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListRental)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataListRental;
        private GroupBox groupBox2;
        private Button btnDelListRental;
        private Button btnEditListRental;
        private Button btnAddRental;
    }
}