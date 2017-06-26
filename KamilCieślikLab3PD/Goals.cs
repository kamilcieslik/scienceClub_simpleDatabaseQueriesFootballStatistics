using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Goals
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllGoals(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT GoalsScored, LostGoals FROM Goals", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void SumScoredGoals(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            int sum;
            try
            {
                sqlConnection.Open();
                string command = "SELECT SUM(GoalsScored) AS Suma FROM Goals";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sum = (int)sqlCommand.ExecuteScalar();
                label.Text = sum.ToString();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }

        public static void SumLostGoals(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            int sum;
            try
            {
                sqlConnection.Open();
                string command = "SELECT SUM(LostGoals) AS Suma FROM Goals";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sum = (int)sqlCommand.ExecuteScalar();
                label.Text = sum.ToString();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }

        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}