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
    public class Club
    {
        static SqlCommand sqlCommand = new SqlCommand();
        private static SqlDataAdapter sqlDataAdapter;

        public static void ShowAllClubs(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            sqlDataAdapter = new SqlDataAdapter("SELECT Stadium.StadiumName, [KamilCieślikSportClub].[dbo].[Statistics].Points, Goals.GoalsScored, Goals.LostGoals, Cards.RedCards, Cards.YellowCards, Coach.CoachName, Coach.CoachSurname, Sponsor.SponsorName FROM Club JOIN Stadium ON IDStadium=Stadium.ID JOIN [KamilCieślikSportClub].[dbo].[Statistics] ON IDStatistics=[KamilCieślikSportClub].[dbo].[Statistics].ID JOIN Goals ON IDGoals=Goals.ID JOIN Cards ON IDCards=Cards.ID JOIN Coach ON IDCoach=Coach.ID JOIN Sponsor ON IDSponsor=Sponsor.ID", sqlConnection);
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
