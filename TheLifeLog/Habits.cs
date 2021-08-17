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
    public partial class Habits : Form
    {
        readonly string yesDate = DateTime.Now.AddDays(-1).ToString("ddMM");
        readonly string today = DateTime.Now.ToString("ddMM");
        int t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10;
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0, click10 = 0;
        string y1, y2, y3, y4, y5, y6, y7, y8, y9, y10;

        public Habits()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");
            string sql = "UPDATE Habits SET name1 = (@appt), name2 = (@appt2), name3 = (@appt3), name4 = (@appt4), name5 = (@appt5), " +
                "name6 = (@appt6), name7 = (@appt7), name8 = (@appt8), name9 = (@appt9), name10 = (@appt10), total1 = (@appt11), " +
                "total2 = (@appt12), total3 = (@appt13), total4 = (@appt14), total5 = (@appt15), total6 = (@appt16), total7 = (@appt17)," +
                "total8 = (@appt18), total9 = (@appt19), total10 = (@appt20), streak1 = (@appt21), streak2 = (@appt22), streak3 = (@appt23)," +
                "streak4 = (@appt24), streak5 = (@appt25), streak6 = (@appt26), streak7 = (@appt27), streak8 = (@appt28), streak9 = (@appt29)," +
                "streak10 = (@appt30), yesDate1 = (@appt31), yesDate2 = (@appt32), yesDate3 = (@appt33), yesDate4 = (@appt34), " +
                "yesDate5 = (@appt35), yesDate6 = (@appt36), yesDate7 = (@appt37), yesDate8 = (@appt38), yesDate9 = (@appt39), yesDate10 = (@appt40)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@appt", SqlDbType.VarChar);
            cmd.Parameters["@appt"].Value = habitTB1.Text;
            cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
            cmd.Parameters["@appt2"].Value = habitTB2.Text;
            cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
            cmd.Parameters["@appt3"].Value = habitTB3.Text;
            cmd.Parameters.Add("@appt4", SqlDbType.VarChar);
            cmd.Parameters["@appt4"].Value = habitTB4.Text;
            cmd.Parameters.Add("@appt5", SqlDbType.VarChar);
            cmd.Parameters["@appt5"].Value = habitTB5.Text;
            cmd.Parameters.Add("@appt6", SqlDbType.VarChar);
            cmd.Parameters["@appt6"].Value = habitTB6.Text;
            cmd.Parameters.Add("@appt7", SqlDbType.VarChar);
            cmd.Parameters["@appt7"].Value = habitTB7.Text;
            cmd.Parameters.Add("@appt8", SqlDbType.VarChar);
            cmd.Parameters["@appt8"].Value = habitTB8.Text;
            cmd.Parameters.Add("@appt9", SqlDbType.VarChar);
            cmd.Parameters["@appt9"].Value = habitTB9.Text;
            cmd.Parameters.Add("@appt10", SqlDbType.VarChar);
            cmd.Parameters["@appt10"].Value = habitTB10.Text;
            cmd.Parameters.Add("@appt11", SqlDbType.VarChar);
            cmd.Parameters["@appt11"].Value = t1;
            cmd.Parameters.Add("@appt12", SqlDbType.VarChar);
            cmd.Parameters["@appt12"].Value = t2;
            cmd.Parameters.Add("@appt13", SqlDbType.VarChar);
            cmd.Parameters["@appt13"].Value = t3;
            cmd.Parameters.Add("@appt14", SqlDbType.VarChar);
            cmd.Parameters["@appt14"].Value = t4;
            cmd.Parameters.Add("@appt15", SqlDbType.VarChar);
            cmd.Parameters["@appt15"].Value = t5;
            cmd.Parameters.Add("@appt16", SqlDbType.VarChar);
            cmd.Parameters["@appt16"].Value = t6;
            cmd.Parameters.Add("@appt17", SqlDbType.VarChar);
            cmd.Parameters["@appt17"].Value = t7;
            cmd.Parameters.Add("@appt18", SqlDbType.VarChar);
            cmd.Parameters["@appt18"].Value = t8;
            cmd.Parameters.Add("@appt19", SqlDbType.VarChar);
            cmd.Parameters["@appt19"].Value = t9;
            cmd.Parameters.Add("@appt20", SqlDbType.VarChar);
            cmd.Parameters["@appt20"].Value = t10;
            cmd.Parameters.Add("@appt21", SqlDbType.VarChar);
            cmd.Parameters["@appt21"].Value = s1;
            cmd.Parameters.Add("@appt22", SqlDbType.VarChar);
            cmd.Parameters["@appt22"].Value = s2;
            cmd.Parameters.Add("@appt23", SqlDbType.VarChar);
            cmd.Parameters["@appt23"].Value = s3;
            cmd.Parameters.Add("@appt24", SqlDbType.VarChar);
            cmd.Parameters["@appt24"].Value = s4;
            cmd.Parameters.Add("@appt25", SqlDbType.VarChar);
            cmd.Parameters["@appt25"].Value = s5;
            cmd.Parameters.Add("@appt26", SqlDbType.VarChar);
            cmd.Parameters["@appt26"].Value = s6;
            cmd.Parameters.Add("@appt27", SqlDbType.VarChar);
            cmd.Parameters["@appt27"].Value = s7;
            cmd.Parameters.Add("@appt28", SqlDbType.VarChar);
            cmd.Parameters["@appt28"].Value = s8;
            cmd.Parameters.Add("@appt29", SqlDbType.VarChar);
            cmd.Parameters["@appt29"].Value = s9;
            cmd.Parameters.Add("@appt30", SqlDbType.VarChar);
            cmd.Parameters["@appt30"].Value = s10;
            cmd.Parameters.Add("@appt31", SqlDbType.VarChar);
            cmd.Parameters["@appt31"].Value = y1;
            cmd.Parameters.Add("@appt32", SqlDbType.VarChar);
            cmd.Parameters["@appt32"].Value = y2;
            cmd.Parameters.Add("@appt33", SqlDbType.VarChar);
            cmd.Parameters["@appt33"].Value = y3;
            cmd.Parameters.Add("@appt34", SqlDbType.VarChar);
            cmd.Parameters["@appt34"].Value = y4;
            cmd.Parameters.Add("@appt35", SqlDbType.VarChar);
            cmd.Parameters["@appt35"].Value = y5;
            cmd.Parameters.Add("@appt36", SqlDbType.VarChar);
            cmd.Parameters["@appt36"].Value = y6;
            cmd.Parameters.Add("@appt37", SqlDbType.VarChar);
            cmd.Parameters["@appt37"].Value = y7;
            cmd.Parameters.Add("@appt38", SqlDbType.VarChar);
            cmd.Parameters["@appt38"].Value = y8;
            cmd.Parameters.Add("@appt39", SqlDbType.VarChar);
            cmd.Parameters["@appt39"].Value = y9;
            cmd.Parameters.Add("@appt40", SqlDbType.VarChar);
            cmd.Parameters["@appt40"].Value = y10;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your habits have been saved!");
        }

        private void Habits_Load(object sender, EventArgs e)
        {
            //Reads data from db and places it into textboxes
            string constr = @"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Habits"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        habitTB1.Text = sdr["name1"].ToString();
                        habitTB2.Text = sdr["name2"].ToString();
                        habitTB3.Text = sdr["name3"].ToString();
                        habitTB4.Text = sdr["name4"].ToString();
                        habitTB5.Text = sdr["name5"].ToString();
                        habitTB6.Text = sdr["name6"].ToString();
                        habitTB7.Text = sdr["name7"].ToString();
                        habitTB8.Text = sdr["name8"].ToString();
                        habitTB9.Text = sdr["name9"].ToString();
                        habitTB10.Text = sdr["name10"].ToString();
                        t1 = Convert.ToInt32(sdr["total1"]);
                        t2 = Convert.ToInt32(sdr["total2"]);
                        t3 = Convert.ToInt32(sdr["total3"]);
                        t4 = Convert.ToInt32(sdr["total4"]);
                        t5 = Convert.ToInt32(sdr["total5"]);
                        t6 = Convert.ToInt32(sdr["total6"]);
                        t7 = Convert.ToInt32(sdr["total7"]);
                        t8 = Convert.ToInt32(sdr["total8"]);
                        t9 = Convert.ToInt32(sdr["total9"]);
                        t10 = Convert.ToInt32(sdr["total10"]);
                        s1 = Convert.ToInt32(sdr["streak1"]);
                        s2 = Convert.ToInt32(sdr["streak2"]);
                        s3 = Convert.ToInt32(sdr["streak3"]);
                        s4 = Convert.ToInt32(sdr["streak4"]);
                        s5 = Convert.ToInt32(sdr["streak5"]);
                        s6 = Convert.ToInt32(sdr["streak6"]);
                        s7 = Convert.ToInt32(sdr["streak7"]);
                        s8 = Convert.ToInt32(sdr["streak8"]);
                        s9 = Convert.ToInt32(sdr["streak9"]);
                        s10 = Convert.ToInt32(sdr["streak10"]);
                        y1 = sdr["yesDate1"].ToString();
                        y2 = sdr["yesDate2"].ToString();
                        y3 = sdr["yesDate3"].ToString();
                        y4 = sdr["yesDate4"].ToString();
                        y5 = sdr["yesDate5"].ToString();
                        y6 = sdr["yesDate6"].ToString();
                        y7 = sdr["yesDate7"].ToString();
                        y8 = sdr["yesDate8"].ToString();
                        y9 = sdr["yesDate9"].ToString();
                        y10 = sdr["yesDate10"].ToString();
                    }
                    con.Close();
                }
            }

            refreshLabels();
            refreshChecks();
        }

        private void refreshChecks()
        {
            //Goes through the arrays and sets up what checkmarks need to be filled in
            string[] checks = {y1, y2, y3, y4, y5, y6, y7, y8, y9, y10};

            PictureBox[] boxes = {pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10};

            for (int i = 0; i < checks.Length; i++)
            {
                if (checks[i] == today)
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/Checked.png");
                }
                else 
                {
                    boxes[i].Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/images/checks.png");
                }
            }
        }

        private void refreshLabels()
        {
            //Populate labels from db
            td1Label.Text = t1.ToString();
            td2Label.Text = t2.ToString();
            td3Label.Text = t3.ToString();
            td4Label.Text = t4.ToString();
            td5Label.Text = t5.ToString();
            td6Label.Text = t6.ToString();
            td7Label.Text = t7.ToString();
            td8Label.Text = t8.ToString();
            td9Label.Text = t9.ToString();
            td10Label.Text = t10.ToString();
            cs1Label.Text = s1.ToString();
            cs2Label.Text = s2.ToString();
            cs3Label.Text = s3.ToString();
            cs4Label.Text = s4.ToString();
            cs5Label.Text = s5.ToString();
            cs6Label.Text = s6.ToString();
            cs7Label.Text = s7.ToString();
            cs8Label.Text = s8.ToString();
            cs9Label.Text = s9.ToString();
            cs10Label.Text = s10.ToString();
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            if (click10 == 0)
            {
                pb10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click10 = 1;
                t10++;

                if (y10 == yesDate)
                {
                    s10++;
                }
                else
                {
                    s10 = 0;
                    
                }

                y10 = today;
            }
            else if (click10 == 1)
            {
                pb10.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click10 = 0;
                t10--;

                if (y10 == yesDate)
                {
                    s10--;
                }
                else
                {
                    s10 = 0;
                }
            }
            refreshLabels();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                pb9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click9 = 1;
                t9++;

                if (y9 == yesDate)
                {
                    s9++;
                }
                else
                {
                    s9 = 0;

                }
                y9 = today;
            }
            else if (click9 == 1)
            {
                pb9.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click9 = 0;
                t9--;

                if (y9 == yesDate)
                {
                    s9--;
                }
                else
                {
                    s9 = 0;
                }
            }
            refreshLabels();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                pb8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click8 = 1;
                t8++;

                if (y8 == yesDate)
                {
                    s8++;
                }
                else
                {
                    s8 = 0;

                }
                y8 = today;

            }
            else if (click8 == 1)
            {
                pb8.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click8 = 0;
                t8--;

                if (y8 == yesDate)
                {
                    s8--;
                }
                else
                {
                    s8 = 0;
                }
            }
            refreshLabels();
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                pb7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click7 = 1;
                t7++;

                if (y7 == yesDate)
                {
                    s7++;
                }
                else
                {
                    s7 = 0;

                }
                y7 = today;

            }
            else if (click7 == 1)
            {
                pb7.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click7 = 0;
                t7--;

                if (y7 == yesDate)
                {
                    s7--;
                }
                else
                {
                    s7 = 0;
                }
            }
            refreshLabels();
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                pb6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click6 = 1;
                t6++;

                if (y6 == yesDate)
                {
                    s6++;
                }
                else
                {
                    s6 = 0;

                }
                y6 = today;

            }
            else if (click6 == 1)
            {
                pb6.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click6 = 0;
                t6--;

                if (y6 == yesDate)
                {
                    s6--;
                }
                else
                {
                    s6 = 0;
                }
            }
            refreshLabels();
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                pb5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click5 = 1;
                t5++;

                if (y5 == yesDate)
                {
                    s5++;
                }
                else
                {
                    s5 = 0;

                }
                y5 = today;

            }
            else if (click5 == 1)
            {
                pb5.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click5 = 0;
                t5--;

                if (y5 == yesDate)
                {
                    s5--;
                }
                else
                {
                    s5 = 0;
                }
            }
            refreshLabels();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                pb4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click4 = 1;
                t4++;

                if (y4 == yesDate)
                {
                    s4++;
                }
                else
                {
                    s4 = 0;

                }
                y4 = today;

            }
            else if (click4 == 1)
            {
                pb4.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click4 = 0;
                t4--;

                if (y4 == yesDate)
                {
                    s4--;
                }
                else
                {
                    s4 = 0;
                }
            }
            refreshLabels();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                pb3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click3 = 1;
                t3++;

                if (y3 == yesDate)
                {
                    s3++;
                }
                else
                {
                    s3 = 0;

                }
                y3 = today;

            }
            else if (click3 == 1)
            {
                pb3.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click3 = 0;
                t3--;

                if (y3 == yesDate)
                {
                    s3--;
                }
                else
                {
                    s3 = 0;
                }
            }
            refreshLabels();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                pb2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click2 = 1;
                t2++;

                if (y2 == yesDate)
                {
                    s2++;
                }
                else
                {
                    s2 = 0;

                }
                y2 = today;

            }
            else if (click2 == 1)
            {
                pb2.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click2 = 0;
                t2--;

                if (y2 == yesDate)
                {
                    s2--;
                }
                else
                {
                    s2 = 0;
                }
            }
            refreshLabels();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                pb1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/Checked.png");
                click1 = 1;
                t1++;

                if (y1 == yesDate)
                {
                    s1++;
                }
                else
                {
                    s1 = 0;

                }
                y1 = today;

            }
            else if (click1 == 1)
            {
                pb1.Image = Image.FromFile("C:/Users/royet/source/repos/TheLifeLog/Images/checks.png");
                click1 = 0;
                t1--;

                if (y1 == yesDate)
                {
                    s1--;
                }
                else
                {
                    s1 = 0;
                }
            }
            refreshLabels();
        }
    }
}
