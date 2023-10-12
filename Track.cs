using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubCar_TestTrack_AlphaVersion
{
    public partial class Track : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        public Track()
        {
            InitializeComponent();
        }
        //Opens SQL Connection
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
                    MessageBox.Show("Error: Please check All things submitted.");
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
        //Submit Button
        private void bttn_Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
