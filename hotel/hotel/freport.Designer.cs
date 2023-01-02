namespace hotel
{
    partial class freport
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataReport = new System.Windows.Forms.DataGridView();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1181, 688);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo Cáo Doanh Thu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataReport);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(24, 212);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1136, 460);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Báo Cáo";
            // 
            // dataReport
            // 
            this.dataReport.AutoGenerateColumns = false;
            this.dataReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loaiphong,
            this.tyleDataGridViewTextBoxColumn,
            this.doanhthu});
            this.dataReport.DataSource = this.class1BindingSource;
            this.dataReport.Location = new System.Drawing.Point(8, 46);
            this.dataReport.Margin = new System.Windows.Forms.Padding(4);
            this.dataReport.Name = "dataReport";
            this.dataReport.RowHeadersWidth = 51;
            this.dataReport.RowTemplate.Height = 29;
            this.dataReport.Size = new System.Drawing.Size(1121, 406);
            this.dataReport.TabIndex = 0;
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "TenLoaiPhong";
            this.loaiphong.HeaderText = "Loại Phòng";
            this.loaiphong.MinimumWidth = 8;
            this.loaiphong.Name = "loaiphong";
            // 
            // tyleDataGridViewTextBoxColumn
            // 
            this.tyleDataGridViewTextBoxColumn.DataPropertyName = "tyle";
            this.tyleDataGridViewTextBoxColumn.HeaderText = "Tỷ lệ (%)";
            this.tyleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tyleDataGridViewTextBoxColumn.Name = "tyleDataGridViewTextBoxColumn";
            // 
            // doanhthu
            // 
            this.doanhthu.DataPropertyName = "DoanhThu";
            this.doanhthu.HeaderText = "Doanh Thu";
            this.doanhthu.MinimumWidth = 8;
            this.doanhthu.Name = "doanhthu";
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(hotel.baocao.Class1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbMonth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(21, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1138, 130);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(906, 54);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(184, 56);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Xem";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(539, 59);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(188, 44);
            this.txtYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm:";
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(172, 59);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(148, 46);
            this.cbbMonth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // freport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 709);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "freport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dataReport;
        private GroupBox groupBox2;
        private Button btnDisplay;
        private TextBox txtYear;
        private Label label2;
        private ComboBox cbbMonth;
        private Label label1;
        private DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ghichu;
        private BindingSource class1BindingSource;
        private DataGridViewTextBoxColumn doanhthuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaiphong;
        private DataGridViewTextBoxColumn tyleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn doanhthu;
    }
}