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
    public partial class frmList : Form
    {
        DataTable _dt;
        public frmList(DataTable dt)
        {
            _dt = dt;
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            dgvList.DataSource = _dt;
        }
    }
}
