using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTMPDapk.Views.UserControls
{
    public partial class uc_home : UserControl
    {
        public uc_home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_home_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void uc_home_Load_1(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
