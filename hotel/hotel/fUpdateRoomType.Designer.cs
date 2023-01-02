namespace hotel
{
    partial class fUpdateRoomType
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomTypeName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveRoomType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại Phòng:";
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoomTypeName.Location = new System.Drawing.Point(270, 59);
            this.txtRoomTypeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Size = new System.Drawing.Size(262, 44);
            this.txtRoomTypeName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(270, 151);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(262, 44);
            this.txtPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn Giá:";
            // 
            // btnSaveRoomType
            // 
            this.btnSaveRoomType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveRoomType.Location = new System.Drawing.Point(358, 242);
            this.btnSaveRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveRoomType.Name = "btnSaveRoomType";
            this.btnSaveRoomType.Size = new System.Drawing.Size(175, 78);
            this.btnSaveRoomType.TabIndex = 4;
            this.btnSaveRoomType.Text = "SAVE";
            this.btnSaveRoomType.UseVisualStyleBackColor = true;
            this.btnSaveRoomType.Click += new System.EventHandler(this.btnSaveRoomType_Click);
            // 
            // fUpdateRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 380);
            this.Controls.Add(this.btnSaveRoomType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoomTypeName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "fUpdateRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT LOẠI PHÒNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtRoomTypeName;
        private TextBox txtPrice;
        private Label label2;
        private Button btnSaveRoomType;
    }
}