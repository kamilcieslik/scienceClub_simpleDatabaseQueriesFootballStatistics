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
    public class Adress
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllAdresses(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT Country, City, ZipCode, Street, AdressNumber FROM Adress", sqlConnection);
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
