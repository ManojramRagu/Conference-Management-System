namespace CMS
{
    partial class ManageConferenceUI
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
            this.listofconference = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Conference = new System.Windows.Forms.GroupBox();
            this.removebtn = new System.Windows.Forms.Button();
            this.managebtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.Conference.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTIVE CONFERENCE";
            // 
            // listofconference
            // 
            this.listofconference.FormattingEnabled = true;
            this.listofconference.Location = new System.Drawing.Point(51, 75);
            this.listofconference.Name = "listofconference";
            this.listofconference.Size = new System.Drawing.Size(552, 95);
            this.listofconference.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Conference
            // 
            this.Conference.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Conference.Controls.Add(this.removebtn);
            this.Conference.Controls.Add(this.managebtn);
            this.Conference.Controls.Add(this.createbtn);
            this.Conference.Controls.Add(this.listofconference);
            this.Conference.Controls.Add(this.label1);
            this.Conference.Location = new System.Drawing.Point(96, 79);
            this.Conference.Name = "Conference";
            this.Conference.Size = new System.Drawing.Size(646, 285);
            this.Conference.TabIndex = 3;
            this.Conference.TabStop = false;
            this.Conference.Text = "Conference";
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(447, 189);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(156, 31);
            this.removebtn.TabIndex = 4;
            this.removebtn.Text = "Remove Conference";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // managebtn
            // 
            this.managebtn.Location = new System.Drawing.Point(254, 189);
            this.managebtn.Name = "managebtn";
            this.managebtn.Size = new System.Drawing.Size(156, 31);
            this.managebtn.TabIndex = 3;
            this.managebtn.Text = "Edit Conference";
            this.managebtn.UseVisualStyleBackColor = true;
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(51, 189);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(156, 31);
            this.createbtn.TabIndex = 2;
            this.createbtn.Text = "Create Conference";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // ManageConferenceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Conference);
            this.Controls.Add(this.button1);
            this.Name = "ManageConferenceUI";
            this.Text = "ManageConferenceUI";
            this.Conference.ResumeLayout(false);
            this.Conference.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listofconference;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Conference;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button managebtn;
        private System.Windows.Forms.Button createbtn;
    }
}