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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.AddRange(new string[] { "ACT", "BSOA", "HM" });
            cmbSection.Items.AddRange(new string[] { "1A", "1B", "1C", "1D" });
            // Optional: no selection by default
            cmbCourse.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Declare inputs
            string firstname = txtFirstname.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            string course = cmbCourse.SelectedItem?.ToString();
            string section = cmbSection.SelectedItem?.ToString();
            string birthdate = txtBirthdate.Text.Trim();
            string ID = txtID.Text.Trim();
            int age;
            // Validate inputs
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty
            (lastname) ||
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

                string query = "INSERT INTO student_info (ID, firstname, lastname, course, section, age, birthdate,) " +
"VALUES (@id, @firstname, @lastname, @course, @section, @age, @birthdate,)";
                // Create the command
                MySql.Data.MySqlClient.MySqlCommand cmd =
                new MySql.Data.MySqlClient.MySqlCommand(query,
                db.Connection);
                // Add parameters
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@section", section);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@id", ID);

                // Execute the command
                cmd.ExecuteNonQuery();

                MessageBox.Show("Student added successfully!");

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                // Clear fields after save
                txtFirstname.Clear();
                txtLastname.Clear();
                cmbCourse.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtAge.Clear();
                txtBirthdate.Clear();
                txtID.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}