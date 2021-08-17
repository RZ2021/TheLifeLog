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
    public partial class Savings : Form
    {
        private string goalOne, goalTwo, goalThree, goalFour, goalOnePro, goalTwoPro, goalThreePro, goalFourPro;
        private double progressBar, g1, g2, g3, g4, gp1, gp2, gp3, gp4;

        private void proBar1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void proBar4_MouseHover(object sender, EventArgs e)
        {
            if(goalFourPro != "" && goalFourPro != " " )
            {if (goalFourPro != "" && goalFourPro != " ")
                {
                    ToolTip tt4 = new ToolTip();
                    tt4.Show(goalFourPro, proBar4);
                }
            }
            
        }

        private void proBar3_MouseHover(object sender, EventArgs e)
        {
            if (goalThreePro != "" && goalThreePro != " ")
            {if (goalThreePro != "" && goalThreePro != " ")
                {
                    ToolTip tt3 = new ToolTip();
                    tt3.Show(goalThreePro, proBar3);
                }
            }
            
            
        }

        private void proBar2_MouseHover(object sender, EventArgs e)
        {if (goalTwoPro != "" && goalTwoPro != " ")
            {
                ToolTip tt2 = new ToolTip();
                tt2.Show(goalTwoPro, proBar2);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All savings goals will be deleted. Continue?", "Clear", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");
                conn.Open();
                string sql = "UPDATE Savings SET GoalOneLabel = (@appt), GoalOneGoal = (@appt2), GoalOneProgress = (@appt3), GoalTwoLabel = (@appt4), " +
                    "GoalTwoGoal = (@appt5), GoalTwoProgress = (@appt6), GoalThreeLabel = (@appt7), GoalThreeGoal = (@appt8), GoalThreeProgress = (@appt9)," +
                    "GoalFourLabel = (@appt10), GoalFourGoal = (@appt11), GoalFourProgress = (@appt12)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@appt", SqlDbType.VarChar);
                cmd.Parameters["@appt"].Value = " ";
                cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
                cmd.Parameters["@appt2"].Value = " ";
                cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
                cmd.Parameters["@appt3"].Value = " ";
                cmd.Parameters.Add("@appt4", SqlDbType.VarChar);
                cmd.Parameters["@appt4"].Value = " ";
                cmd.Parameters.Add("@appt5", SqlDbType.VarChar);
                cmd.Parameters["@appt5"].Value = " ";
                cmd.Parameters.Add("@appt6", SqlDbType.VarChar);
                cmd.Parameters["@appt6"].Value = " ";
                cmd.Parameters.Add("@appt7", SqlDbType.VarChar);
                cmd.Parameters["@appt7"].Value = " ";
                cmd.Parameters.Add("@appt8", SqlDbType.VarChar);
                cmd.Parameters["@appt8"].Value = " ";
                cmd.Parameters.Add("@appt9", SqlDbType.VarChar);
                cmd.Parameters["@appt9"].Value = " ";
                cmd.Parameters.Add("@appt10", SqlDbType.VarChar);
                cmd.Parameters["@appt10"].Value = " ";
                cmd.Parameters.Add("@appt11", SqlDbType.VarChar);
                cmd.Parameters["@appt11"].Value = " ";
                cmd.Parameters.Add("@appt12", SqlDbType.VarChar);
                cmd.Parameters["@appt12"].Value = " ";
                cmd.ExecuteNonQuery();

                oneUpdateTB.Text = "";
                twoUpdateTB.Text = "";
                threeUpdateTB.Text = "";
                fourUpdateTB.Text = "";
                MessageBox.Show("Your savings goals have all been cleared.");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
            

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Any unsaved progress will be lost, are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           
        }

        

        private void proBar1_MouseHover(object sender, EventArgs e)
        {if (goalOnePro != "" && goalOnePro != " ")
            {
                ToolTip tt1 = new ToolTip();
                tt1.Show(goalOnePro, proBar1);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string temp1 = removeSpace(oneUpdateTB.Text);
            bool d1 = isDigits(temp1);
            string temp2 = removeSpace(twoUpdateTB.Text);
            bool d2 = isDigits(temp2);
            string temp3 = removeSpace(threeUpdateTB.Text);
            bool d3 = isDigits(temp3);
            string temp4 = removeSpace(fourUpdateTB.Text);
            bool d4 = isDigits(temp4);

            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");
            conn.Open();

            if (oneUpdateTB.Text.Length > 0 && goalOne != "" && d1 == true)
            {
                gp1 += Convert.ToDouble(oneUpdateTB.Text);
                goalOnePro = gp1.ToString();

                string sql = "UPDATE Savings SET GoalOneProgress = (@appt)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@appt", SqlDbType.VarChar);
                cmd.Parameters["@appt"].Value = goalOnePro;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Goal one has been saved.");

            }
            else if (oneUpdateTB.Text.Length > 0 && goalOne.Equals(""))
            {
                MessageBox.Show("Goal one has not been set.");
            }
            else if(oneUpdateTB.Text.Length > 0 && d1 == false)
            {
                MessageBox.Show("Enter numbers only in goal one.");
            }


            if (twoUpdateTB.Text.Length > 0 && goalTwo != "" && d2 == true)
            {
                gp2 += Convert.ToDouble(twoUpdateTB.Text);
                goalTwoPro = gp2.ToString();

                string sql = "UPDATE Savings SET GoalTwoProgress = (@appt2)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
                cmd.Parameters["@appt2"].Value = goalTwoPro;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Goal two has been saved.");

            }
            else if (twoUpdateTB.Text.Length > 0 && goalTwo.Equals(""))
            {
                MessageBox.Show("Goal two has not been set.");
            }
            else if (twoUpdateTB.Text.Length > 0 && d2 == false)
            {
                MessageBox.Show("Enter numbers only in goal two.");
            }

            if (threeUpdateTB.Text.Length > 0 && goalThree != "" && d3 == true)
            {
                gp3 += Convert.ToDouble(threeUpdateTB.Text);
                goalThreePro = gp3.ToString();

                string sql = "UPDATE Savings SET GoalThreeProgress = (@appt3)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
                cmd.Parameters["@appt3"].Value = goalThreePro;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Goal three has been saved.");

            }
            else if (threeUpdateTB.Text.Length > 0 && goalThree.Equals(""))
            {
                MessageBox.Show("Goal three has not been set");
            }
            else if (threeUpdateTB.Text.Length > 0 && d3 == false)
            {
                MessageBox.Show("Enter numbers only in goal three.");
            }

            if (fourUpdateTB.Text.Length > 0 && goalFour != "" && d4 == true)
            {
                gp4 += Convert.ToDouble(fourUpdateTB.Text);
                goalFourPro = gp4.ToString();

                string sql = "UPDATE Savings SET GoalFourProgress = (@appt4)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@appt4", SqlDbType.VarChar);
                cmd.Parameters["@appt4"].Value = goalFourPro;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Goal four has been saved.");

            }
            else if (fourUpdateTB.Text.Length > 0 && goalFour.Equals(""))
            {
                MessageBox.Show("Goal four has not been set.");
            }
            else if (fourUpdateTB.Text.Length > 0 && d4 == false)
            {
                MessageBox.Show("Enter numbers only in goal four.");
            }

            conn.Close();

            
            progressUpdate(gp1, g1, 0);
            progressUpdate(gp2, g2, 1);
            progressUpdate(gp3, g3, 2);
            progressUpdate(gp4, g4, 3);

            oneUpdateTB.Text = "";
            twoUpdateTB.Text = "";
            threeUpdateTB.Text = "";
            fourUpdateTB.Text = "";



        }

        public Savings()
        {
            InitializeComponent();
        }

        private void PSButton_Click(object sender, EventArgs e)
        {
            PastSpending ps = new PastSpending();
            ps.Show();
            this.Close();
        }

        private void BudgetButton_Click(object sender, EventArgs e)
        {
            Budget bud = new Budget(1);
            bud.Show();
            this.Close();
        }

        private void SavingSetting_Click(object sender, EventArgs e)
        {
            SavingsSettings ss = new SavingsSettings();
            ss.Show();

        }

        private void Savings_Load(object sender, EventArgs e)
        {
            savingsButton.BackColor = Color.Gold;

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
                        name1Label.Text = sdr["GoalOneLabel"].ToString();
                        goalOne = sdr["GoalOneGoal"].ToString();
                        goalOnePro = sdr["GoalOneProgress"].ToString();
                        name2Label.Text = sdr["GoalTwoLabel"].ToString();
                        goalTwo = sdr["GoalTwoGoal"].ToString();
                        goalTwoPro = sdr["GoalTwoProgress"].ToString();
                        name3Label.Text = sdr["GoalThreeLabel"].ToString();
                        goalThree = sdr["GoalThreeGoal"].ToString();
                        goalThreePro = sdr["GoalThreeProgress"].ToString();
                        name4Label.Text = sdr["GoalFourLabel"].ToString();
                        goalFour = sdr["GoalFourGoal"].ToString();
                        goalFourPro = sdr["GoalFourProgress"].ToString();


                    }
                    con.Close();
                }
            }

            goalOne = removeSpace(goalOne);
            goalTwo = removeSpace(goalTwo);
            goalThree = removeSpace(goalThree);
            goalFour = removeSpace(goalFour);

            if (goalOne.Length > 0)
            {
                Goal1Label.Text = goalOne;
                g1 = Convert.ToDouble(goalOne);
                gp1 = Convert.ToDouble(goalOnePro);
                progressUpdate(gp1, g1, 0);
            }

            if (goalTwo.Length > 0)
            {
                Goal2Label.Text = goalTwo;
                g2 = Convert.ToDouble(goalTwo);
                gp2 = Convert.ToDouble(goalTwoPro);
                progressUpdate(gp2, g2, 1);
            }
            
            if (goalThree.Length > 0)
            {
                Goal3Label.Text = goalThree;
                g3 = Convert.ToDouble(goalThree);
                gp3 = Convert.ToDouble(goalThreePro);
                progressUpdate(gp3, g3, 2);
            }
            
            if (goalFour.Length > 0)
            {
                Goal4Label.Text = goalFour;
                g4 = Convert.ToDouble(goalFour);
                gp4 = Convert.ToDouble(goalFourPro);
                progressUpdate(gp4, g4, 3);
            }
            


        }

        string removeSpace(string str)
        {
            string var = str.Replace(" ", String.Empty);
            return var;
        }

        bool isDigits(string s)
        {
            bool isDig = double.TryParse(s, out _);
            return isDig;
        }

        private void progressUpdate(double goalPro, double goalTotal, int i)
        {
            PictureBox[] boxes = { proBar1, proBar2, proBar3, proBar4};
            progressBar = (goalPro / goalTotal) * 100;

            if (progressBar >= 1 && progressBar <= 10)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/TenPB.png");
            }
            else if (progressBar > 10 && progressBar <= 20)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/TwentyPB.png");
            }
            else if (progressBar > 20 && progressBar <= 30)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/ThirtyPB.png");
            }
            else if (progressBar > 30 && progressBar <= 40)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/FourtyPB.png");
            }
            else if (progressBar > 40 && progressBar <= 50)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/FiftyPB.png");
            }
            else if (progressBar > 50 && progressBar <= 60)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/SixtyPB.png");
            }
            else if (progressBar > 60 && progressBar <= 70)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/SeventyPB.png");
            }
            else if (progressBar > 70 && progressBar <= 80)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/EightyPB.png");
            }
            else if (progressBar > 80 && progressBar <= 90)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/NinetyPB.png");
            }
            else if (progressBar > 90 && progressBar <= 100)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/AlmostHundredPB.png");
            }
            else if (progressBar > 100)
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/OverBudPB.png");
                MessageBox.Show("Congrats! You hit your savings goal!");
            }
            else
            {
                boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/EmptyPB.png");
            }
        }
    }
}