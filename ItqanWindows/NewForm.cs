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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            if(nameTb.Text == "" || phoneTb.Text == "" || salaryTb.Text == "")
            {
                MessageBox.Show("missing information");
                return;
            }
            dgvEmployees.Rows.Add(nameTb.Text, phoneTb.Text, salaryTb.Text);
            //nameTb.Text = "";
            nameTb.Clear();
            phoneTb.Clear();
            salaryTb.Clear();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployees.Columns[e.ColumnIndex].Name;
            if(colName == "show")
            {
                nameTb.Text = dgvEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                phoneTb.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                salaryTb.Text = dgvEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else if(colName == "delete")
            {
                if(MessageBox.Show("are you sure you want to delete", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvEmployees.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
