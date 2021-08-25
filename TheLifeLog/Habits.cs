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
    public partial class Habits : Form
    {
        int userId;
        readonly string yesDate = DateTime.Now.AddDays(-1).ToString("ddMM");
        readonly string today = DateTime.Now.ToString("ddMM");
        List<string> yesterday = new List<string>();
        List<string> checks = new List<string>();

        public Habits(int user)
        {
            InitializeComponent();
            userId = user;

            GetHabits();
            RefreshChecks();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] tb = {habitTB1, habitTB2, habitTB3, habitTB4, habitTB5, habitTB6, habitTB7, habitTB8, habitTB9,
                habitTB10};
                string habits = "";
                //writes data in textboxes to database};
                for (int len = 0; len < tb.Length; len++)
                {
                    habits += tb[len].Text + "*";
                }

                Label[] totals = {td1Label, td2Label, td3Label, td4Label, td5Label, td6Label, td7Label, td8Label,
                td9Label, td10Label};
                string tot = "";
                //writes data in textboxes to database};
                for (int len = 0; len < tb.Length; len++)
                {
                    tot += totals[len].Text + "*";
                }

                Label[] streaks = {cs1Label, cs2Label, cs3Label, cs4Label, cs5Label, cs6Label, cs7Label, cs8Label,
                cs9Label, cs10Label};
                string stk = "";
                for (int x = 0; x < streaks.Length; x++)
                {
                    stk += streaks[x].Text + "*";
                }

                string yes = String.Join("*", yesterday.ToArray());


                DataConnect dc = new DataConnect();
                int answer = dc.WriteHabit(userId, habits, tot, stk, yes);
                if (answer != 0)
                {
                    MessageBox.Show("Your habits were saved!");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong. Try again later.");
            }

            MessageBox.Show("Your habits have been saved!");
        }

        private void GetHabits()
        {
            try
            {
                DataConnect dc = new DataConnect();
                string list = dc.ReadHabit(userId);
                string[] tempArray = list.Split('|');

                TextBox[] tb = {habitTB1, habitTB2, habitTB3, habitTB4, habitTB5, habitTB6, habitTB7, habitTB8, habitTB9,
                habitTB10};
                string[] habits = tempArray[0].Split('*');
                for (int len = 0; len < tb.Length; len++)
                {
                    tb[len].Text = habits[len];
                }

                Label[] totals = {td1Label, td2Label, td3Label, td4Label, td5Label, td6Label, td7Label, td8Label,
                td9Label, td10Label};
                string[] tots = tempArray[1].Split('*');
                for(int x = 0; x < totals.Length; x++)
                {
                    totals[x].Text = tots[x];
                }

                Label[] streaks = {cs1Label, cs2Label, cs3Label, cs4Label, cs5Label, cs6Label, cs7Label, cs8Label,
                cs9Label, cs10Label};
                string[] stk = tempArray[2].Split('*');
                for (int x = 0; x < streaks.Length; x++)
                {
                    streaks[x].Text = stk[x];
                }

                string[] temp = tempArray[3].Split('*');
                foreach (string str in temp)
                {
                    yesterday.Add(str);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void RefreshChecks()
        {
            //Goes through the arrays and sets up what checkmarks need to be filled in
            PictureBox[] boxes = {pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10};

            for (int i = 0; i < boxes.Length; i++)
            {
                if (yesterday[i] == today)
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/Checked.png");
                    checks.Add("1");
                }
                else 
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checks.png");
                    checks.Add("0");
                }
            }
        }

        private void Checking(int pb)
        {
            PictureBox[] boxes = { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10 };
            Label[] totals = {td1Label, td2Label, td3Label, td4Label, td5Label, td6Label, td7Label, td8Label,
                td9Label, td10Label};
            Label[] streaks = {cs1Label, cs2Label, cs3Label, cs4Label, cs5Label, cs6Label, cs7Label, cs8Label,
                cs9Label, cs10Label};

            Validation val = new Validation();
            double totalNum = val.ToDigits(totals[pb].Text);
            double streak = val.ToDigits(streaks[pb].Text);

            if (checks[pb] == "0")
            {
                boxes[pb].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                checks[pb] = "1";
                totalNum++;

                if (yesterday[pb] == yesDate)
                {
                    streak++;
                }
                else
                {
                    streak = 0;

                }

                yesterday[pb] = today;
            }
            else if (checks[pb] == "1")
            {
                boxes[pb].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                checks[pb] = "0";
                totalNum--;

                if (yesterday[pb] == yesDate)
                {
                    streak--;
                }
                else
                {
                    streak = 0;
                }
            }
            totals[pb].Text = totalNum.ToString();
            streaks[pb].Text = streak.ToString();
            
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            Checking(9);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            Checking(8);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            Checking(7);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            Checking(6);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            Checking(5);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            Checking(4);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            Checking(3);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            Checking(2);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Checking(1);
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Checking(0);
        }
    }
}
