using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TheLifeLog
{
    public partial class GoalsMain : Form
    {
        string currentGoalName;
        int userId;
        List<string> Tasks = new List<string>();
        List<string> Checks = new List<string>();

        public GoalsMain(int user)
        {
            InitializeComponent();
            GoalsButton.BackColor = Color.Gold;
            userId = user;

            for(int i = 0; i < 10; i++)
            {
                Checks.Add("0");
            }

            LoadGoals();
        }

        private void LoadGoals()
        {
            goalsCombo.Items.Clear();
            string constr = @"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True;";
            string sql = "SELECT GoalName from Goals WHERE UserId = (@id)";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand comboCom = new SqlCommand(sql, conn);
            comboCom.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            SqlDataReader reader = comboCom.ExecuteReader();
            while (reader.Read())
            {
                goalsCombo.Items.Add(reader[0]);
            }
        }

        private void SaveGoals(string sql, int option)
        {
            TextBox[] tb = {taskOneTB, taskTwoTB, taskThreeTB, taskFourTB, taskFiveTB, taskSixTB, taskSevenTB,
                taskEightTB, taskNineTB, taskTenTB};

            //writes data in textboxes to database
            for (int len = 0; len < tb.Length; len++)
            {
                Tasks.Add(tb[len].Text);
            }

            string task = String.Join("*", Tasks.ToArray());
            string check = String.Join("*", Checks.ToArray());

            //writes data in textboxes to database
            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True;");
            
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            if (option == 2)
            {
                cmd.Parameters.Add("@on", SqlDbType.NVarChar).Value = currentGoalName;
            }
            cmd.Parameters.Add("@gn", SqlDbType.NVarChar).Value = goalTB.Text;
            cmd.Parameters.Add("@gw", SqlDbType.NVarChar).Value = whyTB.Text;
            cmd.Parameters.Add("@gc", SqlDbType.NVarChar).Value = challengeTB.Text;
            cmd.Parameters.Add("@gm", SqlDbType.NVarChar).Value = motivateTB.Text;
            cmd.Parameters.Add("@gd", SqlDbType.NVarChar).Value = dateTB.Text;
            cmd.Parameters.Add("@Task", SqlDbType.NVarChar).Value = task;
            cmd.Parameters.Add("@Check", SqlDbType.NVarChar).Value = check;
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadGoals();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Goals (UserId, GoalName, GoalWhy, GoalChal, GoalMot, GoalDate, Tasks, Checks) VALUES (@id, @gn, @gw," +
                "@gc, @gm, @gd, @Task, @Check)";
            SaveGoals(sql, 1);
            MessageBox.Show("Your goal has been saved.");

        }

        private void goalsCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            string task, check;
            Tasks.Clear();
            Checks.Clear();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to open a different goal? Anything that hasn't been saved will be lost.", "Continue", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string choice = goalsCombo.Text;
                string constr = @"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Goals WHERE GoalName = @Name AND UserId = @id"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Name", choice);
                        cmd.Parameters.AddWithValue("@id", userId);
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            goalTB.Text = sdr["GoalName"].ToString();
                            whyTB.Text = sdr["GoalWhy"].ToString();
                            challengeTB.Text = sdr["GoalChal"].ToString();
                            motivateTB.Text = sdr["GoalMot"].ToString();
                            dateTB.Text = sdr["GoalDate"].ToString();
                            task = sdr["Tasks"].ToString();
                            check = sdr["Checks"].ToString();

                        }
                        con.Close();
                    }
                }

                currentGoalName = goalTB.Text;
                TextBox[] tb = {taskOneTB, taskTwoTB, taskThreeTB, taskFourTB, taskFiveTB, taskSixTB, taskSevenTB,
                taskEightTB, taskNineTB, taskTenTB};

                string[] tempArray = task.Split('*');
                foreach (string str in tempArray)
                {
                    Tasks.Add(str);
                }

                for (int len = 0; len < 10; len++)
                {
                    tb[len].Text = Tasks[len];
                }

                string[] tempArray2 = check.Split('*');
                foreach (string str in tempArray2)
                {
                    Checks.Add(str);
                }

                CheckMarks(0, true);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Goals SET UserId = @id, GoalName = @gn, GoalWhy = @gw, GoalChal = @gc, GoalMot = @gm, GoalDate = @gd, Tasks = @Task, Checks = @Check WHERE UserId = @id AND GoalName = @on";
            SaveGoals(sql, 2);
            MessageBox.Show("Your goal has been updated!");
        }

        private void CheckMarks(int pb, bool get)
        {
            PictureBox[] boxes = { cm1, cm2, cm3, cm4, cm5, cm6, cm7, cm8, cm9, cm10 };
            if(get)
            {
                for (int i = 0; i < Checks.Count; i++)
                {
                    if (Checks[i] == "0")
                    {
                        boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                    }
                    else if (Checks[i] == "1")
                    {
                        boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                    }
                }
            }
            else
            {
                if (Checks[pb] == "0")
                {
                    boxes[pb].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                    Checks[pb] = "1";
                }
                else if (Checks[pb] == "1")
                {
                    boxes[pb].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                    Checks[pb] = "0";
                }
            }
            
        }

        private void cm6_Click(object sender, EventArgs e)
        {
            CheckMarks(5, false);
        }

        private void cm5_Click(object sender, EventArgs e)
        {
            CheckMarks(4, false);
        }

        private void cm4_Click(object sender, EventArgs e)
        {
            CheckMarks(3, false);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            clearTB();
        }

        private void cm3_Click(object sender, EventArgs e)
        {
            CheckMarks(2, false);
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabitsButton_Click(object sender, EventArgs e)
        {
            Habits hb = new Habits();
            hb.Show();
            this.Hide();
        }

        private void cm2_Click(object sender, EventArgs e)
        {
            CheckMarks(1, false);
        }

        private void cm1_Click(object sender, EventArgs e)
        {
            CheckMarks(0, false);
        }

        private void cm7_Click(object sender, EventArgs e)
        {
            CheckMarks(6, false);
        }

        private void cm8_Click(object sender, EventArgs e)
        {
            CheckMarks(7, false);
        }

        private void cm9_Click(object sender, EventArgs e)
        {
            CheckMarks(8, false);
        }

        private void cm10_Click(object sender, EventArgs e)
        {
            CheckMarks(9, false);
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.Show("Start New Goal", label11);
        }

        private void clearTB()
        {
            goalTB.Clear();
            whyTB.Clear();
            challengeTB.Clear();
            motivateTB.Clear();
            dateTB.Clear();

            TextBox[] tb = {taskOneTB, taskTwoTB, taskThreeTB, taskFourTB, taskFiveTB, taskSixTB, taskSevenTB,
                taskEightTB, taskNineTB, taskTenTB};
            for (int i = 0; i < Tasks.Count; i++)
            {
                tb[i].Text = "";
                Checks[i] = "0";
            }

            CheckMarks(0, true);
        }

        
    }
}
