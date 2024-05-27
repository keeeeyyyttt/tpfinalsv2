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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Testing
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin f1 = new frmLogin();
            f1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=KEITH\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            string FullName = txtFname.Text;
            string Email = txtEmail.Text;
            string UserName = txtUsername.Text;
            string Password = txtPass.Text;

            string Query = "INSERT INTO Info(FullName, Email, Username, Password) VALUES ('"+FullName+"', '"+Email+"', '"+UserName+"', '"+Password+"')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Login information saved successfully.");

            frmLogin f1 = new frmLogin();
            f1.Show();
            Hide();

        }
    }
}
