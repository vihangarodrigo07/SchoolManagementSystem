using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crysralrep
{
    public partial class FrmCourseRep : Form
    {
        public FrmCourseRep()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CrystalReport11_InitReport(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrystalReport1 crystalReport1 = new CrystalReport1();
        }
    }
}
