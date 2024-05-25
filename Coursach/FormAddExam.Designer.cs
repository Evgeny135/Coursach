namespace Coursach
{
    partial class FormAddExam
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
            this.cbNumberGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDiscipline = new System.Windows.Forms.ComboBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.btnAddNewExam = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNumberGroup
            // 
            this.cbNumberGroup.FormattingEnabled = true;
            this.cbNumberGroup.Location = new System.Drawing.Point(93, 27);
            this.cbNumberGroup.Name = "cbNumberGroup";
            this.cbNumberGroup.Size = new System.Drawing.Size(132, 21);
            this.cbNumberGroup.TabIndex = 0;
            this.cbNumberGroup.SelectedIndexChanged += new System.EventHandler(this.cbNumberGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группа";
            // 
            // dgStudent
            // 
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Location = new System.Drawing.Point(12, 192);
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.Size = new System.Drawing.Size(760, 286);
            this.dgStudent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дисциплина";
            // 
            // cbDiscipline
            // 
            this.cbDiscipline.FormattingEnabled = true;
            this.cbDiscipline.Location = new System.Drawing.Point(330, 26);
            this.cbDiscipline.Name = "cbDiscipline";
            this.cbDiscipline.Size = new System.Drawing.Size(165, 21);
            this.cbDiscipline.TabIndex = 4;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(580, 18);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 5;
            // 
            // btnAddNewExam
            // 
            this.btnAddNewExam.Location = new System.Drawing.Point(105, 496);
            this.btnAddNewExam.Name = "btnAddNewExam";
            this.btnAddNewExam.Size = new System.Drawing.Size(100, 42);
            this.btnAddNewExam.TabIndex = 6;
            this.btnAddNewExam.Text = "Добавить";
            this.btnAddNewExam.UseVisualStyleBackColor = true;
            this.btnAddNewExam.Click += new System.EventHandler(this.btnAddNewExam_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(434, 496);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(100, 42);
            this.btnCancelAdd.TabIndex = 7;
            this.btnCancelAdd.Text = "Отмена";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // FormAddExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnAddNewExam);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.cbDiscipline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNumberGroup);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormAddExam";
            this.Text = "Добавление экзамена";
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNumberGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDiscipline;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button btnAddNewExam;
        private System.Windows.Forms.Button btnCancelAdd;
    }
}