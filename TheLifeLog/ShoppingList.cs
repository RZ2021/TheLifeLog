using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheLifeLog
{
    public partial class ShoppingList : Form
    {
        readonly int userId, listNum;
        readonly List<string> listData = new List<string>();
        readonly List<string> chData = new List<string>();

        public ShoppingList(int user)
        {
            InitializeComponent();

            userId = user;
            listNum = 1;

            mainButton.BackColor = Color.Gold;
            RightArrow.Visible = false;
            LeftArrow.Visible = false;

            LoadList();
            CheckMarked();
        }

        private void LoadList()
        {
            try
            {
                DataConnect dc = new DataConnect();
                string lists = dc.ReadShop(userId, listNum, 1);
                string checks = dc.ReadShop(userId, listNum, 2);

                string[] tempArray = lists.Split('*');
                foreach (string str in tempArray)
                {
                    listData.Add(str);
                }

                TextBox[] tb = { slTb1, slTb2, slTb3, slTb4, slTb5, slTb6, slTb7, slTb8, slTb9, slTb10, 
                    slTb11, slTb12, slTb13, slTb14, slTb15, slTb16, slTb17, slTb18, slTb19, slTb20,
                    slTb21, slTb22, slTb23, slTb24, slTb25, slTb26, slTb27, slTb28, slTb29, slTb30};

                for (int len = 0; len < tb.Length; len++)
                {
                    tb[len].Text = listData[len];
                }

                string[] tempArray2 = checks.Split('*');
                foreach (string str in tempArray2)
                {
                    chData.Add(str);
                }

                if(listData)

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private void CheckMarked()
        {
            //Goes through the arrays and sets up what checkmarks need to be filled in
            PictureBox[] boxes = { checkMark1, checkMark2, checkMark3, checkMark4, checkMark5, checkMark6, checkMark7, 
                checkMark8, checkMark9, checkMark10, checkMark11, checkMark12, checkMark13, checkMark14, checkMark15, 
                checkMark16, checkMark17, checkMark18, checkMark19, checkMark20, checkMark21, checkMark22, checkMark23, 
                checkMark24, checkMark25, checkMark26, checkMark27, checkMark28, checkMark29, checkMark30 };

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
                listData.Clear();
                TextBox[] tb = { slTb1, slTb2, slTb3, slTb4, slTb5, slTb6, slTb7, slTb8, slTb9, slTb10,
                    slTb11, slTb12, slTb13, slTb14, slTb15, slTb16, slTb17, slTb18, slTb19, slTb20,
                    slTb21, slTb22, slTb23, slTb24, slTb25, slTb26, slTb27, slTb28, slTb29, slTb30};

                //writes data in textboxes to database
                for (int len = 0; len < tb.Length; len++)
                {
                    listData.Add(tb[len].Text);
                }

                string list = String.Join("*", listData.ToArray());
                string check = String.Join("*", chData.ToArray());

                DataConnect dc = new DataConnect();
                int update = dc.WriteShop(userId, list, check, listNum);
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

        private void checkMark17_Click(object sender, EventArgs e)
        {
            if (chData[16] == "0")
            {
                checkMark17.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[16] = "1";
            }
            else if (chData[16] == "1")
            {
                checkMark17.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[16] = "0";
            }
        }

        private void checkMark18_Click(object sender, EventArgs e)
        {
            if (chData[17] == "0")
            {
                checkMark18.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[17] = "1";
            }
            else if (chData[17] == "1")
            {
                checkMark18.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[17] = "0";
            }
        }

        private void checkMark19_Click(object sender, EventArgs e)
        {
            if (chData[18] == "0")
            {
                checkMark19.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[18] = "1";
            }
            else if (chData[18] == "1")
            {
                checkMark19.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[18] = "0";
            }
        }

        private void checkMark20_Click(object sender, EventArgs e)
        {
            if (chData[19] == "0")
            {
                checkMark20.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[19] = "1";
            }
            else if (chData[19] == "1")
            {
                checkMark20.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[19] = "0";
            }
        }

        private void checkMark16_Click(object sender, EventArgs e)
        {
            if (chData[15] == "0")
            {
                checkMark16.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[15] = "1";
            }
            else if (chData[15] == "1")
            {
                checkMark16.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[15] = "0";
            }
        }

        private void checkMark15_Click(object sender, EventArgs e)
        {
            if (chData[14] == "0")
            {
                checkMark15.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[14] = "1";
            }
            else if (chData[14] == "1")
            {
                checkMark15.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[14] = "0";
            }
        }

        private void checkMark14_Click(object sender, EventArgs e)
        {
            if (chData[13] == "0")
            {
                checkMark14.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[13] = "1";
            }
            else if (chData[13] == "1")
            {
                checkMark14.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[13] = "0";
            }
        }

        private void checkMark13_Click(object sender, EventArgs e)
        {
            if (chData[12] == "0")
            {
                checkMark13.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[12] = "1";
            }
            else if (chData[12] == "1")
            {
                checkMark13.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[12] = "0";
            }
        }

        private void checkMark12_Click(object sender, EventArgs e)
        {
            if (chData[11] == "0")
            {
                checkMark12.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[11] = "1";
            }
            else if (chData[11] == "1")
            {
                checkMark12.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[11] = "0";
            }
        }

        private void checkMark11_Click(object sender, EventArgs e)
        {
            if (chData[10] == "0")
            {
                checkMark11.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[10] = "1";
            }
            else if (chData[10] == "1")
            {
                checkMark11.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[10] = "0";
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

        private void checkMark21_Click(object sender, EventArgs e)
        {
            if (chData[20] == "0")
            {
                checkMark21.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[20] = "1";
            }
            else if (chData[20] == "1")
            {
                checkMark21.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[20] = "0";
            }
        }

        private void checkMark22_Click(object sender, EventArgs e)
        {
            if (chData[21] == "0")
            {
                checkMark22.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[21] = "1";
            }
            else if (chData[21] == "1")
            {
                checkMark22.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[21] = "0";
            }
        }

        private void checkMark23_Click(object sender, EventArgs e)
        {
            if (chData[22] == "0")
            {
                checkMark23.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[22] = "1";
            }
            else if (chData[22] == "1")
            {
                checkMark23.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[22] = "0";
            }
        }

        private void checkMark24_Click(object sender, EventArgs e)
        {
            if (chData[23] == "0")
            {
                checkMark24.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[23] = "1";
            }
            else if (chData[23] == "1")
            {
                checkMark24.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[23] = "0";
            }
        }

        private void checkMark25_Click(object sender, EventArgs e)
        {
            if (chData[24] == "0")
            {
                checkMark25.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[24] = "1";
            }
            else if (chData[24] == "1")
            {
                checkMark25.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[24] = "0";
            }
        }

        private void checkMark26_Click(object sender, EventArgs e)
        {
            if (chData[25] == "0")
            {
                checkMark26.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[25] = "1";
            }
            else if (chData[25] == "1")
            {
                checkMark26.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[25] = "0";
            }
        }

        private void checkMark27_Click(object sender, EventArgs e)
        {
            if (chData[26] == "0")
            {
                checkMark27.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[26] = "1";
            }
            else if (chData[26] == "1")
            {
                checkMark27.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[26] = "0";
            }
        }

        private void checkMark28_Click(object sender, EventArgs e)
        {
            if (chData[27] == "0")
            {
                checkMark28.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[27] = "1";
            }
            else if (chData[27] == "1")
            {
                checkMark28.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[27] = "0";
            }
        }

        private void checkMark29_Click(object sender, EventArgs e)
        {
            if (chData[28] == "0")
            {
                checkMark29.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[28] = "1";
            }
            else if (chData[28] == "1")
            {
                checkMark29.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[28] = "0";
            }
        }

        private void checkMark30_Click(object sender, EventArgs e)
        {
            if (chData[29] == "0")
            {
                checkMark30.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                chData[29] = "1";
            }
            else if (chData[29] == "1")
            {
                checkMark30.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                chData[29] = "0";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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


    }
}
