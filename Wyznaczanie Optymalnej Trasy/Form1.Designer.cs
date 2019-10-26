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
            this.CustomerListview = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.langitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.building = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.local = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zipcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Algorithm = new System.Windows.Forms.TabPage();
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.CustomersList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CustomersList);
            this.tabControl1.Controls.Add(this.Algorithm);
            this.tabControl1.Location = new System.Drawing.Point(30, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1518, 1105);
            this.tabControl1.TabIndex = 0;
            // 
            // CustomersList
            // 
            this.CustomersList.Controls.Add(this.CustomerListview);
            this.CustomersList.Location = new System.Drawing.Point(4, 40);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersList.Size = new System.Drawing.Size(1510, 1061);
            this.CustomersList.TabIndex = 0;
            this.CustomersList.Text = "Lista odbiorców";
            this.CustomersList.UseVisualStyleBackColor = true;
            // 
            // CustomerListview
            // 
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
            this.CustomerListview.Size = new System.Drawing.Size(1504, 1055);
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
            // Algorithm
            // 
            this.Algorithm.Location = new System.Drawing.Point(4, 40);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Padding = new System.Windows.Forms.Padding(3);
            this.Algorithm.Size = new System.Drawing.Size(1510, 1061);
            this.Algorithm.TabIndex = 1;
            this.Algorithm.Text = "Wyznacz trasę";
            this.Algorithm.UseVisualStyleBackColor = true;
            // 
            // city
            // 
            this.city.Text = "miasto";
            this.city.Width = 267;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1163);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.CustomersList.ResumeLayout(false);
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
    }
}

