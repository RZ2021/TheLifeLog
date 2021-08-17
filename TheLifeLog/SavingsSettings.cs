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
    public partial class SavingsSettings : Form
    {
        public SavingsSettings()
        {
            InitializeComponent();
        }
        bool isDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
                else if (char.IsWhiteSpace(c))
                {
                    return false;
                }

            }
            return true;
        }
        string removeSpace(string str)
        {
            string var = str.Replace(" ", String.Empty);
            return var;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string g1 = removeSpace(tb1.Text);
            string g2 = removeSpace(tb2.Text);
            string g3 = removeSpace(tb3.Text);
            string g4 = removeSpace(tb4.Text);
            string g5 = removeSpace(tb5.Text);
            string g6 = removeSpace(tb6.Text);
            string g7 = removeSpace(tb7.Text);
            string g8 = removeSpace(tb8.Text);
            int count = 0;

            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");
            conn.Open();

            if (g1 != "" && g2 != "")
            {
                bool goal1 = isDigits(g2);
                if(goal1)
                {
                    string gp1 = "0";
                    string sql = "UPDATE Savings SET GoalOneLabel = (@appt), GoalOneGoal = (@appt2), GoalOneProgress = (@appt3)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@appt", SqlDbType.VarChar);
                    cmd.Parameters["@appt"].Value = g1;
                    cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
                    cmd.Parameters["@appt2"].Value = g2;
                    cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
                    cmd.Parameters["@appt3"].Value = gp1;
                    cmd.ExecuteNonQuery();
                    count++;

                    MessageBox.Show("Savings goal one has been set!");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Check your input for goal one.");
                    tb2.Clear();
                }
            }
            else if ((g1 != "" && g2 == "") || (g1 == "" && g2 != ""))
            {
                MessageBox.Show("Please enter both a goal name and a goal amount.");
            }

            if (g3 != "" && g4 != "")
            {
                bool goal2 = isDigits(g4);
                if(goal2)
                {
                    string gp2 = "0";
                    string sql = "UPDATE Savings SET GoalTwoLabel = (@appt), GoalTwoGoal = (@appt2), GoalTwoProgress = (@appt3)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@appt", SqlDbType.VarChar);
                    cmd.Parameters["@appt"].Value = g3;
                    cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
                    cmd.Parameters["@appt2"].Value = g4;
                    cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
                    cmd.Parameters["@appt3"].Value = gp2;
                    cmd.ExecuteNonQuery();
                    count++;

                    MessageBox.Show("Savings goal two has been set!");

                }
                else
                {
                    MessageBox.Show("Something went wrong. Check your input for goal two.");
                    tb4.Clear();
                }
                
            }
            else if ((g3 != "" && g4 == "") || (g3 == "" && g4 != ""))
            {
                MessageBox.Show("Please enter both a goal name and a goal amount.");
            }


            if (g5 != "" && g6 != "")
            {
                bool goal3 = isDigits(g6);
                if (goal3)
                {
                    string gp3 = "0";
                    string sql = "UPDATE Savings SET GoalThreeLabel = (@appt), GoalThreeGoal = (@appt2), GoalThreeProgress = (@appt3)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@appt", SqlDbType.VarChar);
                    cmd.Parameters["@appt"].Value = g5;
                    cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
                    cmd.Parameters["@appt2"].Value = g6;
                    cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
                    cmd.Parameters["@appt3"].Value = gp3;
                    cmd.ExecuteNonQuery();
                    count++;

                    MessageBox.Show("Savings goal three has been set!");

                }
                else
                {
                    MessageBox.Show("Something went wrong. Check your input for goal three.");
                    tb6.Clear();
                }
                
            }
            else if ((g5 != "" && g6 == "") || (g5 == "" && g6 != ""))
            {
                MessageBox.Show("Please enter both a goal name and a goal amount.");
            }


            if (g7 != "" && g8 != "")
            {
                bool goal4 = isDigits(g8);
                if (goal4)
                {
                    string gp4 = "0";
                    string sql = "UPDATE Savings SET GoalFourLabel = (@appt), GoalFourGoal = (@appt2), GoalFourProgress = (@appt3)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@appt", SqlDbType.VarChar);
                    cmd.Parameters["@appt"].Value = g7;
                    cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
                    cmd.Parameters["@appt2"].Value = g8;
                    cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
                    cmd.Parameters["@appt3"].Value = gp4;
                    cmd.ExecuteNonQuery();
                    count++;

                    MessageBox.Show("Savings goal four has been set!");

                }
                else
                {
                    MessageBox.Show("Something went wrong. Check your input for goal four.");
                    tb8.Clear();
                }
                
            }
            else if ((g7 != "" && g8 == "") || (g7 == "" && g8 != ""))
            {
                MessageBox.Show("Please enter both a goal name and a goal amount.");
            }

            if (tb1.Text.Equals("") && tb2.Text.Equals("") && tb3.Text.Equals("") && tb4.Text.Equals("") && tb5.Text.Equals("") &&
                tb6.Text.Equals("") && tb7.Text.Equals("") && tb8.Text.Equals(""))
            {
                MessageBox.Show("You haven't entered any new goals.");
            }
            else if (count > 0)
            {
                
                tb1.Clear();
                tb2.Clear();
                tb3.Clear();
                tb4.Clear();
                tb5.Clear();
                tb6.Clear();
                tb7.Clear();
                tb8.Clear();
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
    }
}
