namespace hotel
{
    partial class fCustomerType
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
            this.btnEditCusType = new System.Windows.Forms.Button();
            this.btnDelCusType = new System.Windows.Forms.Button();
            this.btnAddCusType = new System.Windows.Forms.Button();
            this.dsCusType = new System.Windows.Forms.GroupBox();
            this.dataCusType = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.dsCusType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCusType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditCusType);
            this.groupBox1.Controls.Add(this.btnDelCusType);
            this.groupBox1.Controls.Add(this.btnAddCusType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(972, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnEditCusType
            // 
            this.btnEditCusType.Location = new System.Drawing.Point(718, 58);
            this.btnEditCusType.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCusType.Name = "btnEditCusType";
            this.btnEditCusType.Size = new System.Drawing.Size(208, 58);
            this.btnEditCusType.TabIndex = 2;
            this.btnEditCusType.Text = "Sửa";
            this.btnEditCusType.UseVisualStyleBackColor = true;
            this.btnEditCusType.Click += new System.EventHandler(this.btnEditCusType_Click);
            // 
            // btnDelCusType
            // 
            this.btnDelCusType.Location = new System.Drawing.Point(392, 58);
            this.btnDelCusType.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelCusType.Name = "btnDelCusType";
            this.btnDelCusType.Size = new System.Drawing.Size(208, 58);
            this.btnDelCusType.TabIndex = 1;
            this.btnDelCusType.Text = "Xóa";
            this.btnDelCusType.UseVisualStyleBackColor = true;
            this.btnDelCusType.Click += new System.EventHandler(this.btnDelCusType_Click);
            // 
            // btnAddCusType
            // 
            this.btnAddCusType.Location = new System.Drawing.Point(66, 58);
            this.btnAddCusType.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCusType.Name = "btnAddCusType";
            this.btnAddCusType.Size = new System.Drawing.Size(208, 58);
            this.btnAddCusType.TabIndex = 0;
            this.btnAddCusType.Text = "Thêm";
            this.btnAddCusType.UseVisualStyleBackColor = true;
            this.btnAddCusType.Click += new System.EventHandler(this.btnAddCusType_Click);
            // 
            // dsCusType
            // 
            this.dsCusType.Controls.Add(this.dataCusType);
            this.dsCusType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dsCusType.Location = new System.Drawing.Point(14, 158);
            this.dsCusType.Margin = new System.Windows.Forms.Padding(4);
            this.dsCusType.Name = "dsCusType";
            this.dsCusType.Padding = new System.Windows.Forms.Padding(4);
            this.dsCusType.Size = new System.Drawing.Size(972, 394);
            this.dsCusType.TabIndex = 2;
            this.dsCusType.TabStop = false;
            this.dsCusType.Text = "Danh Sánh Loại Khách Hàng";
            // 
            // dataCusType
            // 
            this.dataCusType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCusType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCusType.Location = new System.Drawing.Point(0, 46);
            this.dataCusType.Margin = new System.Windows.Forms.Padding(4);
            this.dataCusType.Name = "dataCusType";
            this.dataCusType.RowHeadersWidth = 51;
            this.dataCusType.RowTemplate.Height = 29;
            this.dataCusType.Size = new System.Drawing.Size(972, 348);
            this.dataCusType.TabIndex = 0;
            // 
            // fCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dsCusType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fCustomerType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI KHÁCH HÀNG";
            this.groupBox1.ResumeLayout(false);
            this.dsCusType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCusType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEditCusType;
        private Button btnDelCusType;
        private Button btnAddCusType;
        private GroupBox dsCusType;
        private DataGridView dataCusType;
    }
}