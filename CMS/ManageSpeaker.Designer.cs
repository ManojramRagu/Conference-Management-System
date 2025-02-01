namespace CMS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.AddNewSpeakerbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURRENT SPEAKER";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Editbtn);
            this.groupBox1.Controls.Add(this.Removebtn);
            this.groupBox1.Controls.Add(this.AddNewSpeakerbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(151, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1205, 422);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(80, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(727, 245);
            this.dataGridView1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 374);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 30;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(861, 300);
            this.Editbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(248, 52);
            this.Editbtn.TabIndex = 4;
            this.Editbtn.Text = "Edit Details";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Removebtn
            // 
            this.Removebtn.Location = new System.Drawing.Point(861, 206);
            this.Removebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(248, 50);
            this.Removebtn.TabIndex = 3;
            this.Removebtn.Text = "Remove Speaker";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // AddNewSpeakerbtn
            // 
            this.AddNewSpeakerbtn.Location = new System.Drawing.Point(861, 107);
            this.AddNewSpeakerbtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewSpeakerbtn.Name = "AddNewSpeakerbtn";
            this.AddNewSpeakerbtn.Size = new System.Drawing.Size(248, 54);
            this.AddNewSpeakerbtn.TabIndex = 2;
            this.AddNewSpeakerbtn.Text = "Add New Speaker";
            this.AddNewSpeakerbtn.UseVisualStyleBackColor = true;
            this.AddNewSpeakerbtn.Click += new System.EventHandler(this.AddNewSpeakerbtn_Click);
            // 
            // ManageSpeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 540);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageSpeaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSpeaker";
            this.Load += new System.EventHandler(this.ManageSpeaker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button AddNewSpeakerbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}