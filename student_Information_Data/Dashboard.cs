using Mysqlx.Crud;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_Information_Data
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbSection.Items.AddRange(new string[] { "1A", "1B", "1C", "1D" });
            // Optional: no selection by default
            cmbCourse.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
        }

        private void LoadStudents()
        {
            string search = txtSearch.Text.Trim();
            // Create a new database connection using the simplified DBConnect class
            DBConnect db = new DBConnect();
            try
            {

                // Open the connection to MySQL
                db.Open();
                // SQL query to select all columns from the students table
                string query = @"SELECT id, firstname, lastname, course,
section, age, birthdate
                FROM student_info
WHERE firstname LIKE @search
OR lastname LIKE @search
OR course LIKE @search
OR section LIKE @search
OR birthdate LIKE @search";

                // Create a command to execute the SQL query
                MySql.Data.MySqlClient.MySqlCommand cmd = new
                MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                // Add wildcards for partial search
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                // DataAdapter is used to fill a DataTable with the query results
                MySql.Data.MySqlClient.MySqlDataAdapter adapter =
                new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                // Create a DataTable to store the query results
                System.Data.DataTable table = new System.Data.DataTable();
                // Fill the DataTable with data from the database
                adapter.Fill(table);
                // Bind the DataTable to the DataGridView to display data
                dgvStudents.DataSource = table;
                // Change column headers to be more readable
                dgvStudents.Columns["id"].HeaderText = "Student ID";
                dgvStudents.Columns["firstname"].HeaderText = "First Name";
                dgvStudents.Columns["lastname"].HeaderText = "Last Name";
                dgvStudents.Columns["course"].HeaderText = "Course";
                dgvStudents.Columns["section"].HeaderText = "Section";
                dgvStudents.Columns["age"].HeaderText = "Age";
                dgvStudents.Columns["birthdate"].HeaderText = "Birthdate";

                // Dispose command and adapter to free resources
                adapter.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Always close the database connection
                db.Close();

            }
        }
        private void dgvStudents_CellClick(object sender,
DataGridViewCellEventArgs e)
        {
            // Prevent error when clicking header
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                // Transfer values to controls
                txtID.Text = row.Cells["id"].Value.ToString();
                txtFirstname.Text = row.Cells["firstname"].Value.ToString();
                txtLastname.Text = row.Cells["lastname"].Value.ToString();
                cmbCourse.Text = row.Cells["course"].Value.ToString();
                cmbSection.Text = row.Cells["section"].Value.ToString();
                txtAge.Text = row.Cells["age"].Value.ToString();
                txtBrithdate.Text = row.Cells["birthdate"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //Declare inputs
            string firstName = txtFirstname.Text.Trim();
            string lastName = txtLastname.Text.Trim();
            string course = cmbCourse.SelectedItem.ToString();
            string section = cmbSection.SelectedItem.ToString();
            string birthdate = txtBrithdate.Text.Trim();
            int age;
            int ID;
            // Validate ID
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please Click Record to Update");
                return;
            }
            // Validate inputs
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty
            (lastName) ||
            string.IsNullOrEmpty(course) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            // Validate inputs age
            if (!int.TryParse(txtAge.Text.Trim(), out age))
            {
                MessageBox.Show("Please enter a valid age.");

                return;
            }

            //Call connection string
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                string query = @"UPDATE students
SET firstname=@firstname,
lastname=@lastname,
course=@course,
section=@section,
age=@age
birthdate=@birthdate
WHERE id=@id";
                // Create the command
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query,
                db.Connection))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@firstname",
                    txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                    cmd.Parameters.AddWithValue("@course", cmbCourse.Text);
                    cmd.Parameters.AddWithValue("@section", cmbSection.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@birthdate", txtBrithdate.Text);
                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Record Updated Successfully!");
                // Clear fields after UPDATE
                txtID.Clear();
                txtFirstname.Clear();
                txtLastname.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtAge.Clear();
                txtBrithdate.Clear();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                db.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DELETE BUTTON
            int ID;
            // Validate ID
            if (!int.TryParse(txtID.Text.Trim(), out ID))
            {
                MessageBox.Show("Please select a student first.");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student ? "
            , "Confirm Delete"
            , MessageBoxButtons.YesNo
            , MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            DBConnect db = new DBConnect();
            try
            {
                db.Open();
                // SQL DELETE command
                string query = "DELETE FROM students WHERE id=@id";
                MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(query,
                db.Connection);
                // Parameter
                cmd.Parameters.AddWithValue("@id", ID);
                // Execute delete
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                MessageBox.Show("Student deleted successfully!");
                // Refresh DataGridView
                // Clear fields after UPDATE
                txtID.Clear();
                txtFirstname.Clear();
                txtLastname.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtAge.Clear();
                txtBrithdate.Clear();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}

