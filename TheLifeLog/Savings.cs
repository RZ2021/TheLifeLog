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
        public Savings(int id)
        {
            InitializeComponent();

            userId = id;
        }
        private void Savings_Load(object sender, EventArgs e)
        {
            savingsButton.BackColor = Color.Gold;
            GetSavings();

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
                    Label[] n = { name1Label, name2Label, name3Label, name4Label };
                    Label[] c = {currentLabel1, currentLabel2, currentLabel3,
                    currentLabel4 };
                    Label[] g = { gnLabel1, gnLabel2, gnLabel3, gnLabel4 };

                    int x = 0;
                    string[] tempArray1 = names.Split('*');
                    foreach (string str in tempArray1)
                    {
                        
                        n[x].Text = str;
                        x++;
                    }

                    x = 0;
                    string[] tempArray2 = current.Split('*');
                    foreach (string str in tempArray2)
                    {
                        
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
            Budget bud = new Budget(1);
            bud.Show();
            this.Close();
        }

        private void SavingSetting_Click(object sender, EventArgs e)
        {
            SavingsSettings ss = new SavingsSettings();
            ss.Show();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}