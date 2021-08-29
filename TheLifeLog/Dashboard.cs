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
        private readonly int userId;
        private bool mouseDown;
        private Point lastLocation;
        public Dashboard(int user)
        {
            InitializeComponent();
            userId = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ToDoProgress();
            CalendarPreview();
            motivationQuotes();
            SavingsPreview();
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

        private void ToDoProgress()
        {
            DataConnect dc = new DataConnect();
            string checks = dc.ReadTodo(userId, 1, 2);
            int count = 0;

            string[] tempArray = checks.Split('*');
            foreach (string str in tempArray)
            {
                if(str == "1")
                {
                    count++;
                }
            }

            string[] paths = { "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro1.png", "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro2.png", "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro3.png",
            "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro4.png", "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro5.png", "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro6.png",
            "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro7.png", "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro8.png", "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro9.png",
            "C:/Users/royet/source/repos/TheLifeLog/Images/tdPro10.png"};

            
            if(count == 0)
            {
                tdPro.Image = Image.FromFile(paths[0]);
                tdProLabel.Text = count + " Tasks Completed";
            }
            else if(count == 10)
            {
                tdPro.Image = Image.FromFile(paths[count - 1]);
                tdProLabel.Text = "Main list completed!!!";
            }
            else
            {
                tdPro.Image = Image.FromFile(paths[count - 1]);
                tdProLabel.Text = count + " Tasks Completed";
            }
        }


       

        private void CalendarPreview()
        {
            DataConnect dc = new DataConnect();
            string temp = dc.ReadCalendar(userId, 1);
            List<string> calData = new List<string>();

            string[] tempArray = temp.Split('*');
            foreach (string str in tempArray)
            {
                calData.Add(str);
            }
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            DateTime dt = new DateTime(year, month, 1);
            int start = (int)dt.DayOfWeek;
            int today = DateTime.Now.Day;

            if(start == 0)
            {
                start += today - 1;
            }
            else if (start == 1)
            {
                start += today - 1;
            }
            else if (start == 2)
            {
                start += today - 1;
            }
            else if (start == 3)
            {
                start += today - 1;
            }
            else if (start == 4)
            {
                start += today - 1;
            }
            else if (start == 5)
            {
                start += today - 1;
            }
            else if (start == 6)
            {
                start += today - 1;
            }

            int count = 0;

            if(calData[start] != "")
            {
                count++;
            }
            if(calData[start+1] != "")
            {
                count++;
            }
            if(calData[start+2] != "")
            {
                count++;
            }

            if (count == 1)
            {
                calendarDaysLabel.Text = count.ToString();
                label10.Text = "event";
            }
            else if(count == 0)
            {
                label1.Text = "";
                label10.Text = "";
                label2.Text = "No calendar preview available";
            }
            else
            {
                calendarDaysLabel.Text = count.ToString();
            }
        }


        private void SavingsPreview()
        {
            DataConnect dc = new DataConnect();
            string goals = dc.ReadSavings(userId, 1);
            string totals = dc.ReadSavings(userId, 3);

            List<double> Goals = new List<double>();
            List<double> Totals = new List<double>();

            string[] tempArray = goals.Split('*');
            foreach (string str in tempArray)
            {
                if(str == "")
                {
                    Goals.Add(0);
                }
                else
                {
                    Goals.Add(Convert.ToDouble(str));
                }
            }

            string[] tempArray2 = totals.Split('*');
            foreach (string str in tempArray2)
            {
                if (str == "")
                {
                    Totals.Add(0);
                }
                else
                {
                    Totals.Add(Convert.ToDouble(str));
                }
            }

            List<double> save = new List<double>();
            for(int x = 0; x < Totals.Count; x++)
            {
                if (Goals[x] != 0 && Totals[x] != 0)
                {
                    double done = Totals[x] / Goals[x] * 100;
                    done = 100 - done;
                    save.Add(Math.Round(done));
                }
            }

            var min = save.Min();
            percentLabel.Text = "You are " + min.ToString() + "% away from a savings goal!";

        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar(userId);
            cal.Show();
        }

        private void ToDoButton_Click(object sender, EventArgs e)
        {
            ToDo td = new ToDo(userId);
            td.Show();

        }

        private void MealPlanningButton_Click(object sender, EventArgs e)
        {
            MealPlan mp = new MealPlan(userId);
            mp.Show();

        }

        private void BudgetButton_Click(object sender, EventArgs e)
        {
            BudgetMain bm = new BudgetMain(userId);
            bm.Show();
        }

        private void ShoppingButton_Click(object sender, EventArgs e)
        {
            ShoppingList sl = new ShoppingList(userId);
            sl.Show();
        }

        private void GoalsButton_Click(object sender, EventArgs e)
        {
            GoalsMain gm = new GoalsMain(userId);
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
            CalendarPreview();
            ToDoProgress();
            SavingsPreview(); 
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
