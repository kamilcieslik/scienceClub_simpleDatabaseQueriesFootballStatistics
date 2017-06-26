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
    public class Statistics
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllStatistics(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT Points, Goals.GoalsScored, Goals.LostGoals, Cards.RedCards, Cards.YellowCards FROM [KamilCieślikSportClub].[dbo].[Statistics] JOIN Goals ON IDGoals=Goals.ID JOIN Cards ON IDCards=Cards.ID", sqlConnection);
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
