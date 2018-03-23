namespace Bài_Số_1
{
    partial class Form1
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
            this.GiaoVienListBox = new System.Windows.Forms.ListBox();
            this.LopListBox = new System.Windows.Forms.ListBox();
            this.KetQuaListBox = new System.Windows.Forms.ListBox();
            this.ChuyenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GiaoVienListBox
            // 
            this.GiaoVienListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GiaoVienListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaoVienListBox.FormattingEnabled = true;
            this.GiaoVienListBox.ItemHeight = 21;
            this.GiaoVienListBox.Location = new System.Drawing.Point(3, 9);
            this.GiaoVienListBox.Name = "GiaoVienListBox";
            this.GiaoVienListBox.Size = new System.Drawing.Size(215, 256);
            this.GiaoVienListBox.TabIndex = 0;
            // 
            // LopListBox
            // 
            this.LopListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LopListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopListBox.FormattingEnabled = true;
            this.LopListBox.ItemHeight = 21;
            this.LopListBox.Location = new System.Drawing.Point(235, 12);
            this.LopListBox.Name = "LopListBox";
            this.LopListBox.Size = new System.Drawing.Size(215, 256);
            this.LopListBox.TabIndex = 1;
            // 
            // KetQuaListBox
            // 
            this.KetQuaListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.KetQuaListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQuaListBox.FormattingEnabled = true;
            this.KetQuaListBox.ItemHeight = 21;
            this.KetQuaListBox.Location = new System.Drawing.Point(467, 12);
            this.KetQuaListBox.Name = "KetQuaListBox";
            this.KetQuaListBox.Size = new System.Drawing.Size(414, 256);
            this.KetQuaListBox.TabIndex = 2;
            // 
            // ChuyenButton
            // 
            this.ChuyenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChuyenButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuyenButton.Location = new System.Drawing.Point(370, 303);
            this.ChuyenButton.Name = "ChuyenButton";
            this.ChuyenButton.Size = new System.Drawing.Size(104, 35);
            this.ChuyenButton.TabIndex = 3;
            this.ChuyenButton.Text = "Chuyển";
            this.ChuyenButton.UseVisualStyleBackColor = true;
            this.ChuyenButton.Click += new System.EventHandler(this.ChuyenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 371);
            this.Controls.Add(this.ChuyenButton);
            this.Controls.Add(this.KetQuaListBox);
            this.Controls.Add(this.LopListBox);
            this.Controls.Add(this.GiaoVienListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GiaoVienListBox;
        private System.Windows.Forms.ListBox LopListBox;
        private System.Windows.Forms.ListBox KetQuaListBox;
        private System.Windows.Forms.Button ChuyenButton;
    }
}

