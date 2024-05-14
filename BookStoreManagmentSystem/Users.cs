using System.Data;
using System.Data.SqlClient;

namespace BookStoreManagmentSystem
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection Con = new SqlConnection("Data Source=ACER;Initial Catalog=BookShopManagmentSystem;Integrated Security=True;Encrypt=False");

        private void Populate()
        {
            try
            {
                Con.Open();
                string query = "select * from UserTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                UsersDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
            finally
            {
                Con.Close();
            }
        }

        private void Save()
        {
            if (UName.Text == "" || UPhone.Text == "" || UAddress.Text == "" || UPassword.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values('" + UName.Text + "', '" + UPhone.Text + "', '" + UAddress.Text + "', '" + UPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
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
            UName.Text = "";
            UPhone.Text = "";
            UAddress.Text = "";
            UPassword.Text = "";
        }

        int key = 0;
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
                    string query = "delete from UserTbl where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
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

        private void Update()
        {
            if (UName.Text == "" || UPhone.Text == "" || UAddress.Text == "" || UPassword.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTbl set UName='" + UName.Text + "', UPhone='" + UPhone.Text + "', UAdd='" + UAddress.Text + "', UPass=" + UPassword.Text + " where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
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

        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UName.Text = UsersDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            UPhone.Text = UsersDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            UAddress.Text = UsersDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            UPassword.Text = UsersDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (UName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UsersDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM UserTbl ";
            query += "WHERE UId LIKE '%' + @param + '%' ";
            query += "OR UName LIKE '%' + @param + '%' ";
            query += "OR UPhone LIKE '%' + @param + '%' ";
            query += "OR UAdd LIKE '%' + @param + '%' ";
            query += "OR UPass LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=BookShopManagmentSystem;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", SearchAllTbl.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        UsersDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void SearchAllTbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchAllTbl.Text = "";
            Populate();
            Con.Close();
        }

        private void clbl_Click(object sender, EventArgs e)
        {
            Category users = new();
            users.Show();
            this.Hide();
        }
    }
}
