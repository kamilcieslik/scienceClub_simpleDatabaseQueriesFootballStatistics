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
    public class Stadium
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllStadiums(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT StadiumName, Surface, Capacity, Adress.Country, Adress.City, Adress.Street, Adress.AdressNumber FROM Stadium JOIN Adress ON IDAdress=Adress.ID", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void SearchByCapacity(SqlConnection sqlConnection, DataGridView dataGridView, string from, string to)
        {
            if ((from == "") || (to == ""))
            {
                MessageBox.Show("Aby rozpocząć przeszukiwanie uzupełnij pola: OD, DO!");
            }
            else
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Stadium WHERE Capacity Between " + from + " AND " + to, sqlConnection);
                FillDataGridView(sqlDataAdapter, dataGridView);
            }
        }

        public static void ShowStadiumsWithSelectedSurface(SqlConnection sqlConnection, DataGridView dataGridView, string selectedText)
        {
            if (selectedText == "")
            {
                MessageBox.Show("Aby wyświetlić stadiony z daną nawierzchnią w pierwszej kolejności musisz jakąś wybrać!");
            }
            else
            {
                dataGridView.DataSource = null;
                sqlDataAdapter = new SqlDataAdapter($"SELECT StadiumName, Surface, Capacity, Adress.Country, Adress.City, Adress.Street, Adress.AdressNumber FROM Stadium JOIN Adress ON IDAdress=Adress.ID WHERE Surface LIKE '{selectedText}'", sqlConnection);
                FillDataGridView(sqlDataAdapter, dataGridView);
            }
        }

        public static void SortBy(SqlConnection sqlConnection, DataGridView dataGridView, string selectedText)
        {
            if (selectedText == "")
            {
                MessageBox.Show("Aby wyświetlić posortowane stadiony w pierwszej kolejności musisz wybrać kryterium sortowania!");
            }
            else
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT StadiumName, Surface, Capacity, Adress.Country, Adress.City, Adress.Street, Adress.AdressNumber FROM Stadium JOIN Adress ON IDAdress=Adress.ID ORDER BY " + selectedText, sqlConnection);
                FillDataGridView(sqlDataAdapter, dataGridView);
            }
        }

        private static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
