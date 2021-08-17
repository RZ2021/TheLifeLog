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
    public partial class BudgetMain : Form
    {
        public BudgetMain()
        {
            InitializeComponent();
        }

        private void BudgetButton_Click(object sender, EventArgs e)
        {
            Budget bud = new Budget(1);
            bud.Show();
            this.Close();
        }

        private void SavingsButton_Click(object sender, EventArgs e)
        {
            Savings save = new Savings();
            save.Show();
            this.Close();

        }

        private void PSButton_Click(object sender, EventArgs e)
        {
            PastSpending ps = new PastSpending();
            ps.Show();
            this.Close();

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void billsButton_Click(object sender, EventArgs e)
        {
            Bills bs = new Bills(2);
            bs.Show();
            this.Close();
        }
    }
}
