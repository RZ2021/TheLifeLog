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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            todoProgress();
            calendarPreview();
            motivationQuotes();
            savingsPreview();

        }

        private void motivationQuotes()
        {
            String[] quotes = {"The secret to getting ahead is getting started.", "The best time to plant a tree was 20 years ago. " +
                    "The second best time is now.", "It’s hard to beat a person who never gives up.", "If people are doubting how far you can go, " +
                    "go so far that you can’t hear them anymore.", "Impossible is just an opinion.", "One day or day one. You decide.",
                    "Some people want it to happen, some wish it would happen, others make it happen.", "Don’t limit your challenges. Challenge your limits",};

            Random ran = new Random();
            int i = ran.Next(0, 7);

            motivationLabel.Text = quotes[i];
            motivationLabel.ForeColor = Color.Gold;
            
        }


        private void todoProgress()
        {
            string checkPos1, checkPos2, checkPos3, checkPos4, checkPos5, checkPos6, checkPos7, checkPos8, checkPos9, checkPos10;
            try
            {
                //Reads data from db and places it into variables
                string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Checked1, Checked2, Checked3, Checked4, Checked5, Checked6," +
                        "Checked7, Checked8, Checked9, Checked10 FROM ToDo"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            checkPos1 = sdr["Checked1"].ToString();
                            checkPos2 = sdr["Checked2"].ToString();
                            checkPos3 = sdr["Checked3"].ToString();
                            checkPos4 = sdr["Checked4"].ToString();
                            checkPos5 = sdr["Checked5"].ToString();
                            checkPos6 = sdr["Checked6"].ToString();
                            checkPos7 = sdr["Checked7"].ToString();
                            checkPos8 = sdr["Checked8"].ToString();
                            checkPos9 = sdr["Checked9"].ToString();
                            checkPos10 = sdr["Checked10"].ToString();

                        }
                        con.Close();
                    }
                }

                string[] checkedState = {checkPos1, checkPos2, checkPos3, checkPos4, checkPos5, checkPos6, checkPos7, checkPos8, checkPos9, checkPos10};
                int count = 0;
                foreach(string x in checkedState)
                {
                    if (x == "1")
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro1.png");
                    tdProLabel.Text = "1 Task Completed";
                }
                else if (count == 2)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro2.png");
                    tdProLabel.Text = "2 Tasks Completed";
                }
                else if (count == 3)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro3.png");
                    tdProLabel.Text = "3 Tasks Completed";
                }
                else if (count == 4)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro4.png");
                    tdProLabel.Text = "4 Tasks Completed";

                }
                else if (count == 5)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro5.png");
                    tdProLabel.Text = "5 Tasks Completed";

                }
                else if (count == 6)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro6.png");
                    tdProLabel.Text = "6 Tasks Completed";

                }
                else if (count == 7)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro7.png");
                    tdProLabel.Text = "7 Tasks Completed";

                }
                else if (count == 8)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro8.png");
                    tdProLabel.Text = "8 Tasks Completed";

                }
                else if (count == 9)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro9.png");
                    tdProLabel.Text = "9 Tasks Completed";

                }
                else if (count == 10)
                {
                    tdPro.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/tdPro10.png");
                    tdProLabel.Text = "All Tasks Completed!!!";

                }
                else 
                {
                    tdPro.Image = null;
                    tdProLabel.Text = "0 Tasks Completed";

                }
            }
            catch
            {
                tdPro.Image = null;
                tdProLabel.Text = "0 Tasks Completed";

            }

        }

        private void calendarPreview()
        {
           try
            {
                string d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22,
                d23, d24, d25, d26, d27, d28, d29, d30, d31, d32, d33, d34, d35, d36, d37;
                int mon, year;

                DateTime myDay = DateTime.Today;
                int today = myDay.Day;


                //Reads data from db 
                string constr = @"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Calendar"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            d1 = sdr["Box1"].ToString();
                            d2 = sdr["Box2"].ToString();
                            d3 = sdr["Box3"].ToString();
                            d4 = sdr["Box4"].ToString();
                            d5 = sdr["Box5"].ToString();
                            d6 = sdr["Box6"].ToString();
                            d7 = sdr["Box7"].ToString();
                            d8 = sdr["Box8"].ToString();
                            d9 = sdr["Box9"].ToString();
                            d10 = sdr["Box10"].ToString();
                            d11 = sdr["Box11"].ToString();
                            d12 = sdr["Box12"].ToString();
                            d13 = sdr["Box13"].ToString();
                            d14 = sdr["Box14"].ToString();
                            d15 = sdr["Box15"].ToString();
                            d16 = sdr["Box16"].ToString();
                            d17 = sdr["Box17"].ToString();
                            d18 = sdr["Box18"].ToString();
                            d19 = sdr["Box19"].ToString();
                            d20 = sdr["Box20"].ToString();
                            d21 = sdr["Box21"].ToString();
                            d22 = sdr["Box22"].ToString();
                            d23 = sdr["Box23"].ToString();
                            d24 = sdr["Box24"].ToString();
                            d25 = sdr["Box25"].ToString();
                            d26 = sdr["Box26"].ToString();
                            d27 = sdr["Box27"].ToString();
                            d28 = sdr["Box28"].ToString();
                            d29 = sdr["Box29"].ToString();
                            d30 = sdr["Box30"].ToString();
                            d31 = sdr["Box31"].ToString();
                            d32 = sdr["Box32"].ToString();
                            d33 = sdr["Box33"].ToString();
                            d34 = sdr["Box34"].ToString();
                            d35 = sdr["Box35"].ToString();
                            d36 = sdr["Box36"].ToString();
                            d37 = sdr["Box37"].ToString();
                            mon = Convert.ToInt32(sdr["Month"]);
                            year = Convert.ToInt32(sdr["Year"]);
                        }
                        con.Close();
                    }
                }

                if (mon != 0 && year != 0)
                {
                    DateTime dt = new DateTime(year, mon, 1);
                    int wday = (int)dt.DayOfWeek;
                    int i = 0;

                    if (wday == 0)
                    {
                        i = today;
                    }
                    else if (wday == 1)
                    {
                        i = today + 1;
                    }
                    else if (wday == 2)
                    {
                        i = today + 2;
                    }
                    else if (wday == 3)
                    {
                        i = today + 3;
                    }
                    else if (wday == 4)
                    {
                        i = today + 4;
                    }
                    else if (wday == 5)
                    {
                        i = today + 5;
                    }
                    else if (wday == 6)
                    {
                        i = today + 6;
                    }

                    string[] calendarDays = {d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22,
                    d23, d24, d25, d26, d27, d28, d29, d30, d31, d32, d33, d34, d35, d36, d37};

                    int events = isEmpty(calendarDays[i - 1], calendarDays[i], calendarDays[i + 1]);

                    if (events == 1)
                    {
                        calendarDaysLabel.Text = events.ToString();
                        label10.Text = "event";
                    }
                    else
                    {
                        calendarDaysLabel.Text = events.ToString();
                    }
                }
                else
                {
                    label1.Text = "";
                    label10.Text = "";
                    label2.Text = "No calendar preview available";
                }
            }
            catch
            {
                label2.Text = "No calendar preview available";
            }

        }

        private void savingsPreview()
        {
            string goalOne, goalOnePro, goalTwo, goalTwoPro, goalThree, goalThreePro, goalFour, goalFourPro;
            double p1, p2, p3, p4;
            //Reads data from db and places it into variables
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Savings"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();

                        goalOne = sdr["GoalOneGoal"].ToString();
                        goalOnePro = sdr["GoalOneProgress"].ToString();

                        goalTwo = sdr["GoalTwoGoal"].ToString();
                        goalTwoPro = sdr["GoalTwoProgress"].ToString();

                        goalThree = sdr["GoalThreeGoal"].ToString();
                        goalThreePro = sdr["GoalThreeProgress"].ToString();

                        goalFour = sdr["GoalFourGoal"].ToString();
                        goalFourPro = sdr["GoalFourProgress"].ToString();

                    }
                    con.Close();
                }
            }
            if (goalOnePro == " " && goalOne == " ")
            {
                p1 = 0;

            }
            else
            {
                p1 = Convert.ToDouble(goalOnePro) / Convert.ToDouble(goalOne);
            }

            if (goalTwoPro == " " && goalTwo == " ")
            {
                p2 = 0;
            }
            else
            {
                p2 = Convert.ToDouble(goalTwoPro) / Convert.ToDouble(goalTwo);

            }

            if (goalThreePro == " " && goalThree == " ")
            {
                p3 = 0;
            }
            else
            {

                p3 = Convert.ToDouble(goalThreePro) / Convert.ToDouble(goalThree);
            }

            if (goalFourPro == " " && goalFour == " ")
            {
                p4 = 0;
            }
            else
            {
                p4 = Convert.ToDouble(goalFourPro) / Convert.ToDouble(goalFour);
            }

            double[] nums = { p1, p2, p3, p4 };
            double big = nums.Max();
            big = Math.Round((100 - (big * 100)), 1);



            if (big == 100 || big == 0)
            {
                percentLabel.Text = "You have no saving goals at the moment.";
                
            }
            else
            {
                percentLabel.Text = "You are " + big.ToString() + "% away from a savings goal!";
            }


        }

        int isEmpty(string day1, string day2, string day3)
        {
            int counter = 0;
            if (day1 != "" && day1 != " ")
            {
                counter++;
            }

            if (day2 != "" && day2 != " ")
            {
                counter++;
            }

            if (day3 != "" && day3 != " ")
            {
                counter++;
            }

            return counter;
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar(1);
            cal.Show();


        }

        private void ToDoButton_Click(object sender, EventArgs e)
        {
            ToDo td = new ToDo(1);
            td.Show();

        }

        private void MealPlanningButton_Click(object sender, EventArgs e)
        {
            MealPlan mp = new MealPlan();
            mp.Show();


        }

        private void BudgetButton_Click(object sender, EventArgs e)
        {
            BudgetMain bm = new BudgetMain();
            bm.Show();


        }

        private void ShoppingButton_Click(object sender, EventArgs e)
        {
            ShoppingList sl = new ShoppingList();
            sl.Show();


        }

        private void GoalsButton_Click(object sender, EventArgs e)
        {
            GoalsMain gm = new GoalsMain();
            gm.Show();


        }

        private void CleaningButton_Click(object sender, EventArgs e)
        {
            Cleaning clean = new Cleaning();
            clean.Show();


        }

        private void CalendarButton_MouseHover(object sender, EventArgs e)
        {
            CalendarButton.BackColor = Color.Gold;
        }

        private void CalendarButton_MouseLeave(object sender, EventArgs e)
        {
            CalendarButton.BackColor = Color.MediumTurquoise;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            calendarPreview();
            todoProgress();
            savingsPreview();
            
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToDoButton_MouseHover(object sender, EventArgs e)
        {
            ToDoButton.BackColor = Color.Gold;
        }

        private void ToDoButton_MouseLeave(object sender, EventArgs e)
        {
            ToDoButton.BackColor = Color.MediumTurquoise;

        }

        private void GoalsButton_MouseHover(object sender, EventArgs e)
        {
            GoalsButton.BackColor = Color.Gold;

        }

        private void GoalsButton_MouseLeave(object sender, EventArgs e)
        {
            GoalsButton.BackColor = Color.MediumTurquoise;

        }

        private void BudgetButton_MouseHover(object sender, EventArgs e)
        {
            BudgetButton.BackColor = Color.Gold;

        }

        private void BudgetButton_MouseLeave(object sender, EventArgs e)
        {
            BudgetButton.BackColor = Color.MediumTurquoise;

        }

        private void ShoppingButton_MouseHover(object sender, EventArgs e)
        {
            ShoppingButton.BackColor = Color.Gold;

        }

        private void ShoppingButton_MouseLeave(object sender, EventArgs e)
        {
            ShoppingButton.BackColor = Color.MediumTurquoise;

        }

        private void MealPlanningButton_MouseHover(object sender, EventArgs e)
        {
            MealPlanningButton.BackColor = Color.Gold;

        }

        private void MealPlanningButton_MouseLeave(object sender, EventArgs e)
        {
            MealPlanningButton.BackColor = Color.MediumTurquoise;

        }

        private void CleaningButton_MouseHover(object sender, EventArgs e)
        {
            CleaningButton.BackColor = Color.Gold;

        }

        private void CleaningButton_MouseLeave(object sender, EventArgs e)
        {
            CleaningButton.BackColor = Color.MediumTurquoise;

        }
    }
}
