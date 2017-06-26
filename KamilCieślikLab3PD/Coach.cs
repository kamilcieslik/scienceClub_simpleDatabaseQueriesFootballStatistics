using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Coach
    {
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllTrainers(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT CoachName, CoachSurname, Nationality, YearsOfExperience FROM Coach", sqlConnection);
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
