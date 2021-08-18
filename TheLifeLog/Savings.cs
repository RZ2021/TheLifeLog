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

        public Savings()
        {
            InitializeComponent();
        }
        private void Savings_Load(object sender, EventArgs e)
        {
            savingsButton.BackColor = Color.Gold;


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

    }
}