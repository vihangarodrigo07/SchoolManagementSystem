using crysralrep;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Project
{
    public partial class FrmCourses : Form
    {
        public FrmCourses()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=VIHANGAHP\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        private void FrmCourses_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }

        private void btnSE_Click(object sender, EventArgs e)
        {
            CRviewcourses CrRep = new CRviewcourses();
            DataSet DsRep = new DataSet();
            FrmViewer ObjViwer = new FrmViewer();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CID, cname, fee, duration FROM Student.dbo.tblcourse WHERE CID = 1", con);
            da.Fill(DsRep);

            CrRep.SetDataSource(DsRep.Tables[0]);
            ObjViwer.SetReport(CrRep);
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            FrmCourseRep frmCourseRep = new FrmCourseRep();
            frmCourseRep.ShowDialog();
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            CRviewcourses CrRep = new CRviewcourses();
            DataSet DsRep = new DataSet();
            FrmViewer ObjViwer = new FrmViewer();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CID, cname, fee, duration FROM Student.dbo.tblcourse WHERE CID = 2", con);
            da.Fill(DsRep);

            CrRep.SetDataSource(DsRep.Tables[0]);
            ObjViwer.SetReport(CrRep);
            con.Close();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            CRviewcourses CrRep = new CRviewcourses();
            DataSet DsRep = new DataSet();
            FrmViewer ObjViwer = new FrmViewer();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CID, cname, fee, duration FROM Student.dbo.tblcourse WHERE CID = 3", con);
            da.Fill(DsRep);

            CrRep.SetDataSource(DsRep.Tables[0]);
            ObjViwer.SetReport(CrRep);
            con.Close();
        }

        private void btnNE_Click(object sender, EventArgs e)
        {
            CRviewcourses CrRep = new CRviewcourses();
            DataSet DsRep = new DataSet();
            FrmViewer ObjViwer = new FrmViewer();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CID, cname, fee, duration FROM Student.dbo.tblcourse WHERE CID = 4", con);
            da.Fill(DsRep);

            CrRep.SetDataSource(DsRep.Tables[0]);
            ObjViwer.SetReport(CrRep);
            con.Close();
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            CRviewcourses CrRep = new CRviewcourses();
            DataSet DsRep = new DataSet();
            FrmViewer ObjViwer = new FrmViewer();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CID, cname, fee, duration FROM Student.dbo.tblcourse WHERE CID = 5", con);
            da.Fill(DsRep);

            CrRep.SetDataSource(DsRep.Tables[0]);
            ObjViwer.SetReport(CrRep);
            con.Close();
        }
    }
}
