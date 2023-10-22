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


namespace inventory
{
    public partial class account_form : Form
    {
        private string username { get; set; }
        private string password { get; set; }
        SqlConnection conn = new SqlConnection(@"Data Source=MY13-LABTOP;Initial Catalog=Einventory;Integrated Security=True");
        
        public account_form(string str_username,string pass)
        {
            username = str_username;
            password = pass;
            InitializeComponent();
        }
        

        private void account_form_Load(object sender, EventArgs e)
        {
            string query = string.Format("select * from users where username = '{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            conn.Close();
            realid_label.Text = dataTable.Rows[0][0].ToString();
            realuser_label.Text = dataTable.Rows[0][1].ToString();
            reallast_label.Text = DateTime.Now.ToString();
        }

        private void oldpass_txtbox_Click(object sender, EventArgs e)
        {
            oldpass_txtbox.Text = String.Empty;
            oldpass_txtbox.PasswordChar = '*';
        }

        private void newpass_txtbox_Click(object sender, EventArgs e)
        {
            newpass_txtbox.Text = String.Empty;
            newpass_txtbox.PasswordChar = '*';
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            this.AcceptButton = submit_btn;

            if(oldpass_txtbox.Text == password)
            {
                string query = string.Format("update users set password = '{0}'", newpass_txtbox.Text);
                SqlCommand cmd = new SqlCommand(query,conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Application will restart please login again.");
                Application.Restart();
            }
            else
            {
                login_errorlabel.Visible = true;
            }

        }
    }
}
