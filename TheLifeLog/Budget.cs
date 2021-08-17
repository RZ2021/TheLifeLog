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
    public partial class Budget : Form
    {
        List<string> budData = new List<string>();
        List<string> exData = new List<string>();
        List<TextBox> test = new List<TextBox>();
        int userId;
        string total;
        public Budget(int user)
        {
            InitializeComponent();
            userId = user;
        }

        private void Budget_Load(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                string ex = dc.ReadBudget(userId, 1);
                string budget = dc.ReadBudget(userId, 2);
                string income = dc.ReadBudget(userId, 3);
                total = dc.ReadBudget(userId, 4);

                //Get expenses categories and set the correct labels
                string[] tempArray1 = ex.Split('*');
                foreach (string str in tempArray1)
                {
                    exData.Add(str);
                }

                Label[] lab = {ExLabel1, ExLabel2, ExLabel3, ExLabel4, ExLabel5, ExLabel6, ExLabel7,
                ExLabel8, ExLabel9, ExLabel10, ExLabel11, ExLabel12, ExLabel13, ExLabel14, ExLabel15,
                ExLabel16, ExLabel17, ExLabel18};

                for (int len = 0; len < exData.Count; len++)
                {
                    lab[len].Text = exData[len];
                }

                //Seperate user nums and put them into their respective textboxes
                string[] tempArray2 = budget.Split('*');
                foreach (string str in tempArray2)
                {
                    budData.Add(str);
                }

                TextBox[] tb = {budgetTB1, budgetTB2, budgetTB3, budgetTB4, budgetTB5, budgetTB6, budgetTB7,
                budgetTB8, budgetTB9, budgetTB10, budgetTB11, budgetTB12, budgetTB13, budgetTB14, budgetTB15,
                budgetTB16, budgetTB17, budgetTB18};

                for(int len = 0; len < budData.Count; len++)
                {
                    tb[len].Text = budData[len];
                }

                IncomeTb.Text = income;
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear everything?", "Clear Budget", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                IncomeTb.Text = "0.0";
                budgetTB1.Text = "0.0";
                budgetTB2.Text = "0.0";
                budgetTB3.Text = "0.0";
                budgetTB4.Text = "0.0";
                budgetTB5.Text = "0.0";
                budgetTB6.Text = "0.0";
                budgetTB7.Text = "0.0";
                budgetTB8.Text = "0.0";
                budgetTB9.Text = "0.0";
                budgetTB10.Text = "0.0";
                budgetTB11.Text = "0.0";
                budgetTB12.Text = "0.0";
                budgetTB13.Text = "0.0";
                budgetTB14.Text = "0.0";
                budgetTB15.Text = "0.0";
                budgetTB16.Text = "0.0";
                budgetTB17.Text = "0.0";
                budgetTB18.Text = "0.0";

                MessageBox.Show("Your budget has been cleared, be sure to save to make this permanent");
            }

        }

        private void SetBudgetButton_Click(object sender, EventArgs e)
        {

            budData.Clear();
            budData.Add(budgetTB1.Text);
            budData.Add(budgetTB2.Text);
            budData.Add(budgetTB3.Text);
            budData.Add(budgetTB4.Text);
            budData.Add(budgetTB5.Text);
            budData.Add(budgetTB6.Text);
            budData.Add(budgetTB7.Text);
            budData.Add(budgetTB8.Text);
            budData.Add(budgetTB9.Text);
            budData.Add(budgetTB10.Text);
            budData.Add(budgetTB11.Text);
            budData.Add(budgetTB12.Text);
            budData.Add(budgetTB13.Text);
            budData.Add(budgetTB14.Text);
            budData.Add(budgetTB15.Text);
            budData.Add(budgetTB16.Text);
            budData.Add(budgetTB17.Text);
            budData.Add(budgetTB18.Text);
            string budget = String.Join("*", budData.ToArray());

            exData.Clear();
            exData.Add(ExLabel1.Text);
            exData.Add(ExLabel2.Text);
            exData.Add(ExLabel3.Text);
            exData.Add(ExLabel4.Text);
            exData.Add(ExLabel5.Text);
            exData.Add(ExLabel6.Text);
            exData.Add(ExLabel7.Text);
            exData.Add(ExLabel8.Text);
            exData.Add(ExLabel9.Text);
            exData.Add(ExLabel10.Text);
            exData.Add(ExLabel11.Text);
            exData.Add(ExLabel12.Text);
            exData.Add(ExLabel13.Text);
            exData.Add(ExLabel14.Text);
            exData.Add(ExLabel15.Text);
            exData.Add(ExLabel16.Text);
            exData.Add(ExLabel17.Text);
            exData.Add(ExLabel18.Text);
            string expense = String.Join("*", exData.ToArray());

            string income = IncomeTb.Text;


            DataConnect dc = new DataConnect();
            int answer = dc.WriteBudget(userId, expense, budget, income);
            if (answer != 0)
            {
                MessageBox.Show("Your budget has been saved!");

            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

        }

        bool isDigits(string s)
        {
            bool isDig = double.TryParse(s, out _);
            return isDig;
        }

        string removeSpace(string str)
        {
            string var = str.Replace(" ", String.Empty);
            return var;
        }


        private void SavingsButton_Click(object sender, EventArgs e)
        {
            Savings save = new Savings();
            save.Show();
            this.Close();
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
