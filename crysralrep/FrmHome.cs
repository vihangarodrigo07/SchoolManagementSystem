using Final_Project;
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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourses frmCourses = new FrmCourses();
            frmCourses.ShowDialog();
        }

        private void newStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removeStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmLecturers frmlecturers = new FrmLecturers();
            frmlecturers.ShowDialog();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void markSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarkViewer frmViewMarks = new FrmMarkViewer();
            frmViewMarks.ShowDialog();
        }
    }
}
