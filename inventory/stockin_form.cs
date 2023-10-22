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
    
    public partial class stockin_form : Form
    {
        private string username { set; get; }
        SqlConnection conn = new SqlConnection(@"Data Source=MY13-LABTOP;Initial Catalog=Einventory;Integrated Security=True");
        DateTime now = DateTime.Now;

        public void create_table()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Stockin", conn);
            DataTable dataTable = new DataTable();
            conn.Open();
            dataTable.Load(cmd.ExecuteReader());
            conn.Close();
            stockin_data.DataSource = dataTable;
        }
        public stockin_form(string str_user)
        {
            username = str_user;
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void stockin_form_Load(object sender, EventArgs e)
        {
            quantity.Value = 1;
            conn.Close();
            create_table();
            
        }

        private void price_txtbox_TextChanged(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar)&&!char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void price_txtbox_clicked(object sender, EventArgs e)
        {
            price_txtbox.Text = String.Empty;
        }
        private void category_txtbox_clicked(object sender, EventArgs e)
        {
            category_txtbox.Text = String.Empty;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            try
            {
                string query;
                if (exp_chkbx.Checked)
                {
                    query = string.Format("INSERT INTO stockin VALUES('{0}',{1},'{2}',{3},'{4}','{5}','{6}','{7}')",
                    productname_txtbox.Text,
                    price_txtbox.Text,
                    category_txtbox.Text,
                    int.Parse(quantity.Value.ToString()),
                    stockin_date.Text,
                    exp_date.Text,
                    now.ToString("d"),
                    username
                    );
                }
                else
                {
                    query = string.Format("INSERT INTO stockin VALUES('{0}',{1},'{2}',{3},'{4}','{5}','{6}','{7}')",
                    productname_txtbox.Text,
                    price_txtbox.Text,
                    category_txtbox.Text,
                    int.Parse(quantity.Value.ToString()),
                    stockin_date.Text,
                    "None",
                    now.ToString("d"),
                    username
                    );
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                create_table();
                MessageBox.Show("Done!");
            }
            catch
            {
                MessageBox.Show("Wrong inputs");
            }


        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            conn.Close();
            //selected id
            int id = int.Parse(stockin_data.SelectedCells[0].Value.ToString());

            string query = string.Format("DELETE Stockin WHERE id ={0}", id);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            create_table();
            //MessageBox.Show("Done!");
        }

        private void productname_txtbox_Click(object sender, EventArgs e)
        {
            productname_txtbox.Text = String.Empty;

        }

        private void stockin_data_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                id_label_real.Text = stockin_data.SelectedCells[0].Value.ToString();
                name_label_real.Text = stockin_data.SelectedCells[1].Value.ToString();
                intiprice_label_real.Text = stockin_data.SelectedCells[2].Value.ToString();
                category_label_real.Text = stockin_data.SelectedCells[3].Value.ToString();
                quantity_label_real.Text = stockin_data.SelectedCells[4].Value.ToString();
                Deposit_label_real.Text = stockin_data.SelectedCells[5].Value.ToString();
                exp_label_real.Text = stockin_data.SelectedCells[6].Value.ToString();
                lastup_label_real.Text = stockin_data.SelectedCells[7].Value.ToString();
                admin_label_real.Text = stockin_data.SelectedCells[8].Value.ToString();
                total_label.Text = (double.Parse(intiprice_label_real.Text)*Convert.ToDouble(quantity_label_real.Text)).ToString();
            }
            catch
            {
                
            }
        }
    }
}
