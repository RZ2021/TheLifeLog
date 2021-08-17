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
    public partial class Calendar : Form
    {
        int mon, year, id;
        List<string> calData = new List<string>();

        public Calendar(int id)
        {
            InitializeComponent();

            this.id = id;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            GetCalendar();
            Months();
            
        }

        private void Months()
        {
            if (mon != 0 && year != 0)
            {
                setDates();
                switch (mon.ToString())
                {
                    case "1":
                        monthTitle.Text = "January";
                        break;
                    case "2":
                        monthTitle.Text = "Feburary";
                        break;
                    case "3":
                        monthTitle.Text = "March";
                        break;
                    case "4":
                        monthTitle.Text = "April";
                        break;
                    case "5":
                        monthTitle.Text = "May";
                        break;
                    case "6":
                        monthTitle.Text = "June";
                        break;
                    case "7":
                        monthTitle.Text = "July";
                        break;
                    case "8":
                        monthTitle.Text = "August";
                        break;
                    case "9":
                        monthTitle.Text = "September";
                        break;
                    case "10":
                        monthTitle.Text = "October";
                        break;
                    case "11":
                        monthTitle.Text = "November";
                        break;
                    case "12":
                        monthTitle.Text = "December";
                        break;
                }
            }
        }

        private void GetCalendar()
        {
            try
            {
                DataConnect dc = new DataConnect();
                string temp = dc.ReadCalendar(id, 1);
                if (temp == null)
                {

                }
                else
                {
                    mon = Convert.ToInt32(dc.ReadCalendar(id, 2));
                    year = Convert.ToInt32(dc.ReadCalendar(id, 3));
                    string[] tempArray = temp.Split('*');
                    foreach (string str in tempArray)
                    {
                        calData.Add(str);
                    }

                    tb1.Text = calData[0];
                    tb2.Text = calData[1];
                    tb3.Text = calData[2];
                    tb4.Text = calData[3];
                    tb5.Text = calData[4];
                    tb6.Text = calData[5];
                    tb7.Text = calData[6];
                    tb8.Text = calData[7];
                    tb9.Text = calData[8];
                    tb10.Text = calData[9];
                    tb11.Text = calData[10];
                    tb12.Text = calData[11];
                    tb13.Text = calData[12];
                    tb14.Text = calData[13];
                    tb15.Text = calData[14];
                    tb16.Text = calData[15];
                    tb17.Text = calData[16];
                    tb18.Text = calData[17];
                    tb19.Text = calData[18];
                    tb20.Text = calData[19];
                    tb21.Text = calData[20];
                    tb22.Text = calData[21];
                    tb23.Text = calData[22];
                    tb24.Text = calData[23];
                    tb25.Text = calData[24];
                    tb26.Text = calData[25];
                    tb27.Text = calData[26];
                    tb28.Text = calData[27];
                    tb29.Text = calData[28];
                    tb30.Text = calData[29];
                    tb31.Text = calData[30];
                    tb32.Text = calData[31];
                    tb33.Text = calData[32];
                    tb34.Text = calData[33];
                    tb35.Text = calData[34];
                    tb36.Text = calData[35];
                    tb37.Text = calData[36];
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
            
        }

        private void updateCalendar_Click(object sender, EventArgs e)
        {
            calData.Clear();
            //writes data in textboxes to database
            calData.Add(tb1.Text);
            calData.Add(tb2.Text);
            calData.Add(tb3.Text);
            calData.Add(tb4.Text);
            calData.Add(tb5.Text);
            calData.Add(tb6.Text);
            calData.Add(tb7.Text);
            calData.Add(tb8.Text);
            calData.Add(tb9.Text);
            calData.Add(tb10.Text);
            calData.Add(tb11.Text);
            calData.Add(tb12.Text);
            calData.Add(tb13.Text);
            calData.Add(tb14.Text);
            calData.Add(tb15.Text);
            calData.Add(tb16.Text);
            calData.Add(tb17.Text);
            calData.Add(tb18.Text);
            calData.Add(tb19.Text);
            calData.Add(tb20.Text);
            calData.Add(tb21.Text);
            calData.Add(tb22.Text);
            calData.Add(tb23.Text);
            calData.Add(tb24.Text);
            calData.Add(tb25.Text);
            calData.Add(tb26.Text);
            calData.Add(tb27.Text);
            calData.Add(tb28.Text);
            calData.Add(tb29.Text);
            calData.Add(tb30.Text);
            calData.Add(tb31.Text);
            calData.Add(tb32.Text);
            calData.Add(tb33.Text);
            calData.Add(tb34.Text);
            calData.Add(tb35.Text);
            calData.Add(tb36.Text);
            calData.Add(tb37.Text);

            string dates = String.Join("*", calData.ToArray());
            DataConnect dc = new DataConnect();
            int answer = dc.WriteCalendar(id, dates, mon, year);
            if(answer != 0)
            {
                MessageBox.Show("Your calendar has been saved!");

            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void monthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gets selected month and changes the title to the correct month
            mon = Int32.Parse(monthCombo.Text);
            switch (monthCombo.Text)
            {
                case "1":
                    monthTitle.Text = "January";
                    break;
                case "2":
                    monthTitle.Text = "Feburary";
                    break;
                case "3":
                    monthTitle.Text = "March";
                    break;
                case "4":
                    monthTitle.Text = "April";
                    break;
                case "5":
                    monthTitle.Text = "May";
                    break;
                case "6":
                    monthTitle.Text = "June";
                    break;
                case "7":
                    monthTitle.Text = "July";
                    break;
                case "8":
                    monthTitle.Text = "August";
                    break;
                case "9":
                    monthTitle.Text = "September";
                    break;
                case "10":
                    monthTitle.Text = "October";
                    break;
                case "11":
                    monthTitle.Text = "November";
                    break;
                case "12":
                    monthTitle.Text = "December";
                    break;

            }
        }
        

        private void yearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gets users chosen year
            year = Int32.Parse(yearCombo.Text);
        }

        private void dateSetter_Click(object sender, EventArgs e)
        {
            setDates();
        }

        private void setDates()
        {
            //Send the mon and year to the database
            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=LifeLog;Integrated Security=True;");
            string sql = "UPDATE Calendar SET Month = (@appt), Year = (@appt2)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@appt", SqlDbType.VarChar);
            cmd.Parameters["@appt"].Value = mon;
            cmd.Parameters.Add("@appt2", SqlDbType.VarChar);
            cmd.Parameters["@appt2"].Value = year;
            cmd.ExecuteNonQuery();
            conn.Close();

            //Get the right day of the week
            DateTime dt = new DateTime(year, mon, 1);
            int wday = (int)dt.DayOfWeek;
            bool leapYear = DateTime.IsLeapYear(year);

            //Set the calendar dates to line up with the correct days of the week
            //Sets a baseline of 31 days to start with
            switch (wday)
            {
                case 0:
                    date1.Text = "1";
                    date2.Text = "2";
                    date3.Text = "3";
                    date4.Text = "4";
                    date5.Text = "5";
                    date6.Text = "6";
                    date7.Text = "7";
                    date8.Text = "8";
                    date9.Text = "9";
                    date10.Text = "10";
                    date11.Text = "11";
                    date12.Text = "12";
                    date13.Text = "13";
                    date14.Text = "14";
                    date15.Text = "15";
                    date16.Text = "16";
                    date17.Text = "17";
                    date18.Text = "18";
                    date19.Text = "19";
                    date20.Text = "20";
                    date21.Text = "21";
                    date22.Text = "22";
                    date23.Text = "23";
                    date24.Text = "24";
                    date25.Text = "25";
                    date26.Text = "26";
                    date27.Text = "27";
                    date28.Text = "28";
                    date29.Text = "29";
                    date30.Text = "30";
                    date31.Text = "31";
                    date32.Text = "";
                    date33.Text = "";
                    date34.Text = "";
                    date35.Text = "";
                    date36.Text = "";
                    date37.Text = "";
                    tb32.ReadOnly = true;
                    tb33.ReadOnly = true;
                    tb34.ReadOnly = true;
                    tb35.ReadOnly = true;
                    tb36.ReadOnly = true;
                    tb37.ReadOnly = true;


                    break;
                case 1:
                    date1.Text = "";
                    date2.Text = "1";
                    date3.Text = "2";
                    date4.Text = "3";
                    date5.Text = "4";
                    date6.Text = "5";
                    date7.Text = "6";
                    date8.Text = "7";
                    date9.Text = "8";
                    date10.Text = "9";
                    date11.Text = "10";
                    date12.Text = "11";
                    date13.Text = "12";
                    date14.Text = "13";
                    date15.Text = "14";
                    date16.Text = "15";
                    date17.Text = "16";
                    date18.Text = "17";
                    date19.Text = "18";
                    date20.Text = "19";
                    date21.Text = "20";
                    date22.Text = "21";
                    date23.Text = "22";
                    date24.Text = "23";
                    date25.Text = "24";
                    date26.Text = "25";
                    date27.Text = "26";
                    date28.Text = "27";
                    date29.Text = "28";
                    date30.Text = "29";
                    date31.Text = "30";
                    date32.Text = "31";
                    date33.Text = "";
                    date34.Text = "";
                    date35.Text = "";
                    date36.Text = "";
                    date37.Text = "";
                    tb1.ReadOnly = true;
                    tb33.ReadOnly = true;
                    tb34.ReadOnly = true;
                    tb35.ReadOnly = true;
                    tb36.ReadOnly = true;
                    tb37.ReadOnly = true;
                    break;
                case 2:
                    date1.Text = "";
                    date2.Text = "";
                    date3.Text = "1";
                    date4.Text = "2";
                    date5.Text = "3";
                    date6.Text = "4";
                    date7.Text = "5";
                    date8.Text = "6";
                    date9.Text = "7";
                    date10.Text = "8";
                    date11.Text = "9";
                    date12.Text = "10";
                    date13.Text = "11";
                    date14.Text = "12";
                    date15.Text = "13";
                    date16.Text = "14";
                    date17.Text = "15";
                    date18.Text = "16";
                    date19.Text = "17";
                    date20.Text = "18";
                    date21.Text = "19";
                    date22.Text = "20";
                    date23.Text = "21";
                    date24.Text = "22";
                    date25.Text = "23";
                    date26.Text = "24";
                    date27.Text = "25";
                    date28.Text = "26";
                    date29.Text = "27";
                    date30.Text = "28";
                    date31.Text = "29";
                    date32.Text = "30";
                    date33.Text = "31";
                    date34.Text = "";
                    date35.Text = "";
                    date36.Text = "";
                    date37.Text = "";
                    tb1.ReadOnly = true;
                    tb2.ReadOnly = true;
                    tb34.ReadOnly = true;
                    tb35.ReadOnly = true;
                    tb36.ReadOnly = true;
                    tb37.ReadOnly = true;
                    break;
                case 3:
                    date1.Text = "";
                    date2.Text = "";
                    date3.Text = "";
                    date4.Text = "1";
                    date5.Text = "2";
                    date6.Text = "3";
                    date7.Text = "4";
                    date8.Text = "5";
                    date9.Text = "6";
                    date10.Text = "7";
                    date11.Text = "8";
                    date12.Text = "9";
                    date13.Text = "10";
                    date14.Text = "11";
                    date15.Text = "12";
                    date16.Text = "13";
                    date17.Text = "14";
                    date18.Text = "15";
                    date19.Text = "16";
                    date20.Text = "17";
                    date21.Text = "18";
                    date22.Text = "19";
                    date23.Text = "20";
                    date24.Text = "21";
                    date25.Text = "22";
                    date26.Text = "23";
                    date27.Text = "24";
                    date28.Text = "25";
                    date29.Text = "26";
                    date30.Text = "27";
                    date31.Text = "28";
                    date32.Text = "29";
                    date33.Text = "30";
                    date34.Text = "31";
                    date35.Text = "";
                    date36.Text = "";
                    date37.Text = "";
                    tb1.ReadOnly = true;
                    tb2.ReadOnly = true;
                    tb3.ReadOnly = true;
                    tb35.ReadOnly = true;
                    tb36.ReadOnly = true;
                    tb37.ReadOnly = true;
                    break;
                case 4:
                    date1.Text = "";
                    date2.Text = "";
                    date3.Text = "";
                    date4.Text = "";
                    date5.Text = "1";
                    date6.Text = "2";
                    date7.Text = "3";
                    date8.Text = "4";
                    date9.Text = "5";
                    date10.Text = "6";
                    date11.Text = "7";
                    date12.Text = "8";
                    date13.Text = "9";
                    date14.Text = "10";
                    date15.Text = "11";
                    date16.Text = "12";
                    date17.Text = "13";
                    date18.Text = "14";
                    date19.Text = "15";
                    date20.Text = "16";
                    date21.Text = "17";
                    date22.Text = "18";
                    date23.Text = "19";
                    date24.Text = "20";
                    date25.Text = "21";
                    date26.Text = "22";
                    date27.Text = "23";
                    date28.Text = "24";
                    date29.Text = "25";
                    date30.Text = "26";
                    date31.Text = "27";
                    date32.Text = "28";
                    date33.Text = "29";
                    date34.Text = "30";
                    date35.Text = "31";
                    date36.Text = "";
                    date37.Text = "";
                    tb1.ReadOnly = true;
                    tb2.ReadOnly = true;
                    tb3.ReadOnly = true;
                    tb4.ReadOnly = true;
                    tb36.ReadOnly = true;
                    tb37.ReadOnly = true;
                    break;
                case 5:
                    date1.Text = "";
                    date2.Text = "";
                    date3.Text = "";
                    date4.Text = "";
                    date5.Text = "";
                    date6.Text = "1";
                    date7.Text = "2";
                    date8.Text = "3";
                    date9.Text = "4";
                    date10.Text = "5";
                    date11.Text = "6";
                    date12.Text = "7";
                    date13.Text = "8";
                    date14.Text = "9";
                    date15.Text = "10";
                    date16.Text = "11";
                    date17.Text = "12";
                    date18.Text = "13";
                    date19.Text = "14";
                    date20.Text = "15";
                    date21.Text = "16";
                    date22.Text = "17";
                    date23.Text = "18";
                    date24.Text = "19";
                    date25.Text = "20";
                    date26.Text = "21";
                    date27.Text = "22";
                    date28.Text = "23";
                    date29.Text = "24";
                    date30.Text = "25";
                    date31.Text = "26";
                    date32.Text = "27";
                    date33.Text = "28";
                    date34.Text = "29";
                    date35.Text = "30";
                    date36.Text = "31";
                    date37.Text = "";
                    tb1.ReadOnly = true;
                    tb2.ReadOnly = true;
                    tb3.ReadOnly = true;
                    tb4.ReadOnly = true;
                    tb5.ReadOnly = true;
                    tb37.ReadOnly = true;
                    break;
                case 6:
                    date1.Text = "";
                    date2.Text = "";
                    date3.Text = "";
                    date4.Text = "";
                    date5.Text = "";
                    date6.Text = "";
                    date7.Text = "1";
                    date8.Text = "2";
                    date9.Text = "3";
                    date10.Text = "4";
                    date11.Text = "5";
                    date12.Text = "6";
                    date13.Text = "7";
                    date14.Text = "8";
                    date15.Text = "9";
                    date16.Text = "10";
                    date17.Text = "11";
                    date18.Text = "12";
                    date19.Text = "13";
                    date20.Text = "14";
                    date21.Text = "15";
                    date22.Text = "16";
                    date23.Text = "17";
                    date24.Text = "18";
                    date25.Text = "19";
                    date26.Text = "20";
                    date27.Text = "21";
                    date28.Text = "22";
                    date29.Text = "23";
                    date30.Text = "24";
                    date31.Text = "25";
                    date32.Text = "26";
                    date33.Text = "27";
                    date34.Text = "28";
                    date35.Text = "29";
                    date36.Text = "30";
                    date37.Text = "31";
                    tb1.ReadOnly = true;
                    tb2.ReadOnly = true;
                    tb3.ReadOnly = true;
                    tb4.ReadOnly = true;
                    tb5.ReadOnly = true;
                    tb6.ReadOnly = true;
                    break;

            }

            //To set the correct amount of days for Feb and check for leap year
            if (mon == 2 && leapYear == true)
            {
                switch (wday)
                {
                    case 0:
                        date30.Text = "";
                        date31.Text = "";
                        tb30.ReadOnly = true;
                        tb31.ReadOnly = true;
                        break;

                    case 1:
                        date31.Text = "";
                        date32.Text = "";
                        tb31.ReadOnly = true;
                        tb32.ReadOnly = true;
                        break;

                    case 2:
                        date32.Text = "";
                        date33.Text = "";
                        tb32.ReadOnly = true;
                        tb33.ReadOnly = true;
                        break;

                    case 3:
                        date33.Text = "";
                        date34.Text = "";
                        tb33.ReadOnly = true;
                        tb34.ReadOnly = true;
                        break;

                    case 4:
                        date34.Text = "";
                        date35.Text = "";
                        tb34.ReadOnly = true;
                        tb35.ReadOnly = true;
                        break;

                    case 5:
                        date35.Text = "";
                        date36.Text = "";
                        tb35.ReadOnly = true;
                        tb36.ReadOnly = true;
                        break;

                    case 6:
                        date36.Text = "";
                        date37.Text = "";
                        tb36.ReadOnly = true;
                        tb37.ReadOnly = true;
                        break;

                }
            } //Feburary months that aren't leap year
            else if (mon == 2 && leapYear == false)
            {
                switch (wday)
                {
                    case 0:
                        date29.Text = "";
                        date30.Text = "";
                        date31.Text = "";
                        tb29.ReadOnly = true;
                        tb30.ReadOnly = true;
                        tb31.ReadOnly = true;

                        break;

                    case 1:
                        date30.Text = "";
                        date31.Text = "";
                        date32.Text = "";
                        tb30.ReadOnly = true;
                        tb31.ReadOnly = true;
                        tb32.ReadOnly = true;
                        break;

                    case 2:
                        date31.Text = "";
                        date32.Text = "";
                        date33.Text = "";
                        tb31.ReadOnly = true;
                        tb32.ReadOnly = true;
                        tb33.ReadOnly = true;
                        break;

                    case 3:
                        date32.Text = "";
                        date33.Text = "";
                        date34.Text = "";
                        tb32.ReadOnly = true;
                        tb33.ReadOnly = true;
                        tb34.ReadOnly = true;
                        break;

                    case 4:
                        date33.Text = "";
                        date34.Text = "";
                        date35.Text = "";
                        tb33.ReadOnly = true;
                        tb34.ReadOnly = true;
                        tb35.ReadOnly = true;
                        break;

                    case 5:
                        date34.Text = "";
                        date35.Text = "";
                        date36.Text = "";
                        tb34.ReadOnly = true;
                        tb35.ReadOnly = true;
                        tb36.ReadOnly = true;
                        break;

                    case 6:
                        date35.Text = "";
                        date36.Text = "";
                        date37.Text = "";
                        tb35.ReadOnly = true;
                        tb36.ReadOnly = true;
                        tb37.ReadOnly = true;
                        break;

                }
            } //Months with only 30 days
            else if (mon == 4 || mon == 6 || mon == 9 || mon == 11)
            {
                switch (wday)
                {
                    case 0:
                        date31.Text = "";
                        tb31.ReadOnly = true;
                        break;

                    case 1:
                        date32.Text = "";
                        tb32.ReadOnly = true;
                        break;

                    case 2:
                        date33.Text = "";
                        tb33.ReadOnly = true;
                        break;

                    case 3:
                        date34.Text = "";
                        tb34.ReadOnly = true;
                        break;

                    case 4:
                        date35.Text = "";
                        tb35.ReadOnly = true;
                        break;

                    case 5:
                        date36.Text = "";
                        tb36.ReadOnly = true;
                        break;

                    case 6:
                        date37.Text = "";
                        tb37.ReadOnly = true;
                        break;
                }
            }
        }

        

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearCalendar_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
            tb9.Text = "";
            tb10.Text = "";
            tb11.Text = "";
            tb12.Text = "";
            tb13.Text = "";
            tb14.Text = "";
            tb15.Text = "";
            tb16.Text = "";
            tb17.Text = "";
            tb18.Text = "";
            tb19.Text = "";
            tb20.Text = "";
            tb21.Text = "";
            tb22.Text = "";
            tb23.Text = "";
            tb24.Text = "";
            tb25.Text = "";
            tb26.Text = "";
            tb27.Text = "";
            tb28.Text = "";
            tb29.Text = "";
            tb30.Text = "";
            tb31.Text = "";
            tb32.Text = "";
            tb33.Text = "";
            tb34.Text = "";
            tb35.Text = "";
            tb36.Text = "";
            tb37.Text = "";
        }
    }
}
