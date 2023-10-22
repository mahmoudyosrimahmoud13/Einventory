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
    public partial class return_form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MY13-LABTOP;Initial Catalog=Einventory;Integrated Security=True");

        public void create_table()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Stockout", conn);
            DataTable dataTable = new DataTable();
            conn.Open();
            dataTable.Load(cmd.ExecuteReader());
            conn.Close();
            stockin_data.DataSource = dataTable;
        }


        public return_form()
        {
            InitializeComponent();
        }

        private void search_txtbox_Click(object sender, EventArgs e)
        {
            search_txtbox.Text = String.Empty;
        }

        private void return_form_Load(object sender, EventArgs e)
        {
            create_table();

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM Stockout WHERE product_name LIKE '%{0}%'", search_txtbox.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            conn.Close();
            stockin_data.DataSource = dataTable;
        }

        private void stockreturn_btn_Click(object sender, EventArgs e)
        {
            //selected id
            int id = int.Parse(stockin_data.SelectedCells[0].Value.ToString());

            //add to stockout
            string query = string.Format("SELECT * from Stockout WHERE id ={0}", id);
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            dt.Load(cmd.ExecuteReader());
            conn.Close();
            query = string.Format("INSERT INTO stockin VALUES('{0}',{1},'{2}',{3},'{4}','{5}','{6}','{7}')",
                dt.Rows[0][1].ToString(),
                dt.Rows[0][2],
                dt.Rows[0][3].ToString(),
                dt.Rows[0][4],
                dt.Rows[0][5].ToString(),
                dt.Rows[0][6].ToString(),
                dt.Rows[0][7].ToString(),
                dt.Rows[0][8].ToString()
                );
            conn.Open();
            cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();
            conn.Close();



            query = string.Format("DELETE Stockout WHERE id ={0}", id);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            create_table();
            MessageBox.Show("Done!");
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
                total_label.Text = (double.Parse(intiprice_label_real.Text) * Convert.ToDouble(quantity_label_real.Text)).ToString();
            }
            catch
            {

            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //selected id
                int id = int.Parse(stockin_data.SelectedCells[0].Value.ToString());

                string query = string.Format("DELETE Stockout WHERE id ={0}", id);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                create_table();
                //MessageBox.Show("Done!");
            }
            catch
            {
                MessageBox.Show("Select row!");
            }
        }
    }
}
