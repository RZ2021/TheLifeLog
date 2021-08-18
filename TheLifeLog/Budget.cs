using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheLifeLog
{
    public partial class Budget : Form
    {
        List<string> budData = new List<string>();
        List<string> exData = new List<string>();
        int userId;
        double income;
        string total;
        public Budget(int user)
        {
            InitializeComponent();
            userId = user;
        }

        private void Budget_Load(object sender, EventArgs e)
        {
            budgetProgressBar.Enabled = true;
            budgetProgressBar.Minimum = 0;
            budgetProgressBar.Maximum = 100;
            progressTimer.Enabled = true;
            try
            {
                DataConnect dc = new DataConnect();
                string ex = dc.ReadBudget(userId, 1);
                string budget = dc.ReadBudget(userId, 2);
                string userIncome = dc.ReadBudget(userId, 3);
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

                

                IncomeTb.Text = userIncome;
                income = double.Parse(userIncome);
                totalLabel.Text = total;

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
                TextBox[] tb = {IncomeTb, budgetTB1, budgetTB2, budgetTB3, budgetTB4, budgetTB5, budgetTB6, budgetTB7,
                budgetTB8, budgetTB9, budgetTB10, budgetTB11, budgetTB12, budgetTB13, budgetTB14, budgetTB15,
                budgetTB16, budgetTB17, budgetTB18};

                for (int len = 0; len < tb.Length; len++)
                {
                    tb[len].Text = "0.0";
                }

                MessageBox.Show("Your budget has been cleared, be sure to save to make this permanent");
            }

        }

        private void SetBudgetButton_Click(object sender, EventArgs e)
        {
            budData.Clear();
            TextBox[] tb = {budgetTB1, budgetTB2, budgetTB3, budgetTB4, budgetTB5, budgetTB6, budgetTB7,
                budgetTB8, budgetTB9, budgetTB10, budgetTB11, budgetTB12, budgetTB13, budgetTB14, budgetTB15,
                budgetTB16, budgetTB17, budgetTB18};

            for (int len = 0; len < tb.Length; len++)
            {
                budData.Add(tb[len].Text);
            }

            string budget = String.Join("*", budData.ToArray());

            exData.Clear();
            Label[] lab = {ExLabel1, ExLabel2, ExLabel3, ExLabel4, ExLabel5, ExLabel6, ExLabel7,
                ExLabel8, ExLabel9, ExLabel10, ExLabel11, ExLabel12, ExLabel13, ExLabel14, ExLabel15,
                ExLabel16, ExLabel17, ExLabel18};

            for (int len = 0; len < lab.Length; len++)
            {
                exData.Add(lab[len].Text);
            }

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

        private void SavingsButton_Click(object sender, EventArgs e)
        {
            Savings save = new Savings(1);
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

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            double total = GetTotal();
            totalLabel.Text = total.ToString();
            income = double.Parse(IncomeTb.Text);
            double pbValue = total / income * 100;
            try
            {
                if (pbValue > 100)
                {
                    ProgressLabel.Text = "You are \nover budget!!!";
                    ProgressLabel.ForeColor = Color.Red;
                    budgetProgressBar.Enabled = false;
                }
                else
                {
                    ProgressLabel.Text = "You're getting \nthere!";
                    budgetProgressBar.Enabled = true;
                    budgetProgressBar.Value = Convert.ToInt32(pbValue);
                }
            }
            catch
            {
                errorLabel.Text = "Your way too over budget";
            }

        }

        private double GetTotal()
        {
            List<double> items = new List<double>();
            TextBox[] tb = {budgetTB1, budgetTB2, budgetTB3, budgetTB4, budgetTB5, budgetTB6, budgetTB7,
                budgetTB8, budgetTB9, budgetTB10, budgetTB11, budgetTB12, budgetTB13, budgetTB14, budgetTB15,
                budgetTB16, budgetTB17, budgetTB18};

            for (int len = 0; len < tb.Length; len++)
            {
                bool isDig = double.TryParse(tb[len].Text, out double x);
                if(isDig)
                {
                    items.Add(x);
                }
                else
                {
                    errorLabel.Text = "Make sure to use only numbers";
                }
            }
            double total = 0;
            foreach(double i in items)
            {
                total += i;
            }

            return total;

        }
    }
}
