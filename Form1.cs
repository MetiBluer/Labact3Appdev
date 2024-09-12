using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevPrac
{
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void frmReg_Load(object sender, EventArgs e)
        {
            cbSex.Items.Add("Male");
            cbSex.Items.Add("Female");

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Sex");

            dt.Rows.Add(txtFname.Text,txtLname.Text,cbSex.Text);

            frmList frmList = new frmList(dt);
            frmList.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtLname.Text = "";
            txtFname.Text = "";
            cbSex.Text = "";
        }
    }
}
