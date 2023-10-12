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
    public partial class Login_ClubCar : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        public Login_ClubCar()
        {
            InitializeComponent();
        }
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
        //Login Button
        private void bttn_Login_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO clubcar.employeelogin(username, password) VALUES('" + txb_Username.Text + "','" + txb_Password.Text + "')";
            executeQuery(insertQuery);

            Club_Car_Test_Track_Alpha_Version mainForm = new Club_Car_Test_Track_Alpha_Version();
            this.Hide(); // Hide the login form
            mainForm.Show(); // Show the main application form
        }
        //Clear Button
        private void bttn_Clear_Click(object sender, EventArgs e)
        {
            txb_Username.Text = "";
            txb_Password.Text = "";
        }
        //Exit Button
        private void bttn_Exit_Click(object sender, EventArgs e)
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
