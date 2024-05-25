namespace Coursach
{
    partial class FormEditExam
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
            this.cbDiscipline = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeExam = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMark = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcceptEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDiscipline
            // 
            this.cbDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDiscipline.FormattingEnabled = true;
            this.cbDiscipline.Location = new System.Drawing.Point(120, 28);
            this.cbDiscipline.Name = "cbDiscipline";
            this.cbDiscipline.Size = new System.Drawing.Size(187, 24);
            this.cbDiscipline.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дисциплина";
            // 
            // dateTimeExam
            // 
            this.dateTimeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeExam.Location = new System.Drawing.Point(431, 26);
            this.dateTimeExam.Name = "dateTimeExam";
            this.dateTimeExam.Size = new System.Drawing.Size(200, 22);
            this.dateTimeExam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(386, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата";
            // 
            // cbMark
            // 
            this.cbMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMark.FormattingEnabled = true;
            this.cbMark.Location = new System.Drawing.Point(304, 151);
            this.cbMark.Name = "cbMark";
            this.cbMark.Size = new System.Drawing.Size(121, 24);
            this.cbMark.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(236, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оценка";
            // 
            // btnAcceptEdit
            // 
            this.btnAcceptEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAcceptEdit.Location = new System.Drawing.Point(187, 269);
            this.btnAcceptEdit.Name = "btnAcceptEdit";
            this.btnAcceptEdit.Size = new System.Drawing.Size(120, 51);
            this.btnAcceptEdit.TabIndex = 6;
            this.btnAcceptEdit.Text = "Изменить экзамен";
            this.btnAcceptEdit.UseVisualStyleBackColor = true;
            this.btnAcceptEdit.Click += new System.EventHandler(this.btnAcceptEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelEdit.Location = new System.Drawing.Point(355, 269);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(112, 51);
            this.btnCancelEdit.TabIndex = 7;
            this.btnCancelEdit.Text = "Отмена";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // FormEditExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnAcceptEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDiscipline);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormEditExam";
            this.Text = "Редактирование экзамена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDiscipline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcceptEdit;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}