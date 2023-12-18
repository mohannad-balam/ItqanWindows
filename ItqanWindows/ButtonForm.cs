using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItqanWindows
{
    public partial class ButtonForm : Form
    {
        public ButtonForm()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Btn.Text = "Button Clicked";
        }

        private void ButtonForm_Load(object sender, EventArgs e)
        {
            Btn.BackColor = Color.Black;
        }

        private void categoriesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(categoriesCb.Text);
        }

        private void myDt_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(myDt.Value.ToString());
        }

        private void myCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(myCheckBox.Checked.ToString());
        }

        private void myTextBox_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(myTextBox.Text);
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myTextBox.Text);
        }
    }
}
