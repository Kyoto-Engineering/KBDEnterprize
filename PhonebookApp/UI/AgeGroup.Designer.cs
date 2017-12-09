﻿namespace PhonebookApp.UI
{
    partial class AgeGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeGroup));
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtAgeGroup = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveAgeGroup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCategoryName.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryName.Location = new System.Drawing.Point(36, 19);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(112, 24);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Age Group";
            // 
            // txtAgeGroup
            // 
            this.txtAgeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAgeGroup.Location = new System.Drawing.Point(22, 31);
            this.txtAgeGroup.MaxLength = 90;
            this.txtAgeGroup.Name = "txtAgeGroup";
            this.txtAgeGroup.Size = new System.Drawing.Size(367, 29);
            this.txtAgeGroup.TabIndex = 1;
            this.txtAgeGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAgeGroup_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAgeGroup);
            this.groupBox1.Location = new System.Drawing.Point(31, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSaveAgeGroup
            // 
            this.btnSaveAgeGroup.BackColor = System.Drawing.Color.Lime;
            this.btnSaveAgeGroup.BackgroundImage = global::PhonebookApp.Properties.Resources.whiteyglossyrectanglebuttonmd;
            this.btnSaveAgeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveAgeGroup.ForeColor = System.Drawing.Color.Blue;
            this.btnSaveAgeGroup.Location = new System.Drawing.Point(306, 173);
            this.btnSaveAgeGroup.Name = "btnSaveAgeGroup";
            this.btnSaveAgeGroup.Size = new System.Drawing.Size(124, 70);
            this.btnSaveAgeGroup.TabIndex = 1;
            this.btnSaveAgeGroup.Text = "Save ";
            this.btnSaveAgeGroup.UseVisualStyleBackColor = false;
            this.btnSaveAgeGroup.Click += new System.EventHandler(this.btnSaveAgeGroup_Click);
            // 
            // AgeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(502, 277);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveAgeGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgeGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgeGroup";
            this.Load += new System.EventHandler(this.AgeGroup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtAgeGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveAgeGroup;
    }
}