namespace CMS
{
    partial class OrganiserUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.managebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.managebtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(89, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Manage Speakers";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manage Sessions";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // managebtn
            // 
            this.managebtn.Location = new System.Drawing.Point(219, 148);
            this.managebtn.Name = "managebtn";
            this.managebtn.Size = new System.Drawing.Size(168, 27);
            this.managebtn.TabIndex = 1;
            this.managebtn.Text = "Manage Conference";
            this.managebtn.UseVisualStyleBackColor = true;
            this.managebtn.Click += new System.EventHandler(this.managebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            // 
            // OrganiserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 457);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrganiserUI";
            this.Text = "OrganiserUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button managebtn;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}