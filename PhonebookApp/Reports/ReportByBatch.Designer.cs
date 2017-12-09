namespace PhonebookApp.Reports
{
    partial class ReportByBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportByBatch));
            this.getButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.batchIdCombobox = new System.Windows.Forms.ComboBox();
            this.PortraitRadioButton = new System.Windows.Forms.RadioButton();
            this.LandscapeRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // getButton
            // 
            this.getButton.BackgroundImage = global::PhonebookApp.Properties.Resources.whiteyglossyrectanglebuttonmd;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.getButton.ForeColor = System.Drawing.Color.Blue;
            this.getButton.Location = new System.Drawing.Point(210, 199);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(108, 43);
            this.getButton.TabIndex = 0;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(56, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Batch Id   :";
            // 
            // batchIdCombobox
            // 
            this.batchIdCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.batchIdCombobox.FormattingEnabled = true;
            this.batchIdCombobox.Location = new System.Drawing.Point(171, 70);
            this.batchIdCombobox.Name = "batchIdCombobox";
            this.batchIdCombobox.Size = new System.Drawing.Size(222, 32);
            this.batchIdCombobox.TabIndex = 2;
            this.batchIdCombobox.SelectedIndexChanged += new System.EventHandler(this.batchIdCombobox_SelectedIndexChanged);
            // 
            // PortraitRadioButton
            // 
            this.PortraitRadioButton.AutoSize = true;
            this.PortraitRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.PortraitRadioButton.Location = new System.Drawing.Point(144, 118);
            this.PortraitRadioButton.Name = "PortraitRadioButton";
            this.PortraitRadioButton.Size = new System.Drawing.Size(249, 28);
            this.PortraitRadioButton.TabIndex = 3;
            this.PortraitRadioButton.TabStop = true;
            this.PortraitRadioButton.Text = "Batch Report for Portrait";
            this.PortraitRadioButton.UseVisualStyleBackColor = true;
            this.PortraitRadioButton.CheckedChanged += new System.EventHandler(this.PortraitRadioButton_CheckedChanged);
            // 
            // LandscapeRadioButton
            // 
            this.LandscapeRadioButton.AutoSize = true;
            this.LandscapeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.LandscapeRadioButton.Location = new System.Drawing.Point(123, 152);
            this.LandscapeRadioButton.Name = "LandscapeRadioButton";
            this.LandscapeRadioButton.Size = new System.Drawing.Size(286, 28);
            this.LandscapeRadioButton.TabIndex = 4;
            this.LandscapeRadioButton.TabStop = true;
            this.LandscapeRadioButton.Text = "Batch Report for Landscape";
            this.LandscapeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReportByBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(503, 284);
            this.Controls.Add(this.LandscapeRadioButton);
            this.Controls.Add(this.PortraitRadioButton);
            this.Controls.Add(this.batchIdCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportByBatch";
            this.Text = "ReportByBatch";
            this.Load += new System.EventHandler(this.ReportByBatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox batchIdCombobox;
        private System.Windows.Forms.RadioButton PortraitRadioButton;
        private System.Windows.Forms.RadioButton LandscapeRadioButton;
    }
}