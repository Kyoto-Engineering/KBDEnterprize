﻿namespace PhonebookApp.Reports
{
    partial class ListOfContactByReligion
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
            this.workingRadioButton = new System.Windows.Forms.RadioButton();
            this.getButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.religionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // workingRadioButton
            // 
            this.workingRadioButton.AutoSize = true;
            this.workingRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.workingRadioButton.Location = new System.Drawing.Point(167, 135);
            this.workingRadioButton.Name = "workingRadioButton";
            this.workingRadioButton.Size = new System.Drawing.Size(188, 28);
            this.workingRadioButton.TabIndex = 9;
            this.workingRadioButton.TabStop = true;
            this.workingRadioButton.Text = "Working Address";
            this.workingRadioButton.UseVisualStyleBackColor = true;
            // 
            // getButton
            // 
            this.getButton.BackgroundImage = global::PhonebookApp.Properties.Resources.whiteyglossyrectanglebuttonmd;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.getButton.Location = new System.Drawing.Point(203, 190);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(125, 41);
            this.getButton.TabIndex = 8;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Religion";
            // 
            // religionComboBox
            // 
            this.religionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.religionComboBox.FormattingEnabled = true;
            this.religionComboBox.Location = new System.Drawing.Point(146, 87);
            this.religionComboBox.Name = "religionComboBox";
            this.religionComboBox.Size = new System.Drawing.Size(262, 32);
            this.religionComboBox.TabIndex = 6;
            this.religionComboBox.SelectedIndexChanged += new System.EventHandler(this.religionComboBox_SelectedIndexChanged_1);
            // 
            // ListOfContactByReligion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(497, 312);
            this.Controls.Add(this.workingRadioButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.religionComboBox);
            this.Name = "ListOfContactByReligion";
            this.Text = "ListOfContactByReligion";
            this.Load += new System.EventHandler(this.ListOfContactByReligion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton workingRadioButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox religionComboBox;
    }
}