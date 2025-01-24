﻿namespace CMS
{
    partial class ManageSpeaker
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
            this.speakerlist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.AddNewSpeakerbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURRENT SPEAKER";
            // 
            // speakerlist
            // 
            this.speakerlist.FormattingEnabled = true;
            this.speakerlist.Location = new System.Drawing.Point(69, 87);
            this.speakerlist.Name = "speakerlist";
            this.speakerlist.Size = new System.Drawing.Size(152, 199);
            this.speakerlist.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Editbtn);
            this.groupBox1.Controls.Add(this.Removebtn);
            this.groupBox1.Controls.Add(this.AddNewSpeakerbtn);
            this.groupBox1.Controls.Add(this.speakerlist);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(113, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(257, 244);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(186, 42);
            this.Editbtn.TabIndex = 4;
            this.Editbtn.Text = "Edit Details";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Removebtn
            // 
            this.Removebtn.Location = new System.Drawing.Point(257, 167);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(186, 41);
            this.Removebtn.TabIndex = 3;
            this.Removebtn.Text = "Remove Speaker";
            this.Removebtn.UseVisualStyleBackColor = true;
            // 
            // AddNewSpeakerbtn
            // 
            this.AddNewSpeakerbtn.Location = new System.Drawing.Point(257, 87);
            this.AddNewSpeakerbtn.Name = "AddNewSpeakerbtn";
            this.AddNewSpeakerbtn.Size = new System.Drawing.Size(186, 44);
            this.AddNewSpeakerbtn.TabIndex = 2;
            this.AddNewSpeakerbtn.Text = "Add New Speaker";
            this.AddNewSpeakerbtn.UseVisualStyleBackColor = true;
            this.AddNewSpeakerbtn.Click += new System.EventHandler(this.AddNewSpeakerbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManageSpeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 439);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageSpeaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSpeaker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox speakerlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button AddNewSpeakerbtn;
        private System.Windows.Forms.Button button2;
    }
}