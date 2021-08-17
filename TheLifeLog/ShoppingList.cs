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
    public partial class ShoppingList : Form
    {
        int c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20;

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            string sl1 = slTb1.Text;
            string sl2 = slTb2.Text;
            string sl3 = slTb3.Text;
            string sl4 = slTb4.Text;
            string sl5 = slTb5.Text;
            string sl6 = slTb6.Text;
            string sl7 = slTb7.Text;
            string sl8 = slTb8.Text;
            string sl9 = slTb9.Text;
            string sl10 = slTb10.Text;
            string sl11 = slTb11.Text;
            string sl12 = slTb12.Text;
            string sl13 = slTb13.Text;
            string sl14 = slTb14.Text;
            string sl15 = slTb15.Text;
            string sl16 = slTb16.Text;
            string sl17 = slTb17.Text;
            string sl18 = slTb18.Text;
            string sl19 = slTb19.Text;
            string sl20 = slTb20.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");
            string sql = "UPDATE Shopping SET shop1 = (@appt), shop2 = (@appt2), shop3 = (@appt3), shop4 = (@appt4), shop5 = (@appt5)," +
                "shop6 = (@appt6), shop7 = (@appt7), shop8 = (@appt8), shop9 = (@appt9), shop10 = (@appt10), shop11 = (@appt11), shop12 = (@appt12), " +
                "shop13 = (@appt13), shop14 = (@appt14), shop15 = (@appt15)," + "shop16 = (@appt16), shop17 = (@appt17), shop18 = (@appt18), shop19 = (@appt19), " +
                "shop20 = (@appt20), check1 = (@appt21), check2 = (@appt22), " + "check3 = (@appt23), check4 = (@appt24), check5 = (@appt25), " +
                "check6 = (@appt26), check7 = (@appt27), check8 = (@appt28)," + "check9 = (@appt29), check10 = (@appt30), check11 = (@appt31), " +
                "check12 = (@appt32), " + "check13 = (@appt33), check14 = (@appt34), check15 = (@appt35), " + "check16 = (@appt36), check17 = (@appt37), " +
                "check18 = (@appt38)," + "check19 = (@appt39), check20 = (@appt40)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@appt", SqlDbType.VarChar);
                cmd.Parameters["@appt"].Value = sl1;
                cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
                cmd.Parameters["@appt2"].Value = sl2;
                cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
                cmd.Parameters["@appt3"].Value = sl3;
                cmd.Parameters.Add("@appt4", SqlDbType.VarChar);
                cmd.Parameters["@appt4"].Value = sl4;
                cmd.Parameters.Add("@appt5", SqlDbType.VarChar);
                cmd.Parameters["@appt5"].Value = sl5;
                cmd.Parameters.Add("@appt6", SqlDbType.VarChar);
                cmd.Parameters["@appt6"].Value = sl6;
                cmd.Parameters.Add("@appt7", SqlDbType.VarChar);
                cmd.Parameters["@appt7"].Value = sl7;
                cmd.Parameters.Add("@appt8", SqlDbType.VarChar);
                cmd.Parameters["@appt8"].Value = sl8;
                cmd.Parameters.Add("@appt9", SqlDbType.VarChar);
                cmd.Parameters["@appt9"].Value = sl9;
                cmd.Parameters.Add("@appt10", SqlDbType.VarChar);
                cmd.Parameters["@appt10"].Value = sl10;
                cmd.Parameters.Add("@appt11", SqlDbType.VarChar);
                cmd.Parameters["@appt11"].Value = sl11;
                cmd.Parameters.Add("@appt12", SqlDbType.VarChar);
                cmd.Parameters["@appt12"].Value = sl12;
                cmd.Parameters.Add("@appt13", SqlDbType.VarChar);
                cmd.Parameters["@appt13"].Value = sl13;
                cmd.Parameters.Add("@appt14", SqlDbType.VarChar);
                cmd.Parameters["@appt14"].Value = sl14;
                cmd.Parameters.Add("@appt15", SqlDbType.VarChar);
                cmd.Parameters["@appt15"].Value = sl15;
                cmd.Parameters.Add("@appt16", SqlDbType.VarChar);
                cmd.Parameters["@appt16"].Value = sl16;
                cmd.Parameters.Add("@appt17", SqlDbType.VarChar);
                cmd.Parameters["@appt17"].Value = sl17;
                cmd.Parameters.Add("@appt18", SqlDbType.VarChar);
                cmd.Parameters["@appt18"].Value = sl18;
                cmd.Parameters.Add("@appt19", SqlDbType.VarChar);
                cmd.Parameters["@appt19"].Value = sl19;
                cmd.Parameters.Add("@appt20", SqlDbType.VarChar);
                cmd.Parameters["@appt20"].Value = sl20;
                cmd.Parameters.Add("@appt21", SqlDbType.Int);
                cmd.Parameters["@appt21"].Value = c1;
                cmd.Parameters.Add("@appt22", SqlDbType.Int);
                cmd.Parameters["@appt22"].Value = c2;
                cmd.Parameters.Add("@appt23", SqlDbType.Int);
                cmd.Parameters["@appt23"].Value = c3;
                cmd.Parameters.Add("@appt24", SqlDbType.Int);
                cmd.Parameters["@appt24"].Value = c4;
                cmd.Parameters.Add("@appt25", SqlDbType.Int);
                cmd.Parameters["@appt25"].Value = c5;
                cmd.Parameters.Add("@appt26", SqlDbType.Int);
                cmd.Parameters["@appt26"].Value = c6;
                cmd.Parameters.Add("@appt27", SqlDbType.Int);
                cmd.Parameters["@appt27"].Value = c7;
                cmd.Parameters.Add("@appt28", SqlDbType.Int);
                cmd.Parameters["@appt28"].Value = c8;
                cmd.Parameters.Add("@appt29", SqlDbType.Int);
                cmd.Parameters["@appt29"].Value = c9;
                cmd.Parameters.Add("@appt30", SqlDbType.Int);
                cmd.Parameters["@appt30"].Value = c10;
                cmd.Parameters.Add("@appt31", SqlDbType.Int);
                cmd.Parameters["@appt31"].Value = c11;
                cmd.Parameters.Add("@appt32", SqlDbType.Int);
                cmd.Parameters["@appt32"].Value = c12;
                cmd.Parameters.Add("@appt33", SqlDbType.Int);
                cmd.Parameters["@appt33"].Value = c13;
                cmd.Parameters.Add("@appt34", SqlDbType.Int);
                cmd.Parameters["@appt34"].Value = c14;
                cmd.Parameters.Add("@appt35", SqlDbType.Int);
                cmd.Parameters["@appt35"].Value = c15;
                cmd.Parameters.Add("@appt36", SqlDbType.Int);
                cmd.Parameters["@appt36"].Value = c16;
                cmd.Parameters.Add("@appt37", SqlDbType.Int);
                cmd.Parameters["@appt37"].Value = c17;
                cmd.Parameters.Add("@appt38", SqlDbType.Int);
                cmd.Parameters["@appt38"].Value = c18;
                cmd.Parameters.Add("@appt39", SqlDbType.Int);
                cmd.Parameters["@appt39"].Value = c19;
                cmd.Parameters.Add("@appt40", SqlDbType.Int);
                cmd.Parameters["@appt40"].Value = c20;
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Your shopping list was saved!");
            }
            catch
            {
                MessageBox.Show("Something went wrong. Try again later.");
            }
        }

        public ShoppingList()
        {
            InitializeComponent();
        }

        private void ShoppingList_Load(object sender, EventArgs e)
        {
            mainButton.BackColor = Color.Gold;

            //Reads data from db and places it into variables
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Shopping"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        slTb1.Text = sdr["shop1"].ToString();
                        slTb2.Text = sdr["shop2"].ToString();
                        slTb3.Text = sdr["shop3"].ToString();
                        slTb4.Text = sdr["shop4"].ToString();
                        slTb5.Text = sdr["shop5"].ToString();
                        slTb6.Text = sdr["shop6"].ToString();
                        slTb7.Text = sdr["shop7"].ToString();
                        slTb8.Text = sdr["shop8"].ToString();
                        slTb9.Text = sdr["shop9"].ToString();
                        slTb10.Text = sdr["shop10"].ToString();
                        slTb11.Text = sdr["shop11"].ToString();
                        slTb12.Text = sdr["shop12"].ToString();
                        slTb13.Text = sdr["shop13"].ToString();
                        slTb14.Text = sdr["shop14"].ToString();
                        slTb15.Text = sdr["shop15"].ToString();
                        slTb16.Text = sdr["shop16"].ToString();
                        slTb17.Text = sdr["shop17"].ToString();
                        slTb18.Text = sdr["shop18"].ToString();
                        slTb19.Text = sdr["shop19"].ToString();
                        slTb20.Text = sdr["shop20"].ToString();
                        c1 = Convert.ToInt32(sdr["Check1"]);
                        c2 = Convert.ToInt32(sdr["Check2"]);
                        c3 = Convert.ToInt32(sdr["Check3"]);
                        c4 = Convert.ToInt32(sdr["Check4"]);
                        c5 = Convert.ToInt32(sdr["Check5"]);
                        c6 = Convert.ToInt32(sdr["Check6"]);
                        c7 = Convert.ToInt32(sdr["Check7"]);
                        c8 = Convert.ToInt32(sdr["Check8"]);
                        c9 = Convert.ToInt32(sdr["Check9"]);
                        c10 = Convert.ToInt32(sdr["Check10"]);
                        c11 = Convert.ToInt32(sdr["Check11"]);
                        c12 = Convert.ToInt32(sdr["Check12"]);
                        c13 = Convert.ToInt32(sdr["Check13"]);
                        c14 = Convert.ToInt32(sdr["Check14"]);
                        c15 = Convert.ToInt32(sdr["Check15"]);
                        c16 = Convert.ToInt32(sdr["Check16"]);
                        c17 = Convert.ToInt32(sdr["Check17"]);
                        c18 = Convert.ToInt32(sdr["Check18"]);
                        c19 = Convert.ToInt32(sdr["Check19"]);
                        c20 = Convert.ToInt32(sdr["Check20"]);

                    }
                    con.Close();
                }
            }

            //Goes through the arrays and sets up what checkmarks need to be filled in
            int[] checks = {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20};

            PictureBox[] boxes = { checkMark1, checkMark2, checkMark3, checkMark4, checkMark5, checkMark6, checkMark7, 
                checkMark8, checkMark9, checkMark10, checkMark11, checkMark12, checkMark13, checkMark14, checkMark15, 
                checkMark16, checkMark17, checkMark18, checkMark19, checkMark20 };

            for (int i = 0; i < checks.Length; i++)
            {
                if (checks[i] == 0)
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                }
                else if (checks[i] == 1)
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                }
            }
        }

        private void checkMark17_Click(object sender, EventArgs e)
        {
            if (c17 == 0)
            {
                checkMark17.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c17 = 1;
            }
            else if (c17 == 1)
            {
                checkMark17.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c17 = 0;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkMark18_Click(object sender, EventArgs e)
        {
            if (c18 == 0)
            {
                checkMark18.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c18 = 1;
            }
            else if (c18 == 1)
            {
                checkMark18.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c18 = 0;
            }
        }

        private void checkMark19_Click(object sender, EventArgs e)
        {
            if (c19 == 0)
            {
                checkMark19.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c19 = 1;
            }
            else if (c19 == 1)
            {
                checkMark19.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c19 = 0;
            }
        }

        private void checkMark20_Click(object sender, EventArgs e)
        {
            if (c20 == 0)
            {
                checkMark20.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c20 = 1;
            }
            else if (c20 == 1)
            {
                checkMark20.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c20 = 0;
            }
        }

        private void checkMark16_Click(object sender, EventArgs e)
        {
            if (c16 == 0)
            {
                checkMark16.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c16 = 1;
            }
            else if (c16 == 1)
            {
                checkMark16.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c16 = 0;
            }
        }

        private void checkMark15_Click(object sender, EventArgs e)
        {
            if (c15 == 0)
            {
                checkMark15.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c15 = 1;
            }
            else if (c15 == 1)
            {
                checkMark15.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c15 = 0;
            }
        }

        private void checkMark14_Click(object sender, EventArgs e)
        {
            if (c14 == 0)
            {
                checkMark14.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c14 = 1;
            }
            else if (c14 == 1)
            {
                checkMark14.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c14 = 0;
            }
        }

        private void checkMark13_Click(object sender, EventArgs e)
        {
            if (c13 == 0)
            {
                checkMark13.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c13 = 1;
            }
            else if (c13 == 1)
            {
                checkMark13.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c13 = 0;
            }
        }

        private void checkMark12_Click(object sender, EventArgs e)
        {
            if (c12 == 0)
            {
                checkMark12.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c12 = 1;
            }
            else if (c12 == 1)
            {
                checkMark12.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c12 = 0;
            }
        }

        private void checkMark11_Click(object sender, EventArgs e)
        {
            if (c11 == 0)
            {
                checkMark11.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c11 = 1;
            }
            else if (c11 == 1)
            {
                checkMark11.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c11 = 0;
            }
        }

        private void checkMark10_Click(object sender, EventArgs e)
        {
            if (c10 == 0)
            {
                checkMark10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c10 = 1;
            }
            else if (c10 == 1)
            {
                checkMark10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c10 = 0;
            }
        }

        private void checkMark9_Click(object sender, EventArgs e)
        {
            if (c9 == 0)
            {
                checkMark9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c9 = 1;
            }
            else if (c9 == 1)
            {
                checkMark9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c9 = 0;
            }
        }

        private void checkMark8_Click(object sender, EventArgs e)
        {
            if (c8 == 0)
            {
                checkMark8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c8 = 1;
            }
            else if (c8 == 1)
            {
                checkMark8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c8 = 0;
            }
        }

        private void checkMark7_Click(object sender, EventArgs e)
        {
            if (c7 == 0)
            {
                checkMark7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c7 = 1;
            }
            else if (c7 == 1)
            {
                checkMark7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c7 = 0;
            }
        }

        private void checkMark6_Click(object sender, EventArgs e)
        {
            if (c6 == 0)
            {
                checkMark6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c6 = 1;
            }
            else if (c6 == 1)
            {
                checkMark6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c6 = 0;
            }
        }

        private void checkMark5_Click(object sender, EventArgs e)
        {
            if (c5 == 0)
            {
                checkMark5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c5 = 1;
            }
            else if (c5 == 1)
            {
                checkMark5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c5 = 0;
            }
        }

        private void checkMark4_Click(object sender, EventArgs e)
        {
            if (c4 == 0)
            {
                checkMark4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c4 = 1;
            }
            else if (c4 == 1)
            {
                checkMark4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c4 = 0;
            }
        }

        private void checkMark3_Click(object sender, EventArgs e)
        {
            if (c3 == 0)
            {
                checkMark3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c3 = 1;
            }
            else if (c3 == 1)
            {
                checkMark3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c3 = 0;
            }
        }

        private void checkMark2_Click(object sender, EventArgs e)
        {
            if (c2 == 0)
            {
                checkMark2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c2 = 1;
            }
            else if (c2 == 1)
            {
                checkMark2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c2 = 0;
            }
        }

        private void checkMark1_Click(object sender, EventArgs e)
        {
            if (c1 == 0)
            {
                checkMark1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkedCheckbox.png");
                c1 = 1;
            }
            else if (c1 == 1)
            {
                checkMark1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checkbox111.png");
                c1 = 0;
            }
        }


    }
}
