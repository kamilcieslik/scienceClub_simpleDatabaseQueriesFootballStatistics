using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Goals
    {
        private static SqlCommand _sqlCommand = new SqlCommand();
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllGoals(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT GoalsScored, LostGoals FROM Goals", sqlConnection);
            FillDataGridView(_sqlDataAdapter, dataGridView);
        }

        public static void SumScoredGoals(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            try
            {
                sqlConnection.Open();
                const string command = "SELECT SUM(GoalsScored) AS Suma FROM Goals";
                _sqlCommand = new SqlCommand(command, sqlConnection);
                var sum = (int)_sqlCommand.ExecuteScalar();
                label.Text = sum.ToString();
                _sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show(@"Błąd");
            }
        }

        public static void SumLostGoals(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            try
            {
                sqlConnection.Open();
                const string command = "SELECT SUM(LostGoals) AS Suma FROM Goals";
                _sqlCommand = new SqlCommand(command, sqlConnection);
                var sum = (int)_sqlCommand.ExecuteScalar();
                label.Text = sum.ToString();
                _sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show(@"Błąd");
            }
        }

        private static void FillDataGridView(DbDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}