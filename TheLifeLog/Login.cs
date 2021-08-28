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
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        
        public Login()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.Show();
            this.Close();
        }
    }
}
