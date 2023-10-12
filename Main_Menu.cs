using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubCar_TestTrack_AlphaVersion
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void bttn_Car_Submission_Click(object sender, EventArgs e)
        {
            Club_Car_Test_Track_Alpha_Version mainForm = new Club_Car_Test_Track_Alpha_Version();
            this.Hide(); // Hide the Screen form
            mainForm.Show(); // Show the main application form
        }

        private void bttn_Employee_Submission(object sender, EventArgs e)
        {
              Employees Employees = new Employees();

            // Hide the current form
              this.Hide();

             //Show the Employees form
             Employees.Show();
        }

        private void bttn_Holidays_Click(object sender, EventArgs e)
        {
            // Create an instance of the Holidays form
            Holidays holidaysForm = new Holidays();

            // Hide the current form
            this.Hide();

            // Show the Holidays form
            holidaysForm.Show();
        }

        private void bttn_Tracks_Click(object sender, EventArgs e)
        {
            // Create an instance of the Holidays form
            Track TrackForm = new Track();

            // Hide the current form
            this.Hide();

            // Show the Holidays form
            TrackForm.Show();
        }
    }
}
