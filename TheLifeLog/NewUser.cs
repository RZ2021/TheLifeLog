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
                            Setup(newId);
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

        private void Setup(int id)
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using(SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO Budget (UserId, Expenses, UserNums, Income, Total) VALUES (@id, @ex, @un, @in, @tot)", conn);
                cmd1.Parameters.AddWithValue("@ex", "Rent/Morgage:*Utilities:*Home Insurance:*Medical Insurance:*Car Expenses:*Gas:*Food:*Necessities:*Credit Card(s):*Debt:*Entertainment:*Subscriptions:*Phone:*Wifi:*Cable:*Gym:*Saving1s:*Other:");
                cmd1.Parameters.AddWithValue("@un", "0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0*0.0");
                cmd1.Parameters.AddWithValue("@in", "0");
                cmd1.Parameters.AddWithValue("@tot", "0");
                cmd1.Parameters.AddWithValue("@id", id);

                SqlCommand cmd2 = new SqlCommand("INSERT INTO Habits (UserId, Habit, Total, Streak, Yesterday) VALUES (@id, @hab, @to, @str, @yes)", conn);
                cmd2.Parameters.AddWithValue("@hab", "Habit 1:*Habit 2:*Habit 3:*Habit 4:*Habit 5:*Habit 6:*Habit 7:*Habit 8:*Habit 9:*Habit 10:");
                cmd2.Parameters.AddWithValue("@to", "0*0*0*0*0*0*0*0*0*0");
                cmd2.Parameters.AddWithValue("@str", "0*0*0*0*0*0*0*0*0*0");
                cmd2.Parameters.AddWithValue("@yes", "0000*0000*0000*0000*0000*0000*0000*0000*0000*0000");
                cmd2.Parameters.AddWithValue("@id", id);

                SqlCommand cmd3 = new SqlCommand("INSERT INTO MealPlan (UserId, Meals) VALUES (@id, @meal)", conn);
                cmd3.Parameters.AddWithValue("@meal", "***************************");
                cmd3.Parameters.AddWithValue("@id", id);

                SqlCommand cmd4 = new SqlCommand("INSERT INTO MonthlyCalendar (UserId, Dates, Month, Year) VALUES (@id, @date, @mon, @year)", conn);
                cmd4.Parameters.AddWithValue("@date", "************************************");
                cmd4.Parameters.AddWithValue("@mon", month);
                cmd4.Parameters.AddWithValue("@year", year);
                cmd4.Parameters.AddWithValue("@id", id);

                SqlCommand cmd5 = new SqlCommand("INSERT INTO Savings (UserId, Goals, Names, CurrentTotal) VALUES (@id, @goal, @name, @cur)", conn);
                cmd5.Parameters.AddWithValue("@goal", "****");
                cmd5.Parameters.AddWithValue("@name", "****");
                cmd5.Parameters.AddWithValue("@cur", "0*0*0*0");
                cmd5.Parameters.AddWithValue("@id", id);

                SqlCommand cmd6 = new SqlCommand("INSERT INTO ShoppingList (UserId, ListOne, Checked, ListNames) VALUES (@id, @list, @check, @names)", conn);
                cmd6.Parameters.AddWithValue("@list", "******************************************************************************************************************************************************");
                cmd6.Parameters.AddWithValue("@check", "0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0*0");
                cmd6.Parameters.AddWithValue("@names", "Main*Home*Amazon*Gifts*Other*");
                cmd6.Parameters.AddWithValue("@id", id);

                SqlCommand cmd7 = new SqlCommand("INSERT INTO ToDo (UserId, ToDo, Checked, ListNum) VALUES (@id, @td, @ch, @num)", conn);
                cmd7.Parameters.AddWithValue("@td", "*********");
                cmd7.Parameters.AddWithValue("@ch", "0*0*0*0*0*0*0*0*0*0");
                cmd7.Parameters.AddWithValue("@num", 1);
                cmd7.Parameters.AddWithValue("@id", id);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();

                conn.Close();


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
