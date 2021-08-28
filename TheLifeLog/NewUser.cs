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
            while(true)
            {
                if (p1TB.Text.Equals(p2TB.Text))
                {
                    
                }
                else
                {
                    ErrorLabel.Text = " \nYour passwords do not match";
                    break;
                }

                string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    string exists;
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserName = @us"))
                    {
                        cmd.Parameters.Add("@us", SqlDbType.NVarChar).Value = unTB.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if(sdr.Read())
                            {
                                exists = sdr["UserName"].ToString();
                            }
                            else
                            {
                                exists = null;
                            }
                            
                            
                        }
                    }
                    if (exists != null)
                    {
                        ErrorLabel.Text = "That username is already taken, pick another.";
                        break;
                    }
                    else
                    {
                        int newId = GetId();
                        if(newId == 0)
                        {
                            newId = 1;
                        }
                        SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserId, UserName, Password) VALUES (@id, @us, @pass)", con);
                        cmd.Parameters.AddWithValue("@id", newId);
                        cmd.Parameters.AddWithValue("@us", unTB.Text);
                        cmd.Parameters.AddWithValue("@pass", p1TB.Text);
                        int confirm = cmd.ExecuteNonQuery();

                        if (confirm > 0)
                        {
                            MessageBox.Show("Your account has been created.");
                        }


                    }
                    con.Close();
                }

                unTB.Text = "";
                p1TB.Text = "";
                p2TB.Text = "";
                ErrorLabel.Text = "";
                break;

            }


        }

        private void Setup()
        {
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using(SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO Budget SET Expenses = @ex, UserNums = @un, Income = @in, Total = @tot WHERE " +
                    "UserId = @id");
                cmd1.Parameters.AddWithValue("@ex", "Rent/Morgage:*Utilities:*Home Insurance:*Medical Insurance:*Car Expenses:*Gas:*Food:*Necessities:*Credit Card(s):*Debt:*Entertainment:*Subscriptions:*Phone:*Wifi:*Cable:*Gym:*Saving1s:*Other:");
                cmd1.Parameters.AddWithValue("@un", "0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0")
            }
        }

        private int GetId()
        {
            int num;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 UserId FROM Users ORDER BY UserId DESC"))
                {
                    
                    cmd.Connection = con;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            num = Convert.ToInt32(sdr["UserId"]);
                        }
                        else
                        {
                            num = 0;
                        }


                    }
                    con.Close();
                }
            }

            if (num > 0)
            {
                num += 1;
                return num;
            }
            else
            {
                return num;
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
