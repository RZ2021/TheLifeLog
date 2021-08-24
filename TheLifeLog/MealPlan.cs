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
                if (meal == null)
                {

                }
                else
                {
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
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            TB1.Text = " ";
            TB8.Text = " ";
            TB15.Text = " ";
            TB22.Text = " ";
            TB2.Text = " ";
            TB9.Text = " ";
            TB16.Text = " ";
            TB23.Text = " ";
            TB3.Text = " ";
            TB10.Text = " ";
            TB17.Text = " ";
            TB24.Text = " ";
            TB4.Text = " ";
            TB11.Text = " ";
            TB18.Text = " ";
            TB25.Text = " ";
            TB5.Text = " ";
            TB12.Text = " ";
            TB19.Text = " ";
            TB26.Text = " ";
            TB6.Text = " ";
            TB13.Text = " ";
            TB20.Text = " ";
            TB27.Text = " ";
            TB7.Text = " ";
            TB14.Text = " ";
            TB21.Text = " ";
            TB28.Text = " ";
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
            List<string> listData = new List<string>();
            DataConnect dc = new DataConnect();
            string shopLists = dc.ReadShop(userId, 1);

            string[] tempArray1 = shopLists.Split('*');
            foreach (string str in tempArray1)
            {
                listData.Add(str);
            }

            int ind = listData.FindIndex(a => a.Contains(""));

            if(ind > 29)
            {
                DialogResult dr = MessageBox.Show("You're main shopping list is full, do you want to send these items" +
                    " to the next available list?", "Continue", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    string items = ListTB.Text;
                    string[] tempArray2 = items.Split(',');
                    int count = 0;
                    for (int x = ind; x < tempArray2.Length; x++)
                    {
                        if (listData[ind] != "")
                        {
                            continue;
                        }
                        else
                        {
                            listData[ind] = tempArray2[count];
                            count++;
                        }
                    }
                    MessageBox.Show("Your items have been sent");
                }
                else
                {
                    MessageBox.Show("Your items will not be sent");
                }
            }
            else
            {
                string items = ListTB.Text;
                string[] tempArray2 = items.Split(',');
                int count = 0;
                for (int x = ind; x < tempArray2.Length; x++)
                {
                    if (listData[ind] != "")
                    {
                        continue;
                    }
                    else
                    {
                        listData[ind] = tempArray2[count];
                        count++;
                    }
                }

                MessageBox.Show("Your items have been sent");

            }

        }

   

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
