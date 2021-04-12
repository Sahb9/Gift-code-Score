namespace Bai_login
{
    partial class PrintScoreForm
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
            this.labelCourseList = new System.Windows.Forms.Label();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.labelScoreList = new System.Windows.Forms.Label();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.labelStudentList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseList
            // 
            this.labelCourseList.Location = new System.Drawing.Point(40, 60);
            this.labelCourseList.Name = "labelCourseList";
            this.labelCourseList.Size = new System.Drawing.Size(94, 13);
            this.labelCourseList.TabIndex = 0;
            this.labelCourseList.Text = "Course List";
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Location = new System.Drawing.Point(28, 76);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(172, 238);
            this.listBoxCourses.TabIndex = 1;
            this.listBoxCourses.Click += new System.EventHandler(this.listBoxCourses_Click);
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(222, 43);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.Size = new System.Drawing.Size(331, 276);
            this.dataGridViewScore.TabIndex = 2;
            // 
            // labelScoreList
            // 
            this.labelScoreList.Location = new System.Drawing.Point(224, 21);
            this.labelScoreList.Name = "labelScoreList";
            this.labelScoreList.Size = new System.Drawing.Size(94, 13);
            this.labelScoreList.TabIndex = 3;
            this.labelScoreList.Text = "Score List";
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(559, 43);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.Size = new System.Drawing.Size(339, 276);
            this.dataGridViewStudentList.TabIndex = 4;
            this.dataGridViewStudentList.Click += new System.EventHandler(this.dataGridViewStudentList_Click);
            // 
            // labelStudentList
            // 
            this.labelStudentList.Location = new System.Drawing.Point(556, 21);
            this.labelStudentList.Name = "labelStudentList";
            this.labelStudentList.Size = new System.Drawing.Size(81, 13);
            this.labelStudentList.TabIndex = 5;
            this.labelStudentList.Text = "Student List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reset";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(187, 327);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(526, 23);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Print To Text File";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(910, 362);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStudentList);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.labelScoreList);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.labelCourseList);
            this.Name = "PrintScoreForm";
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourseList;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Label labelScoreList;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Label labelStudentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrint;
    }
}