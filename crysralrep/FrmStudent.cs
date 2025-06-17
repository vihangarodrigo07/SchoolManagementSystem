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
    public partial class FrmStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=VIHANGAHP\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.CustomFormat = "yyyy/MM/dd";
            dtpDob.Value = DateTime.Now.AddYears(-20);

            con.Open();
            string query_select = "SELECT * FROM tblStudent";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            SqlDataReader row = cmnd.ExecuteReader();
            cmbReg.Items.Add("New Register");
            while (row.Read())
            {
                cmbReg.Items.Add(row[0].ToString());
                cmbRegNo.Items.Add(row[0].ToString());
            }
            con.Close();
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = cmbReg.Text;
            if (no != "New Register")
            {
                con.Open();
                string query_select = "SELECT * FROM tblStudent WHERE regNo =" + no;
                SqlCommand cmnd = new SqlCommand(query_select, con);
                SqlDataReader row = cmnd.ExecuteReader();
                while (row.Read())
                {
                    txtfirstname.Text = row[1].ToString();
                    txtlastname.Text = row[2].ToString();
                    dtpDob.Format = DateTimePickerFormat.Custom;
                    dtpDob.CustomFormat = "yyyy/MM/dd";
                    dtpDob.Text = row[3].ToString();
                    if (row[4].ToString() == "Male")
                    {
                        rbMale.Checked = true;
                        rbFemale.Checked = false;
                    }
                    else
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }
                    txtAddress.Text = row[5].ToString();
                    txtEmail.Text = row[6].ToString();
                    txtMobile.Text = row[7].ToString();
                    txtHphone.Text = row[8].ToString();
                    txtPname.Text = row[9].ToString();
                    txtNIC.Text = row[10].ToString();
                    txtCnumber.Text = row[11].ToString();
                }
                con.Close();
                btnRegister.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                cmbReg.Text = "";
                txtfirstname.Text = "";
                txtlastname.Text = "";
                dtpDob.Format = DateTimePickerFormat.Custom;
                dtpDob.CustomFormat = "yyyy/MM/dd";
                dtpDob.Value = DateTime.Now.AddYears(-20);

                rbMale.Checked = false;
                rbFemale.Checked = false;

                txtAddress.Text = "";
                txtEmail.Text = "";
                txtMobile.Text = "";
                txtHphone.Text = "";
                txtPname.Text = "";
                txtNIC.Text = "";
                txtCnumber.Text = "";
                btnRegister.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtfirstname.Text;
                string lastName = txtlastname.Text;

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
                int mobilePhone = int.Parse(txtMobile.Text);
                int homephone = int.Parse(txtHphone.Text);
                string parentName = txtPname.Text;
                string nic = txtNIC.Text;
                int contactNo = int.Parse(txtCnumber.Text);
                string query_insert = "INSERT INTO tblStudent([firstName],[lastName],[dateOfBirth],[gender],[address],[email],[mobilePhone],[homePhone],[parentName],[nic],[contactNo]) " +
                    "Values ('" + firstName + "','" + lastName + "','" + dtpDob.Value.ToString("MM/dd/yyyy") + "','"
                    + gender + "','" + address + "','" + email + "'," + mobilePhone + "," + homephone + ",'" + parentName
                    + "','" + nic + "'," + contactNo + ")";

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Successfully!", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string no = cmbReg.Text;

                if (no != "New Register")
                {
                    string firstName = txtfirstname.Text;
                    string lastName = txtlastname.Text;
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
                    int mobilePhone = int.Parse(txtMobile.Text);
                    int homephone = int.Parse(txtHphone.Text);
                    string parentName = txtPname.Text;
                    string nic = txtNIC.Text;
                    int contactNo = int.Parse(txtCnumber.Text);
                    string query_insert = "UPDATE tblStudent SET firstName = '" + firstName + "',lastName ='" + lastName + "'" +
                        ",dateOfBirth='" + dtpDob.Text + "',gender='" + gender + "',address = '" + address + "',email = '" + email +
                        "',mobilePhone = " + mobilePhone + ",homePhone = " + homephone + ",parentName = '" + parentName +
                        "',nic = '" + nic + "',contactNo = " + contactNo + " WHERE regNo = " + no;

                    con.Open();
                    SqlCommand cmnd = new SqlCommand(query_insert, con);

                    cmnd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
                (SqlException ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                string msg = ex.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbReg.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dtpDob.Text = thisDay.ToString();

            rbMale.Checked = false;
            rbFemale.Checked = false;

            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtHphone.Text = "";
            txtPname.Text = "";
            txtNIC.Text = "";
            txtCnumber.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you relly want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string no = cmbReg.Text;

                string query_insert = "DELETE FROM tblStudent WHERE regNo = " + no + "";
                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            if(cmbRegNo.SelectedItem != null)
            {
                try
                {
                    string regNo = cmbRegNo.Text;
                    string course = cmbsub.Text;
                    string english = txts1.Text;
                    string subject = txts2.Text;
                    string total = txtTotal.Text;
                    string avg = txtAvg.Text;

                    string query_insert = "INSERT INTO tblMarks([RegNo],[course],[english],[submarks],[total],[avg]) " +
                        "Values ('" + regNo + "','" + course + "','" + english + "','" + subject + "','" + total + "','" + avg + "')";

                    con.Open();
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    cmnd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Added Successfully!", "Add Marks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    string msg = ex.Message;
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select the Index number of the Student to Add Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = this.cmbRegNo.Text;
            string query = "SELECT * FROM tblMarks WHERE RegNo = @no";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@no", no);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cmbsub.Text = dr[1].ToString();
                    txts1.Text = dr[2].ToString();
                    txts2.Text = dr[3].ToString();
                    txtTotal.Text = dr[4].ToString();
                    txtAvg.Text = dr[5].ToString();

                }
                btnMarks.Enabled = false;
            }
            else
            {
                cmbsub.Text = "";
                txts1.Text = "";
                txts2.Text = "";
                txtTotal.Text = "";
                txtAvg.Text = "";
            }
            con.Close();
            btnMarks.Enabled = true;
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double english = Convert.ToDouble(txts1.Text);
            double submarks = Convert.ToDouble(txts2.Text);

            double total = english + submarks;
            double avg = total / 2;

            txtTotal.Text = total.ToString();
            txtAvg.Text = avg.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }
    }
}
