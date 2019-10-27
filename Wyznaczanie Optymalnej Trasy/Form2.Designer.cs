using System.Collections.Generic;

namespace Wyznaczanie_Optymalnej_Trasy
{
    partial class AddCustomerForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LatBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LocalBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BuildingBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LenBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ZipCodeBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(445, 92);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(515, 38);
            this.NameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szerokość geograficzna:";
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(445, 162);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(515, 38);
            this.StreetBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Długość geograficzna";
            // 
            // LatBox
            // 
            this.LatBox.Location = new System.Drawing.Point(445, 232);
            this.LatBox.Name = "LatBox";
            this.LatBox.Size = new System.Drawing.Size(515, 38);
            this.LatBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numer budynku";
            // 
            // LocalBox
            // 
            this.LocalBox.Location = new System.Drawing.Point(445, 463);
            this.LocalBox.Name = "LocalBox";
            this.LocalBox.Size = new System.Drawing.Size(515, 38);
            this.LocalBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numer lokalu:";
            // 
            // BuildingBox
            // 
            this.BuildingBox.Location = new System.Drawing.Point(445, 385);
            this.BuildingBox.Name = "BuildingBox";
            this.BuildingBox.Size = new System.Drawing.Size(515, 38);
            this.BuildingBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kod pocztowy:";
            // 
            // LenBox
            // 
            this.LenBox.Location = new System.Drawing.Point(445, 303);
            this.LenBox.Name = "LenBox";
            this.LenBox.Size = new System.Drawing.Size(515, 38);
            this.LenBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 606);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Miasto:";
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(445, 683);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(515, 38);
            this.CountryBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 683);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kraj:";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(445, 606);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(515, 38);
            this.CityBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ulica:";
            // 
            // ZipCodeBox
            // 
            this.ZipCodeBox.Location = new System.Drawing.Point(445, 535);
            this.ZipCodeBox.Name = "ZipCodeBox";
            this.ZipCodeBox.Size = new System.Drawing.Size(515, 38);
            this.ZipCodeBox.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(445, 792);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(515, 75);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Zatwierdź";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1293, 946);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ZipCodeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LocalBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BuildingBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LenBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LatBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Name = "AddCustomerForm";
            this.Text = "Dodaj Odbiorcę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeAdditional()
        {
            this.CoordinatesBoxes = new List<System.Windows.Forms.TextBox> { this.LatBox, this.LenBox };
            this.AddressBoxes = new List<System.Windows.Forms.TextBox> {
                this.StreetBox,
                this.BuildingBox,
                this.LocalBox,
                this.CountryBox,
                this.CityBox,
                this.ZipCodeBox
            };
        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LatBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LocalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BuildingBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LenBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ZipCodeBox;
        private System.Windows.Forms.Button AddButton;
        private List<System.Windows.Forms.TextBox> CoordinatesBoxes;
        private List<System.Windows.Forms.TextBox> AddressBoxes;
    }
}