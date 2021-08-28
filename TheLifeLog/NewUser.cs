using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheLifeLog
{
    public partial class NewUser : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public NewUser()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                bool exists = false;
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserName = @us"))
                {
                    cmd.Parameters.Add("@us", SqlDbType.Int).Value = unTB.Text;
                    exists = (int)cmd.ExecuteScalar() > 0;
                }
                if (exists)
                {
                    ErrorLabel.Text = "That username is already taken, pick another.";
                }
                con.Close();

            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show(); 
            this.Close();
        }

        private void NewUser_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void NewUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void NewUser_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
