namespace Bài_2
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
            this.ShowTextBox = new System.Windows.Forms.TextBox();
            this.FontListBox = new System.Windows.Forms.ListBox();
            this.SizeFontComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItalicCheckBox = new System.Windows.Forms.CheckBox();
            this.UnderlineCheckBox = new System.Windows.Forms.CheckBox();
            this.BoldCheckBox = new System.Windows.Forms.CheckBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.FontStyleLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.Label();
            this.ColorButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowTextBox
            // 
            this.ShowTextBox.Location = new System.Drawing.Point(78, 42);
            this.ShowTextBox.Name = "ShowTextBox";
            this.ShowTextBox.Size = new System.Drawing.Size(434, 20);
            this.ShowTextBox.TabIndex = 0;
            // 
            // FontListBox
            // 
            this.FontListBox.FormattingEnabled = true;
            this.FontListBox.Location = new System.Drawing.Point(21, 162);
            this.FontListBox.Name = "FontListBox";
            this.FontListBox.Size = new System.Drawing.Size(270, 264);
            this.FontListBox.TabIndex = 1;
            this.FontListBox.SelectedIndexChanged += new System.EventHandler(this.FontListBox_SelectedIndexChanged);
            // 
            // SizeFontComboBox
            // 
            this.SizeFontComboBox.FormattingEnabled = true;
            this.SizeFontComboBox.Items.AddRange(new object[] {
            "  8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "36",
            "38",
            "40"});
            this.SizeFontComboBox.Location = new System.Drawing.Point(348, 162);
            this.SizeFontComboBox.Name = "SizeFontComboBox";
            this.SizeFontComboBox.Size = new System.Drawing.Size(62, 21);
            this.SizeFontComboBox.TabIndex = 2;
            this.SizeFontComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeFontComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItalicCheckBox);
            this.groupBox1.Controls.Add(this.UnderlineCheckBox);
            this.groupBox1.Controls.Add(this.BoldCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(348, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ItalicCheckBox
            // 
            this.ItalicCheckBox.AutoSize = true;
            this.ItalicCheckBox.Location = new System.Drawing.Point(125, 28);
            this.ItalicCheckBox.Name = "ItalicCheckBox";
            this.ItalicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.ItalicCheckBox.TabIndex = 3;
            this.ItalicCheckBox.Text = "Italic";
            this.ItalicCheckBox.UseVisualStyleBackColor = true;
            this.ItalicCheckBox.CheckedChanged += new System.EventHandler(this.ItalicCheckBox_CheckedChanged);
            // 
            // UnderlineCheckBox
            // 
            this.UnderlineCheckBox.AutoSize = true;
            this.UnderlineCheckBox.Location = new System.Drawing.Point(61, 87);
            this.UnderlineCheckBox.Name = "UnderlineCheckBox";
            this.UnderlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.UnderlineCheckBox.TabIndex = 2;
            this.UnderlineCheckBox.Text = "Underline";
            this.UnderlineCheckBox.UseVisualStyleBackColor = true;
            this.UnderlineCheckBox.CheckedChanged += new System.EventHandler(this.UnderlineCheckBox_CheckedChanged);
            // 
            // BoldCheckBox
            // 
            this.BoldCheckBox.AutoSize = true;
            this.BoldCheckBox.Location = new System.Drawing.Point(18, 28);
            this.BoldCheckBox.Name = "BoldCheckBox";
            this.BoldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.BoldCheckBox.TabIndex = 0;
            this.BoldCheckBox.Text = "Bold";
            this.BoldCheckBox.UseVisualStyleBackColor = true;
            this.BoldCheckBox.CheckedChanged += new System.EventHandler(this.BoldCheckBox_CheckedChanged);
            // 
            // FontLabel
            // 
            this.FontLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FontLabel.AutoSize = true;
            this.FontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontLabel.Location = new System.Drawing.Point(119, 135);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(28, 13);
            this.FontLabel.TabIndex = 4;
            this.FontLabel.Text = "Font";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(362, 135);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.SizeLabel.TabIndex = 5;
            this.SizeLabel.Text = "Size";
            // 
            // FontStyleLabel
            // 
            this.FontStyleLabel.AutoSize = true;
            this.FontStyleLabel.Location = new System.Drawing.Point(426, 249);
            this.FontStyleLabel.Name = "FontStyleLabel";
            this.FontStyleLabel.Size = new System.Drawing.Size(54, 13);
            this.FontStyleLabel.TabIndex = 6;
            this.FontStyleLabel.Text = "Font Style";
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Location = new System.Drawing.Point(272, 9);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(49, 13);
            this.TextBox.TabIndex = 7;
            this.TextBox.Text = "Text Box";
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(470, 154);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(83, 35);
            this.ColorButton.TabIndex = 8;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.FontStyleLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SizeFontComboBox);
            this.Controls.Add(this.FontListBox);
            this.Controls.Add(this.ShowTextBox);
            this.Name = "Form1";
            this.Text = "Thao Tác với Font Chữ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowTextBox;
        private System.Windows.Forms.ListBox FontListBox;
        private System.Windows.Forms.ComboBox SizeFontComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox UnderlineCheckBox;
        private System.Windows.Forms.CheckBox BoldCheckBox;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label FontStyleLabel;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.CheckBox ItalicCheckBox;
    }
}

