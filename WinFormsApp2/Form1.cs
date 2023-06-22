using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string name;
        private string email;
        private string contact;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //name = nameText.Text;
            email = emailText.Text;
            //contact = contactText.Text;
            //string value = "Name: " + name + " " + "Email: " + email + " " + "Contact: " + contact;
            //MessageBox.Show(value);
            //string[] rowData = { name, email, contact };
            //string filePath = "G:\\Dot Net/data.csv";

            //SaveDataToCSV(filePath, rowData);

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");

                return;
            }

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NBUE2H8\\SQLEXPRESS;Initial Catalog=day1;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into user_data(name,email,contact) values('" + nameText.Text+"','"+ emailText.Text+"', '"+ contactText.Text+"')", connection);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("save");
            }
            else
            {
                MessageBox.Show("error");
            }

            //string query ="INSERT INTO userdata(name, email, contact) VALUES (@name, @email, @contact)";

            //SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@name", name);
            //command.Parameters.AddWithValue("@email", email);
            //command.Parameters.AddWithValue("@contact", contact);

            //int rowsAffected = command.ExecuteNonQuery();

            //if (rowsAffected > 0)
            //{
            //    MessageBox.Show("Saved");
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}


            connection.Close();

        }
        //private void SaveDataToCSV(string filePath, string[] rowData)
        //{
        //    // Create or append the data to the CSV file
        //    using (StreamWriter writer = new StreamWriter(filePath, true))
        //    {
        //        string line = string.Join(",", rowData);
        //        writer.WriteLine(line);
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string searchEmail = findmailText.Text;

            // Establish connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NBUE2H8\\SQLEXPRESS;Initial Catalog=day1;Integrated Security=True"))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Construct the SQL query
                    string query = "SELECT COUNT(*) FROM user_data WHERE email = @email";

                    // Create the command object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the email parameter
                        command.Parameters.AddWithValue("@email", searchEmail);

                        // Execute the query and get the result
                        int count = (int)command.ExecuteScalar();

                        // Check if the email exists
                        if (count > 0)
                        {
                            MessageBox.Show("Email found in the database.");
                        }
                        else
                        {
                            MessageBox.Show("Email not found in the database.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any potential errors
                    MessageBox.Show("An error occurred while searching for the email: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    connection.Close();
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            // Use regex pattern for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
    }
}
