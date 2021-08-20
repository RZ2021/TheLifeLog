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
        int userId;
        List<string> GoalName = new List<string>();
        List<string> CurrentTot = new List<string>();

        public Savings(int id)
        {
            InitializeComponent();

            userId = id;
        }
        private void Savings_Load(object sender, EventArgs e)
        {
            savingsButton.BackColor = Color.Gold;
            GetSavings();
            ProgressTimer.Enabled = true;
            ProgressTimer.Interval = 1000;
            MyProgressBar[] pb = { myProgressBar1, myProgressBar2, myProgressBar3, myProgressBar4 };
            for(int x = 0; x < pb.Length; x++)
            {
                pb[x].Enabled = true;
                pb[x].Minimum = 0;
                pb[x].Maximum = 100;
            }

        }

        private void GetSavings()
        {
            try
            {
                DataConnect dc = new DataConnect();
                string goal = dc.ReadSavings(userId, 1);
                string names = dc.ReadSavings(userId, 2);
                string current = dc.ReadSavings(userId, 3);
                if (names == String.Empty || names == null || names == "****")
                {
                    Label[] lb = {gnLabel1, gnLabel2, gnLabel3, gnLabel4, currentLabel1, currentLabel2, currentLabel3,
                    currentLabel4, name1Label, name2Label, name3Label, name4Label};

                    foreach (Label l in lb)
                    {
                        l.Text = "";
                    }
                }
                else
                {
                    CurrentTot.Clear();
                    GoalName.Clear();
                    Label[] n = { name1Label, name2Label, name3Label, name4Label };
                    Label[] c = {currentLabel1, currentLabel2, currentLabel3,
                    currentLabel4 };
                    Label[] g = { gnLabel1, gnLabel2, gnLabel3, gnLabel4 };

                    int x = 0;
                    string[] tempArray1 = names.Split('*');
                    foreach (string str in tempArray1)
                    {
                        GoalName.Add(str);
                        n[x].Text = str;
                        x++;
                    }

                    x = 0;
                    string[] tempArray2 = current.Split('*');
                    foreach (string str in tempArray2)
                    {
                        CurrentTot.Add(str);
                        c[x].Text = str;
                        x++;
                    }

                    x = 0;
                    string[] tempArray3 = goal.Split('*');
                    foreach (string str in tempArray3)
                    {
                        g[x].Text = str;
                        x++;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

       

        private void exitLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Any unsaved progress will be lost, are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void PSButton_Click(object sender, EventArgs e)
        {
            PastSpending ps = new PastSpending();
            ps.Show();
            this.Close();
        }

        private void BudgetButton_Click(object sender, EventArgs e)
        {
            Budget bud = new Budget(userId);
            bud.Show();
            this.Close();
        }

        private void SavingSetting_Click(object sender, EventArgs e)
        {
            SavingsSettings ss = new SavingsSettings(userId);
            ss.Show();
            this.Close();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            Validation val = new Validation();
            RichTextBox[] tb = { oneUpdateTB, twoUpdateTB, threeUpdateTB, fourUpdateTB };
            for(int x = 0; x < tb.Length; x++)
            {
                if(tb[x].Text.Length !=0 && GoalName[x].Length == 0)
                {
                    MessageBox.Show("You're trying to update a goal that doesn't exist.");
                }
                else if(tb[x].Text != null && tb[x].Text != " " && GoalName[x] != "")
                {
                    double current = val.ToDigits(CurrentTot[x]);
                    double update = val.ToDigits(tb[x].Text);
                    if (update == -1)
                    {
                        MessageBox.Show("Use numbers only.");
                    }
                    else if(update == -2)
                    {

                    }
                    else
                    {
                        current += update;
                        CurrentTot[x] = current.ToString();
                        count++;
                    }
                }
            }

            if(count != 0)
            {
                string currents = String.Join("*", CurrentTot.ToArray());
                DataConnect dc = new DataConnect();
                int answer = dc.WriteSavings(userId, currents);
                if (answer != 0)
                {
                    MessageBox.Show("Your savings have been updated!");
                    GetSavings();
                    oneUpdateTB.Text = "";
                    twoUpdateTB.Text = "";
                    threeUpdateTB.Text = "";
                    fourUpdateTB.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong. Try again.");
                }
            }
            
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            MyProgressBar[] pb = { myProgressBar1, myProgressBar2, myProgressBar3, myProgressBar4 };
            Label[] g = { gnLabel1, gnLabel2, gnLabel3, gnLabel4 };
            for(int x = 0; x < pb.Length; x++)
            {
                Validation val = new Validation();
                double current = val.ToDigits(CurrentTot[x]);
                double goal = val.ToDigits(g[x].Text);

                if(current == -2 || goal == -2)
                {
                    continue;
                }

                double pbValue = current / goal * 100;
                try
                {
                    if (pbValue > 100)
                    {
                        congratsLabel.Text = "You completed a savings goal!!!";
                        pb[x].Value = 100;
                        pb[x].Enabled = false;
                    }
                    else
                    {
                        pb[x].Enabled = true;
                        pb[x].Value = Convert.ToInt32(pbValue);
                    }
                }
                catch
                {
                    
                }
            }
            
        }
    }
}