using System;
using System.Collections.Generic;
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
            this.ResultTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ResultListViews = new List<System.Windows.Forms.ListView>();

            this.ResultTableLayout.ColumnCount = Result.Car;
            this.ResultTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ResultTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTableLayout.Location = new System.Drawing.Point(3, 3);
            this.ResultTableLayout.Name = "ResultTableLayout";
            this.ResultTableLayout.RowCount = 1;
            this.ResultTableLayout.Size = new System.Drawing.Size(1546, 1113);
            this.ResultTableLayout.TabIndex = 3;

            int currentPosition = 0;
            for(int i = 0; i < Result.Car; i++)
            {
                var CarResultList = new System.Windows.Forms.ListView();
                CarResultList.Cursor = System.Windows.Forms.Cursors.Arrow;
                CarResultList.Dock = System.Windows.Forms.DockStyle.Fill;
                CarResultList.HideSelection = false;
                CarResultList.Location = new System.Drawing.Point(3, 3);
                CarResultList.Name = "CarResultList";
                CarResultList.Size = new System.Drawing.Size(1546, 1113);
                CarResultList.TabIndex = 1;
                CarResultList.UseCompatibleStateImageBehavior = false;
                CarResultList.View = System.Windows.Forms.View.LargeIcon;

                int start = Array.IndexOf(Result.Road, 0, currentPosition);
                currentPosition = Array.IndexOf(Result.Road, 0, start + 1);

                for (int j = 0; j < currentPosition; j++)
                {
                    int cityIndex = Result.Road[j];
                    string[] row = { Addresses[cityIndex].Name };
                    var listviewItem = new ListViewItem(row);
                    CarResultList.Items.Add(listviewItem);
                }

                ResultTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                this.ResultListViews.Add(CarResultList);
                this.ResultTableLayout.Controls.Add(this.ResultListViews[i], i, 0);
            }

            this.ResultTableLayout.ResumeLayout(false);
            this.ResultTableLayout.PerformLayout();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 810);
            this.Name = "ResultForm";
            this.Text = "Wynik";
            this.ResumeLayout(true);

        }

        #endregion


        private System.Windows.Forms.TableLayoutPanel ResultTableLayout;
        private List<System.Windows.Forms.ListView> ResultListViews;
    }
}