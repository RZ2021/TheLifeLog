using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TheLifeLog
{
    class DataConnect
    {

        public string ReadCalendar(int id, int option)
        {
            string temp, mon, year;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Dates, Month, Year FROM MonthlyCalendar WHERE UserId = @id"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        temp = sdr["Dates"].ToString();
                        mon = sdr["Month"].ToString();
                        year = sdr["Year"].ToString();
                    }
                    con.Close();
                }
            }
            if(option == 1)
            {
                return temp;
            }
            else if(option == 2)
            {
                return mon;
            }
            else
            {
                return year;
            }
        }

        public int WriteCalendar(int id, string dates, int month, int year)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True");
            string sql = "UPDATE MonthlyCalendar SET Dates = (@appt), Month = (@mon), Year = (@year) WHERE UserId = (@id)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@appt", SqlDbType.NVarChar).Value = dates;
            cmd.Parameters.Add("@mon", SqlDbType.Int).Value = month;
            cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
            int updated = cmd.ExecuteNonQuery();
            conn.Close();
            return updated;
        }

        public string ReadTodo(int id, int ln, int option)
        {
            string temp, check;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ToDo, Checked FROM ToDo WHERE UserId = @id AND ListNum = @ln"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@ln", SqlDbType.Int).Value = ln;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        temp = sdr["ToDo"].ToString();
                        check = sdr["Checked"].ToString();
                    }
                    con.Close();
                }
            }
            if (option == 1)
            {
                return temp;
            }
            else
            {
                return check;
            }
        }

        public int WriteTodo(int id, string td, string check, int listNum)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True");
            string sql = "UPDATE ToDo SET ToDo = (@td), Checked = (@checks) WHERE UserId = (@id) AND ListNum = (@LN)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@td", SqlDbType.NVarChar).Value = td;
            cmd.Parameters.Add("@checks", SqlDbType.NVarChar).Value = check;
            cmd.Parameters.Add("@LN", SqlDbType.Int).Value = listNum;
            int updated = cmd.ExecuteNonQuery();
            conn.Close();
            return updated;
        }

        public string ReadBudget(int id, int option)
        {
            string ex, nums, income, total;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Expenses, UserNums, Income, Total FROM Budget WHERE UserId = @id"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        ex = sdr["Expenses"].ToString();
                        nums = sdr["UserNums"].ToString();
                        income = sdr["Income"].ToString();
                        total = sdr["Total"].ToString();

                    }
                    con.Close();
                }
            }
            if (option == 1)
            {
                return ex;
            }
            else if (option == 2)
            {
                return nums;
            }
            else if (option == 3)
            {
                return income;
            }
            else
            {
                return total;
            }
        }

        public int WriteBudget(int id, string ex, string bud, string income)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True");
            string sql = "UPDATE Budget SET Expenses = (@exs), UserNums = (@budget), Income = (@inc) WHERE UserId = (@id)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@exs", SqlDbType.NVarChar).Value = ex;
            cmd.Parameters.Add("@budget", SqlDbType.NVarChar).Value = bud;
            cmd.Parameters.Add("@inc", SqlDbType.NVarChar).Value = income;
            int updated = cmd.ExecuteNonQuery();
            conn.Close();
            return updated;
        }

        public string ReadSavings(int id, int option)
        {
            string goal, names, current;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Goals, Names, CurrentTotal FROM Savings WHERE UserId = @id"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        goal = sdr["Goals"].ToString();
                        names = sdr["Names"].ToString();
                        current = sdr["CurrentTotal"].ToString();
                    }
                    con.Close();
                }
            }
            if (option == 1)
            {
                return goal;
            }
            else if (option == 2)
            {
                return names;
            }
            else
            {
                return current;
            }
        }
        public int WriteSavings(int id, string current)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True");
            string sql = "UPDATE Savings SET CurrentTotal = (@cur) WHERE UserId = (@id)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@cur", SqlDbType.NVarChar).Value = current;
            int updated = cmd.ExecuteNonQuery();
            conn.Close();
            return updated;
        }

        public int WriteSavings(int id, string names, string goals, string current)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True");
            string sql = "UPDATE Savings SET Goals = (@goal), Names = (@name), CurrentTotal = (@cur) WHERE UserId = (@id)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@goal", SqlDbType.NVarChar).Value = goals;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = names;
            cmd.Parameters.Add("@cur", SqlDbType.NVarChar).Value = current;
            int updated = cmd.ExecuteNonQuery();
            conn.Close();
            return updated;
        }

        public string ReadShop(int id, int option)
        {
            string list, check, names;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ListOne, Checked, ListNames FROM ShoppingList WHERE UserId = @id"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        list = sdr["ListOne"].ToString();
                        check = sdr["Checked"].ToString();
                        names = sdr["ListNames"].ToString();

                    }
                    con.Close();
                }
            }
            if (option == 1)
            {
                return list;
            }
            else if (option == 2)
            {
                return check;
            }
            else
            {
                return names;
            }
        }

        public int WriteShop(int id, string items, string check)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True");
            string sql = "UPDATE ShoppingList SET ListOne = (@lo), Checked = (@checks) WHERE UserId = (@id)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@lo", SqlDbType.NVarChar).Value = items;
            cmd.Parameters.Add("@checks", SqlDbType.NVarChar).Value = check;
            int updated = cmd.ExecuteNonQuery();
            conn.Close();
            return updated;
        }


        public string ReadMeal(int id)
        {
            string meal;
            string constr = @"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Meals FROM MealPlan WHERE UserId = @id"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        meal = sdr["Meals"].ToString();
                    }
                    con.Close();
                }
            }
            return meal;
        }

        public int WriteMeal(int id, string meals)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MasterBlaster\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True");
            string sql = "UPDATE MealPlan SET Meals = @meal WHERE UserId = (@id)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@meal", SqlDbType.NVarChar).Value = meals;
            int updated = cmd.ExecuteNonQuery();
            conn.Close();
            return updated;
        }
    }
}
