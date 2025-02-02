namespace CMS
{
    partial class EditSession
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.TextBox();
            this.conferenceDropdown = new System.Windows.Forms.ComboBox();
            this.speakerDropdown = new System.Windows.Forms.ComboBox();
            this.sessionName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Session Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conference :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Speaker :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Start Time :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "End Time :";
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "HH:mm tt";
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime.Location = new System.Drawing.Point(495, 266);
            this.endTime.Margin = new System.Windows.Forms.Padding(4);
            this.endTime.MinDate = new System.DateTime(2025, 2, 2, 0, 0, 0, 0);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(176, 22);
            this.endTime.TabIndex = 23;
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "HH:mm tt";
            this.startTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(495, 233);
            this.startTime.Margin = new System.Windows.Forms.Padding(4);
            this.startTime.MinDate = new System.DateTime(2025, 2, 2, 0, 0, 0, 0);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(176, 22);
            this.startTime.TabIndex = 22;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(495, 203);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(176, 22);
            this.description.TabIndex = 21;
            // 
            // conferenceDropdown
            // 
            this.conferenceDropdown.FormattingEnabled = true;
            this.conferenceDropdown.Location = new System.Drawing.Point(495, 128);
            this.conferenceDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.conferenceDropdown.Name = "conferenceDropdown";
            this.conferenceDropdown.Size = new System.Drawing.Size(176, 24);
            this.conferenceDropdown.TabIndex = 19;
            // 
            // speakerDropdown
            // 
            this.speakerDropdown.AllowDrop = true;
            this.speakerDropdown.FormattingEnabled = true;
            this.speakerDropdown.Location = new System.Drawing.Point(495, 166);
            this.speakerDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.speakerDropdown.Name = "speakerDropdown";
            this.speakerDropdown.Size = new System.Drawing.Size(176, 24);
            this.speakerDropdown.TabIndex = 18;
            // 
            // sessionName
            // 
            this.sessionName.Location = new System.Drawing.Point(495, 94);
            this.sessionName.Margin = new System.Windows.Forms.Padding(4);
            this.sessionName.Name = "sessionName";
            this.sessionName.Size = new System.Drawing.Size(176, 22);
            this.sessionName.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 315);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 31;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.description);
            this.Controls.Add(this.conferenceDropdown);
            this.Controls.Add(this.speakerDropdown);
            this.Controls.Add(this.sessionName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditSession";
            this.Text = "EditSession";
            this.Load += new System.EventHandler(this.EditSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox conferenceDropdown;
        private System.Windows.Forms.ComboBox speakerDropdown;
        private System.Windows.Forms.TextBox sessionName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}