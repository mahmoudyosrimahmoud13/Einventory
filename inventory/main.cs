using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace inventory
{
    public partial class inventory_form : Form
    {
        //timers
        public bool side_expand;
        public bool user_expand;
        public bool loged_in;


        private string username { get; set; }
        private string password { get; set; }



        SqlConnection conn = new SqlConnection(@"Data Source=MY13-LABTOP;Initial Catalog=Einventory;Integrated Security=True");
        

        public inventory_form()
        {
            InitializeComponent();
        }
        
        private void inventory_form_Load(object sender, EventArgs e)
        {
            conn.Close();
            
            //disable buttons
            loged_in = false;
            stockin_btn.Enabled = loged_in;
            stockout_btn.Enabled = loged_in;
            stockreturn_btn.Enabled = loged_in;
            analysis_btn.Enabled    = loged_in;
            user_btn.Enabled = loged_in;

        }

        



        private void sidebar_timer_Tick(object sender, EventArgs e)
        {
            if(side_expand)
            {
                panel_side.Width -= 40;
                if(panel_side.Width == panel_side.MinimumSize.Width)
                {
                    side_expand = false;
                    sidebar_timer.Stop();
                }
            }
            else
            {
                panel_side.Width += 40;
                if(panel_side.Width == panel_side.MaximumSize.Width)
                {
                    side_expand = true;
                    sidebar_timer.Stop();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void exit_btn_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
        }

        private void userpanel_timer_Tick(object sender, EventArgs e)
        {
            if (user_expand)
            {
                user_panel.Height -= 50;
                if (user_panel.Height == user_panel.MinimumSize.Height)
                {
                    user_expand = false;
                    userpanel_timer.Stop();
                }
            }
            else
            {
                user_panel.Height += 50;
                if (user_panel.Height == user_panel.MaximumSize.Height)
                {
                    user_expand = true;
                    userpanel_timer.Stop();
                }
            }
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            userpanel_timer.Start();
        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            this.AcceptButton = Login_btn;
            string query = string.Format("SELECT username , password FROM users WHERE username = '{0}'", user_txtbox.Text);
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader;
            
            try
            {
                reader = sqlCommand.ExecuteReader();
                reader.Read();
                if (reader[0].ToString() == user_txtbox.Text && reader[1].ToString() == pass_txtbox.Text)
                {
                    //username passing
                    username = user_txtbox.Text;
                    password = pass_txtbox.Text;

                    //welcome form loader:
                    this.main_pnl.Controls.Clear();
                    welcome_form welcome_Form = new welcome_form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    welcome_Form.FormBorderStyle = FormBorderStyle.None;
                    this.main_pnl.Controls.Add(welcome_Form);
                    welcome_Form.Show();


                    //Buttons enabler:
                    loged_in = true;
                    stockin_btn.Enabled = loged_in;
                    stockout_btn.Enabled = loged_in;
                    stockreturn_btn.Enabled = loged_in;
                    analysis_btn.Enabled = loged_in;
                    user_btn.Enabled = loged_in;
                }
                else
                {
                    login_errorlabel.Visible = true;
                }
                conn.Close();
                
            }
            

            catch
            {
                login_errorlabel.Visible = true;
            }

            //Database connection close:
            conn.Close();   


        }
        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void username_clicked(object sender, EventArgs e)
        {
            user_txtbox.Text = String.Empty;
        }

        public void password_clicked(object sender, EventArgs e)
        {
            pass_txtbox.Text = String.Empty;
            pass_txtbox.PasswordChar = '*';
        }

        private void stockin_btn_Click(object sender, EventArgs e)
        {
            this.main_pnl.Controls.Clear();
            stockin_form welcome_Form = new stockin_form(username) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            welcome_Form.FormBorderStyle = FormBorderStyle.None;
            this.main_pnl.Controls.Add(welcome_Form);
            welcome_Form.Show();
        }

        private void stockout_btn_Click(object sender, EventArgs e)
        {
            this.main_pnl.Controls.Clear();
            stockout_form welcome_Form = new stockout_form(username) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            welcome_Form.FormBorderStyle = FormBorderStyle.None;
            this.main_pnl.Controls.Add(welcome_Form);
            welcome_Form.Show();
        }

        private void stockreturn_btn_Click(object sender, EventArgs e)
        {
            this.main_pnl.Controls.Clear();
            return_form welcome_Form = new return_form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            welcome_Form.FormBorderStyle = FormBorderStyle.None;
            this.main_pnl.Controls.Add(welcome_Form);
            welcome_Form.Show();
        }

        private void analysis_btn_Click(object sender, EventArgs e)
        {
            this.main_pnl.Controls.Clear();
            analysis_form welcome_Form = new analysis_form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            welcome_Form.FormBorderStyle = FormBorderStyle.None;
            this.main_pnl.Controls.Add(welcome_Form);
            welcome_Form.Show();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            this.main_pnl.Controls.Clear();
            about_form welcome_Form = new about_form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            welcome_Form.FormBorderStyle = FormBorderStyle.None;
            this.main_pnl.Controls.Add(welcome_Form);
            welcome_Form.Show();
        }
        private void account_btn_Click(object sender, EventArgs e)
        {
            this.main_pnl.Controls.Clear();
            account_form welcome_Form = new account_form(username,password) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            welcome_Form.FormBorderStyle = FormBorderStyle.None;
            this.main_pnl.Controls.Add(welcome_Form);
            welcome_Form.Show();
        }

        private void main_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
