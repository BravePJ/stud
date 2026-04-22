using Mysqlx.Expr;

namespace student_Information_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the username and password from the textboxes and remove extra spaces
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            // Check if username or password is empty
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return; // Stop the login process
            }
            // Create database connection object
            DBConnect db = new DBConnect();
            try
            {
                db.Open(); // Open database connection
                           // SQL query to count matching username and password
                string query = "SELECT COUNT(*) FROM userlogin WHERE " +
                    "username = @username AND password = @password";
                // Create MySQL command
                MySql.Data.MySqlClient.MySqlCommand cmd =
               new MySql.Data.MySqlClient.MySqlCommand(query,
                db.Connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                // Execute query and get result (number of matched records)
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose(); // Release command resources
                               // If exactly 1 record found, login successful
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    // Open Dashboard form
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    // Hide current Login form
                    this.Hide();
                }
                else
                {
                    // If no match found
                    MessageBox.Show("Invalid Username or Password.");
                }
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close(); // Close database connection
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.Show();
            // Hide current Login form
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

