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
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        int user;

        public Login()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.Show();
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string exists;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Password, UserId FROM Users WHERE UserName = @us"))
                {
                    cmd.Parameters.Add("@us", SqlDbType.NVarChar).Value = unTB.Text;
                    cmd.Connection = con;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            exists = sdr["Password"].ToString();
                            user = Convert.ToInt32(sdr["UserId"]);

                        }
                        else
                        {
                            exists = null;
                        }


                    }
                }
                con.Close();
            }

            if(exists != null && exists == passTB.Text)
            {
                MessageBox.Show("Welcome to The Life Log, " + unTB.Text);
                Dashboard db = new Dashboard(user);
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your username or password is incorrect. Please try again.");
                unTB.Text = "";
                passTB.Text = "";
            }
        }
    }
}
