namespace hotel
{
    partial class fUpdateRoom
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
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveRoom.Location = new System.Drawing.Point(319, 245);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(133, 57);
            this.btnSaveRoom.TabIndex = 13;
            this.btnSaveRoom.Text = "SAVE";
            this.btnSaveRoom.UseVisualStyleBackColor = true;
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Location = new System.Drawing.Point(195, 108);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(257, 39);
            this.cbbRoomType.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại Phòng:";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNote.Location = new System.Drawing.Point(195, 184);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(257, 38);
            this.txtNote.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ghi Chú:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoomName.Location = new System.Drawing.Point(195, 28);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(257, 38);
            this.txtRoomName.TabIndex = 8;
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ten.Location = new System.Drawing.Point(23, 28);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(126, 31);
            this.Ten.TabIndex = 7;
            this.Ten.Text = "Tên Phòng:";
            // 
            // fEditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 320);
            this.Controls.Add(this.btnSaveRoom);
            this.Controls.Add(this.cbbRoomType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.Ten);
            this.Name = "fEditRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSaveRoom;
        private ComboBox cbbRoomType;
        private Label label2;
        private TextBox txtNote;
        private Label label1;
        private TextBox txtRoomName;
        private Label Ten;
    }
}