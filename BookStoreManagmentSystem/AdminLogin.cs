namespace BookStoreManagmentSystem
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UPasswordTb.Text == "useradmin")
            {
                Books books = new Books();
                books.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wring Password. Contact The Admin");
            }
        }

        private void AdminLink_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
