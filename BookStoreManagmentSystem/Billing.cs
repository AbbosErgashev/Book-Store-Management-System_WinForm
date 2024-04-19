using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BookStoreManagmentSystem
{
    public partial class Billing : Form
    {
        public Billing()
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
                string query = "select * from BookTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BooksListDGV.DataSource = ds.Tables[0];
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
        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if (Qty.Text == "" || Convert.ToInt32(Qty.Text) > stock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(Qty.Text) * Convert.ToInt32(Price.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BooksBillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BNameTb.Text;
                newRow.Cells[2].Value = Qty.Text;
                newRow.Cells[3].Value = Price.Text;
                newRow.Cells[4].Value = total;
                BooksBillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                GrdTotal = GrdTotal + total;
                TotalLbl.Text = "$ " + GrdTotal;
            }
        }
        int key = 0;
        int stock = 0;
        int n = 0;
        int GrdTotal = 0;

        private void BooksListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BNameTb.Text = BooksListDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            Price.Text = BooksListDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (BNameTb.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BooksListDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                stock = Convert.ToInt32(BooksListDGV.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }

        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(Qty.Text);
            try
            {
                Con.Open();
                string query = "update BookTbl set BQty=" + newQty + " where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                Populate();
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

        private void Reset()
        {
            BNameTb.Text = "";
            Qty.Text = "";
            Price.Text = "";
            CNameTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || BNameTb.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values('" + UsernameLbl.Text + "', '" + CNameTb.Text + "'," + GrdTotal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }

            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        int prodid, prodqty, prodprice, total, pos = 60;
        string prodname;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int centerX = e.PageBounds.Width / 2;

            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(centerX - 50, 10));
            e.Graphics.DrawString("ID Product Price Quantity Total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(centerX - 100, 40));

            int column1X = centerX - 200;
            int column2X = centerX - 150;
            int column3X = centerX;
            int column4X = centerX + 50;
            int column5X = centerX + 150;

            int rowSpacing = 30;
            int startPos = 70;

            int currentY = startPos;

            foreach (DataGridViewRow row in BooksBillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                total = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(column1X, currentY));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(column2X, currentY));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(column3X, currentY));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(column4X, currentY));
                e.Graphics.DrawString("" + total, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(column5X, currentY));
                pos = pos + 20;
            }

            int totalY = currentY + 50;

            if (BooksBillDGV.Rows.Count > 0)
            {
                int grandTotal = 0;
                foreach (DataGridViewRow row in BooksBillDGV.Rows)
                {
                    grandTotal += Convert.ToInt32(row.Cells["Column5"].Value);
                }

                e.Graphics.DrawString(" Grand Total: $ " + grandTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(centerX - 50, totalY));
            }

            e.Graphics.DrawString("*********** BookStore ***********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(centerX - 100, totalY + 50));

            BooksBillDGV.Rows.Clear();
            BooksBillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            UsernameLbl.Text = Login.UserName;
        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
