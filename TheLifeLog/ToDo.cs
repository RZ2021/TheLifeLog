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
    public partial class ToDo : Form
    {
        private string checkPos1, checkPos2, checkPos3, checkPos4, checkPos5, checkPos6,
            checkPos7, checkPos8, checkPos9, checkPos10;
        readonly int userId, listNum;
        List<string> tdData = new List<string>();
        List<string> chData = new List<string>();

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

                string[] check = {checkPos1, checkPos2, checkPos3, checkPos4, checkPos5, checkPos6, checkPos7,
                checkPos8, checkPos9, checkPos10};

                for (int len = 0; len < chData.Count; len++)
                {
                    check[len] = chData[len];
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
            string[] checks = { checkPos1, checkPos2, checkPos3, checkPos4, checkPos5, checkPos6, checkPos7, checkPos8, checkPos9, checkPos10 };

            PictureBox[] boxes = { checkMark1, checkMark2, checkMark3, checkMark4, checkMark5, checkMark6, checkMark7, checkMark8, checkMark9, checkMark10 };

            for (int i = 0; i < checks.Length; i++)
            {
                if (checks[i] == "0")
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                }
                else if (checks[i] == "1")
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

                chData.Clear();
                string[] checks = {checkPos1, checkPos2, checkPos3, checkPos4, checkPos5, checkPos6, checkPos7,
                checkPos8, checkPos9, checkPos10};

                for (int len = 0; len < checks.Length; len++)
                {
                    chData.Add(checks[len]);
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

            }
            


        }

        private void checkMark1_Click(object sender, EventArgs e)
        {
            if (checkPos1 == "0")
            {
                checkMark1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos1 = "1";
            }
            else if (checkPos1 == "1")
            {
                checkMark1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos1 = "0";
            }
        }

        private void checkMark2_Click(object sender, EventArgs e)
        {
            if (checkPos2 == "0")
            {
                checkMark2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos2 = "1";
            }
            else if (checkPos2 == "1")
            {
                checkMark2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos2 = "0";
            }
        }

        private void checkMark3_Click(object sender, EventArgs e)
        {
            if (checkPos3 == "0")
            {
                checkMark3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos3 = "1";
            }
            else if (checkPos3 == "1")
            {
                checkMark3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos3 = "0";
            }
        }

        private void checkMark4_Click(object sender, EventArgs e)
        {
            if (checkPos4 == "0")
            {
                checkMark4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos4 = "1";
            }
            else if (checkPos4 == "1")
            {
                checkMark4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos4 = "0";
            }
        }

        private void checkMark5_Click(object sender, EventArgs e)
        {
            if (checkPos5 == "0")
            {
                checkMark5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos5 = "1";
            }
            else if (checkPos5 == "1")
            {
                checkMark5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos5 = "0";
            }
        }

        private void checkMark6_Click(object sender, EventArgs e)
        {
            if (checkPos6 == "0")
            {
                checkMark6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos6 = "1";
            }
            else if (checkPos6 == "1")
            {
                checkMark6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos6 = "0";
            }
        }

        private void checkMark7_Click(object sender, EventArgs e)
        {
            if (checkPos7 == "0")
            {
                checkMark7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos7 = "1";
            }
            else if (checkPos7 == "1")
            {
                checkMark7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos7 = "0";
            }
        }

        private void checkMark8_Click(object sender, EventArgs e)
        {
            if (checkPos8 == "0")
            {
                checkMark8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos8 = "1";
            }
            else if (checkPos8 == "1")
            {
                checkMark8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos8 = "0";
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
                tdTb1.Text = " ";
                tdTb2.Text = " ";
                tdTb3.Text = " ";
                tdTb4.Text = " ";
                tdTb5.Text = " ";
                tdTb6.Text = " ";
                tdTb7.Text = " ";
                tdTb8.Text = " ";
                tdTb9.Text = " ";
                tdTb10.Text = " ";
                checkPos1 = "0";
                checkPos2 = "0";
                checkPos3 = "0";
                checkPos4 = "0";
                checkPos5 = "0";
                checkPos6 = "0";
                checkPos7 = "0";
                checkPos8 = "0";
                checkPos9 = "0";
                checkPos10 = "0";

                checkMarked();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            


        }

        private void checkMark9_Click(object sender, EventArgs e)
        {
            if (checkPos9 == "0")
            {
                checkMark9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos9 = "1";
            }
            else if (checkPos9 == "1")
            {
                checkMark9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos9 = "0";
            }
        }

        private void checkMark10_Click(object sender, EventArgs e)
        {
            if (checkPos10 == "0")
            {
                checkMark10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                checkPos10 = "1";
            }
            else if (checkPos10 == "1")
            {
                checkMark10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                checkPos10 = "0";
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
