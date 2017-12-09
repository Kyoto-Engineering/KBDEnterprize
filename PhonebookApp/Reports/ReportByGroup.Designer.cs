namespace PhonebookApp.Reports
{
    partial class ReportByGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportByGroup));
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.workingRadioButton = new System.Windows.Forms.RadioButton();
            this.resedentialRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // groupComboBox
            // 
            this.groupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(167, 36);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(307, 32);
            this.groupComboBox.TabIndex = 0;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.getButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(88, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group";
            // 
            // getButton
            // 
            this.getButton.BackgroundImage = global::PhonebookApp.Properties.Resources.whiteyglossyrectanglebuttonmd;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.getButton.ForeColor = System.Drawing.Color.Blue;
            this.getButton.Location = new System.Drawing.Point(227, 174);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(101, 39);
            this.getButton.TabIndex = 4;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // workingRadioButton
            // 
            this.workingRadioButton.AutoSize = true;
            this.workingRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.workingRadioButton.Location = new System.Drawing.Point(201, 82);
            this.workingRadioButton.Name = "workingRadioButton";
            this.workingRadioButton.Size = new System.Drawing.Size(188, 28);
            this.workingRadioButton.TabIndex = 5;
            this.workingRadioButton.TabStop = true;
            this.workingRadioButton.Text = "Working Address";
            this.workingRadioButton.UseVisualStyleBackColor = true;
            // 
            // resedentialRadioButton
            // 
            this.resedentialRadioButton.AutoSize = true;
            this.resedentialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.resedentialRadioButton.Location = new System.Drawing.Point(201, 116);
            this.resedentialRadioButton.Name = "resedentialRadioButton";
            this.resedentialRadioButton.Size = new System.Drawing.Size(214, 28);
            this.resedentialRadioButton.TabIndex = 6;
            this.resedentialRadioButton.TabStop = true;
            this.resedentialRadioButton.Text = "Residential Address";
            this.resedentialRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReportByGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(532, 281);
            this.Controls.Add(this.resedentialRadioButton);
            this.Controls.Add(this.workingRadioButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportByGroup";
            this.Text = "ReportByGroup";
            this.Load += new System.EventHandler(this.ReportByGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.RadioButton workingRadioButton;
        private System.Windows.Forms.RadioButton resedentialRadioButton;
    }
}