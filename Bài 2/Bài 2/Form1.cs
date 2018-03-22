using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ShowTextBox.Font = new Font(ShowTextBox.Font.Name,
                ShowTextBox.Font.Size,
                ShowTextBox.Font.Style ^ FontStyle.Italic);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {

            ColorDialog myDialog = new ColorDialog();
            //Keeps the user from selecting a custom color

            myDialog.AllowFullOpen = false;

            //Sets the initial color select to the current text color
            myDialog.Color = ShowTextBox.ForeColor;

            //Update the text box color if the user clicks OK
            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                ShowTextBox.ForeColor = myDialog.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            try
            {
                foreach (FontFamily font in fonts.Families)
                {
                    FontListBox.Items.Add(font.Name);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(e.ToString());
            }
        }

        private void BoldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowTextBox.Font = new Font(ShowTextBox.Font.Name,
                ShowTextBox.Font.Size,
                ShowTextBox.Font.Style ^ FontStyle.Bold);
        }

        private void UnderlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowTextBox.Font = new Font(ShowTextBox.Font.Name,
               ShowTextBox.Font.Size,
               ShowTextBox.Font.Style ^ FontStyle.Underline);
        }

        private void ItalicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowTextBox.Font = new Font(ShowTextBox.Font.Name,
               ShowTextBox.Font.Size,
               ShowTextBox.Font.Style ^ FontStyle.Italic);
        }

        private void FontListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //để có thể làm được cái này em phải nhờ đến stackoverflow
            ShowTextBox.Font = new Font(FontListBox.SelectedItem.ToString(), ShowTextBox.Font.Size);
        }

        private void SizeFontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTextBox.Font = new Font(FontListBox.SelectedItem.ToString(), Convert.ToInt32(SizeFontComboBox.SelectedItem.ToString()));
        }
    }
}
