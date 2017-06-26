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
    public class Sponsor
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllSponsors(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT SponsorName, Subsidy, KindOfSponsorship FROM Sponsor", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void AverageOfGrants(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            int average;
            try
            {
                sqlConnection.Open();
                string command = "SELECT AVG(Subsidy) AS Srednia FROM Sponsor";
                sqlCommand = new SqlCommand(command, sqlConnection);
                average = (int)sqlCommand.ExecuteScalar();
                label.Text = average.ToString();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch 
            {
                MessageBox.Show("Błąd");
            }
        }

        public static void CountPassiveSponsors(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            int sum;
            try
            {
                sqlConnection.Open();
                string command = "SELECT COUNT(*) FROM Sponsor WHERE KindOfSponsorship = 'pasywny'";
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

        public static void CountActiveSponsors(SqlConnection sqlConnection, DataGridView dataGridView, Label label)
        {
            int sum;
            try
            {
                sqlConnection.Open();
                string command = "SELECT COUNT(*) FROM Sponsor WHERE KindOfSponsorship = 'aktywny'";
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

        public static void SearchSponsorByName(SqlConnection sqlConnection, DataGridView dataGridView, string name)
        {
            sqlDataAdapter = new SqlDataAdapter("SELECT* FROM Sponsor WHERE SponsorName LIKE '" + name + "%'", sqlConnection);
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