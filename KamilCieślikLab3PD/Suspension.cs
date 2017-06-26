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
    public class Suspension
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllSuspensions(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT Footballer.Name, Footballer.Surname, Footballer.Nationality, Footballer.Age, StartDate, EndDate FROM Suspension JOIN Footballer ON IDFootballer=Footballer.ID", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
