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
    public partial class GoalsMain : Form
    {
        int check1 = 0, check2 = 0, check3 = 0, check4 = 0, check5 = 0, check6 = 0, check7 = 0, check8 = 0, check9 = 0, check10 = 0;
        string currentGoal;

        

        public GoalsMain()
        {
            InitializeComponent();
        }

        private void GoalsMain_Load(object sender, EventArgs e)
        {
            GoalsButton.BackColor = Color.Gold;

            
            currentGoal = goalTB.Text;
            string constr = @"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;";
            string sql = "SELECT goalName from Goals";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand comboCom = new SqlCommand(sql, conn);
            SqlDataReader reader = comboCom.ExecuteReader();
            while (reader.Read())
            {
                goalsCombo.Items.Add(reader[0]);
            }
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            //writes data in textboxes to database
            string g1 = goalTB.Text;
            string g2 = whyTB.Text;
            string g3 = challengeTB.Text;
            string g4 = motivateTB.Text;
            string g5 = dateTB.Text;
            string g6 = taskOneTB.Text;
            string g7 = taskTwoTB.Text;
            string g8 = taskThreeTB.Text;
            string g9 = taskFourTB.Text;
            string g10 = taskFiveTB.Text;
            string g11 = taskSixTB.Text;
            string g12 = taskSevenTB.Text;
            string g13 = taskEightTB.Text;
            string g14 = taskNineTB.Text;
            string g15 = taskTenTB.Text;

            String[] boxes = { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15 };
            int i = 0;
            if(boxes[i] == null)
            {
                boxes[i] = " ";
            }


            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");

            string sql = "INSERT INTO Goals (goalName, goalWhy, goalChallenges, goalMotivation, goalDate, taskOne, taskTwo, taskThree," +
                "taskFour, taskFive, taskSix, taskSeven, taskEight, taskNine, taskTen, checkmarkOne, checkmarkTwo, checkmarkThree," +
                "checkmarkFour, checkmarkFive, checkmarkSix, checkmarkSeven, checkmarkEight, checkmarkNine, checkmarkTen) VALUES (@appt1," +
                "@appt2, @appt3, @appt4, @appt5, @appt6, @appt7, @appt8, @appt9, @appt10, @appt11, @appt12, @appt13, @appt14, @appt15," +
                "@appt16, @appt17, @appt18, @appt19, @appt20, @appt21, @appt22, @appt23, @appt24, @appt25)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@appt1", SqlDbType.VarChar);
            cmd.Parameters["@appt1"].Value = g1;
            cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
            cmd.Parameters["@appt2"].Value = g2;
            cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
            cmd.Parameters["@appt3"].Value = g3;
            cmd.Parameters.Add("@appt4", SqlDbType.VarChar);
            cmd.Parameters["@appt4"].Value = g4;
            cmd.Parameters.Add("@appt5", SqlDbType.VarChar);
            cmd.Parameters["@appt5"].Value = g5;
            cmd.Parameters.Add("@appt6", SqlDbType.VarChar);
            cmd.Parameters["@appt6"].Value = g6;
            cmd.Parameters.Add("@appt7", SqlDbType.VarChar);
            cmd.Parameters["@appt7"].Value = g7;
            cmd.Parameters.Add("@appt8", SqlDbType.VarChar);
            cmd.Parameters["@appt8"].Value = g8;
            cmd.Parameters.Add("@appt9", SqlDbType.VarChar);
            cmd.Parameters["@appt9"].Value = g9;
            cmd.Parameters.Add("@appt10", SqlDbType.VarChar);
            cmd.Parameters["@appt10"].Value = g10;
            cmd.Parameters.Add("@appt11", SqlDbType.VarChar);
            cmd.Parameters["@appt11"].Value = g11;
            cmd.Parameters.Add("@appt12", SqlDbType.VarChar);
            cmd.Parameters["@appt12"].Value = g12;
            cmd.Parameters.Add("@appt13", SqlDbType.VarChar);
            cmd.Parameters["@appt13"].Value = g13;
            cmd.Parameters.Add("@appt14", SqlDbType.VarChar);
            cmd.Parameters["@appt14"].Value = g14;
            cmd.Parameters.Add("@appt15", SqlDbType.VarChar);
            cmd.Parameters["@appt15"].Value = g15;
            cmd.Parameters.Add("@appt16", SqlDbType.Int);
            cmd.Parameters["@appt16"].Value = check1;
            cmd.Parameters.Add("@appt17", SqlDbType.Int);
            cmd.Parameters["@appt17"].Value = check2;
            cmd.Parameters.Add("@appt18", SqlDbType.Int);
            cmd.Parameters["@appt18"].Value = check3;
            cmd.Parameters.Add("@appt19", SqlDbType.Int);
            cmd.Parameters["@appt19"].Value = check4;
            cmd.Parameters.Add("@appt20", SqlDbType.Int);
            cmd.Parameters["@appt20"].Value = check5;
            cmd.Parameters.Add("@appt21", SqlDbType.Int);
            cmd.Parameters["@appt21"].Value = check6;
            cmd.Parameters.Add("@appt22", SqlDbType.Int);
            cmd.Parameters["@appt22"].Value = check7;
            cmd.Parameters.Add("@appt23", SqlDbType.Int);
            cmd.Parameters["@appt23"].Value = check8;
            cmd.Parameters.Add("@appt24", SqlDbType.Int);
            cmd.Parameters["@appt24"].Value = check9;
            cmd.Parameters.Add("@appt25", SqlDbType.Int);
            cmd.Parameters["@appt25"].Value = check10;

            cmd.ExecuteNonQuery();

            MessageBox.Show("Your goal has been saved.");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            currentGoal = goalTB.Text;
            string g1 = goalTB.Text;
            string g2 = whyTB.Text;
            string g3 = challengeTB.Text;
            string g4 = motivateTB.Text;
            string g5 = dateTB.Text;
            string g6 = taskOneTB.Text;
            string g7 = taskTwoTB.Text;
            string g8 = taskThreeTB.Text;
            string g9 = taskFourTB.Text;
            string g10 = taskFiveTB.Text;
            string g11 = taskSixTB.Text;
            string g12 = taskSevenTB.Text;
            string g13 = taskEightTB.Text;
            string g14 = taskNineTB.Text;
            string g15 = taskTenTB.Text;

            String[] boxes = { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15 };
            int i = 0;
            if (boxes[i] == null)
            {
                boxes[i] = " ";
            }

            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");
            string sql = "UPDATE Goals SET goalName = (@appt), goalWhy = (@appt2), goalChallenges = (@appt3), goalMotivation = (@appt4), goalDate = (@appt5)," +
                "taskOne = (@appt6), taskTwo = (@appt7), taskThree = (@appt8), taskFour = (@appt9), taskFive = (@appt10), taskSix = (@appt11), taskSeven = (@appt12), " +
                "taskEight = (@appt13), taskNine = (@appt14), taskTen = (@appt15), checkmarkOne = (@appt16), checkmarkTwo = (@appt17), checkmarkThree = (@appt18)," +
                "checkmarkFour = (@appt19), checkmarkFive = (@appt20), checkmarkSix = (@appt21), checkmarkSeven = (@appt22), checkmarkEight = (@appt23), checkmarkNine = (@appt24), checkmarkTen = (@appt25) WHERE goalName = @Name";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@Name", SqlDbType.VarChar);
            cmd.Parameters["@Name"].Value = currentGoal;
            cmd.Parameters.Add("@appt", SqlDbType.VarChar);
            cmd.Parameters["@appt"].Value = g1;
            cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
            cmd.Parameters["@appt2"].Value = g2;
            cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
            cmd.Parameters["@appt3"].Value = g3;
            cmd.Parameters.Add("@appt4", SqlDbType.VarChar);
            cmd.Parameters["@appt4"].Value = g4;
            cmd.Parameters.Add("@appt5", SqlDbType.VarChar);
            cmd.Parameters["@appt5"].Value = g5;
            cmd.Parameters.Add("@appt6", SqlDbType.VarChar);
            cmd.Parameters["@appt6"].Value = g6;
            cmd.Parameters.Add("@appt7", SqlDbType.VarChar);
            cmd.Parameters["@appt7"].Value = g7;
            cmd.Parameters.Add("@appt8", SqlDbType.VarChar);
            cmd.Parameters["@appt8"].Value = g8;
            cmd.Parameters.Add("@appt9", SqlDbType.VarChar);
            cmd.Parameters["@appt9"].Value = g9;
            cmd.Parameters.Add("@appt10", SqlDbType.VarChar);
            cmd.Parameters["@appt10"].Value = g10;
            cmd.Parameters.Add("@appt11", SqlDbType.VarChar);
            cmd.Parameters["@appt11"].Value = g11;
            cmd.Parameters.Add("@appt12", SqlDbType.VarChar);
            cmd.Parameters["@appt12"].Value = g12;
            cmd.Parameters.Add("@appt13", SqlDbType.VarChar);
            cmd.Parameters["@appt13"].Value = g13;
            cmd.Parameters.Add("@appt14", SqlDbType.VarChar);
            cmd.Parameters["@appt14"].Value = g14;
            cmd.Parameters.Add("@appt15", SqlDbType.VarChar);
            cmd.Parameters["@appt15"].Value = g15;
            cmd.Parameters.Add("@appt16", SqlDbType.Int);
            cmd.Parameters["@appt16"].Value = check1;
            cmd.Parameters.Add("@appt17", SqlDbType.Int);
            cmd.Parameters["@appt17"].Value = check2;
            cmd.Parameters.Add("@appt18", SqlDbType.Int);
            cmd.Parameters["@appt18"].Value = check3;
            cmd.Parameters.Add("@appt19", SqlDbType.Int);
            cmd.Parameters["@appt19"].Value = check4;
            cmd.Parameters.Add("@appt20", SqlDbType.Int);
            cmd.Parameters["@appt20"].Value = check5;
            cmd.Parameters.Add("@appt21", SqlDbType.Int);
            cmd.Parameters["@appt21"].Value = check6;
            cmd.Parameters.Add("@appt22", SqlDbType.Int);
            cmd.Parameters["@appt22"].Value = check7;
            cmd.Parameters.Add("@appt23", SqlDbType.Int);
            cmd.Parameters["@appt23"].Value = check8;
            cmd.Parameters.Add("@appt24", SqlDbType.Int);
            cmd.Parameters["@appt24"].Value = check9;
            cmd.Parameters.Add("@appt25", SqlDbType.Int);
            cmd.Parameters["@appt25"].Value = check10;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your goal has been updated!");
        }

        private void cm6_Click(object sender, EventArgs e)
        {
            if (check6 == 0)
            {
                cm6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check6 = 1;
            }
            else if (check6 == 1)
            {
                cm6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check6 = 0;
            }
        }

        private void cm5_Click(object sender, EventArgs e)
        {
            if (check5 == 0)
            {
                cm5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check5 = 1;
            }
            else if (check5 == 1)
            {
                cm5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check5 = 0;
            }
        }

        private void goalsCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to open a different goal? Anything that hasn't been saved will be lost.", "Continue", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string choice = goalsCombo.Text;
                string constr = @"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Goals WHERE goalName = @Name"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Name", choice);
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {

                            sdr.Read();
                            goalTB.Text = sdr["goalName"].ToString();
                            whyTB.Text = sdr["goalWhy"].ToString();
                            challengeTB.Text = sdr["goalChallenges"].ToString();
                            motivateTB.Text = sdr["goalMotivation"].ToString();
                            dateTB.Text = sdr["goalDate"].ToString();
                            taskOneTB.Text = sdr["taskOne"].ToString();
                            taskTwoTB.Text = sdr["taskTwo"].ToString();
                            taskThreeTB.Text = sdr["taskThree"].ToString();
                            taskFourTB.Text = sdr["taskFour"].ToString();
                            taskFiveTB.Text = sdr["taskFive"].ToString();
                            taskSixTB.Text = sdr["taskSix"].ToString();
                            taskSevenTB.Text = sdr["taskSeven"].ToString();
                            taskEightTB.Text = sdr["taskEight"].ToString();
                            taskNineTB.Text = sdr["taskNine"].ToString();
                            taskTenTB.Text = sdr["taskTen"].ToString();
                            check1 = Convert.ToInt32(sdr["checkmarkOne"]);
                            check2 = Convert.ToInt32(sdr["checkmarkTwo"]);
                            check3 = Convert.ToInt32(sdr["checkmarkThree"]);
                            check4 = Convert.ToInt32(sdr["checkmarkFour"]);
                            check5 = Convert.ToInt32(sdr["checkmarkFive"]);
                            check6 = Convert.ToInt32(sdr["checkmarkSix"]);
                            check7 = Convert.ToInt32(sdr["checkmarkSeven"]);
                            check8 = Convert.ToInt32(sdr["checkmarkEight"]);
                            check9 = Convert.ToInt32(sdr["checkmarkNine"]);
                            check10 = Convert.ToInt32(sdr["checkmarkTen"]);

                        }
                        con.Close();
                    }
                }

                checkMarks();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
        }

        private void cm4_Click(object sender, EventArgs e)
        {
            if (check4 == 0)
            {
                cm4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check4 = 1;
            }
            else if (check4 == 1)
            {
                cm4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check4 = 0;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            clearTB();
            currentGoal = goalTB.Text;

        }

        private void cm3_Click(object sender, EventArgs e)
        {
            if (check3 == 0)
            {
                cm3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check3 = 1;
            }
            else if (check3 == 1)
            {
                cm3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check3 = 0;
            }
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
            if (check2 == 0)
            {
                cm2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check2 = 1;
            }
            else if (check2 == 1)
            {
                cm2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check2 = 0;
            }
        }

        private void cm1_Click(object sender, EventArgs e)
        {
            if (check1 == 0)
            {
                cm1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check1 = 1;
            }
            else if (check1 == 1)
            {
                cm1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check1 = 0;
            }
        }

        private void cm7_Click(object sender, EventArgs e)
        {
            if (check7 == 0)
            {
                cm7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check7 = 1;
            }
            else if (check7 == 1)
            {
                cm7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check7 = 0;
            }
        }

        private void cm8_Click(object sender, EventArgs e)
        {
            if (check8 == 0)
            {
                cm8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check8 = 1;
            }
            else if (check8 == 1)
            {
                cm8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check8 = 0;
            }
        }

        private void cm9_Click(object sender, EventArgs e)
        {
            if (check9 == 0)
            {
                cm9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check9 = 1;
            }
            else if (check9 == 1)
            {
                cm9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check9 = 0;
            }
        }

        private void cm10_Click(object sender, EventArgs e)
        {
            if (check10 == 0)
            {
                cm10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                check10 = 1;
            }
            else if (check10 == 1)
            {
                cm10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                check10 = 0;
            }
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
            taskOneTB.Clear();
            taskTwoTB.Clear();
            taskThreeTB.Clear();
            taskFourTB.Clear();
            taskFiveTB.Clear();
            taskSixTB.Clear();
            taskSevenTB.Clear();
            taskEightTB.Clear();
            taskNineTB.Clear();
            taskTenTB.Clear();
            check1 = 0;
            check2 = 0;
            check3 = 0;
            check4 = 0;
            check5 = 0;
            check6 = 0;
            check7 = 0;
            check8 = 0;
            check9 = 0;
            check10 = 0;

            checkMarks();
        }

        void checkMarks()
        {
            //Goes through the arrays and sets up what checkmarks need to be filled in
            int[] checks = { check1, check2, check3, check4, check5, check6, check7, check8, check9, check10 };
            PictureBox[] boxes = {cm1, cm2, cm3, cm4, cm5, cm6, cm7, cm8, cm9, cm10};

            for (int i = 0; i < checks.Length; i++)
            {
                if (checks[i] == 0)
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                }
                else if (checks[i] == 1)
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                }
            }
        }
    }
}
