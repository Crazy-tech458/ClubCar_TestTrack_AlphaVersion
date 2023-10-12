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
    public partial class Club_Car_Test_Track_Alpha_Version : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        public Club_Car_Test_Track_Alpha_Version()
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
        //Submit Button
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO clubcar.car(carID, carType, projectName, carRequestedMiles, startDate, needDate, maxMilesDay, requestor) VALUES('" + txb_carID.Text + "','" + txb_Car_Type.Text + "','" + txb_Project_Name.Text + "','" + txb_Car_Requested_Miles.Text + "','" + DTP_StartDate.Value + "','" + DTP_NeedDate.Value + "','" + txb_Max_Miles_Day.Text + "','" + txb_Requestor.Text + "')";
            executeQuery(insertQuery);
            // Create an instance of the Employees form
          //  Employees Employees = new Employees();

            // Hide the current form
          //  this.Hide();

            // Show the Employees form
           // Employees.Show();
        }
        //Update Button
        private void Update_Button_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE clubcar.car SET " +
              "carType='" + txb_Car_Type.Text + "', " +
              "projectName='" + txb_Project_Name.Text + "', " +
             "carRequestedMiles='" + txb_Car_Requested_Miles.Text + "', " +
             "maxMilesDay='" + txb_Max_Miles_Day.Text + "', " +
             "requestor='" + txb_Requestor.Text + "' " +
             "WHERE carID='" + txb_carID.Text + "'";
            executeQuery(updateQuery);
        }
        //Delete Button
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM clubcar.car WHERE carID = " + txb_carID.Text;
            executeQuery(deleteQuery);
        }
        //Exit Button
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to exit? Any unsubmitted information may be losted.";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
