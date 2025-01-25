namespace CMS
{
    partial class AddNewSession
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
            this.label9 = new System.Windows.Forms.Label();
            this.sessionNameTxt = new System.Windows.Forms.TextBox();
            this.speakerDropDown = new System.Windows.Forms.ComboBox();
            this.conferenceDropdown = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.venue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Session Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conference : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Speaker : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 329);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Venue :";
            // 
            // sessionNameTxt
            // 
            this.sessionNameTxt.Location = new System.Drawing.Point(388, 153);
            this.sessionNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sessionNameTxt.Name = "sessionNameTxt";
            this.sessionNameTxt.Size = new System.Drawing.Size(132, 22);
            this.sessionNameTxt.TabIndex = 9;
            // 
            // speakerDropDown
            // 
            this.speakerDropDown.FormattingEnabled = true;
            this.speakerDropDown.Location = new System.Drawing.Point(388, 225);
            this.speakerDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.speakerDropDown.Name = "speakerDropDown";
            this.speakerDropDown.Size = new System.Drawing.Size(160, 24);
            this.speakerDropDown.TabIndex = 10;
            // 
            // conferenceDropdown
            // 
            this.conferenceDropdown.FormattingEnabled = true;
            this.conferenceDropdown.Location = new System.Drawing.Point(388, 188);
            this.conferenceDropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conferenceDropdown.Name = "conferenceDropdown";
            this.conferenceDropdown.Size = new System.Drawing.Size(160, 24);
            this.conferenceDropdown.TabIndex = 11;
            // 
            // date
            // 
            this.date.CustomFormat = "MMMM dd, yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(388, 260);
            this.date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(204, 22);
            this.date.TabIndex = 12;
            this.date.Value = new System.DateTime(2025, 1, 24, 22, 8, 1, 0);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(388, 294);
            this.description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(160, 22);
            this.description.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 31;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // venue
            // 
            this.venue.Location = new System.Drawing.Point(388, 329);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(100, 22);
            this.venue.TabIndex = 32;
            // 
            // AddNewSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.venue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.date);
            this.Controls.Add(this.conferenceDropdown);
            this.Controls.Add(this.speakerDropDown);
            this.Controls.Add(this.sessionNameTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewSession";
            this.Text = "AddNewSession";
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sessionNameTxt;
        private System.Windows.Forms.ComboBox speakerDropDown;
        private System.Windows.Forms.ComboBox conferenceDropdown;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox venue;
    }
}