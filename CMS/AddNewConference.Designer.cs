namespace CMS
{
    partial class AddNewConference
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.conferenceName = new System.Windows.Forms.TextBox();
            this.conferenceVenue = new System.Windows.Forms.TextBox();
            this.conferenceDescription = new System.Windows.Forms.TextBox();
            this.conferenceCapacity = new System.Windows.Forms.NumericUpDown();
            this.conferenceDate = new System.Windows.Forms.DateTimePicker();
            this.createConference = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new Conference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Venue : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Capacity : ";
            // 
            // conferenceName
            // 
            this.conferenceName.Location = new System.Drawing.Point(473, 110);
            this.conferenceName.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceName.Name = "conferenceName";
            this.conferenceName.Size = new System.Drawing.Size(235, 22);
            this.conferenceName.TabIndex = 6;
            // 
            // conferenceVenue
            // 
            this.conferenceVenue.Location = new System.Drawing.Point(473, 214);
            this.conferenceVenue.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceVenue.Name = "conferenceVenue";
            this.conferenceVenue.Size = new System.Drawing.Size(235, 22);
            this.conferenceVenue.TabIndex = 8;
            // 
            // conferenceDescription
            // 
            this.conferenceDescription.Location = new System.Drawing.Point(473, 273);
            this.conferenceDescription.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceDescription.Multiline = true;
            this.conferenceDescription.Name = "conferenceDescription";
            this.conferenceDescription.Size = new System.Drawing.Size(235, 66);
            this.conferenceDescription.TabIndex = 9;
            // 
            // conferenceCapacity
            // 
            this.conferenceCapacity.Location = new System.Drawing.Point(473, 373);
            this.conferenceCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceCapacity.Name = "conferenceCapacity";
            this.conferenceCapacity.Size = new System.Drawing.Size(235, 22);
            this.conferenceCapacity.TabIndex = 10;
            // 
            // conferenceDate
            // 
            this.conferenceDate.CustomFormat = "MMMM dd, yyyy";
            this.conferenceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.conferenceDate.Location = new System.Drawing.Point(473, 165);
            this.conferenceDate.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceDate.MinDate = new System.DateTime(2025, 2, 1, 0, 0, 0, 0);
            this.conferenceDate.Name = "conferenceDate";
            this.conferenceDate.Size = new System.Drawing.Size(235, 22);
            this.conferenceDate.TabIndex = 13;
            this.conferenceDate.Value = new System.DateTime(2025, 2, 1, 0, 0, 0, 0);
            // 
            // createConference
            // 
            this.createConference.Location = new System.Drawing.Point(404, 434);
            this.createConference.Margin = new System.Windows.Forms.Padding(4);
            this.createConference.Name = "createConference";
            this.createConference.Size = new System.Drawing.Size(100, 28);
            this.createConference.TabIndex = 14;
            this.createConference.Text = "Create";
            this.createConference.UseVisualStyleBackColor = true;
            this.createConference.Click += new System.EventHandler(this.createConference_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 434);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNewConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createConference);
            this.Controls.Add(this.conferenceDate);
            this.Controls.Add(this.conferenceCapacity);
            this.Controls.Add(this.conferenceDescription);
            this.Controls.Add(this.conferenceVenue);
            this.Controls.Add(this.conferenceName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewConference";
            this.Text = "AddNewConference";
            ((System.ComponentModel.ISupportInitialize)(this.conferenceCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox conferenceName;
        private System.Windows.Forms.TextBox conferenceVenue;
        private System.Windows.Forms.TextBox conferenceDescription;
        private System.Windows.Forms.NumericUpDown conferenceCapacity;
        private System.Windows.Forms.DateTimePicker conferenceDate;
        private System.Windows.Forms.Button createConference;
        private System.Windows.Forms.Button button2;
    }
}