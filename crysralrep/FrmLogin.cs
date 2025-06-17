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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using Final_Project;
using crysralrep;

namespace Final_Project
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=VIHANGAHP\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtpassword.Text;

            string query = "SELECT * FROM tblLogin WHERE username = @username AND password = @password";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            con.Open();

            SqlDataReader dr = command.ExecuteReader();

            if (dr.HasRows)
            {
                this.Hide();
                FrmHome home = new FrmHome();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid login credentials, please check Username and Password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();

        }
    }
}
