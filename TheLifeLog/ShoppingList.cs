using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheLifeLog
{
    public partial class ShoppingList : Form
    {
        readonly int userId;
        int listNum, start; 
        readonly List<string> listData = new List<string>();
        readonly List<string> chData = new List<string>();

        public ShoppingList(int user)
        {
            InitializeComponent();

            userId = user;
            listNum = 1;

            ListOneButton.BackColor = Color.Gold;

            LoadList(listNum);
            
        }

        private void LoadList(int ln)
        {
            try
            {
                if(ln == 1)
                {
                    start = 0;
                }
                else if(ln == 2)
                {
                    start = 30;
                }
                else if(ln == 3)
                {
                    start = 60;
                }
                else if (ln == 4)
                {
                    start = 90;
                }
                else
                {
                    start = 120;
                }
                    
                
                DataConnect dc = new DataConnect();
                string lists = dc.ReadShop(userId, 1);
                string checks = dc.ReadShop(userId, 2);
                string names = dc.ReadShop(userId, 3);

                Button[] bts = { ListOneButton, ListTwoButton, ListThreeButton, ListFourButton, ListFiveButton };

                string[] tempArray = names.Split('*');
                for (int len = 0; len < bts.Length; len++)
                {
                    bts[len].Text = tempArray[len];
                }

                listData.Clear();
                string[] tempArray1 = lists.Split('*');
                foreach (string str in tempArray1)
                {
                    listData.Add(str);
                }

                TextBox[] tb = { slTb1, slTb2, slTb3, slTb4, slTb5, slTb6, slTb7, slTb8, slTb9, slTb10, 
                    slTb11, slTb12, slTb13, slTb14, slTb15, slTb16, slTb17, slTb18, slTb19, slTb20,
                    slTb21, slTb22, slTb23, slTb24, slTb25, slTb26, slTb27, slTb28, slTb29, slTb30};

                int temp = start;
                for (int len = 0; len < 30; len++)
                {
                    tb[len].Text = listData[temp];
                    temp++;
                }

                string[] tempArray2 = checks.Split('*');
                foreach (string str in tempArray2)
                {
                    chData.Add(str);
                }

                GetMarks();

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private void GetMarks()
        {
            //Goes through the arrays and sets up what checkmarks need to be filled in
            PictureBox[] boxes = { checkMark1, checkMark2, checkMark3, checkMark4, checkMark5, checkMark6, checkMark7,
                checkMark8, checkMark9, checkMark10, checkMark11, checkMark12, checkMark13, checkMark14, checkMark15,
                checkMark16, checkMark17, checkMark18, checkMark19, checkMark20, checkMark21, checkMark22, checkMark23,
                checkMark24, checkMark25, checkMark26, checkMark27, checkMark28, checkMark29, checkMark30 };
            int temp2 = start;
            for (int i = 0; i < 30; i++)
            {
                if (chData[temp2] == "0")
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                }
                else if (chData[temp2] == "1")
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                }
                temp2++;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveList();
        }

        private void SaveList()
        {
            try
            {
                
                TextBox[] tb = { slTb1, slTb2, slTb3, slTb4, slTb5, slTb6, slTb7, slTb8, slTb9, slTb10,
                    slTb11, slTb12, slTb13, slTb14, slTb15, slTb16, slTb17, slTb18, slTb19, slTb20,
                    slTb21, slTb22, slTb23, slTb24, slTb25, slTb26, slTb27, slTb28, slTb29, slTb30};

                //writes data in textboxes to database
                int temp = start;
                for (int len = 0; len < tb.Length; len++)
                {
                    listData[temp] = tb[len].Text;
                    temp++;
                }

                string list = String.Join("*", listData.ToArray());
                string check = String.Join("*", chData.ToArray());

                DataConnect dc = new DataConnect();
                int update = dc.WriteShop(userId, list, check);
                if (update != 0)
                {
                    MessageBox.Show("Your to shopping list has been updated");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, exit and try again.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear everything?", "Clear Shopping List", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TextBox[] tb = { slTb1, slTb2, slTb3, slTb4, slTb5, slTb6, slTb7, slTb8, slTb9, slTb10,
                    slTb11, slTb12, slTb13, slTb14, slTb15, slTb16, slTb17, slTb18, slTb19, slTb20,
                    slTb21, slTb22, slTb23, slTb24, slTb25, slTb26, slTb27, slTb28, slTb29, slTb30};

                for (int len = 0; len < tb.Length; len++)
                {
                    tb[len].Text = "";
                }

                int temp = start;
                for (int len = 0; len < 30; len++)
                {
                    chData[temp] = "0";
                    temp++;
                }

                GetMarks();
            }
        }

        private void ListOneButton_Click(object sender, EventArgs e)
        {
            ListOneButton.BackColor = Color.Gold;
            ListTwoButton.BackColor = Color.MediumTurquoise;
            ListThreeButton.BackColor = Color.MediumTurquoise;
            ListFourButton.BackColor = Color.MediumTurquoise;
            ListFiveButton.BackColor = Color.MediumTurquoise;
            listNum = 1;
            LoadList(1);
        }

        private void ListTwoButton_Click(object sender, EventArgs e)
        {
            ListTwoButton.BackColor = Color.Gold;
            ListOneButton.BackColor = Color.MediumTurquoise;
            ListThreeButton.BackColor = Color.MediumTurquoise;
            ListFourButton.BackColor = Color.MediumTurquoise;
            ListFiveButton.BackColor = Color.MediumTurquoise;
            listNum = 2;
            LoadList(2);
        }

        private void ListThreeButton_Click(object sender, EventArgs e)
        {
            ListThreeButton.BackColor = Color.Gold;
            ListOneButton.BackColor = Color.MediumTurquoise;
            ListTwoButton.BackColor = Color.MediumTurquoise;
            ListFourButton.BackColor = Color.MediumTurquoise;
            ListFiveButton.BackColor = Color.MediumTurquoise;
            listNum = 3;
            LoadList(3);
        }

        private void ListFourButton_Click(object sender, EventArgs e)
        {
            ListFourButton.BackColor = Color.Gold;
            ListOneButton.BackColor = Color.MediumTurquoise;
            ListTwoButton.BackColor = Color.MediumTurquoise;
            ListThreeButton.BackColor = Color.MediumTurquoise;
            ListFiveButton.BackColor = Color.MediumTurquoise;
            listNum = 4;
            LoadList(4);
        }

        private void ListFiveButton_Click(object sender, EventArgs e)
        {
            ListFiveButton.BackColor = Color.Gold;
            ListOneButton.BackColor = Color.MediumTurquoise;
            ListTwoButton.BackColor = Color.MediumTurquoise;
            ListThreeButton.BackColor = Color.MediumTurquoise;
            ListFourButton.BackColor = Color.MediumTurquoise;
            listNum = 5;
            LoadList(5);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckMarking(int pb, int listNum)
        {
            int num = 0;
            PictureBox[] boxes = { checkMark1, checkMark2, checkMark3, checkMark4, checkMark5, checkMark6, checkMark7,
                checkMark8, checkMark9, checkMark10, checkMark11, checkMark12, checkMark13, checkMark14, checkMark15,
                checkMark16, checkMark17, checkMark18, checkMark19, checkMark20, checkMark21, checkMark22, checkMark23,
                checkMark24, checkMark25, checkMark26, checkMark27, checkMark28, checkMark29, checkMark30 };

            if(listNum == 2)
            {
                num = pb + 30;
            }
            else if(listNum == 3)
            {
                num = pb + 60;
            }
            else if(listNum == 4)
            {
                num = pb + 90;
            }
            else if(listNum == 5)
            {
                num = pb + 120;
            }

            if(chData[num] == "0")
            {
                boxes[pb].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[num] = "1";
            }
            else if(chData[num] == "1")
            {
                boxes[pb].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[num] = "0";
            }
        }

        private void checkMark17_Click(object sender, EventArgs e)
        {
            CheckMarking(16, listNum);
        }

        private void checkMark18_Click(object sender, EventArgs e)
        {
            CheckMarking(17, listNum);
        }

        private void checkMark19_Click(object sender, EventArgs e)
        {
            CheckMarking(18, listNum);
        }

        private void checkMark20_Click(object sender, EventArgs e)
        {
            CheckMarking(29, listNum);
        }

        private void checkMark16_Click(object sender, EventArgs e)
        {
            CheckMarking(15, listNum);
        }

        private void checkMark15_Click(object sender, EventArgs e)
        {
            CheckMarking(14, listNum);
        }

        private void checkMark14_Click(object sender, EventArgs e)
        {
            CheckMarking(13, listNum);
        }

        private void checkMark13_Click(object sender, EventArgs e)
        {
            CheckMarking(12, listNum);
        }

        private void checkMark12_Click(object sender, EventArgs e)
        {
            CheckMarking(11, listNum);
        }

        private void checkMark11_Click(object sender, EventArgs e)
        {
            CheckMarking(10, listNum);
        }

        private void checkMark10_Click(object sender, EventArgs e)
        {
            CheckMarking(9, listNum);
        }

        private void checkMark9_Click(object sender, EventArgs e)
        {
            CheckMarking(8, listNum);
        }

        private void checkMark8_Click(object sender, EventArgs e)
        {
            CheckMarking(7, listNum);
        }

        private void checkMark7_Click(object sender, EventArgs e)
        {
            CheckMarking(6, listNum);
        }

        private void checkMark6_Click(object sender, EventArgs e)
        {
            CheckMarking(5, listNum);
        }

        private void checkMark5_Click(object sender, EventArgs e)
        {
            CheckMarking(4, listNum);
        }

        private void checkMark4_Click(object sender, EventArgs e)
        {
            CheckMarking(3, listNum);
        }

        private void checkMark3_Click(object sender, EventArgs e)
        {
            CheckMarking(2, listNum);
        }

        private void checkMark2_Click(object sender, EventArgs e)
        {
            CheckMarking(1, listNum);
        }

        private void checkMark21_Click(object sender, EventArgs e)
        {
            CheckMarking(20, listNum);
        }

        private void checkMark22_Click(object sender, EventArgs e)
        {
            CheckMarking(21, listNum);
        }

        private void checkMark23_Click(object sender, EventArgs e)
        {
            CheckMarking(22, listNum);
        }

        private void checkMark24_Click(object sender, EventArgs e)
        {
            CheckMarking(23, listNum);
        }

        private void checkMark25_Click(object sender, EventArgs e)
        {
            CheckMarking(24, listNum);
        }

        private void checkMark26_Click(object sender, EventArgs e)
        {
            CheckMarking(25, listNum);
        }

        private void checkMark27_Click(object sender, EventArgs e)
        {
            CheckMarking(26, listNum);
        }

        private void checkMark28_Click(object sender, EventArgs e)
        {
            CheckMarking(27, listNum);
        }

        private void checkMark29_Click(object sender, EventArgs e)
        {
            CheckMarking(28, listNum);
        }

        private void checkMark30_Click(object sender, EventArgs e)
        {
            CheckMarking(29, listNum);
        }

        private void checkMark1_Click(object sender, EventArgs e)
        {
            CheckMarking(0, listNum);
        }


    }
}
