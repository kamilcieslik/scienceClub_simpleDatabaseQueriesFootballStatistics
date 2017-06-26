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
    public class Footballer
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllFootballers(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT Name, Surname, Nationality, BetterLeg, Age FROM Footballer", sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void AddFootballer(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname, string nationality, string betterLeg, string age)
        {
            if ((name == "") || (surname == "") || (nationality == "") || (betterLeg == "") || (age == ""))
            {
                MessageBox.Show("Aby dodać piłkarza w pierwszej kolejności uzupełnij wszystkie pola!");
            }
            else
            {
                try
                {
                    int intAge = int.Parse(age);
                    sqlConnection.Open();
                    string command = $"INSERT INTO Footballer (Name, Surname, Nationality, BetterLeg, Age) VALUES ('{name}', '{surname}', '{nationality}', '{betterLeg}', '{intAge}')";
                    sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Dodano");
                    ShowAllFootballers(sqlConnection, dataGridView);
                    sqlConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Błąd");
                }
            }
        }

        public static void EditFootballer(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname, string nationality, string betterLeg, string age)
        {
            if ((name == "") || (surname == "") || (nationality == "") || (betterLeg == "") || (age == ""))
            {
                MessageBox.Show("Aby edytować piłkarza w pierwszej kolejności musisz wypełnić wszystkie pola!");
            }
            else
            {
                try
                {
                    string previousName;
                    string previousSurname;
                    string previousNationality;
                    string previousBetterLeg;
                    int previousAge;
                    if (dataGridView.SelectedRows.Count > 0)
                    {
                        previousName = dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                        previousSurname = dataGridView.SelectedRows[0].Cells["Surname"].Value.ToString();
                        previousNationality = dataGridView.SelectedRows[0].Cells["Nationality"].Value.ToString();
                        previousBetterLeg= dataGridView.SelectedRows[0].Cells["BetterLeg"].Value.ToString();
                        previousAge = int.Parse(dataGridView.SelectedRows[0].Cells["Age"].Value.ToString());
                        sqlConnection.Open();
                        string command = $"UPDATE Footballer SET Name = '{name}', Surname = '{surname}', Nationality = '{nationality}', BetterLeg = '{betterLeg}', Age = '{age}'  WHERE Name = '{previousName}' AND Surname = '{previousSurname}' AND Nationality = '{previousNationality}' AND BetterLeg = '{previousBetterLeg}' AND Age = '{previousAge}'";
                        sqlCommand = new SqlCommand(command, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Zaktualizowano dane.");
                        ShowAllFootballers(sqlConnection, dataGridView);
                        sqlConnection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nie wykryto zaznaczenia!");
                    }
                }
                catch
                {
                    MessageBox.Show("Błąd");
                }
            }
        }

        public static void DeleteFootballer(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            try
            {
                string name;
                string surname;
                string nationality;
                string betterLeg;
                int age;
                if (dataGridView.SelectedRows.Count > 0)
                {
                    name = dataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                    surname = dataGridView.SelectedRows[0].Cells["Surname"].Value.ToString();
                    nationality = dataGridView.SelectedRows[0].Cells["Nationality"].Value.ToString();
                    betterLeg = dataGridView.SelectedRows[0].Cells["BetterLeg"].Value.ToString();
                    age = int.Parse(dataGridView.SelectedRows[0].Cells["Age"].Value.ToString());
                    sqlConnection.Open();
                    string command = $"DELETE FROM Footballer WHERE Name = '{name}' AND Surname = '{surname}' AND Nationality = '{nationality}' AND BetterLeg = '{betterLeg}' AND Age = '{age}'";
                    sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    ShowAllFootballers(sqlConnection, dataGridView);
                    sqlConnection.Close();
                    MessageBox.Show("Usunięto zaznaczoną pozycję.");
                }
                else
                {
                    MessageBox.Show("Nie wykryto zaznaczenia!");
                }
               
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
