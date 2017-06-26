using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Sponsor
    {
        private static SqlCommand _sqlCommand = new SqlCommand();
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllSponsors(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT SponsorName, Subsidy, KindOfSponsorship FROM Sponsor", sqlConnection);
            FillDataGridView(_sqlDataAdapter, dataGridView);
        }

        public static void AverageOfGrants(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            try
            {
                sqlConnection.Open();
                const string command = "SELECT AVG(Subsidy) AS Srednia FROM Sponsor";
                _sqlCommand = new SqlCommand(command, sqlConnection);
                var average = (int)_sqlCommand.ExecuteScalar();
                label.Text = average.ToString();
                _sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show(@"Błąd");
            }
        }

        public static void CountPassiveSponsors(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            try
            {
                sqlConnection.Open();
                const string command = "SELECT COUNT(*) FROM Sponsor WHERE KindOfSponsorship = 'pasywny'";
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

        public static void CountActiveSponsors(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            try
            {
                sqlConnection.Open();
                const string command = "SELECT COUNT(*) FROM Sponsor WHERE KindOfSponsorship = 'aktywny'";
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

        public static void SearchSponsorByName(SqlConnection sqlConnection, DataGridView dataGridView, string name)
        {
            _sqlDataAdapter = new SqlDataAdapter("SELECT* FROM Sponsor WHERE SponsorName LIKE '" + name + "%'", sqlConnection);
            FillDataGridView(_sqlDataAdapter, dataGridView);
        }

        private static void FillDataGridView(DbDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}