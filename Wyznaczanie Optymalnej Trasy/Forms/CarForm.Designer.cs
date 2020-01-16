namespace Wyznaczanie_Optymalnej_Trasy.Forms
{
    partial class CarForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carCostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kmCostTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(312, 707);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(452, 81);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(97, 177);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(101, 32);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(441, 177);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(496, 38);
            this.modelTextBox.TabIndex = 2;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(441, 284);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(496, 38);
            this.brandTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marka:";
            // 
            // carCostTextBox
            // 
            this.carCostTextBox.Location = new System.Drawing.Point(441, 399);
            this.carCostTextBox.Name = "carCostTextBox";
            this.carCostTextBox.Size = new System.Drawing.Size(496, 38);
            this.carCostTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena samochodu:";
            // 
            // kmCostTextBox
            // 
            this.kmCostTextBox.Location = new System.Drawing.Point(441, 514);
            this.kmCostTextBox.Name = "kmCostTextBox";
            this.kmCostTextBox.Size = new System.Drawing.Size(496, 38);
            this.kmCostTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Koszt na kilometr:";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 892);
            this.Controls.Add(this.kmCostTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carCostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.SaveButton);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carCostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kmCostTextBox;
        private System.Windows.Forms.Label label4;
    }
}