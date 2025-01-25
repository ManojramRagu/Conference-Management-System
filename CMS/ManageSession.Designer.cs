namespace CMS
{
    partial class ManageSession
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
            this.RemoveSessionButton = new System.Windows.Forms.Button();
            this.EditSessionButton = new System.Windows.Forms.Button();
            this.AddSessionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveSessionButton);
            this.groupBox1.Controls.Add(this.EditSessionButton);
            this.groupBox1.Controls.Add(this.AddSessionButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(97, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RemoveSessionButton
            // 
            this.RemoveSessionButton.Location = new System.Drawing.Point(404, 231);
            this.RemoveSessionButton.Name = "RemoveSessionButton";
            this.RemoveSessionButton.Size = new System.Drawing.Size(154, 36);
            this.RemoveSessionButton.TabIndex = 4;
            this.RemoveSessionButton.Text = "Remove Session";
            this.RemoveSessionButton.UseVisualStyleBackColor = true;
            // 
            // EditSessionButton
            // 
            this.EditSessionButton.Location = new System.Drawing.Point(227, 231);
            this.EditSessionButton.Name = "EditSessionButton";
            this.EditSessionButton.Size = new System.Drawing.Size(157, 36);
            this.EditSessionButton.TabIndex = 3;
            this.EditSessionButton.Text = "Edit Session";
            this.EditSessionButton.UseVisualStyleBackColor = true;
            // 
            // AddSessionButton
            // 
            this.AddSessionButton.Location = new System.Drawing.Point(42, 231);
            this.AddSessionButton.Name = "AddSessionButton";
            this.AddSessionButton.Size = new System.Drawing.Size(157, 36);
            this.AddSessionButton.TabIndex = 2;
            this.AddSessionButton.Text = "Add Session";
            this.AddSessionButton.UseVisualStyleBackColor = true;
            this.AddSessionButton.Click += new System.EventHandler(this.AddSessionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACTIVE SESSIONS";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 134);
            this.listBox1.TabIndex = 0;
            // 
            // ManageSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageSession";
            this.Text = "ManageSession";
            this.Load += new System.EventHandler(this.ManageSession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveSessionButton;
        private System.Windows.Forms.Button EditSessionButton;
        private System.Windows.Forms.Button AddSessionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}