namespace Wyznaczanie_Optymalnej_Trasy
{
    partial class Form1
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
            this.DimensionsRefreshButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomerListview = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.langitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.building = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zipcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Algorithm = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.CustomersList.SuspendLayout();
            this.Algorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CustomersList);
            this.tabControl1.Controls.Add(this.Algorithm);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1560, 1163);
            this.tabControl1.TabIndex = 0;
            // 
            // CustomersList
            // 
            this.CustomersList.Controls.Add(this.DimensionsRefreshButton);
            this.CustomersList.Controls.Add(this.AddCustomerButton);
            this.CustomersList.Controls.Add(this.CustomerListview);
            this.CustomersList.Location = new System.Drawing.Point(4, 40);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersList.Size = new System.Drawing.Size(1552, 1119);
            this.CustomersList.TabIndex = 0;
            this.CustomersList.Text = "Lista odbiorców";
            this.CustomersList.UseVisualStyleBackColor = true;
            // 
            // DimensionsRefreshButton
            // 
            this.DimensionsRefreshButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DimensionsRefreshButton.Location = new System.Drawing.Point(3, 908);
            this.DimensionsRefreshButton.Name = "DimensionsRefreshButton";
            this.DimensionsRefreshButton.Size = new System.Drawing.Size(1546, 104);
            this.DimensionsRefreshButton.TabIndex = 2;
            this.DimensionsRefreshButton.Text = "Przelicz odległości";
            this.DimensionsRefreshButton.UseVisualStyleBackColor = true;
            this.DimensionsRefreshButton.Click += new System.EventHandler(this.DimensionsRefreshButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCustomerButton.Location = new System.Drawing.Point(3, 1012);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(1546, 104);
            this.AddCustomerButton.TabIndex = 1;
            this.AddCustomerButton.Text = "Dodaj odbiorcę";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
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
            this.CustomerListview.Location = new System.Drawing.Point(3, 3);
            this.CustomerListview.Name = "CustomerListview";
            this.CustomerListview.Size = new System.Drawing.Size(1546, 1113);
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
            // Algorithm
            // 
            this.Algorithm.Controls.Add(this.ComputeButton);
            this.Algorithm.Controls.Add(this.CustomersListCheck);
            this.Algorithm.Location = new System.Drawing.Point(4, 40);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Padding = new System.Windows.Forms.Padding(3);
            this.Algorithm.Size = new System.Drawing.Size(1552, 1119);
            this.Algorithm.TabIndex = 1;
            this.Algorithm.Text = "Wyznacz trasę";
            this.Algorithm.UseVisualStyleBackColor = true;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComputeButton.Location = new System.Drawing.Point(3, 1009);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(1546, 107);
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
            this.CustomersListCheck.Size = new System.Drawing.Size(1546, 1113);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1560, 1163);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Wyznaczanie optymalnej trasy";
            this.tabControl1.ResumeLayout(false);
            this.CustomersList.ResumeLayout(false);
            this.Algorithm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomersList;
        private System.Windows.Forms.TabPage Algorithm;
        private System.Windows.Forms.ListView CustomerListview;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader langitude;
        private System.Windows.Forms.ColumnHeader longitude;
        private System.Windows.Forms.ColumnHeader street;
        private System.Windows.Forms.ColumnHeader building;
        private System.Windows.Forms.ColumnHeader local;
        private System.Windows.Forms.ColumnHeader zipcode;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button DimensionsRefreshButton;
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
    }
}

