using System.Data;
using System.Data.SqlClient;

namespace BookStoreManagmentSystem
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection Con = new SqlConnection("Data Source=ACER;Initial Catalog=BookShopManagmentSystem;Integrated Security=True;Encrypt=False");
        int key = 0;

        private void Populate()
        {
            try
            {
                Con.Open();
                string query = "select * from BookTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BookDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void Filter()
        {
            try
            {
                Con.Open();
                string query = "select * from BookTbl where BCat='" + CatFiltrCb.SelectedItem.ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BookDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BPriceTb.Text == "" || BautTb.Text == "" || BCatCb.SelectedIndex == -1 || BQuanTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTbl values('" + BTitleTb.Text + "', '" + BautTb.Text + "', '" + BCatCb.SelectedItem.ToString() + "', '" + BQuanTb.Text + "', '" + BPriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void Reset()
        {
            BTitleTb.Text = "";
            BautTb.Text = "";
            BCatCb.SelectedIndex = -1;
            BCatCb.Text = "";
            BPriceTb.Text = "";
            BQuanTb.Text = "";
        }

        private void CatFiltrCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void BRefreshBtn_Click(object sender, EventArgs e)
        {
            CatFiltrCb.SelectedIndex = -1;
            CatFiltrCb.Text = "Filtr by Category";
            AllSearchTbl.Text = "";
            Populate();
            Con.Close();
        }

        private void BResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            BautTb.Text = BookDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            BCatCb.Text = BookDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            BQuanTb.Text = BookDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            BPriceTb.Text = BookDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void BDeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from BookTbl where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfully");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void BUpdateBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BPriceTb.Text == "" || BautTb.Text == "" || BCatCb.SelectedIndex == -1 || BQuanTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update BookTbl set BTitle='" + BTitleTb.Text + "', BAuthor='" + BautTb.Text + "', BCat='" + BCatCb.SelectedItem.ToString() + "', BQty=" + BQuanTb.Text + ", BPrice=" + BPriceTb.Text + " where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM BookTbl ";
            query += "WHERE BId LIKE '%' + @param + '%' ";
            query += "OR BTitle LIKE '%' + @param + '%' ";
            query += "OR BAuthor LIKE '%' + @param + '%' ";
            query += "OR BCat LIKE '%' + @param + '%' ";
            query += "OR BQty LIKE '%' + @param + '%' ";
            query += "OR BPrice LIKE '%' + @param + '%'";
            string con = "Data Source=ACER;Initial Catalog=BookShopManagmentSystem;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", AllSearchTbl.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        BookDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void AllSearchTbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}
    