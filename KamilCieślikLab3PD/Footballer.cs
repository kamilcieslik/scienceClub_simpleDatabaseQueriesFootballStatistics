using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Footballer
    {
        private static SqlCommand _sqlCommand = new SqlCommand();
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllFootballers(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT Name, Surname, Nationality, BetterLeg, Age FROM Footballer", sqlConnection);
            FillDataGridView(_sqlDataAdapter, dataGridView);
        }

        public static void AddFootballer(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname, string nationality, string betterLeg, string age)
        {
            if ((name == "") || (surname == "") || (nationality == "") || (betterLeg == "") || (age == ""))
            {
                MessageBox.Show(@"Aby dodać piłkarza w pierwszej kolejności uzupełnij wszystkie pola!");
            }
            else
            {
                try
                {
                    var intAge = int.Parse(age);
                    sqlConnection.Open();
                    string command = $"INSERT INTO Footballer (Name, Surname, Nationality, BetterLeg, Age) VALUES ('{name}', '{surname}', '{nationality}', '{betterLeg}', '{intAge}')";
                    _sqlCommand = new SqlCommand(command, sqlConnection);
                    _sqlCommand.ExecuteNonQuery();
                    MessageBox.Show(@"Dodano");
                    ShowAllFootballers(sqlConnection, dataGridView);
                    sqlConnection.Close();
                }
                catch
                {
                    MessageBox.Show(@"Błąd");
                }
            }
        }

        public static void EditFootballer(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname, string nationality, string betterLeg, string age)
        {
            if ((name == "") || (surname == "") || (nationality == "") || (betterLeg == "") || (age == ""))
            {
                MessageBox.Show(@"Aby edytować piłkarza w pierwszej kolejności musisz wypełnić wszystkie pola!");
            }
            else
            {
                try
                {
                    if (dataGridView.SelectedRows.Count > 0)
                    {
                        var previousName = dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                        var previousSurname = dataGridView.SelectedRows[0].Cells["Surname"].Value.ToString();
                        var previousNationality = dataGridView.SelectedRows[0].Cells["Nationality"].Value.ToString();
                        var previousBetterLeg = dataGridView.SelectedRows[0].Cells["BetterLeg"].Value.ToString();
                        var previousAge = int.Parse(dataGridView.SelectedRows[0].Cells["Age"].Value.ToString());
                        sqlConnection.Open();
                        string command = $"UPDATE Footballer SET Name = '{name}', Surname = '{surname}', Nationality = '{nationality}', BetterLeg = '{betterLeg}', Age = '{age}'  WHERE Name = '{previousName}' AND Surname = '{previousSurname}' AND Nationality = '{previousNationality}' AND BetterLeg = '{previousBetterLeg}' AND Age = '{previousAge}'";
                        _sqlCommand = new SqlCommand(command, sqlConnection);
                        _sqlCommand.ExecuteNonQuery();
                        MessageBox.Show(@"Zaktualizowano dane.");
                        ShowAllFootballers(sqlConnection, dataGridView);
                        sqlConnection.Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Nie wykryto zaznaczenia!");
                    }
                }
                catch
                {
                    MessageBox.Show(@"Błąd");
                }
            }
        }

        public static void DeleteFootballer(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    var name = dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                    var surname = dataGridView.SelectedRows[0].Cells["Surname"].Value.ToString();
                    var nationality = dataGridView.SelectedRows[0].Cells["Nationality"].Value.ToString();
                    var betterLeg = dataGridView.SelectedRows[0].Cells["BetterLeg"].Value.ToString();
                    var age = int.Parse(dataGridView.SelectedRows[0].Cells["Age"].Value.ToString());
                    sqlConnection.Open();
                    string command = $"DELETE FROM Footballer WHERE Name = '{name}' AND Surname = '{surname}' AND Nationality = '{nationality}' AND BetterLeg = '{betterLeg}' AND Age = '{age}'";
                    _sqlCommand = new SqlCommand(command, sqlConnection);
                    _sqlCommand.ExecuteNonQuery();
                    ShowAllFootballers(sqlConnection, dataGridView);
                    sqlConnection.Close();
                    MessageBox.Show(@"Usunięto zaznaczoną pozycję.");
                }
                else
                {
                    MessageBox.Show(@"Nie wykryto zaznaczenia!");
                }
            }
            catch
            {
                MessageBox.Show(@"Błąd");
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
