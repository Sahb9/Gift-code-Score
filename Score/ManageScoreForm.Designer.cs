namespace Bai_login
{
    partial class ManageScoreForm
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
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAvgScore = new System.Windows.Forms.Button();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowStudents = new System.Windows.Forms.Button();
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAddScore.Location = new System.Drawing.Point(35, 13);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(111, 30);
            this.buttonAddScore.TabIndex = 19;
            this.buttonAddScore.Text = "Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click_1);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxScore);
            this.panel1.Controls.Add(this.comboBoxSelectCourse);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.textBoxStudentID);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelPeriod);
            this.panel1.Controls.Add(this.labelStudentID);
            this.panel1.Controls.Add(this.labelSelectCourse);
            this.panel1.Location = new System.Drawing.Point(19, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 346);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRemove);
            this.panel2.Controls.Add(this.buttonAvgScore);
            this.panel2.Controls.Add(this.buttonAddScore);
            this.panel2.Location = new System.Drawing.Point(14, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 81);
            this.panel2.TabIndex = 23;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.buttonRemove.Location = new System.Drawing.Point(176, 14);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(111, 29);
            this.buttonRemove.TabIndex = 21;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAvgScore
            // 
            this.buttonAvgScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(164)))), ((int)(((byte)(157)))));
            this.buttonAvgScore.Location = new System.Drawing.Point(87, 49);
            this.buttonAvgScore.Name = "buttonAvgScore";
            this.buttonAvgScore.Size = new System.Drawing.Size(178, 29);
            this.buttonAvgScore.TabIndex = 22;
            this.buttonAvgScore.Text = "Avg Score By Course";
            this.buttonAvgScore.UseVisualStyleBackColor = false;
            this.buttonAvgScore.Click += new System.EventHandler(this.buttonAvgScore_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(441, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 286);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonShowStudents
            // 
            this.buttonShowStudents.Location = new System.Drawing.Point(434, 9);
            this.buttonShowStudents.Name = "buttonShowStudents";
            this.buttonShowStudents.Size = new System.Drawing.Size(122, 23);
            this.buttonShowStudents.TabIndex = 23;
            this.buttonShowStudents.Text = "Show Student";
            this.buttonShowStudents.UseVisualStyleBackColor = true;
            this.buttonShowStudents.Click += new System.EventHandler(this.buttonShowStudents_Click);
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.Location = new System.Drawing.Point(741, 9);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(122, 23);
            this.buttonShowScore.TabIndex = 24;
            this.buttonShowScore.Text = "Show Score";
            this.buttonShowScore.UseVisualStyleBackColor = true;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 381);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.buttonShowStudents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAvgScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShowStudents;
        private System.Windows.Forms.Button buttonShowScore;
    }
}