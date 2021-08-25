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
    public partial class MealPlan : Form
    {
        int userId;
        List<string> Meals = new List<string>();
        List<string> listData = new List<string>();

        public MealPlan(int user)
        {
            InitializeComponent();
            userId = user;

            GetMeals();
        }

        private void GetMeals()
        {
            try
            {
                DataConnect dc = new DataConnect();
                string meal = dc.ReadMeal(userId);

                string[] tempArray = meal.Split('*');
                foreach (string str in tempArray)
                {
                    Meals.Add(str);
                }

                RichTextBox[] tb = {TB1, TB2, TB3, TB4, TB5, TB6, TB7, TB8, TB9, TB10, TB11, TB12, TB13, TB14,
                    TB15, TB16, TB17, TB18, TB19, TB20, TB21, TB22, TB23, TB24, TB25, TB26, TB27, TB28};

                for (int len = 0; len < Meals.Count; len++)
                {
                    tb[len].Text = Meals[len];
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            RichTextBox[] tb = {TB1, TB2, TB3, TB4, TB5, TB6, TB7, TB8, TB9, TB10, TB11, TB12, TB13, TB14,
                    TB15, TB16, TB17, TB18, TB19, TB20, TB21, TB22, TB23, TB24, TB25, TB26, TB27, TB28};
            foreach(RichTextBox t in tb)
            {
                t.Text = "";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Meals.Clear();

                RichTextBox[] tb = {TB1, TB2, TB3, TB4, TB5, TB6, TB7, TB8, TB9, TB10, TB11, TB12, TB13, TB14,
                    TB15, TB16, TB17, TB18, TB19, TB20, TB21, TB22, TB23, TB24, TB25, TB26, TB27, TB28};

                //writes data in textboxes to database};
                for (int len = 0; len < tb.Length; len++)
                {
                    Meals.Add(tb[len].Text);
                }

                string meal = String.Join("*", Meals.ToArray());
                DataConnect dc = new DataConnect();
                int answer = dc.WriteMeal(userId, meal);
                if (answer != 0)
                {
                    MessageBox.Show("Your meal planner was saved!");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong. Try again later.");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            DataConnect dc = new DataConnect();
            string shopLists = dc.ReadShop(userId, 1);

            string[] tempArray1 = shopLists.Split('*');
            foreach (string str in tempArray1)
            {
                string i = str.Replace(" ", String.Empty);
                listData.Add(i);
            }

            int ind = listData.IndexOf("");

            string items = ListTB.Text;
            string[] tempArray2 = items.Split(',');
            int check = ind + tempArray2.Length;

            if (ind > 29)
            {
                DialogResult dr = MessageBox.Show("Your main shopping list is full, do you want to send these items" +
                    " to the next available list?", "Continue", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    SendItems(tempArray2, ind);
                }
                else
                {
                    MessageBox.Show("Your items will not be sent");
                }
            }
            else if(check > 29)
            {
                DialogResult dr = MessageBox.Show("These items will fill your main shopping list and go into the next one. " +
                    "Do you still want to send?", "Continue", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SendItems(tempArray2, ind);
                }
                else
                {
                    MessageBox.Show("Your items will not be sent");
                }
            }
            else if (check > 150)
            {
                DialogResult dr = MessageBox.Show("You don't have enough space in any of your shopping lists for all of these items" +
                    ", some will be lost or written over. Would you still like to continue?", "Continue", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SendItems(tempArray2, ind);
                }
                else
                {
                    MessageBox.Show("Your items will not be sent");
                }
            }
            else if(ind == -1)
            {
                MessageBox.Show("Your shopping lists are all full, please make some space before trying to send items.");
            }
            else
            {
                SendItems(tempArray2, ind);
            }

        }

        private void SendItems(string[] tempArray2, int index)
        {
            for (int x = 0; x < tempArray2.Length; x++)
            {
                if (listData[index] != "")
                {
                    index++;
                    continue;
                }
                else
                {
                    listData[index] = tempArray2[x];
                    index++;
                }
            }

            string list = String.Join("*", listData.ToArray());
            DataConnect dc = new DataConnect();
            dc.WriteShop(userId, list, "-1");
            MessageBox.Show("Your items have been sent");
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
