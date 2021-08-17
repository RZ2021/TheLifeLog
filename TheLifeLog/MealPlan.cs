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
        public MealPlan()
        {
            InitializeComponent();
        }

        private void MealPlan_Load(object sender, EventArgs e)
        {
            //Reads data from db and places it into variables
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM MealPlanning"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bmTB.Text = sdr["bkftMon"].ToString();
                        lmTB.Text = sdr["lunMon"].ToString();
                        dmTB.Text = sdr["dinMon"].ToString();
                        demTB.Text = sdr["desMon"].ToString();
                        btTB.Text = sdr["bkftTues"].ToString();
                        lthTB.Text = sdr["lunTues"].ToString();
                        dtTB.Text = sdr["dinTues"].ToString();
                        detTB.Text = sdr["desTues"].ToString();
                        bwTB.Text = sdr["bkftWed"].ToString();
                        lwTB.Text = sdr["lunWed"].ToString();
                        dwTB.Text = sdr["dinWed"].ToString();
                        dewTB.Text = sdr["desWed"].ToString();
                        bthTB.Text = sdr["bkftThurs"].ToString();
                        lthTB.Text = sdr["lunThurs"].ToString();
                        dthTB.Text = sdr["dinThurs"].ToString();
                        dethTB.Text = sdr["desThurs"].ToString();
                        bfTB.Text = sdr["bkftFri"].ToString();
                        lfTB.Text = sdr["lunFri"].ToString();
                        dfTB.Text = sdr["dinFri"].ToString();
                        defTB.Text = sdr["desFri"].ToString();
                        bsTB.Text = sdr["bkftSat"].ToString();
                        lsTB.Text = sdr["lunSat"].ToString();
                        dsTB.Text = sdr["dinSat"].ToString();
                        desTB.Text = sdr["desSat"].ToString();
                        bsuTB.Text = sdr["bkftSun"].ToString();
                        lsuTB.Text = sdr["lunSun"].ToString();
                        desuTB.Text = sdr["dinSun"].ToString();
                        desuTB.Text = sdr["desSun"].ToString();

                    }
                    con.Close();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            bmTB.Text = " ";
            lmTB.Text = " ";
            dmTB.Text = " ";
            demTB.Text = " ";
            btTB.Text = " ";
            ltTB.Text = " ";
            dtTB.Text = " ";
            detTB.Text = " ";
            bwTB.Text = " ";
            lwTB.Text = " ";
            dwTB.Text = " ";
            dewTB.Text = " ";
            bthTB.Text = " ";
            lthTB.Text = " ";
            dthTB.Text = " ";
            dethTB.Text = " ";
            bfTB.Text = " ";
            lfTB.Text = " ";
            dfTB.Text = " ";
            defTB.Text = " ";
            bsTB.Text = " ";
            lsTB.Text = " ";
            dsTB.Text = " ";
            desTB.Text = " ";
            bsuTB.Text = " ";
            lsuTB.Text = " ";
            dsuTB.Text = " ";
            desuTB.Text = " ";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string mp1 = bmTB.Text;
            string mp2 = lmTB.Text;
            string mp3 = dmTB.Text;
            string mp4 = demTB.Text;
            string mp5 = btTB.Text;
            string mp6 = ltTB.Text;
            string mp7 = dtTB.Text;
            string mp8 = detTB.Text;
            string mp9 = bwTB.Text;
            string mp10 = lwTB.Text;
            string mp11 = dwTB.Text;
            string mp12 = dewTB.Text;
            string mp13 = bthTB.Text;
            string mp14 = lthTB.Text;
            string mp15 = dthTB.Text;
            string mp16 = dethTB.Text;
            string mp17 = bfTB.Text;
            string mp18 = lfTB.Text;
            string mp19 = dfTB.Text;
            string mp20 = defTB.Text;
            string mp21 = bsTB.Text;
            string mp22 = lsTB.Text;
            string mp23 = dsTB.Text;
            string mp24 = desTB.Text;
            string mp25 = bsuTB.Text;
            string mp26 = lsuTB.Text;
            string mp27 = dsuTB.Text;
            string mp28 = desuTB.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");
            string sql = "UPDATE MealPlanning SET bkftMon = (@appt), lunMon = (@appt2), dinMon = (@appt3), desMon = (@appt4), bkftTues = (@appt5)," +
                "lunTues = (@appt6), dinTues = (@appt7), desTues = (@appt8), bkftWed = (@appt9), lunWed = (@appt10), dinWed = (@appt11), desWed = (@appt12), " +
                "bkftThurs = (@appt13), lunThurs = (@appt14), dinThurs = (@appt15)," + "desThurs = (@appt16), bkftFri = (@appt17), lunFri = (@appt18), dinFri = (@appt19), " +
                "desFri = (@appt20), bkftSat = (@appt21), lunSat = (@appt22), " + "dinSat = (@appt23), desSat = (@appt24), bkftSun = (@appt25), " +
                "lunSun = (@appt26), dinSun = (@appt27), desSun = (@appt28)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@appt", SqlDbType.VarChar);
                cmd.Parameters["@appt"].Value = mp1;
                cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
                cmd.Parameters["@appt2"].Value = mp2;
                cmd.Parameters.Add("@appt3", SqlDbType.VarChar);
                cmd.Parameters["@appt3"].Value = mp3;
                cmd.Parameters.Add("@appt4", SqlDbType.VarChar);
                cmd.Parameters["@appt4"].Value = mp4;
                cmd.Parameters.Add("@appt5", SqlDbType.VarChar);
                cmd.Parameters["@appt5"].Value = mp5;
                cmd.Parameters.Add("@appt6", SqlDbType.VarChar);
                cmd.Parameters["@appt6"].Value = mp6;
                cmd.Parameters.Add("@appt7", SqlDbType.VarChar);
                cmd.Parameters["@appt7"].Value = mp7;
                cmd.Parameters.Add("@appt8", SqlDbType.VarChar);
                cmd.Parameters["@appt8"].Value = mp8;
                cmd.Parameters.Add("@appt9", SqlDbType.VarChar);
                cmd.Parameters["@appt9"].Value = mp9;
                cmd.Parameters.Add("@appt10", SqlDbType.VarChar);
                cmd.Parameters["@appt10"].Value = mp10;
                cmd.Parameters.Add("@appt11", SqlDbType.VarChar);
                cmd.Parameters["@appt11"].Value = mp11;
                cmd.Parameters.Add("@appt12", SqlDbType.VarChar);
                cmd.Parameters["@appt12"].Value = mp12;
                cmd.Parameters.Add("@appt13", SqlDbType.VarChar);
                cmd.Parameters["@appt13"].Value = mp13;
                cmd.Parameters.Add("@appt14", SqlDbType.VarChar);
                cmd.Parameters["@appt14"].Value = mp14;
                cmd.Parameters.Add("@appt15", SqlDbType.VarChar);
                cmd.Parameters["@appt15"].Value = mp15;
                cmd.Parameters.Add("@appt16", SqlDbType.VarChar);
                cmd.Parameters["@appt16"].Value = mp16;
                cmd.Parameters.Add("@appt17", SqlDbType.VarChar);
                cmd.Parameters["@appt17"].Value = mp17;
                cmd.Parameters.Add("@appt18", SqlDbType.VarChar);
                cmd.Parameters["@appt18"].Value = mp18;
                cmd.Parameters.Add("@appt19", SqlDbType.VarChar);
                cmd.Parameters["@appt19"].Value = mp19;
                cmd.Parameters.Add("@appt20", SqlDbType.VarChar);
                cmd.Parameters["@appt20"].Value = mp20;
                cmd.Parameters.Add("@appt21", SqlDbType.VarChar);
                cmd.Parameters["@appt21"].Value = mp21;
                cmd.Parameters.Add("@appt22", SqlDbType.VarChar);
                cmd.Parameters["@appt22"].Value = mp22;
                cmd.Parameters.Add("@appt23", SqlDbType.VarChar);
                cmd.Parameters["@appt23"].Value = mp23;
                cmd.Parameters.Add("@appt24", SqlDbType.VarChar);
                cmd.Parameters["@appt24"].Value = mp24;
                cmd.Parameters.Add("@appt25", SqlDbType.VarChar);
                cmd.Parameters["@appt25"].Value = mp25;
                cmd.Parameters.Add("@appt26", SqlDbType.VarChar);
                cmd.Parameters["@appt26"].Value = mp26;
                cmd.Parameters.Add("@appt27", SqlDbType.VarChar);
                cmd.Parameters["@appt27"].Value = mp27;
                cmd.Parameters.Add("@appt28", SqlDbType.VarChar);
                cmd.Parameters["@appt28"].Value = mp28;

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Your meal planner was saved!");
            }
            catch
            {
                MessageBox.Show("Something went wrong. Try again later.");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
