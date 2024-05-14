using System.Data.SqlClient;
using System.Data;

namespace BookStoreManagmentSystem
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection Con = new("Data Source=ACER;Initial Catalog=BookShopManagmentSystem;Integrated Security=True;Encrypt=False");
        int key = 0;

        private void Populate()
        {
            try
            {
                Con.Open();
                string query = "select * from CategoryTbl";
                SqlDataAdapter sda = new(query, Con);
                SqlCommandBuilder builder = new(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CategoryDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void Reset()
        {
            ctbl.Text = "";
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM CategoryTbl ";
            query += "WHERE CategoryId LIKE '%' + @param + '%' ";
            query += "OR CategoryName LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=BookShopManagmentSystem;Integrated Security=True;Encrypt=False";

            using SqlConnection conn = new(con);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@param", AllSearchTbl.Text);
            using SqlDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);
            CategoryDGV.DataSource = dt;
            return dt;
        }

        private void Save()
        {
            if (ctbl.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CategoryTbl values('" + ctbl.Text + "')";
                    SqlCommand cmd = new(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Saved Successfully");
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

        private void UpdateCategory()
        {
            if (ctbl.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CategoryTbl set CategoryName='" + ctbl.Text + "' where CategoryId=" + key + ";";
                    SqlCommand cmd = new(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully");
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

        private void Delete()
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
                    string query = "delete from CategoryTbl where CategoryId=" + key + ";";
                    SqlCommand cmd = new(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
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

        private void RestoreFilter()
        {
            AllSearchTbl.Text = "";
            Populate();
            Con.Close();
        }

        private void CategoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ctbl.Text = CategoryDGV.Rows[e.RowIndex].Cells["CategoryName"].FormattedValue.ToString();
            if (ctbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CategoryDGV.Rows[e.RowIndex].Cells["CategoryId"].FormattedValue.ToString());
            }
        }

        private void blbl_Click(object sender, EventArgs e)
        {
            Books users = new();
            users.Show();
            this.Hide();
        }

        private void ulbl_Click(object sender, EventArgs e)
        {
            Users users = new();
            users.Show();
            this.Hide();
        }

        private void dlbl_Click(object sender, EventArgs e)
        {
            Dashboard users = new();
            users.Show();
            this.Hide();
        }

        private void llbl_Click(object sender, EventArgs e)
        {
            Login users = new();
            users.Show();
            this.Hide();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateCategory();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RestoreFilter();
        }

        private void AllSearchTbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}