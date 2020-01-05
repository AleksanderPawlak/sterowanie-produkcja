namespace Wyznaczanie_Optymalnej_Trasy
{
    partial class MainForm
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustomersList = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CustomerListview = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.langitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.building = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zipcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.DimensionsRefreshButton = new System.Windows.Forms.Button();
            this.HomeAddressListView = new System.Windows.Forms.ListView();
            this.HomeLangitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeLongitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeBuildingNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeLocalNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomeCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Algorithm = new System.Windows.Forms.TabPage();
            this.ComputeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.CustomersListCheck = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarNumberLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CarsNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CarNumberTextBox = new System.Windows.Forms.TextBox();
            this.carsListPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.carsListView = new System.Windows.Forms.ListView();
            this.modelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brandHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carCostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kmCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CarFleetExpansionAlgorithmTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.computeCarFleetAlgorithmButton = new System.Windows.Forms.Button();
            this.weeksNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentCarsNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeHourRateInput = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.PenaltyInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.CustomersList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Algorithm.SuspendLayout();
            this.ComputeTableLayoutPanel.SuspendLayout();
            this.CarNumberLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsNumberNumericUpDown)).BeginInit();
            this.carsListPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CarFleetExpansionAlgorithmTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeksNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarsNumberNumericUpDown)).BeginInit();
            this.employeeHourRateInput.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CustomersList);
            this.tabControl1.Controls.Add(this.Algorithm);
            this.tabControl1.Controls.Add(this.carsListPage);
            this.tabControl1.Controls.Add(this.CarFleetExpansionAlgorithmTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1668, 1412);
            this.tabControl1.TabIndex = 0;
            // 
            // CustomersList
            // 
            this.CustomersList.Controls.Add(this.tableLayoutPanel1);
            this.CustomersList.Location = new System.Drawing.Point(4, 40);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersList.Size = new System.Drawing.Size(1660, 1368);
            this.CustomersList.TabIndex = 0;
            this.CustomersList.Text = "Lista odbiorców";
            this.CustomersList.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CustomerListview, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddCustomerButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DimensionsRefreshButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.HomeAddressListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1654, 1362);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1648, 38);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Lista odbiorców";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerListview
            // 
            this.CustomerListview.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.CustomerListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.langitude,
            this.longitude,
            this.street,
            this.building,
            this.local,
            this.zipcode,
            this.city});
            this.CustomerListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerListview.HideSelection = false;
            this.CustomerListview.Location = new System.Drawing.Point(3, 244);
            this.CustomerListview.Name = "CustomerListview";
            this.CustomerListview.Size = new System.Drawing.Size(1648, 904);
            this.CustomerListview.TabIndex = 0;
            this.CustomerListview.UseCompatibleStateImageBehavior = false;
            this.CustomerListview.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Nazwa";
            this.name.Width = 164;
            // 
            // langitude
            // 
            this.langitude.Text = "szerokość geogr.";
            this.langitude.Width = 221;
            // 
            // longitude
            // 
            this.longitude.Text = "długość geogr.";
            this.longitude.Width = 215;
            // 
            // street
            // 
            this.street.Text = "ulica";
            this.street.Width = 98;
            // 
            // building
            // 
            this.building.Text = "nr budynku";
            this.building.Width = 164;
            // 
            // local
            // 
            this.local.Text = "nr lokalu";
            this.local.Width = 162;
            // 
            // zipcode
            // 
            this.zipcode.Text = "kod pocztowy";
            this.zipcode.Width = 186;
            // 
            // city
            // 
            this.city.Text = "miasto";
            this.city.Width = 267;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerButton.Location = new System.Drawing.Point(3, 1258);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(1648, 101);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Dodaj odbiorcę";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // DimensionsRefreshButton
            // 
            this.DimensionsRefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DimensionsRefreshButton.Location = new System.Drawing.Point(3, 1154);
            this.DimensionsRefreshButton.Name = "DimensionsRefreshButton";
            this.DimensionsRefreshButton.Size = new System.Drawing.Size(1648, 98);
            this.DimensionsRefreshButton.TabIndex = 2;
            this.DimensionsRefreshButton.Text = "Przelicz odległości";
            this.DimensionsRefreshButton.UseVisualStyleBackColor = true;
            this.DimensionsRefreshButton.Click += new System.EventHandler(this.DimensionsRefreshButton_Click);
            // 
            // HomeAddressListView
            // 
            this.HomeAddressListView.BackColor = System.Drawing.SystemColors.Menu;
            this.HomeAddressListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HomeLangitude,
            this.HomeLongitude,
            this.HomeStreet,
            this.HomeBuildingNumber,
            this.HomeLocalNumber,
            this.HomeZipCode,
            this.HomeCity});
            this.HomeAddressListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeAddressListView.HideSelection = false;
            this.HomeAddressListView.Location = new System.Drawing.Point(3, 40);
            this.HomeAddressListView.Name = "HomeAddressListView";
            this.HomeAddressListView.Size = new System.Drawing.Size(1648, 154);
            this.HomeAddressListView.TabIndex = 3;
            this.HomeAddressListView.UseCompatibleStateImageBehavior = false;
            this.HomeAddressListView.View = System.Windows.Forms.View.Details;
            // 
            // HomeLangitude
            // 
            this.HomeLangitude.Text = "szerokość geogr.";
            this.HomeLangitude.Width = 225;
            // 
            // HomeLongitude
            // 
            this.HomeLongitude.Text = "długość geogr.";
            this.HomeLongitude.Width = 213;
            // 
            // HomeStreet
            // 
            this.HomeStreet.Text = "ulica";
            this.HomeStreet.Width = 90;
            // 
            // HomeBuildingNumber
            // 
            this.HomeBuildingNumber.Text = "nr budynku";
            this.HomeBuildingNumber.Width = 166;
            // 
            // HomeLocalNumber
            // 
            this.HomeLocalNumber.Text = "nr lokalu";
            this.HomeLocalNumber.Width = 159;
            // 
            // HomeZipCode
            // 
            this.HomeZipCode.Text = "kod pocztowy";
            this.HomeZipCode.Width = 184;
            // 
            // HomeCity
            // 
            this.HomeCity.Text = "miasto";
            this.HomeCity.Width = 288;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1648, 38);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Adres domowy";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Algorithm
            // 
            this.Algorithm.Controls.Add(this.ComputeTableLayoutPanel);
            this.Algorithm.Location = new System.Drawing.Point(4, 40);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Padding = new System.Windows.Forms.Padding(3);
            this.Algorithm.Size = new System.Drawing.Size(1660, 1368);
            this.Algorithm.TabIndex = 1;
            this.Algorithm.Text = "Wyznacz trasę";
            this.Algorithm.UseVisualStyleBackColor = true;
            // 
            // ComputeTableLayoutPanel
            // 
            this.ComputeTableLayoutPanel.ColumnCount = 1;
            this.ComputeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComputeTableLayoutPanel.Controls.Add(this.ComputeButton, 0, 2);
            this.ComputeTableLayoutPanel.Controls.Add(this.CustomersListCheck, 0, 0);
            this.ComputeTableLayoutPanel.Controls.Add(this.CarNumberLayoutPanel, 0, 1);
            this.ComputeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComputeTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ComputeTableLayoutPanel.Name = "ComputeTableLayoutPanel";
            this.ComputeTableLayoutPanel.RowCount = 3;
            this.ComputeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.17706F));
            this.ComputeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.ComputeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82294F));
            this.ComputeTableLayoutPanel.Size = new System.Drawing.Size(1654, 1362);
            this.ComputeTableLayoutPanel.TabIndex = 3;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComputeButton.Location = new System.Drawing.Point(3, 1197);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(1648, 162);
            this.ComputeButton.TabIndex = 2;
            this.ComputeButton.Text = "Wyznacz trasę";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // CustomersListCheck
            // 
            this.CustomersListCheck.CheckBoxes = true;
            this.CustomersListCheck.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.CustomersListCheck.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CustomersListCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersListCheck.HideSelection = false;
            this.CustomersListCheck.Location = new System.Drawing.Point(3, 3);
            this.CustomersListCheck.Name = "CustomersListCheck";
            this.CustomersListCheck.Size = new System.Drawing.Size(1648, 1132);
            this.CustomersListCheck.TabIndex = 1;
            this.CustomersListCheck.UseCompatibleStateImageBehavior = false;
            this.CustomersListCheck.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "szerokość geogr.";
            this.columnHeader2.Width = 221;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "długość geogr.";
            this.columnHeader3.Width = 215;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ulica";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "nr budynku";
            this.columnHeader5.Width = 164;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "nr lokalu";
            this.columnHeader6.Width = 162;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "kod pocztowy";
            this.columnHeader7.Width = 186;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "miasto";
            this.columnHeader8.Width = 267;
            // 
            // CarNumberLayoutPanel
            // 
            this.CarNumberLayoutPanel.ColumnCount = 2;
            this.CarNumberLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.41558F));
            this.CarNumberLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.58442F));
            this.CarNumberLayoutPanel.Controls.Add(this.CarsNumberNumericUpDown, 1, 0);
            this.CarNumberLayoutPanel.Controls.Add(this.CarNumberTextBox, 0, 0);
            this.CarNumberLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarNumberLayoutPanel.Location = new System.Drawing.Point(3, 1141);
            this.CarNumberLayoutPanel.Name = "CarNumberLayoutPanel";
            this.CarNumberLayoutPanel.RowCount = 1;
            this.CarNumberLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CarNumberLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.CarNumberLayoutPanel.Size = new System.Drawing.Size(1648, 50);
            this.CarNumberLayoutPanel.TabIndex = 3;
            // 
            // CarsNumberNumericUpDown
            // 
            this.CarsNumberNumericUpDown.AutoSize = true;
            this.CarsNumberNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarsNumberNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CarsNumberNumericUpDown.Location = new System.Drawing.Point(405, 3);
            this.CarsNumberNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CarsNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CarsNumberNumericUpDown.Name = "CarsNumberNumericUpDown";
            this.CarsNumberNumericUpDown.Size = new System.Drawing.Size(1240, 45);
            this.CarsNumberNumericUpDown.TabIndex = 0;
            this.CarsNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CarNumberTextBox
            // 
            this.CarNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CarNumberTextBox.Location = new System.Drawing.Point(3, 3);
            this.CarNumberTextBox.Name = "CarNumberTextBox";
            this.CarNumberTextBox.Size = new System.Drawing.Size(396, 31);
            this.CarNumberTextBox.TabIndex = 1;
            this.CarNumberTextBox.Text = "Liczba samochodow";
            this.CarNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carsListPage
            // 
            this.carsListPage.Controls.Add(this.tableLayoutPanel2);
            this.carsListPage.Location = new System.Drawing.Point(4, 40);
            this.carsListPage.Name = "carsListPage";
            this.carsListPage.Padding = new System.Windows.Forms.Padding(3);
            this.carsListPage.Size = new System.Drawing.Size(1660, 1368);
            this.carsListPage.TabIndex = 2;
            this.carsListPage.Text = "Lista samochodów";
            this.carsListPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.AddCarButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.carsListView, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.98964F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01037F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1654, 1362);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // AddCarButton
            // 
            this.AddCarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCarButton.Location = new System.Drawing.Point(3, 1228);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(1648, 131);
            this.AddCarButton.TabIndex = 0;
            this.AddCarButton.Text = "Dodaj samochód";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // carsListView
            // 
            this.carsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.modelHeader,
            this.brandHeader,
            this.carCostHeader,
            this.kmCost});
            this.carsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsListView.HideSelection = false;
            this.carsListView.Location = new System.Drawing.Point(3, 3);
            this.carsListView.Name = "carsListView";
            this.carsListView.Size = new System.Drawing.Size(1648, 1219);
            this.carsListView.TabIndex = 1;
            this.carsListView.UseCompatibleStateImageBehavior = false;
            this.carsListView.View = System.Windows.Forms.View.Details;
            // 
            // modelHeader
            // 
            this.modelHeader.Text = "model";
            this.modelHeader.Width = 179;
            // 
            // brandHeader
            // 
            this.brandHeader.Text = "marka";
            this.brandHeader.Width = 219;
            // 
            // carCostHeader
            // 
            this.carCostHeader.Text = "cena samochodu";
            this.carCostHeader.Width = 346;
            // 
            // kmCost
            // 
            this.kmCost.Text = "koszt na kilometr";
            this.kmCost.Width = 424;
            // 
            // CarFleetExpansionAlgorithmTab
            // 
            this.CarFleetExpansionAlgorithmTab.Controls.Add(this.tableLayoutPanel3);
            this.CarFleetExpansionAlgorithmTab.Location = new System.Drawing.Point(4, 40);
            this.CarFleetExpansionAlgorithmTab.Name = "CarFleetExpansionAlgorithmTab";
            this.CarFleetExpansionAlgorithmTab.Padding = new System.Windows.Forms.Padding(3);
            this.CarFleetExpansionAlgorithmTab.Size = new System.Drawing.Size(1660, 1368);
            this.CarFleetExpansionAlgorithmTab.TabIndex = 3;
            this.CarFleetExpansionAlgorithmTab.Text = "Algorytm decyzyjny";
            this.CarFleetExpansionAlgorithmTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.computeCarFleetAlgorithmButton, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.employeeHourRateInput, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.70187F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.583662F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.71448F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1654, 1362);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.currentCarsNumberNumericUpDown, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 242);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1648, 46);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.weeksNumberNumericUpDown, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 294);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1648, 46);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // computeCarFleetAlgorithmButton
            // 
            this.computeCarFleetAlgorithmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computeCarFleetAlgorithmButton.Location = new System.Drawing.Point(3, 346);
            this.computeCarFleetAlgorithmButton.Name = "computeCarFleetAlgorithmButton";
            this.computeCarFleetAlgorithmButton.Size = new System.Drawing.Size(1648, 93);
            this.computeCarFleetAlgorithmButton.TabIndex = 2;
            this.computeCarFleetAlgorithmButton.Text = "Oblicz";
            this.computeCarFleetAlgorithmButton.UseVisualStyleBackColor = true;
            this.computeCarFleetAlgorithmButton.Click += new System.EventHandler(this.computeCarFleetAlgorithmButton_Click);
            // 
            // weeksNumberNumericUpDown
            // 
            this.weeksNumberNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weeksNumberNumericUpDown.Location = new System.Drawing.Point(827, 3);
            this.weeksNumberNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weeksNumberNumericUpDown.Name = "weeksNumberNumericUpDown";
            this.weeksNumberNumericUpDown.Size = new System.Drawing.Size(818, 38);
            this.weeksNumberNumericUpDown.TabIndex = 0;
            // 
            // currentCarsNumberNumericUpDown
            // 
            this.currentCarsNumberNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentCarsNumberNumericUpDown.Location = new System.Drawing.Point(827, 3);
            this.currentCarsNumberNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.currentCarsNumberNumericUpDown.Name = "currentCarsNumberNumericUpDown";
            this.currentCarsNumberNumericUpDown.Size = new System.Drawing.Size(818, 38);
            this.currentCarsNumberNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualna liczba samochodów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(818, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba tygodni";
            // 
            // employeeHourRateInput
            // 
            this.employeeHourRateInput.ColumnCount = 2;
            this.employeeHourRateInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.employeeHourRateInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.employeeHourRateInput.Controls.Add(this.label3, 0, 0);
            this.employeeHourRateInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeHourRateInput.Location = new System.Drawing.Point(3, 190);
            this.employeeHourRateInput.Name = "employeeHourRateInput";
            this.employeeHourRateInput.RowCount = 1;
            this.employeeHourRateInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.employeeHourRateInput.Size = new System.Drawing.Size(1648, 46);
            this.employeeHourRateInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(818, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stawka godziowa pracownika";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.PenaltyInput, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1648, 46);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(818, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kwota kary za dzień spóżnienia";
            // 
            // PenaltyInput
            // 
            this.PenaltyInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PenaltyInput.Location = new System.Drawing.Point(827, 3);
            this.PenaltyInput.Name = "PenaltyInput";
            this.PenaltyInput.Size = new System.Drawing.Size(818, 38);
            this.PenaltyInput.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1668, 1412);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Wyznaczanie optymalnej trasy";
            this.tabControl1.ResumeLayout(false);
            this.CustomersList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Algorithm.ResumeLayout(false);
            this.ComputeTableLayoutPanel.ResumeLayout(false);
            this.CarNumberLayoutPanel.ResumeLayout(false);
            this.CarNumberLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsNumberNumericUpDown)).EndInit();
            this.carsListPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.CarFleetExpansionAlgorithmTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weeksNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentCarsNumberNumericUpDown)).EndInit();
            this.employeeHourRateInput.ResumeLayout(false);
            this.employeeHourRateInput.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomersList;
        private System.Windows.Forms.TabPage Algorithm;
        private System.Windows.Forms.ListView CustomersListCheck;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView CustomerListview;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader langitude;
        private System.Windows.Forms.ColumnHeader longitude;
        private System.Windows.Forms.ColumnHeader street;
        private System.Windows.Forms.ColumnHeader building;
        private System.Windows.Forms.ColumnHeader local;
        private System.Windows.Forms.ColumnHeader zipcode;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.Button DimensionsRefreshButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.ListView HomeAddressListView;
        private System.Windows.Forms.ColumnHeader HomeLangitude;
        private System.Windows.Forms.ColumnHeader HomeLongitude;
        private System.Windows.Forms.ColumnHeader HomeStreet;
        private System.Windows.Forms.ColumnHeader HomeBuildingNumber;
        private System.Windows.Forms.ColumnHeader HomeLocalNumber;
        private System.Windows.Forms.ColumnHeader HomeZipCode;
        private System.Windows.Forms.ColumnHeader HomeCity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel ComputeTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CarNumberLayoutPanel;
        private System.Windows.Forms.NumericUpDown CarsNumberNumericUpDown;
        private System.Windows.Forms.TextBox CarNumberTextBox;
        private System.Windows.Forms.TabPage carsListPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.ListView carsListView;
        private System.Windows.Forms.ColumnHeader modelHeader;
        private System.Windows.Forms.ColumnHeader brandHeader;
        private System.Windows.Forms.ColumnHeader carCostHeader;
        private System.Windows.Forms.ColumnHeader kmCost;
        private System.Windows.Forms.TabPage CarFleetExpansionAlgorithmTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown currentCarsNumberNumericUpDown;
        private System.Windows.Forms.NumericUpDown weeksNumberNumericUpDown;
        private System.Windows.Forms.Button computeCarFleetAlgorithmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel employeeHourRateInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PenaltyInput;
    }
}

