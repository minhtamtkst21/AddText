using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddText
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mmuThemChu_Click(object sender, EventArgs e)
        {
            frmThemChu f = new frmThemChu();
            f.ShowDialog();
        }
    }
}
