using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Suspension
    {
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllSuspensions(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT Footballer.Name, Footballer.Surname, Footballer.Nationality, Footballer.Age, StartDate, EndDate FROM Suspension JOIN Footballer ON IDFootballer=Footballer.ID", sqlConnection);
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
