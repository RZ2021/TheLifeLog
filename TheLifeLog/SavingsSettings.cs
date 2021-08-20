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
        private int userId;
        List<string> GoalNames = new List<string>();
        List<string> Goals = new List<string>();
        List<string> Current = new List<string>();
        public SavingsSettings(int user)
        {
            InitializeComponent();
            userId = user;
        }
        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                string goal = dc.ReadSavings(userId, 1);
                string names = dc.ReadSavings(userId, 2);
                string current = dc.ReadSavings(userId, 3);

                GoalNames.Clear();
                string[] tempArray1 = names.Split('*');
                foreach (string str in tempArray1)
                {
                    GoalNames.Add(str);
                }

                Goals.Clear();
                string[] tempArray2 = goal.Split('*');
                foreach (string str in tempArray2)
                {
                    Goals.Add(str);
                }

                Current.Clear();
                string[] tempArray3 = current.Split('*');
                foreach (string str in tempArray3)
                {
                    Current.Add(str);
                }

                Validation val = new Validation();
                bool con = true;
                while (con)
                {
                    int count = 0;
                    RichTextBox[] tb = { tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8 };
                    for (int x = 0; x <= 6; x +=2)
                    {
                        
                        if (tb[x].Text != "" && tb[x + 1].Text != "")
                        {
                            bool num = val.IsDigits(tb[x + 1].Text);
                            if (num == false)
                            {
                                MessageBox.Show("Use only numbers for your savings goals");
                                con = false;
                                break;
                            }
                            else
                            {
                                GoalNames[count] = tb[x].Text;
                                Goals[count] = tb[x + 1].Text;
                                Current[count] = "0";
                            }
                        }
                        else if ((tb[x].Text.Length == 0 && tb[x + 1].Text.Length != 0) || (tb[x].Text.Length != 0 && tb[x + 1].Text.Length == 0))
                        {
                            MessageBox.Show("Please fill out both the name and the goal");
                            con = false;
                            break;
                        }

                        count++;
                    }
                    if (con == false)
                    {
                        break;
                    }

                    string updatedGoals = String.Join("*", Goals.ToArray());
                    string updatedNames = String.Join("*", GoalNames.ToArray());
                    string currents = String.Join("*", Current.ToArray());

                    int answer = dc.WriteSavings(userId, updatedNames, updatedGoals, currents);
                    if (answer != 0)
                    {
                        MessageBox.Show("Your new savings goals have been updated!");
                        foreach (RichTextBox t in tb)
                        {
                            t.Text = "";
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Try again.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong. Exit and try again.");
                MessageBox.Show(ex.ToString());
            }
 
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Any unsaved progress will be lost, are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Savings save = new Savings(userId);
                save.Show();
                this.Close();
            }
   
        }
    }
}
