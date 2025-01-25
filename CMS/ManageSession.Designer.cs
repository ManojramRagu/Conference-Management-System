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
            this.button2 = new System.Windows.Forms.Button();
            this.RemoveSessionButton = new System.Windows.Forms.Button();
            this.EditSessionButton = new System.Windows.Forms.Button();
            this.AddSessionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.RemoveSessionButton);
            this.groupBox1.Controls.Add(this.EditSessionButton);
            this.groupBox1.Controls.Add(this.AddSessionButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(129, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(827, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 332);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 30;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemoveSessionButton
            // 
            this.RemoveSessionButton.Location = new System.Drawing.Point(539, 284);
            this.RemoveSessionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveSessionButton.Name = "RemoveSessionButton";
            this.RemoveSessionButton.Size = new System.Drawing.Size(205, 44);
            this.RemoveSessionButton.TabIndex = 4;
            this.RemoveSessionButton.Text = "Remove Session";
            this.RemoveSessionButton.UseVisualStyleBackColor = true;
            this.RemoveSessionButton.Click += new System.EventHandler(this.RemoveSessionButton_Click);
            // 
            // EditSessionButton
            // 
            this.EditSessionButton.Location = new System.Drawing.Point(303, 284);
            this.EditSessionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditSessionButton.Name = "EditSessionButton";
            this.EditSessionButton.Size = new System.Drawing.Size(209, 44);
            this.EditSessionButton.TabIndex = 3;
            this.EditSessionButton.Text = "Edit Session";
            this.EditSessionButton.UseVisualStyleBackColor = true;
            this.EditSessionButton.Click += new System.EventHandler(this.EditSessionButton_Click);
            // 
            // AddSessionButton
            // 
            this.AddSessionButton.Location = new System.Drawing.Point(56, 284);
            this.AddSessionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddSessionButton.Name = "AddSessionButton";
            this.AddSessionButton.Size = new System.Drawing.Size(209, 44);
            this.AddSessionButton.TabIndex = 2;
            this.AddSessionButton.Text = "Add Session";
            this.AddSessionButton.UseVisualStyleBackColor = true;
            this.AddSessionButton.Click += new System.EventHandler(this.AddSessionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACTIVE SESSIONS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(688, 178);
            this.dataGridView1.TabIndex = 31;
            // 
            // ManageSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageSession";
            this.Text = "ManageSession";
            this.Load += new System.EventHandler(this.ManageSession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveSessionButton;
        private System.Windows.Forms.Button EditSessionButton;
        private System.Windows.Forms.Button AddSessionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}