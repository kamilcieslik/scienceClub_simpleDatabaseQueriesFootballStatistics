using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Cards
    {
        private static SqlCommand _sqlCommand = new SqlCommand();
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllCards(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT RedCards, YellowCards FROM Cards", sqlConnection);
            FillDataGridView(_sqlDataAdapter, dataGridView);
        }

        public static void SumRedCards(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            try
            {
                sqlConnection.Open();
                const string command = "SELECT SUM(RedCards) AS Suma FROM Cards";
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

        public static void SumYellowCards(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            try
            {
                sqlConnection.Open();
                const string command = "SELECT SUM(YellowCards) AS Suma FROM Cards";
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
