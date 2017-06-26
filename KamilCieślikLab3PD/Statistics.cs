using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Statistics
    {
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllStatistics(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT Points, Goals.GoalsScored, Goals.LostGoals, Cards.RedCards, Cards.YellowCards FROM [KamilCieślikSportClub].[dbo].[Statistics] JOIN Goals ON IDGoals=Goals.ID JOIN Cards ON IDCards=Cards.ID", sqlConnection);
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
