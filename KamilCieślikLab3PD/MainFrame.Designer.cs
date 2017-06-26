namespace KamilCieślikLab3PD
{
    partial class MainFrame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.dataGridViewFootballStatistics = new System.Windows.Forms.DataGridView();
            this.labelFootball = new System.Windows.Forms.Label();
            this.buttonShowAllFootballers = new System.Windows.Forms.Button();
            this.buttonShowAllSponsors = new System.Windows.Forms.Button();
            this.buttonShowAllTrainers = new System.Windows.Forms.Button();
            this.buttonShowAllAdresses = new System.Windows.Forms.Button();
            this.buttonShowAllCards = new System.Windows.Forms.Button();
            this.buttonShowAllGoals = new System.Windows.Forms.Button();
            this.buttonShowAllSuspensions = new System.Windows.Forms.Button();
            this.buttonShowAllStatistics = new System.Windows.Forms.Button();
            this.buttonShowAllStadiums = new System.Windows.Forms.Button();
            this.buttonShowAllClubs = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxFootballer = new System.Windows.Forms.GroupBox();
            this.labelFootballerBetterLeg = new System.Windows.Forms.Label();
            this.labelFootballerAge = new System.Windows.Forms.Label();
            this.labelFootballerNationality = new System.Windows.Forms.Label();
            this.labelFootballerSurname = new System.Windows.Forms.Label();
            this.labelFootballerName = new System.Windows.Forms.Label();
            this.comboBoxFootballerBetterLeg = new System.Windows.Forms.ComboBox();
            this.textBoxFootballerAge = new System.Windows.Forms.TextBox();
            this.textBoxFootballerNationality = new System.Windows.Forms.TextBox();
            this.textBoxFootballerSurname = new System.Windows.Forms.TextBox();
            this.textBoxFootballerName = new System.Windows.Forms.TextBox();
            this.buttonEditFootballer = new System.Windows.Forms.Button();
            this.buttonDeledeSelected = new System.Windows.Forms.Button();
            this.buttonAddFootballer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelYellowCards = new System.Windows.Forms.Label();
            this.labelRedCards = new System.Windows.Forms.Label();
            this.labelLostGoals = new System.Windows.Forms.Label();
            this.labelScoredGoals = new System.Windows.Forms.Label();
            this.buttonSumYellowCards = new System.Windows.Forms.Button();
            this.buttonSumRedCards = new System.Windows.Forms.Button();
            this.buttonSumLostGoals = new System.Windows.Forms.Button();
            this.buttonSumScoredGoals = new System.Windows.Forms.Button();
            this.groupBoxStadiums = new System.Windows.Forms.GroupBox();
            this.labelSurface = new System.Windows.Forms.Label();
            this.comboBoxSurface = new System.Windows.Forms.ComboBox();
            this.buttonShowWithSurface = new System.Windows.Forms.Button();
            this.labelStadiumTo = new System.Windows.Forms.Label();
            this.labelStadiumFrom = new System.Windows.Forms.Label();
            this.buttonSearchByCapacity = new System.Windows.Forms.Button();
            this.textBoxStadiumTo = new System.Windows.Forms.TextBox();
            this.textBoxStadiumFrom = new System.Windows.Forms.TextBox();
            this.labelSearchStadiumFromTo = new System.Windows.Forms.Label();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.buttonSortBy = new System.Windows.Forms.Button();
            this.groupBoxSponsors = new System.Windows.Forms.GroupBox();
            this.labelAverageOfGrants = new System.Windows.Forms.Label();
            this.labelSumOfActiveSponsors = new System.Windows.Forms.Label();
            this.labelSumOfPassiveSponsors = new System.Windows.Forms.Label();
            this.buttonCountPassiveSponsors = new System.Windows.Forms.Button();
            this.labelCountActiveSponsors = new System.Windows.Forms.Label();
            this.textBoxSponsorName = new System.Windows.Forms.TextBox();
            this.labelCountPassiveSponsors = new System.Windows.Forms.Label();
            this.buttonCountActiveSponsors = new System.Windows.Forms.Button();
            this.buttonCalculateDonateAvarage = new System.Windows.Forms.Button();
            this.labelCalculateDonateAvarage = new System.Windows.Forms.Label();
            this.labelSearchSponsorByName = new System.Windows.Forms.Label();
            this.buttonSearchSponsorByName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFootballStatistics)).BeginInit();
            this.groupBoxFootballer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxStadiums.SuspendLayout();
            this.groupBoxSponsors.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFootballStatistics
            // 
            this.dataGridViewFootballStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFootballStatistics.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewFootballStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFootballStatistics.Location = new System.Drawing.Point(137, 148);
            this.dataGridViewFootballStatistics.MultiSelect = false;
            this.dataGridViewFootballStatistics.Name = "dataGridViewFootballStatistics";
            this.dataGridViewFootballStatistics.ReadOnly = true;
            this.dataGridViewFootballStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFootballStatistics.Size = new System.Drawing.Size(1104, 262);
            this.dataGridViewFootballStatistics.TabIndex = 3;
            // 
            // labelFootball
            // 
            this.labelFootball.AutoSize = true;
            this.labelFootball.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelFootball.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFootball.ForeColor = System.Drawing.Color.White;
            this.labelFootball.Location = new System.Drawing.Point(104, 9);
            this.labelFootball.Name = "labelFootball";
            this.labelFootball.Size = new System.Drawing.Size(1180, 114);
            this.labelFootball.TabIndex = 2;
            this.labelFootball.Text = "Statistics in Football";
            // 
            // buttonShowAllFootballers
            // 
            this.buttonShowAllFootballers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllFootballers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllFootballers.Location = new System.Drawing.Point(692, 434);
            this.buttonShowAllFootballers.Name = "buttonShowAllFootballers";
            this.buttonShowAllFootballers.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllFootballers.TabIndex = 5;
            this.buttonShowAllFootballers.Text = "Pokaż wszystkich piłkarzy";
            this.buttonShowAllFootballers.UseVisualStyleBackColor = false;
            this.buttonShowAllFootballers.Click += new System.EventHandler(this.buttonShowAllFootballers_Click);
            // 
            // buttonShowAllSponsors
            // 
            this.buttonShowAllSponsors.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllSponsors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllSponsors.Location = new System.Drawing.Point(137, 434);
            this.buttonShowAllSponsors.Name = "buttonShowAllSponsors";
            this.buttonShowAllSponsors.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllSponsors.TabIndex = 6;
            this.buttonShowAllSponsors.Text = "Pokaż wszystkich sponsorów";
            this.buttonShowAllSponsors.UseVisualStyleBackColor = false;
            this.buttonShowAllSponsors.Click += new System.EventHandler(this.buttonShowAllSponsors_Click);
            // 
            // buttonShowAllTrainers
            // 
            this.buttonShowAllTrainers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllTrainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllTrainers.Location = new System.Drawing.Point(248, 434);
            this.buttonShowAllTrainers.Name = "buttonShowAllTrainers";
            this.buttonShowAllTrainers.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllTrainers.TabIndex = 7;
            this.buttonShowAllTrainers.Text = "Pokaż wszystkich selekcjonerów";
            this.buttonShowAllTrainers.UseVisualStyleBackColor = false;
            this.buttonShowAllTrainers.Click += new System.EventHandler(this.buttonShowAllTrainers_Click);
            // 
            // buttonShowAllAdresses
            // 
            this.buttonShowAllAdresses.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllAdresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllAdresses.Location = new System.Drawing.Point(359, 434);
            this.buttonShowAllAdresses.Name = "buttonShowAllAdresses";
            this.buttonShowAllAdresses.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllAdresses.TabIndex = 8;
            this.buttonShowAllAdresses.Text = "Pokaż wszystkie adresy";
            this.buttonShowAllAdresses.UseVisualStyleBackColor = false;
            this.buttonShowAllAdresses.Click += new System.EventHandler(this.buttonShowAllAdresses_Click);
            // 
            // buttonShowAllCards
            // 
            this.buttonShowAllCards.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllCards.Location = new System.Drawing.Point(803, 434);
            this.buttonShowAllCards.Name = "buttonShowAllCards";
            this.buttonShowAllCards.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllCards.TabIndex = 9;
            this.buttonShowAllCards.Text = "Pokaż wszystkie kartki";
            this.buttonShowAllCards.UseVisualStyleBackColor = false;
            this.buttonShowAllCards.Click += new System.EventHandler(this.buttonShowAllCards_Click);
            // 
            // buttonShowAllGoals
            // 
            this.buttonShowAllGoals.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllGoals.Location = new System.Drawing.Point(914, 434);
            this.buttonShowAllGoals.Name = "buttonShowAllGoals";
            this.buttonShowAllGoals.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllGoals.TabIndex = 10;
            this.buttonShowAllGoals.Text = "Pokaż wszystkie gole";
            this.buttonShowAllGoals.UseVisualStyleBackColor = false;
            this.buttonShowAllGoals.Click += new System.EventHandler(this.buttonShowAllGoals_Click);
            // 
            // buttonShowAllSuspensions
            // 
            this.buttonShowAllSuspensions.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllSuspensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllSuspensions.Location = new System.Drawing.Point(1025, 434);
            this.buttonShowAllSuspensions.Name = "buttonShowAllSuspensions";
            this.buttonShowAllSuspensions.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllSuspensions.TabIndex = 11;
            this.buttonShowAllSuspensions.Text = "Pokaż wszystkie zawieszenia";
            this.buttonShowAllSuspensions.UseVisualStyleBackColor = false;
            this.buttonShowAllSuspensions.Click += new System.EventHandler(this.buttonShowAllSuspensions_Click);
            // 
            // buttonShowAllStatistics
            // 
            this.buttonShowAllStatistics.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllStatistics.Location = new System.Drawing.Point(1136, 434);
            this.buttonShowAllStatistics.Name = "buttonShowAllStatistics";
            this.buttonShowAllStatistics.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllStatistics.TabIndex = 12;
            this.buttonShowAllStatistics.Text = "Pokaż wszystkie statystyki";
            this.buttonShowAllStatistics.UseVisualStyleBackColor = false;
            this.buttonShowAllStatistics.Click += new System.EventHandler(this.buttonShowAllStatistics_Click);
            // 
            // buttonShowAllStadiums
            // 
            this.buttonShowAllStadiums.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllStadiums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllStadiums.Location = new System.Drawing.Point(470, 434);
            this.buttonShowAllStadiums.Name = "buttonShowAllStadiums";
            this.buttonShowAllStadiums.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllStadiums.TabIndex = 13;
            this.buttonShowAllStadiums.Text = "Pokaż wszystkie stadiony";
            this.buttonShowAllStadiums.UseVisualStyleBackColor = false;
            this.buttonShowAllStadiums.Click += new System.EventHandler(this.buttonShowAllStadiums_Click);
            // 
            // buttonShowAllClubs
            // 
            this.buttonShowAllClubs.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonShowAllClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowAllClubs.Location = new System.Drawing.Point(581, 434);
            this.buttonShowAllClubs.Name = "buttonShowAllClubs";
            this.buttonShowAllClubs.Size = new System.Drawing.Size(105, 50);
            this.buttonShowAllClubs.TabIndex = 14;
            this.buttonShowAllClubs.Text = "Pokaż wszystkie kluby";
            this.buttonShowAllClubs.UseVisualStyleBackColor = false;
            this.buttonShowAllClubs.Click += new System.EventHandler(this.buttonShowAllClubs_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonClose.Location = new System.Drawing.Point(1090, 600);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(214, 98);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxFootballer
            // 
            this.groupBoxFootballer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxFootballer.Controls.Add(this.labelFootballerBetterLeg);
            this.groupBoxFootballer.Controls.Add(this.labelFootballerAge);
            this.groupBoxFootballer.Controls.Add(this.labelFootballerNationality);
            this.groupBoxFootballer.Controls.Add(this.labelFootballerSurname);
            this.groupBoxFootballer.Controls.Add(this.labelFootballerName);
            this.groupBoxFootballer.Controls.Add(this.comboBoxFootballerBetterLeg);
            this.groupBoxFootballer.Controls.Add(this.textBoxFootballerAge);
            this.groupBoxFootballer.Controls.Add(this.textBoxFootballerNationality);
            this.groupBoxFootballer.Controls.Add(this.textBoxFootballerSurname);
            this.groupBoxFootballer.Controls.Add(this.textBoxFootballerName);
            this.groupBoxFootballer.Controls.Add(this.buttonEditFootballer);
            this.groupBoxFootballer.Controls.Add(this.buttonDeledeSelected);
            this.groupBoxFootballer.Controls.Add(this.buttonAddFootballer);
            this.groupBoxFootballer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFootballer.Location = new System.Drawing.Point(120, 510);
            this.groupBoxFootballer.Name = "groupBoxFootballer";
            this.groupBoxFootballer.Size = new System.Drawing.Size(345, 133);
            this.groupBoxFootballer.TabIndex = 16;
            this.groupBoxFootballer.TabStop = false;
            this.groupBoxFootballer.Text = "Piłkarz:";
            // 
            // labelFootballerBetterLeg
            // 
            this.labelFootballerBetterLeg.AutoSize = true;
            this.labelFootballerBetterLeg.Location = new System.Drawing.Point(193, 62);
            this.labelFootballerBetterLeg.Name = "labelFootballerBetterLeg";
            this.labelFootballerBetterLeg.Size = new System.Drawing.Size(68, 13);
            this.labelFootballerBetterLeg.TabIndex = 12;
            this.labelFootballerBetterLeg.Text = "Lepsza noga";
            // 
            // labelFootballerAge
            // 
            this.labelFootballerAge.AutoSize = true;
            this.labelFootballerAge.Location = new System.Drawing.Point(95, 62);
            this.labelFootballerAge.Name = "labelFootballerAge";
            this.labelFootballerAge.Size = new System.Drawing.Size(32, 13);
            this.labelFootballerAge.TabIndex = 11;
            this.labelFootballerAge.Text = "Wiek";
            // 
            // labelFootballerNationality
            // 
            this.labelFootballerNationality.AutoSize = true;
            this.labelFootballerNationality.Location = new System.Drawing.Point(241, 18);
            this.labelFootballerNationality.Name = "labelFootballerNationality";
            this.labelFootballerNationality.Size = new System.Drawing.Size(67, 13);
            this.labelFootballerNationality.TabIndex = 10;
            this.labelFootballerNationality.Text = "Narodowość";
            // 
            // labelFootballerSurname
            // 
            this.labelFootballerSurname.AutoSize = true;
            this.labelFootballerSurname.Location = new System.Drawing.Point(143, 18);
            this.labelFootballerSurname.Name = "labelFootballerSurname";
            this.labelFootballerSurname.Size = new System.Drawing.Size(53, 13);
            this.labelFootballerSurname.TabIndex = 9;
            this.labelFootballerSurname.Text = "Nazwisko";
            // 
            // labelFootballerName
            // 
            this.labelFootballerName.AutoSize = true;
            this.labelFootballerName.Location = new System.Drawing.Point(52, 18);
            this.labelFootballerName.Name = "labelFootballerName";
            this.labelFootballerName.Size = new System.Drawing.Size(26, 13);
            this.labelFootballerName.TabIndex = 8;
            this.labelFootballerName.Text = "Imię";
            // 
            // comboBoxFootballerBetterLeg
            // 
            this.comboBoxFootballerBetterLeg.FormattingEnabled = true;
            this.comboBoxFootballerBetterLeg.Items.AddRange(new object[] {
            "prawa",
            "lewa"});
            this.comboBoxFootballerBetterLeg.Location = new System.Drawing.Point(168, 77);
            this.comboBoxFootballerBetterLeg.Name = "comboBoxFootballerBetterLeg";
            this.comboBoxFootballerBetterLeg.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFootballerBetterLeg.TabIndex = 7;
            // 
            // textBoxFootballerAge
            // 
            this.textBoxFootballerAge.Location = new System.Drawing.Point(62, 78);
            this.textBoxFootballerAge.Name = "textBoxFootballerAge";
            this.textBoxFootballerAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxFootballerAge.TabIndex = 6;
            // 
            // textBoxFootballerNationality
            // 
            this.textBoxFootballerNationality.Location = new System.Drawing.Point(226, 34);
            this.textBoxFootballerNationality.Name = "textBoxFootballerNationality";
            this.textBoxFootballerNationality.Size = new System.Drawing.Size(100, 20);
            this.textBoxFootballerNationality.TabIndex = 5;
            // 
            // textBoxFootballerSurname
            // 
            this.textBoxFootballerSurname.Location = new System.Drawing.Point(120, 34);
            this.textBoxFootballerSurname.Name = "textBoxFootballerSurname";
            this.textBoxFootballerSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxFootballerSurname.TabIndex = 4;
            // 
            // textBoxFootballerName
            // 
            this.textBoxFootballerName.Location = new System.Drawing.Point(14, 34);
            this.textBoxFootballerName.Name = "textBoxFootballerName";
            this.textBoxFootballerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFootballerName.TabIndex = 3;
            // 
            // buttonEditFootballer
            // 
            this.buttonEditFootballer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditFootballer.Location = new System.Drawing.Point(87, 104);
            this.buttonEditFootballer.Name = "buttonEditFootballer";
            this.buttonEditFootballer.Size = new System.Drawing.Size(122, 23);
            this.buttonEditFootballer.TabIndex = 2;
            this.buttonEditFootballer.Text = "Edytuj zaznaczonego";
            this.buttonEditFootballer.UseVisualStyleBackColor = true;
            this.buttonEditFootballer.Click += new System.EventHandler(this.buttonEditFootballer_Click);
            // 
            // buttonDeledeSelected
            // 
            this.buttonDeledeSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeledeSelected.Location = new System.Drawing.Point(215, 104);
            this.buttonDeledeSelected.Name = "buttonDeledeSelected";
            this.buttonDeledeSelected.Size = new System.Drawing.Size(122, 23);
            this.buttonDeledeSelected.TabIndex = 1;
            this.buttonDeledeSelected.Text = "Usuń zaznaczonego";
            this.buttonDeledeSelected.UseVisualStyleBackColor = true;
            this.buttonDeledeSelected.Click += new System.EventHandler(this.buttonDeledeSelected_Click);
            // 
            // buttonAddFootballer
            // 
            this.buttonAddFootballer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddFootballer.Location = new System.Drawing.Point(6, 104);
            this.buttonAddFootballer.Name = "buttonAddFootballer";
            this.buttonAddFootballer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFootballer.TabIndex = 0;
            this.buttonAddFootballer.Text = "Dodaj";
            this.buttonAddFootballer.UseVisualStyleBackColor = true;
            this.buttonAddFootballer.Click += new System.EventHandler(this.buttonAddFootballer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.labelYellowCards);
            this.groupBox1.Controls.Add(this.labelRedCards);
            this.groupBox1.Controls.Add(this.labelLostGoals);
            this.groupBox1.Controls.Add(this.labelScoredGoals);
            this.groupBox1.Controls.Add(this.buttonSumYellowCards);
            this.groupBox1.Controls.Add(this.buttonSumRedCards);
            this.groupBox1.Controls.Add(this.buttonSumLostGoals);
            this.groupBox1.Controls.Add(this.buttonSumScoredGoals);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(662, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 133);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bramki i kartki";
            // 
            // labelYellowCards
            // 
            this.labelYellowCards.AutoSize = true;
            this.labelYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYellowCards.Location = new System.Drawing.Point(285, 37);
            this.labelYellowCards.Name = "labelYellowCards";
            this.labelYellowCards.Size = new System.Drawing.Size(11, 13);
            this.labelYellowCards.TabIndex = 7;
            this.labelYellowCards.Text = "-";
            // 
            // labelRedCards
            // 
            this.labelRedCards.AutoSize = true;
            this.labelRedCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRedCards.Location = new System.Drawing.Point(207, 37);
            this.labelRedCards.Name = "labelRedCards";
            this.labelRedCards.Size = new System.Drawing.Size(11, 13);
            this.labelRedCards.TabIndex = 6;
            this.labelRedCards.Text = "-";
            // 
            // labelLostGoals
            // 
            this.labelLostGoals.AutoSize = true;
            this.labelLostGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLostGoals.Location = new System.Drawing.Point(130, 37);
            this.labelLostGoals.Name = "labelLostGoals";
            this.labelLostGoals.Size = new System.Drawing.Size(11, 13);
            this.labelLostGoals.TabIndex = 5;
            this.labelLostGoals.Text = "-";
            // 
            // labelScoredGoals
            // 
            this.labelScoredGoals.AutoSize = true;
            this.labelScoredGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScoredGoals.Location = new System.Drawing.Point(50, 37);
            this.labelScoredGoals.Name = "labelScoredGoals";
            this.labelScoredGoals.Size = new System.Drawing.Size(11, 13);
            this.labelScoredGoals.TabIndex = 4;
            this.labelScoredGoals.Text = "-";
            // 
            // buttonSumYellowCards
            // 
            this.buttonSumYellowCards.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSumYellowCards.Location = new System.Drawing.Point(252, 77);
            this.buttonSumYellowCards.Name = "buttonSumYellowCards";
            this.buttonSumYellowCards.Size = new System.Drawing.Size(71, 50);
            this.buttonSumYellowCards.TabIndex = 3;
            this.buttonSumYellowCards.Text = "Zlicz żółte kartki";
            this.buttonSumYellowCards.UseVisualStyleBackColor = true;
            this.buttonSumYellowCards.Click += new System.EventHandler(this.buttonSumYellowCards_Click);
            // 
            // buttonSumRedCards
            // 
            this.buttonSumRedCards.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSumRedCards.Location = new System.Drawing.Point(175, 77);
            this.buttonSumRedCards.Name = "buttonSumRedCards";
            this.buttonSumRedCards.Size = new System.Drawing.Size(71, 50);
            this.buttonSumRedCards.TabIndex = 2;
            this.buttonSumRedCards.Text = "Zlicz czerwone kartki";
            this.buttonSumRedCards.UseVisualStyleBackColor = true;
            this.buttonSumRedCards.Click += new System.EventHandler(this.buttonSumRedCards_Click);
            // 
            // buttonSumLostGoals
            // 
            this.buttonSumLostGoals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSumLostGoals.Location = new System.Drawing.Point(98, 77);
            this.buttonSumLostGoals.Name = "buttonSumLostGoals";
            this.buttonSumLostGoals.Size = new System.Drawing.Size(71, 50);
            this.buttonSumLostGoals.TabIndex = 1;
            this.buttonSumLostGoals.Text = "Zlicz stracone bramki";
            this.buttonSumLostGoals.UseVisualStyleBackColor = true;
            this.buttonSumLostGoals.Click += new System.EventHandler(this.buttonSumLostGoals_Click);
            // 
            // buttonSumScoredGoals
            // 
            this.buttonSumScoredGoals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSumScoredGoals.Location = new System.Drawing.Point(21, 77);
            this.buttonSumScoredGoals.Name = "buttonSumScoredGoals";
            this.buttonSumScoredGoals.Size = new System.Drawing.Size(71, 50);
            this.buttonSumScoredGoals.TabIndex = 0;
            this.buttonSumScoredGoals.Text = "Zlicz strzelone bramki";
            this.buttonSumScoredGoals.UseVisualStyleBackColor = true;
            this.buttonSumScoredGoals.Click += new System.EventHandler(this.buttonSumScoredGoals_Click);
            // 
            // groupBoxStadiums
            // 
            this.groupBoxStadiums.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxStadiums.Controls.Add(this.labelSurface);
            this.groupBoxStadiums.Controls.Add(this.comboBoxSurface);
            this.groupBoxStadiums.Controls.Add(this.buttonShowWithSurface);
            this.groupBoxStadiums.Controls.Add(this.labelStadiumTo);
            this.groupBoxStadiums.Controls.Add(this.labelStadiumFrom);
            this.groupBoxStadiums.Controls.Add(this.buttonSearchByCapacity);
            this.groupBoxStadiums.Controls.Add(this.textBoxStadiumTo);
            this.groupBoxStadiums.Controls.Add(this.textBoxStadiumFrom);
            this.groupBoxStadiums.Controls.Add(this.labelSearchStadiumFromTo);
            this.groupBoxStadiums.Controls.Add(this.labelSortBy);
            this.groupBoxStadiums.Controls.Add(this.comboBoxSortBy);
            this.groupBoxStadiums.Controls.Add(this.buttonSortBy);
            this.groupBoxStadiums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxStadiums.Location = new System.Drawing.Point(120, 649);
            this.groupBoxStadiums.Name = "groupBoxStadiums";
            this.groupBoxStadiums.Size = new System.Drawing.Size(344, 170);
            this.groupBoxStadiums.TabIndex = 19;
            this.groupBoxStadiums.TabStop = false;
            this.groupBoxStadiums.Text = "Stadiony:";
            // 
            // labelSurface
            // 
            this.labelSurface.AutoSize = true;
            this.labelSurface.Location = new System.Drawing.Point(17, 139);
            this.labelSurface.Name = "labelSurface";
            this.labelSurface.Size = new System.Drawing.Size(71, 13);
            this.labelSurface.TabIndex = 32;
            this.labelSurface.Text = "Nawierzchnia";
            // 
            // comboBoxSurface
            // 
            this.comboBoxSurface.FormattingEnabled = true;
            this.comboBoxSurface.Items.AddRange(new object[] {
            "trawiasta",
            "sztuczna"});
            this.comboBoxSurface.Location = new System.Drawing.Point(99, 136);
            this.comboBoxSurface.Name = "comboBoxSurface";
            this.comboBoxSurface.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSurface.TabIndex = 31;
            // 
            // buttonShowWithSurface
            // 
            this.buttonShowWithSurface.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowWithSurface.Location = new System.Drawing.Point(244, 136);
            this.buttonShowWithSurface.Name = "buttonShowWithSurface";
            this.buttonShowWithSurface.Size = new System.Drawing.Size(75, 23);
            this.buttonShowWithSurface.TabIndex = 30;
            this.buttonShowWithSurface.Text = "Pokaż";
            this.buttonShowWithSurface.UseVisualStyleBackColor = true;
            this.buttonShowWithSurface.Click += new System.EventHandler(this.buttonShowWithSurface_Click);
            // 
            // labelStadiumTo
            // 
            this.labelStadiumTo.AutoSize = true;
            this.labelStadiumTo.Location = new System.Drawing.Point(100, 91);
            this.labelStadiumTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStadiumTo.Name = "labelStadiumTo";
            this.labelStadiumTo.Size = new System.Drawing.Size(26, 13);
            this.labelStadiumTo.TabIndex = 29;
            this.labelStadiumTo.Text = "DO:";
            // 
            // labelStadiumFrom
            // 
            this.labelStadiumFrom.AutoSize = true;
            this.labelStadiumFrom.Location = new System.Drawing.Point(25, 91);
            this.labelStadiumFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStadiumFrom.Name = "labelStadiumFrom";
            this.labelStadiumFrom.Size = new System.Drawing.Size(26, 13);
            this.labelStadiumFrom.TabIndex = 28;
            this.labelStadiumFrom.Text = "OD:";
            // 
            // buttonSearchByCapacity
            // 
            this.buttonSearchByCapacity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchByCapacity.Location = new System.Drawing.Point(244, 88);
            this.buttonSearchByCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchByCapacity.Name = "buttonSearchByCapacity";
            this.buttonSearchByCapacity.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByCapacity.TabIndex = 27;
            this.buttonSearchByCapacity.Text = "Szukaj";
            this.buttonSearchByCapacity.UseVisualStyleBackColor = true;
            this.buttonSearchByCapacity.Click += new System.EventHandler(this.buttonSearchByCapacity_Click);
            // 
            // textBoxStadiumTo
            // 
            this.textBoxStadiumTo.Location = new System.Drawing.Point(128, 88);
            this.textBoxStadiumTo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStadiumTo.Name = "textBoxStadiumTo";
            this.textBoxStadiumTo.Size = new System.Drawing.Size(43, 20);
            this.textBoxStadiumTo.TabIndex = 26;
            // 
            // textBoxStadiumFrom
            // 
            this.textBoxStadiumFrom.Location = new System.Drawing.Point(55, 88);
            this.textBoxStadiumFrom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStadiumFrom.Name = "textBoxStadiumFrom";
            this.textBoxStadiumFrom.Size = new System.Drawing.Size(41, 20);
            this.textBoxStadiumFrom.TabIndex = 25;
            // 
            // labelSearchStadiumFromTo
            // 
            this.labelSearchStadiumFromTo.AutoSize = true;
            this.labelSearchStadiumFromTo.Location = new System.Drawing.Point(17, 63);
            this.labelSearchStadiumFromTo.Name = "labelSearchStadiumFromTo";
            this.labelSearchStadiumFromTo.Size = new System.Drawing.Size(236, 13);
            this.labelSearchStadiumFromTo.TabIndex = 13;
            this.labelSearchStadiumFromTo.Text = "Wyszukaj stadion podając przedział pojemności:";
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(17, 31);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(52, 13);
            this.labelSortBy.TabIndex = 12;
            this.labelSortBy.Text = "Sortuj po:";
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "StadiumName",
            "Surface",
            "Capacity",
            "Country",
            "City",
            "Street",
            "AdressNumber"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(99, 28);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSortBy.TabIndex = 7;
            // 
            // buttonSortBy
            // 
            this.buttonSortBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSortBy.Location = new System.Drawing.Point(244, 28);
            this.buttonSortBy.Name = "buttonSortBy";
            this.buttonSortBy.Size = new System.Drawing.Size(75, 23);
            this.buttonSortBy.TabIndex = 0;
            this.buttonSortBy.Text = "Sortuj";
            this.buttonSortBy.UseVisualStyleBackColor = true;
            this.buttonSortBy.Click += new System.EventHandler(this.buttonSortBy_Click);
            // 
            // groupBoxSponsors
            // 
            this.groupBoxSponsors.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxSponsors.Controls.Add(this.labelAverageOfGrants);
            this.groupBoxSponsors.Controls.Add(this.labelSumOfActiveSponsors);
            this.groupBoxSponsors.Controls.Add(this.labelSumOfPassiveSponsors);
            this.groupBoxSponsors.Controls.Add(this.buttonCountPassiveSponsors);
            this.groupBoxSponsors.Controls.Add(this.labelCountActiveSponsors);
            this.groupBoxSponsors.Controls.Add(this.textBoxSponsorName);
            this.groupBoxSponsors.Controls.Add(this.labelCountPassiveSponsors);
            this.groupBoxSponsors.Controls.Add(this.buttonCountActiveSponsors);
            this.groupBoxSponsors.Controls.Add(this.buttonCalculateDonateAvarage);
            this.groupBoxSponsors.Controls.Add(this.labelCalculateDonateAvarage);
            this.groupBoxSponsors.Controls.Add(this.labelSearchSponsorByName);
            this.groupBoxSponsors.Controls.Add(this.buttonSearchSponsorByName);
            this.groupBoxSponsors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSponsors.Location = new System.Drawing.Point(662, 649);
            this.groupBoxSponsors.Name = "groupBoxSponsors";
            this.groupBoxSponsors.Size = new System.Drawing.Size(344, 170);
            this.groupBoxSponsors.TabIndex = 20;
            this.groupBoxSponsors.TabStop = false;
            this.groupBoxSponsors.Text = "Sponsorzy:";
            // 
            // labelAverageOfGrants
            // 
            this.labelAverageOfGrants.AutoSize = true;
            this.labelAverageOfGrants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAverageOfGrants.Location = new System.Drawing.Point(83, 88);
            this.labelAverageOfGrants.Name = "labelAverageOfGrants";
            this.labelAverageOfGrants.Size = new System.Drawing.Size(11, 13);
            this.labelAverageOfGrants.TabIndex = 38;
            this.labelAverageOfGrants.Text = "-";
            // 
            // labelSumOfActiveSponsors
            // 
            this.labelSumOfActiveSponsors.AutoSize = true;
            this.labelSumOfActiveSponsors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSumOfActiveSponsors.Location = new System.Drawing.Point(197, 136);
            this.labelSumOfActiveSponsors.Name = "labelSumOfActiveSponsors";
            this.labelSumOfActiveSponsors.Size = new System.Drawing.Size(11, 13);
            this.labelSumOfActiveSponsors.TabIndex = 37;
            this.labelSumOfActiveSponsors.Text = "-";
            // 
            // labelSumOfPassiveSponsors
            // 
            this.labelSumOfPassiveSponsors.AutoSize = true;
            this.labelSumOfPassiveSponsors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSumOfPassiveSponsors.Location = new System.Drawing.Point(197, 108);
            this.labelSumOfPassiveSponsors.Name = "labelSumOfPassiveSponsors";
            this.labelSumOfPassiveSponsors.Size = new System.Drawing.Size(11, 13);
            this.labelSumOfPassiveSponsors.TabIndex = 36;
            this.labelSumOfPassiveSponsors.Text = "-";
            // 
            // buttonCountPassiveSponsors
            // 
            this.buttonCountPassiveSponsors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCountPassiveSponsors.Location = new System.Drawing.Point(243, 103);
            this.buttonCountPassiveSponsors.Name = "buttonCountPassiveSponsors";
            this.buttonCountPassiveSponsors.Size = new System.Drawing.Size(75, 23);
            this.buttonCountPassiveSponsors.TabIndex = 35;
            this.buttonCountPassiveSponsors.Text = "Zlicz";
            this.buttonCountPassiveSponsors.UseVisualStyleBackColor = true;
            this.buttonCountPassiveSponsors.Click += new System.EventHandler(this.buttonCountPassiveSponsors_Click);
            // 
            // labelCountActiveSponsors
            // 
            this.labelCountActiveSponsors.AutoSize = true;
            this.labelCountActiveSponsors.Location = new System.Drawing.Point(17, 136);
            this.labelCountActiveSponsors.Name = "labelCountActiveSponsors";
            this.labelCountActiveSponsors.Size = new System.Drawing.Size(140, 13);
            this.labelCountActiveSponsors.TabIndex = 34;
            this.labelCountActiveSponsors.Text = "Zlicz aktywnych sponsorów:";
            // 
            // textBoxSponsorName
            // 
            this.textBoxSponsorName.Location = new System.Drawing.Point(120, 29);
            this.textBoxSponsorName.Name = "textBoxSponsorName";
            this.textBoxSponsorName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSponsorName.TabIndex = 33;
            // 
            // labelCountPassiveSponsors
            // 
            this.labelCountPassiveSponsors.AutoSize = true;
            this.labelCountPassiveSponsors.Location = new System.Drawing.Point(17, 108);
            this.labelCountPassiveSponsors.Name = "labelCountPassiveSponsors";
            this.labelCountPassiveSponsors.Size = new System.Drawing.Size(142, 13);
            this.labelCountPassiveSponsors.TabIndex = 32;
            this.labelCountPassiveSponsors.Text = "Zlicz pasywnych sponsorów:";
            // 
            // buttonCountActiveSponsors
            // 
            this.buttonCountActiveSponsors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCountActiveSponsors.Location = new System.Drawing.Point(243, 131);
            this.buttonCountActiveSponsors.Name = "buttonCountActiveSponsors";
            this.buttonCountActiveSponsors.Size = new System.Drawing.Size(75, 23);
            this.buttonCountActiveSponsors.TabIndex = 30;
            this.buttonCountActiveSponsors.Text = "Zlicz";
            this.buttonCountActiveSponsors.UseVisualStyleBackColor = true;
            this.buttonCountActiveSponsors.Click += new System.EventHandler(this.buttonCountActiveSponsors_Click);
            // 
            // buttonCalculateDonateAvarage
            // 
            this.buttonCalculateDonateAvarage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCalculateDonateAvarage.Location = new System.Drawing.Point(244, 58);
            this.buttonCalculateDonateAvarage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalculateDonateAvarage.Name = "buttonCalculateDonateAvarage";
            this.buttonCalculateDonateAvarage.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateDonateAvarage.TabIndex = 27;
            this.buttonCalculateDonateAvarage.Text = "Oblicz";
            this.buttonCalculateDonateAvarage.UseVisualStyleBackColor = true;
            this.buttonCalculateDonateAvarage.Click += new System.EventHandler(this.buttonCalculateDonateAvarage_Click);
            // 
            // labelCalculateDonateAvarage
            // 
            this.labelCalculateDonateAvarage.AutoSize = true;
            this.labelCalculateDonateAvarage.Location = new System.Drawing.Point(17, 63);
            this.labelCalculateDonateAvarage.Name = "labelCalculateDonateAvarage";
            this.labelCalculateDonateAvarage.Size = new System.Drawing.Size(182, 13);
            this.labelCalculateDonateAvarage.TabIndex = 13;
            this.labelCalculateDonateAvarage.Text = "Oblicz średnią dofinansowania klubu:";
            // 
            // labelSearchSponsorByName
            // 
            this.labelSearchSponsorByName.AutoSize = true;
            this.labelSearchSponsorByName.Location = new System.Drawing.Point(17, 31);
            this.labelSearchSponsorByName.Name = "labelSearchSponsorByName";
            this.labelSearchSponsorByName.Size = new System.Drawing.Size(93, 13);
            this.labelSearchSponsorByName.TabIndex = 12;
            this.labelSearchSponsorByName.Text = "Szukaj po nazwie:";
            // 
            // buttonSearchSponsorByName
            // 
            this.buttonSearchSponsorByName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearchSponsorByName.Location = new System.Drawing.Point(244, 28);
            this.buttonSearchSponsorByName.Name = "buttonSearchSponsorByName";
            this.buttonSearchSponsorByName.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchSponsorByName.TabIndex = 0;
            this.buttonSearchSponsorByName.Text = "Szukaj";
            this.buttonSearchSponsorByName.UseVisualStyleBackColor = true;
            this.buttonSearchSponsorByName.Click += new System.EventHandler(this.buttonSearchSponsorByName_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1373, 831);
            this.Controls.Add(this.groupBoxSponsors);
            this.Controls.Add(this.groupBoxStadiums);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFootballer);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonShowAllClubs);
            this.Controls.Add(this.buttonShowAllStadiums);
            this.Controls.Add(this.buttonShowAllStatistics);
            this.Controls.Add(this.buttonShowAllSuspensions);
            this.Controls.Add(this.buttonShowAllGoals);
            this.Controls.Add(this.buttonShowAllCards);
            this.Controls.Add(this.buttonShowAllAdresses);
            this.Controls.Add(this.buttonShowAllTrainers);
            this.Controls.Add(this.buttonShowAllSponsors);
            this.Controls.Add(this.buttonShowAllFootballers);
            this.Controls.Add(this.dataGridViewFootballStatistics);
            this.Controls.Add(this.labelFootball);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "FootballStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFootballStatistics)).EndInit();
            this.groupBoxFootballer.ResumeLayout(false);
            this.groupBoxFootballer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxStadiums.ResumeLayout(false);
            this.groupBoxStadiums.PerformLayout();
            this.groupBoxSponsors.ResumeLayout(false);
            this.groupBoxSponsors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFootballStatistics;
        private System.Windows.Forms.Label labelFootball;
        private System.Windows.Forms.Button buttonShowAllFootballers;
        private System.Windows.Forms.Button buttonShowAllSponsors;
        private System.Windows.Forms.Button buttonShowAllTrainers;
        private System.Windows.Forms.Button buttonShowAllAdresses;
        private System.Windows.Forms.Button buttonShowAllCards;
        private System.Windows.Forms.Button buttonShowAllGoals;
        private System.Windows.Forms.Button buttonShowAllSuspensions;
        private System.Windows.Forms.Button buttonShowAllStatistics;
        private System.Windows.Forms.Button buttonShowAllStadiums;
        private System.Windows.Forms.Button buttonShowAllClubs;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxFootballer;
        private System.Windows.Forms.Button buttonEditFootballer;
        private System.Windows.Forms.Button buttonDeledeSelected;
        private System.Windows.Forms.Button buttonAddFootballer;
        private System.Windows.Forms.ComboBox comboBoxFootballerBetterLeg;
        private System.Windows.Forms.TextBox textBoxFootballerAge;
        private System.Windows.Forms.TextBox textBoxFootballerNationality;
        private System.Windows.Forms.TextBox textBoxFootballerSurname;
        private System.Windows.Forms.TextBox textBoxFootballerName;
        private System.Windows.Forms.Label labelFootballerBetterLeg;
        private System.Windows.Forms.Label labelFootballerAge;
        private System.Windows.Forms.Label labelFootballerNationality;
        private System.Windows.Forms.Label labelFootballerSurname;
        private System.Windows.Forms.Label labelFootballerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelYellowCards;
        private System.Windows.Forms.Label labelRedCards;
        private System.Windows.Forms.Label labelLostGoals;
        private System.Windows.Forms.Label labelScoredGoals;
        private System.Windows.Forms.Button buttonSumYellowCards;
        private System.Windows.Forms.Button buttonSumRedCards;
        private System.Windows.Forms.Button buttonSumLostGoals;
        private System.Windows.Forms.Button buttonSumScoredGoals;
        private System.Windows.Forms.GroupBox groupBoxStadiums;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Button buttonSortBy;
        private System.Windows.Forms.Label labelSurface;
        private System.Windows.Forms.ComboBox comboBoxSurface;
        private System.Windows.Forms.Button buttonShowWithSurface;
        private System.Windows.Forms.Label labelStadiumTo;
        private System.Windows.Forms.Label labelStadiumFrom;
        private System.Windows.Forms.Button buttonSearchByCapacity;
        private System.Windows.Forms.TextBox textBoxStadiumTo;
        private System.Windows.Forms.TextBox textBoxStadiumFrom;
        private System.Windows.Forms.Label labelSearchStadiumFromTo;
        private System.Windows.Forms.GroupBox groupBoxSponsors;
        private System.Windows.Forms.TextBox textBoxSponsorName;
        private System.Windows.Forms.Label labelCountPassiveSponsors;
        private System.Windows.Forms.Button buttonCountActiveSponsors;
        private System.Windows.Forms.Button buttonCalculateDonateAvarage;
        private System.Windows.Forms.Label labelCalculateDonateAvarage;
        private System.Windows.Forms.Label labelSearchSponsorByName;
        private System.Windows.Forms.Button buttonSearchSponsorByName;
        private System.Windows.Forms.Label labelSumOfActiveSponsors;
        private System.Windows.Forms.Label labelSumOfPassiveSponsors;
        private System.Windows.Forms.Button buttonCountPassiveSponsors;
        private System.Windows.Forms.Label labelCountActiveSponsors;
        private System.Windows.Forms.Label labelAverageOfGrants;
    }
}

