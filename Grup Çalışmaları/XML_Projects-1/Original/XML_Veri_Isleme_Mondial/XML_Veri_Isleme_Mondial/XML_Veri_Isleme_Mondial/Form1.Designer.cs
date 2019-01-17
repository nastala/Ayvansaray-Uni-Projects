namespace XML_Veri_Isleme_Mondial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopulationGrowth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfantMortality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDPAgri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDPTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inflation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndepDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Government = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvCountriesAndCities = new System.Windows.Forms.TreeView();
            this.tbSearchCountry = new System.Windows.Forms.TextBox();
            this.btnSearchCountry = new System.Windows.Forms.Button();
            this.btnFilterByPopulation = new System.Windows.Forms.Button();
            this.dgvFilteredCities = new System.Windows.Forms.DataGridView();
            this.CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityPopulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilterBySeaNames = new System.Windows.Forms.Button();
            this.lbFilterBySeaNames = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFilterByCountryAndCityNames = new System.Windows.Forms.Button();
            this.lbFilterByCountryAndCityNames = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredCities)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCountries
            // 
            this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryName,
            this.Population,
            this.DataCode,
            this.TotalArea,
            this.PopulationGrowth,
            this.InfantMortality,
            this.GDPAgri,
            this.GDPTotal,
            this.Inflation,
            this.IndepDate,
            this.Government,
            this.CarCode});
            this.dgvCountries.Location = new System.Drawing.Point(196, 12);
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.Size = new System.Drawing.Size(841, 223);
            this.dgvCountries.TabIndex = 0;
            // 
            // CountryName
            // 
            this.CountryName.HeaderText = "Name";
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            // 
            // Population
            // 
            this.Population.HeaderText = "Population";
            this.Population.Name = "Population";
            this.Population.ReadOnly = true;
            // 
            // DataCode
            // 
            this.DataCode.HeaderText = "Data Code";
            this.DataCode.Name = "DataCode";
            this.DataCode.ReadOnly = true;
            // 
            // TotalArea
            // 
            this.TotalArea.HeaderText = "Total Area";
            this.TotalArea.Name = "TotalArea";
            this.TotalArea.ReadOnly = true;
            // 
            // PopulationGrowth
            // 
            this.PopulationGrowth.HeaderText = "Population Growth";
            this.PopulationGrowth.Name = "PopulationGrowth";
            this.PopulationGrowth.ReadOnly = true;
            // 
            // InfantMortality
            // 
            this.InfantMortality.HeaderText = "Infant Mortality";
            this.InfantMortality.Name = "InfantMortality";
            this.InfantMortality.ReadOnly = true;
            // 
            // GDPAgri
            // 
            this.GDPAgri.HeaderText = "GDP Agri";
            this.GDPAgri.Name = "GDPAgri";
            this.GDPAgri.ReadOnly = true;
            // 
            // GDPTotal
            // 
            this.GDPTotal.HeaderText = "GDP Total";
            this.GDPTotal.Name = "GDPTotal";
            this.GDPTotal.ReadOnly = true;
            // 
            // Inflation
            // 
            this.Inflation.HeaderText = "Inflation";
            this.Inflation.Name = "Inflation";
            this.Inflation.ReadOnly = true;
            // 
            // IndepDate
            // 
            this.IndepDate.HeaderText = "Indep Date";
            this.IndepDate.Name = "IndepDate";
            this.IndepDate.ReadOnly = true;
            // 
            // Government
            // 
            this.Government.HeaderText = "Government";
            this.Government.Name = "Government";
            this.Government.ReadOnly = true;
            // 
            // CarCode
            // 
            this.CarCode.HeaderText = "Car Code";
            this.CarCode.Name = "CarCode";
            this.CarCode.ReadOnly = true;
            // 
            // tvCountriesAndCities
            // 
            this.tvCountriesAndCities.Location = new System.Drawing.Point(13, 12);
            this.tvCountriesAndCities.Name = "tvCountriesAndCities";
            this.tvCountriesAndCities.Size = new System.Drawing.Size(157, 223);
            this.tvCountriesAndCities.TabIndex = 1;
            // 
            // tbSearchCountry
            // 
            this.tbSearchCountry.Location = new System.Drawing.Point(6, 17);
            this.tbSearchCountry.Name = "tbSearchCountry";
            this.tbSearchCountry.Size = new System.Drawing.Size(90, 20);
            this.tbSearchCountry.TabIndex = 2;
            // 
            // btnSearchCountry
            // 
            this.btnSearchCountry.Location = new System.Drawing.Point(6, 43);
            this.btnSearchCountry.Name = "btnSearchCountry";
            this.btnSearchCountry.Size = new System.Drawing.Size(90, 23);
            this.btnSearchCountry.TabIndex = 3;
            this.btnSearchCountry.Text = "Search Country";
            this.btnSearchCountry.UseVisualStyleBackColor = true;
            this.btnSearchCountry.Click += new System.EventHandler(this.SearchCountry_Click);
            // 
            // btnFilterByPopulation
            // 
            this.btnFilterByPopulation.Location = new System.Drawing.Point(350, 19);
            this.btnFilterByPopulation.Name = "btnFilterByPopulation";
            this.btnFilterByPopulation.Size = new System.Drawing.Size(90, 41);
            this.btnFilterByPopulation.TabIndex = 4;
            this.btnFilterByPopulation.Text = "Filter By Population";
            this.btnFilterByPopulation.UseVisualStyleBackColor = true;
            this.btnFilterByPopulation.Click += new System.EventHandler(this.FilterByPopulation_Click);
            // 
            // dgvFilteredCities
            // 
            this.dgvFilteredCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilteredCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityName,
            this.CityPopulation,
            this.CityCountryName});
            this.dgvFilteredCities.Location = new System.Drawing.Point(6, 16);
            this.dgvFilteredCities.Name = "dgvFilteredCities";
            this.dgvFilteredCities.Size = new System.Drawing.Size(344, 150);
            this.dgvFilteredCities.TabIndex = 5;
            // 
            // CityName
            // 
            this.CityName.HeaderText = "City Name";
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            // 
            // CityPopulation
            // 
            this.CityPopulation.HeaderText = "Population";
            this.CityPopulation.Name = "CityPopulation";
            this.CityPopulation.ReadOnly = true;
            // 
            // CityCountryName
            // 
            this.CityCountryName.HeaderText = "Country Name";
            this.CityCountryName.Name = "CityCountryName";
            this.CityCountryName.ReadOnly = true;
            // 
            // btnFilterBySeaNames
            // 
            this.btnFilterBySeaNames.Location = new System.Drawing.Point(133, 26);
            this.btnFilterBySeaNames.Name = "btnFilterBySeaNames";
            this.btnFilterBySeaNames.Size = new System.Drawing.Size(90, 41);
            this.btnFilterBySeaNames.TabIndex = 6;
            this.btnFilterBySeaNames.Text = "Filter By Sea Names";
            this.btnFilterBySeaNames.UseVisualStyleBackColor = true;
            this.btnFilterBySeaNames.Click += new System.EventHandler(this.FilterBySeaNames_Click);
            // 
            // lbFilterBySeaNames
            // 
            this.lbFilterBySeaNames.FormattingEnabled = true;
            this.lbFilterBySeaNames.Location = new System.Drawing.Point(6, 19);
            this.lbFilterBySeaNames.Name = "lbFilterBySeaNames";
            this.lbFilterBySeaNames.Size = new System.Drawing.Size(121, 147);
            this.lbFilterBySeaNames.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFilterBySeaNames);
            this.groupBox1.Controls.Add(this.btnFilterBySeaNames);
            this.groupBox1.Location = new System.Drawing.Point(574, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question-5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvFilteredCities);
            this.groupBox2.Controls.Add(this.btnFilterByPopulation);
            this.groupBox2.Location = new System.Drawing.Point(119, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question-4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchCountry);
            this.groupBox3.Controls.Add(this.tbSearchCountry);
            this.groupBox3.Location = new System.Drawing.Point(13, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 172);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question-3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFilterByCountryAndCityNames);
            this.groupBox4.Controls.Add(this.lbFilterByCountryAndCityNames);
            this.groupBox4.Location = new System.Drawing.Point(814, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 171);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Question-6";
            // 
            // btnFilterByCountryAndCityNames
            // 
            this.btnFilterByCountryAndCityNames.Location = new System.Drawing.Point(115, 15);
            this.btnFilterByCountryAndCityNames.Name = "btnFilterByCountryAndCityNames";
            this.btnFilterByCountryAndCityNames.Size = new System.Drawing.Size(65, 41);
            this.btnFilterByCountryAndCityNames.TabIndex = 8;
            this.btnFilterByCountryAndCityNames.Text = "Filter By CountryN";
            this.btnFilterByCountryAndCityNames.UseVisualStyleBackColor = true;
            this.btnFilterByCountryAndCityNames.Click += new System.EventHandler(this.FilterByCountryAndCityNames_Click);
            // 
            // lbFilterByCountryAndCityNames
            // 
            this.lbFilterByCountryAndCityNames.FormattingEnabled = true;
            this.lbFilterByCountryAndCityNames.Location = new System.Drawing.Point(6, 16);
            this.lbFilterByCountryAndCityNames.Name = "lbFilterByCountryAndCityNames";
            this.lbFilterByCountryAndCityNames.Size = new System.Drawing.Size(103, 147);
            this.lbFilterByCountryAndCityNames.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 509);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvCountriesAndCities);
            this.Controls.Add(this.dgvCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredCities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountries;
        private System.Windows.Forms.TreeView tvCountriesAndCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopulationGrowth;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfantMortality;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDPAgri;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDPTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inflation;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndepDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Government;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarCode;
        private System.Windows.Forms.TextBox tbSearchCountry;
        private System.Windows.Forms.Button btnSearchCountry;
        private System.Windows.Forms.Button btnFilterByPopulation;
        private System.Windows.Forms.DataGridView dgvFilteredCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityPopulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCountryName;
        private System.Windows.Forms.Button btnFilterBySeaNames;
        private System.Windows.Forms.ListBox lbFilterBySeaNames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFilterByCountryAndCityNames;
        private System.Windows.Forms.ListBox lbFilterByCountryAndCityNames;
    }
}

