namespace Bai_login
{
    partial class AddScoreForm
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
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAddCourse.Location = new System.Drawing.Point(49, 256);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(285, 30);
            this.buttonAddCourse.TabIndex = 19;
            this.buttonAddCourse.Text = "Add Score";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(173, 89);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSelectCourse.TabIndex = 17;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(173, 185);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(161, 52);
            this.textBoxDescription.TabIndex = 16;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(173, 30);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(161, 20);
            this.textBoxStudentID.TabIndex = 15;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(46, 192);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Description";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(46, 137);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(35, 13);
            this.labelPeriod.TabIndex = 13;
            this.labelPeriod.Text = "Score";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(46, 30);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 12;
            this.labelStudentID.Text = "Student ID";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Location = new System.Drawing.Point(46, 89);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(76, 13);
            this.labelSelectCourse.TabIndex = 11;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxScore);
            this.panel1.Controls.Add(this.buttonAddCourse);
            this.panel1.Controls.Add(this.comboBoxSelectCourse);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.textBoxStudentID);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelPeriod);
            this.panel1.Controls.Add(this.labelStudentID);
            this.panel1.Controls.Add(this.labelSelectCourse);
            this.panel1.Location = new System.Drawing.Point(26, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 304);
            this.panel1.TabIndex = 20;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(173, 137);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(161, 20);
            this.textBoxScore.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 286);
            this.dataGridView1.TabIndex = 21;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}