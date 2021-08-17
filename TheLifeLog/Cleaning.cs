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
    public partial class Cleaning : Form
    {
        public Cleaning()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoalsButton_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
        }

        private void GoalsButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumTurquoise;
        }
    }
}
