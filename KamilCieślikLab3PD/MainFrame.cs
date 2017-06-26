using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public partial class MainFrame : Form
    {
        private readonly SqlConnection _sqlConnection;
        public MainFrame()
        {
            InitializeComponent();
            _sqlConnection = new SqlConnection("Data Source=DESKTOP-2LVCHH1\\SQLEXPRESS; database=KamilCieślikSportClub;Trusted_Connection=yes");
            labelFootball.BackColor = Color.Transparent;
        }

        private void buttonShowAllSponsors_Click(object sender, EventArgs e)
        {
            Sponsor.ShowAllSponsors(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllTrainers_Click(object sender, EventArgs e)
        {
            Coach.ShowAllTrainers(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllAdresses_Click(object sender, EventArgs e)
        {
            Adress.ShowAllAdresses(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllStadiums_Click(object sender, EventArgs e)
        {
            Stadium.ShowAllStadiums(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllClubs_Click(object sender, EventArgs e)
        {
            Club.ShowAllClubs(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllFootballers_Click(object sender, EventArgs e)
        {
            Footballer.ShowAllFootballers(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllCards_Click(object sender, EventArgs e)
        {
            Cards.ShowAllCards(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllGoals_Click(object sender, EventArgs e)
        {
            Goals.ShowAllGoals(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllSuspensions_Click(object sender, EventArgs e)
        {
            Suspension.ShowAllSuspensions(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllStatistics_Click(object sender, EventArgs e)
        {
            Statistics.ShowAllStatistics(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSumScoredGoals_Click(object sender, EventArgs e)
        {
            Goals.SumScoredGoals(_sqlConnection, dataGridViewFootballStatistics, labelScoredGoals);
        }

        private void buttonSumLostGoals_Click(object sender, EventArgs e)
        {
            Goals.SumLostGoals(_sqlConnection, dataGridViewFootballStatistics, labelLostGoals);
        }

        private void buttonSumRedCards_Click(object sender, EventArgs e)
        {
            Cards.SumRedCards(_sqlConnection, dataGridViewFootballStatistics, labelRedCards);
        }

        private void buttonSumYellowCards_Click(object sender, EventArgs e)
        {
            Cards.SumYellowCards(_sqlConnection, dataGridViewFootballStatistics, labelYellowCards);
        }

        private void buttonCalculateDonateAvarage_Click(object sender, EventArgs e)
        {
            Sponsor.AverageOfGrants(_sqlConnection, dataGridViewFootballStatistics, labelAverageOfGrants);
        }

        private void buttonCountPassiveSponsors_Click(object sender, EventArgs e)
        {
            Sponsor.CountPassiveSponsors(_sqlConnection, dataGridViewFootballStatistics, labelSumOfPassiveSponsors);
        }

        private void buttonCountActiveSponsors_Click(object sender, EventArgs e)
        {
            Sponsor.CountActiveSponsors(_sqlConnection, dataGridViewFootballStatistics, labelSumOfActiveSponsors);
        }

        private void buttonSearchSponsorByName_Click(object sender, EventArgs e)
        {
            Sponsor.SearchSponsorByName(_sqlConnection, dataGridViewFootballStatistics, textBoxSponsorName.Text);
        }

        private void buttonSearchByCapacity_Click(object sender, EventArgs e)
        {
            Stadium.SearchByCapacity(_sqlConnection, dataGridViewFootballStatistics, textBoxStadiumFrom.Text, textBoxStadiumTo.Text);
        }

        private void buttonShowWithSurface_Click(object sender, EventArgs e)
        {
            Stadium.ShowStadiumsWithSelectedSurface(_sqlConnection, dataGridViewFootballStatistics, comboBoxSurface.Text);
        }

        private void buttonSortBy_Click(object sender, EventArgs e)
        {
            Stadium.SortBy(_sqlConnection, dataGridViewFootballStatistics, comboBoxSortBy.Text);
        }

        private void buttonAddFootballer_Click(object sender, EventArgs e)
        {
            Footballer.AddFootballer(_sqlConnection, dataGridViewFootballStatistics, textBoxFootballerName.Text, textBoxFootballerSurname.Text, textBoxFootballerNationality.Text, comboBoxFootballerBetterLeg.Text, textBoxFootballerAge.Text);
        }

        private void buttonDeledeSelected_Click(object sender, EventArgs e)
        {
            Footballer.DeleteFootballer(_sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonEditFootballer_Click(object sender, EventArgs e)
        {
            Footballer.EditFootballer(_sqlConnection, dataGridViewFootballStatistics, textBoxFootballerName.Text, textBoxFootballerSurname.Text, textBoxFootballerNationality.Text, comboBoxFootballerBetterLeg.Text, textBoxFootballerAge.Text);
        }
    }
}
