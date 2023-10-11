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
    public partial class Employees : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        public Employees()
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
        //Submit Button & Next Button
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO clubcar.employee(employeeName, employeeType) VALUES('" + txb_Employee_Name.Text + "','" + txb_Employee_Type.Text + "')";
            executeQuery(insertQuery);
        }
        //Update Button
        private void Button_Update_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE clubcar.employee SET " +
            "employeeType='" + txb_Employee_Type.Text + "' " +
            "WHERE employeeName = '" + txb_Employee_Name.Text + "'";
            executeQuery(updateQuery);
        }
    }
}
