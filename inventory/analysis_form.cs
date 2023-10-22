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
    public partial class analysis_form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MY13-LABTOP;Initial Catalog=Einventory;Integrated Security=True");


        public void create_table()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Stockin", conn);
            DataTable dataTable = new DataTable();
            conn.Open();
            dataTable.Load(cmd.ExecuteReader());
            conn.Close();
            stockin_data.DataSource = dataTable;
        }

        public analysis_form()
        {
            InitializeComponent();
        }

        private void analysis_form_Load(object sender, EventArgs e)
        {
            create_table();
            //ratio itializer
            ratio.Value = 0;




            //The ratio between the incoming and outcoming.
            string query = "select sum(inti_price*quntity) FROM stockin";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            double stockin = Convert.ToDouble(reader[0]);
            conn.Close();

            query = "select sum(inti_price*quntity) FROM stockout;";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            reader.Read();

            double stockout = Convert.ToDouble(reader[0]);
            conn.Close();

            int stockratio = Convert.ToInt32((stockout / stockin) * 100);
            main_ratio.SubscriptText = "      " + Convert.ToInt32((stockout / stockin) * 100).ToString();
            outcoming.Text = stockout.ToString();
            incoming.Text = stockin.ToString();
            main_ratio.Value = 0;
            if(stockratio > 100)
            {
                main_ratio.Value = 100;
            }
            else
            {
                main_ratio.Value = stockratio;
            }

        }
        private void price_txtbox_clicked1(object sender, EventArgs e)
        {
            price_txtbox.Text = String.Empty;
        }
        private void price_txtbox_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stockreturn_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //first ratio
                ratio.Style = ProgressBarStyle.Continuous;
                double newprice = double.Parse(price_txtbox.Text);
                double oldprice = double.Parse(stockin_data.SelectedCells[2].Value.ToString());
                double real_ratio = (newprice/oldprice) * 100;
                ratio.SubscriptText = "      " + Convert.ToInt32(real_ratio).ToString();
                if(real_ratio > 100)
                {
                    ratio.Value = 100;
                }
                else
                {
                    ratio.Value = Convert.ToInt32(real_ratio);
                }

                




            }
            catch
            {
                MessageBox.Show("Enter correct price!");
            }
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM Stockin WHERE product_name LIKE '%{0}%'", search_txtbox.Text);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            conn.Close();
            stockin_data.DataSource = dataTable;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_txtbox_Click(object sender, EventArgs e)
        {
            search_txtbox.Text = String.Empty;
        }
    }
}
