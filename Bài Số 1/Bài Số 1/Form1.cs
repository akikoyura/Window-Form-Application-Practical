using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Số_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //update teacher into GiaoVienListBox
            GiaoVienListBox.Items.Add("Linh");
            GiaoVienListBox.Items.Add("Mai");
            GiaoVienListBox.Items.Add("Hoàn");
            GiaoVienListBox.Items.Add("Huyền");
            GiaoVienListBox.Items.Add("Hằng");
            GiaoVienListBox.Items.Add("Hoài");
            GiaoVienListBox.Items.Add("Huơng");
            GiaoVienListBox.Items.Add("Hoàng");
            GiaoVienListBox.Items.Add("Anh");
            GiaoVienListBox.Items.Add("Cường");

            //update class into LopListBox
            LopListBox.Items.Add("10A1");
            LopListBox.Items.Add("10A2");
            LopListBox.Items.Add("10A3");
            LopListBox.Items.Add("10A4");
            LopListBox.Items.Add("11A1");
            LopListBox.Items.Add("11A2");
            LopListBox.Items.Add("11A3");
            LopListBox.Items.Add("11A4");
            LopListBox.Items.Add("12A1");
            LopListBox.Items.Add("12A2");

        }

        private void ChuyenButton_Click(object sender, EventArgs e)
        {
            if(LopListBox.SelectedIndex ==-1 || GiaoVienListBox.SelectedIndex==-1)
            {
                var msg = "Please select an item from the list box";
                MessageBox.Show(msg, this.Text);
                return;
            }
            if(KetQuaListBox.Items.Count ==10)
            {
                var msg = "Can not add item into listbox! ";
                MessageBox.Show(msg, this.Text);
                return;
            }
 
            while(KetQuaListBox.Items.Count !=0)
            {
                if (KetQuaListBox.Items.ToString().Contains(GiaoVienListBox.Items.ToString()))
                {
                    var msg = "Can not add item into listbox ! because it's exist!";
                    MessageBox.Show(msg, this.Text);
                    return;
                }
            }
            KetQuaListBox.Items.Add("Giáo Viên " + GiaoVienListBox.Text + " Chủ Nhiệm Lớp" + LopListBox.Text);
        }
    }
}
