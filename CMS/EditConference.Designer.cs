namespace CMS
{
    partial class EditConference
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
            this.button2 = new System.Windows.Forms.Button();
            this.conferenceUpdate = new System.Windows.Forms.Button();
            this.conferenceDate = new System.Windows.Forms.DateTimePicker();
            this.conferenceCapacity = new System.Windows.Forms.NumericUpDown();
            this.conferenceDescription = new System.Windows.Forms.TextBox();
            this.conferenceVenue = new System.Windows.Forms.TextBox();
            this.conferenceName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 430);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 28;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // conferenceUpdate
            // 
            this.conferenceUpdate.Location = new System.Drawing.Point(432, 430);
            this.conferenceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceUpdate.Name = "conferenceUpdate";
            this.conferenceUpdate.Size = new System.Drawing.Size(100, 28);
            this.conferenceUpdate.TabIndex = 27;
            this.conferenceUpdate.Text = "Update";
            this.conferenceUpdate.UseVisualStyleBackColor = true;
            this.conferenceUpdate.Click += new System.EventHandler(this.conferenceUpdate_Click);
            // 
            // conferenceDate
            // 
            this.conferenceDate.CustomFormat = "MMMM dd, yyyy";
            this.conferenceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.conferenceDate.Location = new System.Drawing.Point(496, 164);
            this.conferenceDate.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceDate.Name = "conferenceDate";
            this.conferenceDate.Size = new System.Drawing.Size(204, 22);
            this.conferenceDate.TabIndex = 26;
            this.conferenceDate.Value = new System.DateTime(2025, 1, 24, 22, 8, 1, 0);
            // 
            // conferenceCapacity
            // 
            this.conferenceCapacity.Location = new System.Drawing.Point(496, 357);
            this.conferenceCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceCapacity.Name = "conferenceCapacity";
            this.conferenceCapacity.Size = new System.Drawing.Size(160, 22);
            this.conferenceCapacity.TabIndex = 25;
            // 
            // conferenceDescription
            // 
            this.conferenceDescription.Location = new System.Drawing.Point(496, 258);
            this.conferenceDescription.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceDescription.Multiline = true;
            this.conferenceDescription.Name = "conferenceDescription";
            this.conferenceDescription.Size = new System.Drawing.Size(235, 66);
            this.conferenceDescription.TabIndex = 24;
            // 
            // conferenceVenue
            // 
            this.conferenceVenue.Location = new System.Drawing.Point(496, 213);
            this.conferenceVenue.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceVenue.Name = "conferenceVenue";
            this.conferenceVenue.Size = new System.Drawing.Size(132, 22);
            this.conferenceVenue.TabIndex = 23;
            // 
            // conferenceName
            // 
            this.conferenceName.Location = new System.Drawing.Point(496, 112);
            this.conferenceName.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceName.Name = "conferenceName";
            this.conferenceName.Size = new System.Drawing.Size(132, 22);
            this.conferenceName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Capacity : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Venue : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Edit Conference";
            // 
            // EditConference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.conferenceUpdate);
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
            this.Name = "EditConference";
            this.Text = "EditConference";
            this.Load += new System.EventHandler(this.EditConference_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conferenceCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button conferenceUpdate;
        private System.Windows.Forms.DateTimePicker conferenceDate;
        private System.Windows.Forms.NumericUpDown conferenceCapacity;
        private System.Windows.Forms.TextBox conferenceDescription;
        private System.Windows.Forms.TextBox conferenceVenue;
        private System.Windows.Forms.TextBox conferenceName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}