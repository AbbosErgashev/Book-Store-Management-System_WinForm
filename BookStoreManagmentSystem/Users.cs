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
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Reset()
        {
            UName.Text = "";
            UPhone.Text = "";
            UAddress.Text = "";
            UPassword.Text = "";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
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
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
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
                    string query = "update UserTbl set Name='" + UName.Text + "', UPhone='" + UPhone.Text + "', UAdd='" + UAddress.Text + "', UPass=" + UPassword.Text + " where UId=" + key + ";";
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Update();
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
    }
}
