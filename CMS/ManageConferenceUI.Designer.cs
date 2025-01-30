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
            this.button1 = new System.Windows.Forms.Button();
            this.Conference = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.managebtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.Conference.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "AVAILABLE CONFERENCE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(11, 10);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Conference
            // 
            this.Conference.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Conference.Controls.Add(this.dataGridView1);
            this.Conference.Controls.Add(this.button2);
            this.Conference.Controls.Add(this.removebtn);
            this.Conference.Controls.Add(this.managebtn);
            this.Conference.Controls.Add(this.createbtn);
            this.Conference.Controls.Add(this.label1);
            this.Conference.Location = new System.Drawing.Point(128, 97);
            this.Conference.Margin = new System.Windows.Forms.Padding(4);
            this.Conference.Name = "Conference";
            this.Conference.Padding = new System.Windows.Forms.Padding(4);
            this.Conference.Size = new System.Drawing.Size(861, 351);
            this.Conference.TabIndex = 3;
            this.Conference.TabStop = false;
            this.Conference.Text = "Conference";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 132);
            this.dataGridView1.TabIndex = 30;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 299);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 29;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(596, 233);
            this.removebtn.Margin = new System.Windows.Forms.Padding(4);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(208, 38);
            this.removebtn.TabIndex = 4;
            this.removebtn.Text = "Remove Conference";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // managebtn
            // 
            this.managebtn.Location = new System.Drawing.Point(339, 233);
            this.managebtn.Margin = new System.Windows.Forms.Padding(4);
            this.managebtn.Name = "managebtn";
            this.managebtn.Size = new System.Drawing.Size(208, 38);
            this.managebtn.TabIndex = 3;
            this.managebtn.Text = "Edit Conference";
            this.managebtn.UseVisualStyleBackColor = true;
            this.managebtn.Click += new System.EventHandler(this.managebtn_Click);
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(68, 233);
            this.createbtn.Margin = new System.Windows.Forms.Padding(4);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(208, 38);
            this.createbtn.TabIndex = 2;
            this.createbtn.Text = "Create Conference";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // ManageConferenceUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Conference);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageConferenceUI";
            this.Text = "ManageConferenceUI";
            this.Load += new System.EventHandler(this.ManageConferenceUI_Load);
            this.Conference.ResumeLayout(false);
            this.Conference.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Conference;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button managebtn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}