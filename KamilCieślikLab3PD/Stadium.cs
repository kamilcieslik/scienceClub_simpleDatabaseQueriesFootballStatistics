using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Stadium
    {
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllStadiums(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT StadiumName, Surface, Capacity, Adress.Country, Adress.City, Adress.Street, Adress.AdressNumber FROM Stadium JOIN Adress ON IDAdress=Adress.ID", sqlConnection);
            FillDataGridView(_sqlDataAdapter, dataGridView);
        }

        public static void SearchByCapacity(SqlConnection sqlConnection, DataGridView dataGridView, string from, string to)
        {
            if ((from == "") || (to == ""))
            {
                MessageBox.Show(@"Aby rozpocząć przeszukiwanie uzupełnij pola: OD, DO!");
            }
            else
            {
                _sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Stadium WHERE Capacity Between " + from + " AND " + to, sqlConnection);
                FillDataGridView(_sqlDataAdapter, dataGridView);
            }
        }

        public static void ShowStadiumsWithSelectedSurface(SqlConnection sqlConnection, DataGridView dataGridView, string selectedText)
        {
            if (selectedText == "")
            {
                MessageBox.Show(@"Aby wyświetlić stadiony z daną nawierzchnią w pierwszej kolejności musisz jakąś wybrać!");
            }
            else
            {
                dataGridView.DataSource = null;
                _sqlDataAdapter = new SqlDataAdapter($"SELECT StadiumName, Surface, Capacity, Adress.Country, Adress.City, Adress.Street, Adress.AdressNumber FROM Stadium JOIN Adress ON IDAdress=Adress.ID WHERE Surface LIKE '{selectedText}'", sqlConnection);
                FillDataGridView(_sqlDataAdapter, dataGridView);
            }
        }

        public static void SortBy(SqlConnection sqlConnection, DataGridView dataGridView, string selectedText)
        {
            if (selectedText == "")
            {
                MessageBox.Show(@"Aby wyświetlić posortowane stadiony w pierwszej kolejności musisz wybrać kryterium sortowania!");
            }
            else
            {
                _sqlDataAdapter = new SqlDataAdapter("SELECT StadiumName, Surface, Capacity, Adress.Country, Adress.City, Adress.Street, Adress.AdressNumber FROM Stadium JOIN Adress ON IDAdress=Adress.ID ORDER BY " + selectedText, sqlConnection);
                FillDataGridView(_sqlDataAdapter, dataGridView);
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
