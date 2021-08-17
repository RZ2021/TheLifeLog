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
    public partial class Bills : Form
    {
        string newValue, oldValue, sqlUpdate;
        int userId;
        public Bills(int user)
        {
            InitializeComponent();

            userId = user;
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            tableRefresh();

        }

        private void tableRefresh()
        {
            string conn = @"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True;";
            string sql = "SELECT * FROM Bills WHERE UserId = @id";
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(ds, "Bills");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Bills";
            dataGridView1.Columns["UserId"].Visible = false;
        }

        private void billTB_Click(object sender, EventArgs e)
        {
            billTB.Text = "";
        }

        private void amountTB_Click(object sender, EventArgs e)
        {
            amountTB.Text = "";

        }

        private void formTB_Click(object sender, EventArgs e)
        {
            formTB.Text = "";
        }

        private void dateTB_Click(object sender, EventArgs e)
        {
            dateTB.Text = "";
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            Budget bd = new Budget(1);
            bd.Show();
            this.Close();
        }

        private void SavingsButton_Click(object sender, EventArgs e)
        {
            Savings ss = new Savings();
            ss.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PastSpending ps = new PastSpending();
            ps.Show();
            this.Close();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Bills (Bill, Amount, PayForm, DueDate, UserId) VALUES ((@appt), (@appt2), (@appt3), (@appt4), (@id))";
            string txt = amountTB.Text;
            removeSpace(txt);
            bool numVerify = isDigits(txt);
            if (numVerify)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True;");

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@appt", SqlDbType.VarChar).Value = billTB.Text;
                cmd.Parameters.Add("@appt2", SqlDbType.Float).Value = float.Parse(amountTB.Text);
                cmd.Parameters.Add("@appt3", SqlDbType.VarChar).Value = formTB.Text;
                cmd.Parameters.Add("@appt4", SqlDbType.VarChar).Value = dateTB.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Your bills have been saved!");

                tableRefresh();
            }
            else
            {
                MessageBox.Show("Please enter numbers only for the amount");
            }

            tableRefresh();
            billTB.Text = "Enter bill:";
            amountTB.Text = "Enter amount:";
            formTB.Text = "Enter form:";
            dateTB.Text = "Enter due date:";

        }

        bool isDigits(string s)
        {
            bool isDig = double.TryParse(s, out _);
            return isDig;
        }

        string removeSpace(string str)
        {
            str = str.Replace(" ", String.Empty);
            str = str.Replace(".", String.Empty);
            return str;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oldValue = (dataGridView1[e.ColumnIndex, e.RowIndex].Value).ToString();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Bills WHERE Bill = @ov";
            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ov", SqlDbType.VarChar).Value = oldValue;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Your bill has been deleted");
            tableRefresh();

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            newValue = (dataGridView1[e.ColumnIndex, e.RowIndex].Value).ToString();
            
            SqlConnection conn = new SqlConnection(@"Data Source=MASTERBLASTER\SQLEXPRESS;Initial Catalog=TheLifeLog;Integrated Security=True;");
            conn.Open();


            if(e.ColumnIndex == 0)
            {
                sqlUpdate = "UPDATE Bills SET Bill = @nv WHERE Bill = @ov";

            }
            else if(e.ColumnIndex == 1)
            {
                sqlUpdate = "UPDATE Bills SET Amount = @nv WHERE Amount = @ov";
                
            }
            else if(e.ColumnIndex == 2)
            {
                sqlUpdate = "UPDATE Bills SET PayForm = @nv WHERE PayForm = @ov";

            }
            else if(e.ColumnIndex == 3)
            {
                sqlUpdate = "UPDATE Bills SET DueDate = @nv WHERE DueDate = @ov";

            }

            if (e.ColumnIndex == 1)
            {
                
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.Parameters.Add("@nv", SqlDbType.Float).Value = float.Parse(newValue);
                cmd.Parameters.Add("@ov", SqlDbType.Float).Value = float.Parse(oldValue);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.Parameters.Add("@nv", SqlDbType.VarChar).Value = newValue;
                cmd.Parameters.Add("@ov", SqlDbType.VarChar).Value = oldValue;
                cmd.ExecuteNonQuery();
            }

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = (dataGridView1[e.ColumnIndex, e.RowIndex].Value).ToString();
            
        }
    }
}
