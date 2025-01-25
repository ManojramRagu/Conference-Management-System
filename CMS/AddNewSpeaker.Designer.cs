namespace CMS
{
    partial class AddNewSpeaker
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
            this.SpeakerNameTxt = new System.Windows.Forms.TextBox();
            this.SpeakerEmailTxt = new System.Windows.Forms.TextBox();
            this.SpeakerPhonetxt = new System.Windows.Forms.TextBox();
            this.SpeakerBioTxt = new System.Windows.Forms.TextBox();
            this.CreateSpeakerButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new Speaker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Biography : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone : ";
            // 
            // SpeakerNameTxt
            // 
            this.SpeakerNameTxt.Location = new System.Drawing.Point(256, 137);
            this.SpeakerNameTxt.Name = "SpeakerNameTxt";
            this.SpeakerNameTxt.Size = new System.Drawing.Size(100, 20);
            this.SpeakerNameTxt.TabIndex = 5;
            // 
            // SpeakerEmailTxt
            // 
            this.SpeakerEmailTxt.Location = new System.Drawing.Point(256, 164);
            this.SpeakerEmailTxt.Name = "SpeakerEmailTxt";
            this.SpeakerEmailTxt.Size = new System.Drawing.Size(100, 20);
            this.SpeakerEmailTxt.TabIndex = 6;
            // 
            // SpeakerPhonetxt
            // 
            this.SpeakerPhonetxt.Location = new System.Drawing.Point(256, 190);
            this.SpeakerPhonetxt.Name = "SpeakerPhonetxt";
            this.SpeakerPhonetxt.Size = new System.Drawing.Size(100, 20);
            this.SpeakerPhonetxt.TabIndex = 7;
            // 
            // SpeakerBioTxt
            // 
            this.SpeakerBioTxt.Location = new System.Drawing.Point(256, 225);
            this.SpeakerBioTxt.Multiline = true;
            this.SpeakerBioTxt.Name = "SpeakerBioTxt";
            this.SpeakerBioTxt.Size = new System.Drawing.Size(196, 54);
            this.SpeakerBioTxt.TabIndex = 8;
            // 
            // CreateSpeakerButton
            // 
            this.CreateSpeakerButton.Location = new System.Drawing.Point(231, 313);
            this.CreateSpeakerButton.Name = "CreateSpeakerButton";
            this.CreateSpeakerButton.Size = new System.Drawing.Size(125, 23);
            this.CreateSpeakerButton.TabIndex = 9;
            this.CreateSpeakerButton.Text = "Create Speaker";
            this.CreateSpeakerButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddNewSpeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateSpeakerButton);
            this.Controls.Add(this.SpeakerBioTxt);
            this.Controls.Add(this.SpeakerPhonetxt);
            this.Controls.Add(this.SpeakerEmailTxt);
            this.Controls.Add(this.SpeakerNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewSpeaker";
            this.Text = "AddNewSpeaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SpeakerNameTxt;
        private System.Windows.Forms.TextBox SpeakerEmailTxt;
        private System.Windows.Forms.TextBox SpeakerPhonetxt;
        private System.Windows.Forms.TextBox SpeakerBioTxt;
        private System.Windows.Forms.Button CreateSpeakerButton;
        private System.Windows.Forms.Button button2;
    }
}