using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheLifeLog
{
    public partial class ToDo : Form
    {
        readonly int userId, listNum;
        readonly List<string> tdData = new List<string>();
        readonly List<string> chData = new List<string>();

        public ToDo(int user)
        {
            InitializeComponent();
            userId = user;
            listNum = 1;
        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            GeneralButton.BackColor = Color.Gold;
            GetTodo();
            checkMarked();
            
        }

        public void GetTodo()
        {
            try
            {
                DataConnect dc = new DataConnect();
                string todo = dc.ReadTodo(userId, listNum, 1);
                string checks = dc.ReadTodo(userId, listNum, 2);

                string[] tempArray = todo.Split('*');
                foreach (string str in tempArray)
                {
                    tdData.Add(str);
                }

                TextBox[] tb = { tdTb1, tdTb2, tdTb3, tdTb4, tdTb5, tdTb6, tdTb7, tdTb8, tdTb9, tdTb10 };

                for (int len = 0; len < tdData.Count; len++)
                {
                    tb[len].Text = tdData[len];
                }

                string[] tempArray2 = checks.Split('*');
                foreach (string str in tempArray2)
                {
                    chData.Add(str);
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
            
        }

        private void checkMarked()
        {
            //Goes through the arrays and sets up what checkmarks need to be filled in

            PictureBox[] boxes = { checkMark1, checkMark2, checkMark3, checkMark4, checkMark5, checkMark6, checkMark7, checkMark8, checkMark9, checkMark10 };

            for (int i = 0; i < chData.Count; i++)
            {
                if (chData[i] == "0")
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                }
                else if (chData[i] == "1")
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                tdData.Clear();
                TextBox[] tb = {tdTb1, tdTb2, tdTb3, tdTb4, tdTb5, tdTb6, tdTb7, tdTb8, tdTb9, tdTb10};
                //writes data in textboxes to database
                for (int len = 0; len < tb.Length; len++)
                {
                    tdData.Add(tb[len].Text);
                }

                string todo = String.Join("*", tdData.ToArray());
                string check = String.Join("*", chData.ToArray());

                DataConnect dc = new DataConnect();
                int update = dc.WriteTodo(userId, todo, check, listNum);
                if (update != 0)
                {
                    MessageBox.Show("Your to do list has been updated");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, exit and try again.");
            }

        }

        private void checkMark1_Click(object sender, EventArgs e)
        {
            if (chData[0] == "0")
            {
                checkMark1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[0] = "1";
            }
            else if (chData[0] == "1")
            {
                checkMark1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[0] = "0";
            }
        }

        private void checkMark2_Click(object sender, EventArgs e)
        {
            if (chData[1] == "0")
            {
                checkMark2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[1] = "1";
            }
            else if (chData[1] == "1")
            {
                checkMark2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[1] = "0";
            }
        }

        private void checkMark3_Click(object sender, EventArgs e)
        {
            if (chData[2] == "0")
            {
                checkMark3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[2] = "1";
            }
            else if (chData[2] == "1")
            {
                checkMark3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[2] = "0";
            }
        }

        private void checkMark4_Click(object sender, EventArgs e)
        {
            if (chData[3] == "0")
            {
                checkMark4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[3] = "1";
            }
            else if (chData[3] == "1")
            {
                checkMark4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[3] = "0";
            }
        }

        private void checkMark5_Click(object sender, EventArgs e)
        {
            if (chData[4] == "0")
            {
                checkMark5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[4] = "1";
            }
            else if (chData[4] == "1")
            {
                checkMark5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[4] = "0";
            }
        }

        private void checkMark6_Click(object sender, EventArgs e)
        {
            if (chData[5] == "0")
            {
                checkMark6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[5] = "1";
            }
            else if (chData[5] == "1")
            {
                checkMark6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[5] = "0";
            }
        }

        private void checkMark7_Click(object sender, EventArgs e)
        {
            if (chData[6] == "0")
            {
                checkMark7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[6] = "1";
            }
            else if (chData[6] == "1")
            {
                checkMark7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[6] = "0";
            }
        }

        private void checkMark8_Click(object sender, EventArgs e)
        {
            if (chData[7] == "0")
            {
                checkMark8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[7] = "1";
            }
            else if (chData[7] == "1")
            {
                checkMark8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[7] = "0";
            }
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear everything?", "Clear To Do List", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TextBox[] tb = { tdTb1, tdTb2, tdTb3, tdTb4, tdTb5, tdTb6, tdTb7, tdTb8, tdTb9, tdTb10 };

                for (int len = 0; len < tdData.Count; len++)
                {
                    tb[len].Text = "";
                    chData[len] = "0";
                }

                checkMarked();
            }
            
        }

        private void checkMark9_Click(object sender, EventArgs e)
        {
            if (chData[8] == "0")
            {
                checkMark9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[8] = "1";
            }
            else if (chData[8] == "1")
            {
                checkMark9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[8] = "0";
            }
        }

        private void checkMark10_Click(object sender, EventArgs e)
        {
            if (chData[9] == "0")
            {
                checkMark10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[9] = "1";
            }
            else if (chData[9] == "1")
            {
                checkMark10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[9] = "0";
            }
        }


        private void WeekButton_MouseHover(object sender, EventArgs e)
        {
            WeekButton.BackColor = Color.Gold;
        }

        private void WeekButton_MouseLeave(object sender, EventArgs e)
        {
            WeekButton.BackColor = Color.MediumTurquoise;
        }

        private void MonthButton_MouseHover(object sender, EventArgs e)
        {
            MonthButton.BackColor = Color.Gold;
        }

        private void MonthButton_MouseLeave(object sender, EventArgs e)
        {
            MonthButton.BackColor = Color.MediumTurquoise;
        }

       
    }
}
