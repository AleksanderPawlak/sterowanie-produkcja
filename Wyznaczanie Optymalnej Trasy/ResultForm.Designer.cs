using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Wyznaczanie_Optymalnej_Trasy
{
    partial class ResultForm
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

        private void InitializeDynamicContent()
        {
            //TODO: refactor this ugly solution
            this.ResultListViewHeaders = new List<System.Windows.Forms.ColumnHeader>();
            List<List<string>> resultAddressesNames = new List<List<string>>();
            int maxCarAddresses = 0;

            int currentPosition = 0;
            for (int i = 0; i < Result.Car; i++)
            {
                int start = Array.IndexOf(Result.Road, 0, currentPosition);
                currentPosition = Array.IndexOf(Result.Road, 0, start + 1);
                List<string> carAddrssesNames = new List<string>();
                if ((currentPosition - start + 1) > maxCarAddresses) 
                { maxCarAddresses = currentPosition - start + 1; }

                for (int j = start; j <= currentPosition; j++)
                {
                    int cityIndex = Result.Road[j];
                    carAddrssesNames.Add(Addresses[cityIndex].Name);
                }

                resultAddressesNames.Add(carAddrssesNames);
            }

            for (int i = 0; i < Result.Car; i++)
            {
                var header = new System.Windows.Forms.ColumnHeader();
                header.Text = "Samochód nr " + (i + 1).ToString();
                header.Width = 200;
                this.ResultListViewHeaders.Add(header);
                this.ResultListView.Columns.Add(header);
            }

            for (int i = 0; i < maxCarAddresses; i++)
            {
                List<string> row = new List<string>();

                for (int j = 0; j < Result.Car; j++)
                {
                    row.Add(resultAddressesNames[j].ElementAtOrDefault(i));
                }

                var listviewItem = new ListViewItem(row.ToArray());
                this.ResultListView.Items.Add(listviewItem);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ResultListView
            // 
            this.ResultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(0, 0);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(1630, 810);
            this.ResultListView.TabIndex = 0;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 810);
            this.Controls.Add(this.ResultListView);
            this.Name = "ResultForm";
            this.Text = "Wynik";
            this.ResumeLayout(false);

        }

        private ListView ResultListView;

        #endregion

        private List<System.Windows.Forms.ColumnHeader> ResultListViewHeaders;
    }
}