﻿namespace Wyznaczanie_Optymalnej_Trasy
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
            this.tabControl1.SuspendLayout();
            this.CustomersList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Algorithm.SuspendLayout();
            this.ComputeTableLayoutPanel.SuspendLayout();
            this.CarNumberLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsNumberNumericUpDown)).BeginInit();
            this.carsListPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CustomersList);
            this.tabControl1.Controls.Add(this.Algorithm);
            this.tabControl1.Controls.Add(this.carsListPage);
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
            // 
            // brandHeader
            // 
            this.brandHeader.Text = "marka";
            // 
            // carCostHeader
            // 
            this.carCostHeader.Text = "cena samochodu";
            // 
            // kmCost
            // 
            this.kmCost.Text = "koszt na kilometr";
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
    }
}
