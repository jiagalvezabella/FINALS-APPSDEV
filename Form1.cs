using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParkingSystemManagement
{
    public partial class Form1 : Form
    {
        // Connection string to your SQL Server database
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\ParkingSystemManagement\Database1.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT PlateNumber, VehicleBrand, VehicleType, Color, EntryTime, ExitTime FROM Transactions";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnParkVehicle_Click(object sender, EventArgs e)
        {
            string plateNumber = txtPlateNumber.Text;
            string vehicleBrand = txtVehicleBrand.Text;
            string vehicleType = txtVehicleType.Text;
            string color = txtColor.Text;
            DateTime entryTime = DateTime.Now;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Transactions (PlateNumber, VehicleBrand, VehicleType, Color, EntryTime) VALUES (@PlateNumber, @VehicleBrand, @VehicleType, @Color, @EntryTime)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                        command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);
                        command.Parameters.AddWithValue("@VehicleType", vehicleType);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@EntryTime", entryTime);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error parking vehicle: " + ex.Message);
            }

            // Refresh the DataGridView to show the new data
            LoadData();
        }

        private void btnExitVehicle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string plateNumber = selectedRow.Cells["PlateNumber"].Value.ToString();
                DateTime exitTime = DateTime.Now;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Transactions SET ExitTime = @ExitTime WHERE PlateNumber = @PlateNumber AND ExitTime IS NULL";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                            command.Parameters.AddWithValue("@ExitTime", exitTime);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exiting vehicle: " + ex.Message);
                }

                
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a vehicle to exit.");
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string plateNumber = selectedRow.Cells["PlateNumber"].Value.ToString();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Transactions WHERE PlateNumber = @PlateNumber";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@PlateNumber", plateNumber);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting vehicle: " + ex.Message);
                }

                
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.");
            }
        }

        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (selectedRow.Cells["EntryTime"].Value != DBNull.Value && selectedRow.Cells["ExitTime"].Value != DBNull.Value)
                {
                    DateTime entryTime = Convert.ToDateTime(selectedRow.Cells["EntryTime"].Value);
                    DateTime exitTime = Convert.ToDateTime(selectedRow.Cells["ExitTime"].Value);

                    TimeSpan duration = exitTime - entryTime;
                    double fee = CalculateFee(duration);

                    txtFee.Text = fee.ToString("C");
                }
                else
                {
                    MessageBox.Show("Selected vehicle does not have both entry and exit times.");
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to calculate the fee.");
            }
        }

        private double CalculateFee(TimeSpan duration)
        {
            double hourlyRate = 30.0; // Example hourly rate
            return duration.TotalHours * hourlyRate;
        }
    }
}
