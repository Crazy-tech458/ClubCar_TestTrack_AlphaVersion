using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClubCar_TestTrack_AlphaVersion
{
    public partial class Holidays : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        public Holidays()
        {
            InitializeComponent();
        }
        // Opens SQL Connection
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        // Closes SQL Connection
        public void closedConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        // Executes any Query Commands
        public void executeQuery(String query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Submitted");
                }
                else if (rowsAffected == 0)
                {
                    MessageBox.Show("No rows were updated. Check your WHERE condition.");
                }
                else
                {
                    MessageBox.Show("Multiple rows updated. Check your WHERE condition.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                closedConnection();
            }
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
          //  string insertQuery = "INSERT INTO clubcar.holidays(HolidaysDate, HolidayName) VALUES('" + txb_Holidays_Date.Text + "','" + txb_Holiday_Name.Text + "')";
           // executeQuery(insertQuery);
            // Create an instance of the Holidays form
            Track TrackForm = new Track();

            // Hide the current form
            this.Hide();

            // Show the Holidays form
           TrackForm.Show();
        }
    }
}
