namespace Coursach
{
    partial class FormStudent
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
            this.labelCurrentStudent = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgStudentExams = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgStatementStudent = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentExams)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatementStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentStudent
            // 
            this.labelCurrentStudent.AutoSize = true;
            this.labelCurrentStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCurrentStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentStudent.Location = new System.Drawing.Point(0, 0);
            this.labelCurrentStudent.Name = "labelCurrentStudent";
            this.labelCurrentStudent.Padding = new System.Windows.Forms.Padding(5);
            this.labelCurrentStudent.Size = new System.Drawing.Size(134, 26);
            this.labelCurrentStudent.TabIndex = 0;
            this.labelCurrentStudent.Text = "labelCurrentStudent";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgStudentExams);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Экзамены";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgStudentExams
            // 
            this.dgStudentExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStudentExams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgStudentExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudentExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStudentExams.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgStudentExams.Location = new System.Drawing.Point(3, 3);
            this.dgStudentExams.Name = "dgStudentExams";
            this.dgStudentExams.Size = new System.Drawing.Size(770, 400);
            this.dgStudentExams.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgStatementStudent);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заявления";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgStatementStudent
            // 
            this.dgStatementStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatementStudent.Location = new System.Drawing.Point(8, 6);
            this.dgStatementStudent.Name = "dgStatementStudent";
            this.dgStatementStudent.Size = new System.Drawing.Size(438, 392);
            this.dgStatementStudent.TabIndex = 0;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelCurrentStudent);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormStudent";
            this.Text = "Окно для студента";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentExams)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStatementStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentStudent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgStudentExams;
        private System.Windows.Forms.DataGridView dgStatementStudent;
    }
}