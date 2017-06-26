using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public class Club
    {
        private static SqlDataAdapter _sqlDataAdapter;

        public static void ShowAllClubs(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            _sqlDataAdapter = new SqlDataAdapter("SELECT Stadium.StadiumName, [KamilCieślikSportClub].[dbo].[Statistics].Points, Goals.GoalsScored, Goals.LostGoals, Cards.RedCards, Cards.YellowCards, Coach.CoachName, Coach.CoachSurname, Sponsor.SponsorName FROM Club JOIN Stadium ON IDStadium=Stadium.ID JOIN [KamilCieślikSportClub].[dbo].[Statistics] ON IDStatistics=[KamilCieślikSportClub].[dbo].[Statistics].ID JOIN Goals ON IDGoals=Goals.ID JOIN Cards ON IDCards=Cards.ID JOIN Coach ON IDCoach=Coach.ID JOIN Sponsor ON IDSponsor=Sponsor.ID", sqlConnection);
            FillDataGridView(_sqlDataAdapter, dataGridView);
        }

        private static void FillDataGridView(DbDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
