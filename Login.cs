using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace ParkingSystemManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\ParkingSystemManagement\Database1.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable result = new DataTable();
                    adapter.Fill(result);

                    if (result.Rows.Count > 0)
                    {
                        // Login successful
                        MessageBox.Show("Login successful!");
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                    // Placeholder for any initialization code needed when the form loads
        }
    }
}
