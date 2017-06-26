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
    public class Cards
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllCards(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT RedCards, YellowCards FROM Cards", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void SumRedCards(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            int sum;
            try
            {
                sqlConnection.Open();
                string command = "SELECT SUM(RedCards) AS Suma FROM Cards";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sum = (int)sqlCommand.ExecuteScalar();
                label.Text = sum.ToString();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
        }

        public static void SumYellowCards(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            int sum;
            try
            {
                sqlConnection.Open();
                string command = "SELECT SUM(YellowCards) AS Suma FROM Cards";
                sqlCommand = new SqlCommand(command, sqlConnection);
                sum = (int)sqlCommand.ExecuteScalar();
                label.Text = sum.ToString();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Błąd");
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
