using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheLifeLog
{
    public partial class PastSpending : Form
    {
        public PastSpending()
        {
            InitializeComponent();
        }

        private void SavingsButton_Click(object sender, EventArgs e)
        {
            Savings save = new Savings(1);
            save.Show();
        }

        private void BudgetButton_Click(object sender, EventArgs e)
        {
            Budget bud = new Budget(1);
            bud.Show();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PastSpending_Load(object sender, EventArgs e)
        {
            PSButton.BackColor = Color.Gold;
        }
    }
}
