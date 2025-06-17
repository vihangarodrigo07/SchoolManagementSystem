using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crysralrep
{
    public partial class FrmLecturers : Form
    {
        public FrmLecturers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=VIHANGAHP\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

        private void FrmLecturers_Load(object sender, EventArgs e)
        {
            ShowLecturers();
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.CustomFormat = "yyyy/MM/dd";
            dtpDob.Value = DateTime.Now.AddYears(-50);

            con.Open();
            string query_select = "SELECT * FROM tblLecturer";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            SqlDataReader row = cmnd.ExecuteReader();
            cmbLID.Items.Add("New Register");
            while (row.Read())
            {
                cmbLID.Items.Add(row[0].ToString());
            }
            con.Close();
        }

        private void cmbLID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = cmbLID.Text;
            if (no != "New Register")
            {
                con.Open();
                string query_select = "SELECT * FROM tblLecturer WHERE LID =" + no;
                SqlCommand cmnd = new SqlCommand(query_select, con);
                SqlDataReader row = cmnd.ExecuteReader();
                while (row.Read())
                {
                    txtname.Text = row[1].ToString();
                    txtAddress.Text = row[2].ToString();
                    txtEmail.Text = row[3].ToString();
                    dtpDob.Format = DateTimePickerFormat.Custom;
                    dtpDob.CustomFormat = "yyyy/MM/dd";
                    dtpDob.Text = row[4].ToString();
                    if (row[5].ToString() == "Male")
                    {
                        rbMale.Checked = true;
                        rbFemale.Checked = false;
                    }
                    else
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }
                    txtMobile.Text = row[6].ToString();
                    cmbsub.Text = row[7].ToString();
                }
                con.Close();
                btnRegister.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                cmbLID.Text = "";
                txtname.Text = "";
                dtpDob.Format = DateTimePickerFormat.Custom;
                dtpDob.CustomFormat = "yyyy/MM/dd";
                dtpDob.Value = DateTime.Now.AddYears(-50);

                rbMale.Checked = false;
                rbFemale.Checked = false;

                txtAddress.Text = "";
                txtEmail.Text = "";
                txtMobile.Text = "";
                cmbsub.Text = "";
                btnRegister.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        public void ShowLecturers()
        {
            SqlConnection con = new SqlConnection(@"Data Source=VIHANGAHP\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblLecturer", con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "TB0");

            if (dataSet != null)
            {
                this.GridLecturers.DataSource = dataSet.Tables["TB0"];
                SetGrid();
            }
            else
            {
                this.GridLecturers.DataSource = null;
                this.GridLecturers.DataBindings.Clear();
            }
        }

        private void SetGrid()
        {
            this.GridLecturers.Columns[0].HeaderText = "Lecturer ID";
            this.GridLecturers.Columns[0].Width = 50;
            this.GridLecturers.Columns[1].HeaderText = "Name";
            this.GridLecturers.Columns[1].Width = 100;
            this.GridLecturers.Columns[2].HeaderText = "Address";
            this.GridLecturers.Columns[2].Width = 200;
            this.GridLecturers.Columns[3].HeaderText = "Email";
            this.GridLecturers.Columns[3].Width = 100;
            this.GridLecturers.Columns[4].HeaderText = "Date of Birth";
            this.GridLecturers.Columns[4].Width = 65;
            this.GridLecturers.Columns[5].HeaderText = "Gender";
            this.GridLecturers.Columns[5].Width = 50;
            this.GridLecturers.Columns[6].HeaderText = "Mobile No";
            this.GridLecturers.Columns[6].Width = 75;
            this.GridLecturers.Columns[7].HeaderText = "Course";
            this.GridLecturers.Columns[7].Width = 150;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                string gender;
                if (rbMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string mobilePhone = txtMobile.Text;
                string course = cmbsub.Text;
                string query_insert = "INSERT INTO tblLecturer([name],[address],[email],[DOB],[gender],[mobileNo],[course]) " +
                    "Values ('" + name + "','" + address + "','" + email + "','" + dtpDob.Value.ToString("MM/dd/yyyy") + "','" + gender + "','" + mobilePhone + "','" + course + "')";

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Successfully!", "Register Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                string msg = ex.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string no = cmbLID.Text;

                if (no != "New Register")
                {
                    string name = txtname.Text;
                    dtpDob.Format = DateTimePickerFormat.Custom;
                    dtpDob.CustomFormat = "yyyy/MM/dd";
                    string gender;
                    if (rbMale.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string address = txtAddress.Text;
                    string email = txtEmail.Text;
                    string mobilePhone = txtMobile.Text;
                    string course = cmbsub.Text;
                    string query_insert = "UPDATE tblLecturer SET name = '" + name + "',address ='" + address + "',DOB='" + dtpDob.Text + "',gender='" + gender + "',email = '" + email + "',mobileNo = '" + mobilePhone + "',course = '" + course + "' WHERE LID = " + no;

                    con.Open();
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    cmnd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully!", "Update Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                string msg = ex.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbLID.Text = "";
            txtname.Text = "";
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dtpDob.Text = thisDay.ToString();

            rbMale.Checked = false;
            rbFemale.Checked = false;

            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            cmbsub.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you relly want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string no = cmbLID.Text;

                string query_insert = "DELETE FROM tblLecturer WHERE LID = " + no + "";
                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Remove Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }
    }
}
