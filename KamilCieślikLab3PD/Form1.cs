using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamilCieślikLab3PD
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=DESKTOP-2LVCHH1\\SQLEXPRESS; database=KamilCieślikSportClub;Trusted_Connection=yes");
            labelFootball.BackColor = Color.Transparent;
        }

        private void buttonShowAllSponsors_Click(object sender, EventArgs e)
        {
            Sponsor.ShowAllSponsors(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllTrainers_Click(object sender, EventArgs e)
        {
            Coach.ShowAllTrainers(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllAdresses_Click(object sender, EventArgs e)
        {
            Adress.ShowAllAdresses(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllStadiums_Click(object sender, EventArgs e)
        {
            Stadium.ShowAllStadiums(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllClubs_Click(object sender, EventArgs e)
        {
            Club.ShowAllClubs(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllFootballers_Click(object sender, EventArgs e)
        {
            Footballer.ShowAllFootballers(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllCards_Click(object sender, EventArgs e)
        {
            Cards.ShowAllCards(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllGoals_Click(object sender, EventArgs e)
        {
            Goals.ShowAllGoals(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllSuspensions_Click(object sender, EventArgs e)
        {
            Suspension.ShowAllSuspensions(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonShowAllStatistics_Click(object sender, EventArgs e)
        {
            Statistics.ShowAllStatistics(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSumScoredGoals_Click(object sender, EventArgs e)
        {
            Goals.SumScoredGoals(sqlConnection, dataGridViewFootballStatistics, labelScoredGoals);
        }

        private void buttonSumLostGoals_Click(object sender, EventArgs e)
        {
            Goals.SumLostGoals(sqlConnection, dataGridViewFootballStatistics, labelLostGoals);
        }

        private void buttonSumRedCards_Click(object sender, EventArgs e)
        {
            Cards.SumRedCards(sqlConnection, dataGridViewFootballStatistics, labelRedCards);
        }

        private void buttonSumYellowCards_Click(object sender, EventArgs e)
        {
            Cards.SumYellowCards(sqlConnection, dataGridViewFootballStatistics, labelYellowCards);
        }

        private void buttonCalculateDonateAvarage_Click(object sender, EventArgs e)
        {
            Sponsor.AverageOfGrants(sqlConnection, dataGridViewFootballStatistics, labelAverageOfGrants);
        }

        private void buttonCountPassiveSponsors_Click(object sender, EventArgs e)
        {
            Sponsor.CountPassiveSponsors(sqlConnection, dataGridViewFootballStatistics, labelSumOfPassiveSponsors);
        }

        private void buttonCountActiveSponsors_Click(object sender, EventArgs e)
        {
            Sponsor.CountActiveSponsors(sqlConnection, dataGridViewFootballStatistics, labelSumOfActiveSponsors);
        }

        private void buttonSearchSponsorByName_Click(object sender, EventArgs e)
        {
            Sponsor.SearchSponsorByName(sqlConnection, dataGridViewFootballStatistics, textBoxSponsorName.Text);
        }

        private void buttonSearchByCapacity_Click(object sender, EventArgs e)
        {
            Stadium.SearchByCapacity(sqlConnection, dataGridViewFootballStatistics, textBoxStadiumFrom.Text, textBoxStadiumTo.Text);
        }

        private void buttonShowWithSurface_Click(object sender, EventArgs e)
        {
            Stadium.ShowStadiumsWithSelectedSurface(sqlConnection, dataGridViewFootballStatistics, comboBoxSurface.Text);
        }

        private void buttonSortBy_Click(object sender, EventArgs e)
        {
            Stadium.SortBy(sqlConnection, dataGridViewFootballStatistics, comboBoxSortBy.Text);
        }

        private void buttonAddFootballer_Click(object sender, EventArgs e)
        {
            Footballer.AddFootballer(sqlConnection, dataGridViewFootballStatistics, textBoxFootballerName.Text, textBoxFootballerSurname.Text, textBoxFootballerNationality.Text, comboBoxFootballerBetterLeg.Text, textBoxFootballerAge.Text);
        }

        private void buttonDeledeSelected_Click(object sender, EventArgs e)
        {
            Footballer.DeleteFootballer(sqlConnection, dataGridViewFootballStatistics);
        }

        private void buttonEditFootballer_Click(object sender, EventArgs e)
        {
            Footballer.EditFootballer(sqlConnection, dataGridViewFootballStatistics, textBoxFootballerName.Text, textBoxFootballerSurname.Text, textBoxFootballerNationality.Text, comboBoxFootballerBetterLeg.Text, textBoxFootballerAge.Text);
        }
    }
}
