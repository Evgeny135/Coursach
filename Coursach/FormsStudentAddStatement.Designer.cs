namespace Coursach
{
    partial class FormsStudentAddStatement
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
            this.cbTypeStatementStudent = new System.Windows.Forms.ComboBox();
            this.checkListBoxDocument = new System.Windows.Forms.CheckedListBox();
            this.listBoxNewDocument = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTypeDocument = new System.Windows.Forms.ComboBox();
            this.textBoxNameEvent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNewDocument = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddNewStatement = new System.Windows.Forms.Button();
            this.btnAddStatementCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид заявления: ";
            // 
            // cbTypeStatementStudent
            // 
            this.cbTypeStatementStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTypeStatementStudent.FormattingEnabled = true;
            this.cbTypeStatementStudent.Location = new System.Drawing.Point(180, 31);
            this.cbTypeStatementStudent.Name = "cbTypeStatementStudent";
            this.cbTypeStatementStudent.Size = new System.Drawing.Size(205, 24);
            this.cbTypeStatementStudent.TabIndex = 1;
            this.cbTypeStatementStudent.SelectedIndexChanged += new System.EventHandler(this.cbTypeStatementStudent_SelectedIndexChanged);
            // 
            // checkListBoxDocument
            // 
            this.checkListBoxDocument.FormattingEnabled = true;
            this.checkListBoxDocument.Location = new System.Drawing.Point(66, 159);
            this.checkListBoxDocument.Name = "checkListBoxDocument";
            this.checkListBoxDocument.Size = new System.Drawing.Size(683, 139);
            this.checkListBoxDocument.TabIndex = 3;
            // 
            // listBoxNewDocument
            // 
            this.listBoxNewDocument.FormattingEnabled = true;
            this.listBoxNewDocument.Location = new System.Drawing.Point(66, 318);
            this.listBoxNewDocument.Name = "listBoxNewDocument";
            this.listBoxNewDocument.Size = new System.Drawing.Size(683, 95);
            this.listBoxNewDocument.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип документа";
            // 
            // cbTypeDocument
            // 
            this.cbTypeDocument.FormattingEnabled = true;
            this.cbTypeDocument.Location = new System.Drawing.Point(427, 43);
            this.cbTypeDocument.Name = "cbTypeDocument";
            this.cbTypeDocument.Size = new System.Drawing.Size(188, 21);
            this.cbTypeDocument.TabIndex = 6;
            // 
            // textBoxNameEvent
            // 
            this.textBoxNameEvent.Location = new System.Drawing.Point(427, 83);
            this.textBoxNameEvent.Name = "textBoxNameEvent";
            this.textBoxNameEvent.Size = new System.Drawing.Size(188, 20);
            this.textBoxNameEvent.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название статьи/олимпиады";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ссылка на документ";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(430, 127);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(185, 20);
            this.textBoxUrl.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Добавить новый документ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Добавить существующий документ";
            // 
            // btnAddNewDocument
            // 
            this.btnAddNewDocument.Location = new System.Drawing.Point(639, 127);
            this.btnAddNewDocument.Name = "btnAddNewDocument";
            this.btnAddNewDocument.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewDocument.TabIndex = 13;
            this.btnAddNewDocument.Text = "Добавить";
            this.btnAddNewDocument.UseVisualStyleBackColor = true;
            this.btnAddNewDocument.Click += new System.EventHandler(this.btnAddNewDocument_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Новые документы";
            // 
            // btnAddNewStatement
            // 
            this.btnAddNewStatement.Location = new System.Drawing.Point(66, 419);
            this.btnAddNewStatement.Name = "btnAddNewStatement";
            this.btnAddNewStatement.Size = new System.Drawing.Size(145, 38);
            this.btnAddNewStatement.TabIndex = 15;
            this.btnAddNewStatement.Text = "Добавить заявление";
            this.btnAddNewStatement.UseVisualStyleBackColor = true;
            this.btnAddNewStatement.Click += new System.EventHandler(this.btnAddNewStatement_Click);
            // 
            // btnAddStatementCancel
            // 
            this.btnAddStatementCancel.Location = new System.Drawing.Point(494, 419);
            this.btnAddStatementCancel.Name = "btnAddStatementCancel";
            this.btnAddStatementCancel.Size = new System.Drawing.Size(142, 37);
            this.btnAddStatementCancel.TabIndex = 16;
            this.btnAddStatementCancel.Text = "Отменить";
            this.btnAddStatementCancel.UseVisualStyleBackColor = true;
            this.btnAddStatementCancel.Click += new System.EventHandler(this.btnAddStatementCancel_Click);
            // 
            // FormsStudentAddStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnAddStatementCancel);
            this.Controls.Add(this.btnAddNewStatement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddNewDocument);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNameEvent);
            this.Controls.Add(this.cbTypeDocument);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxNewDocument);
            this.Controls.Add(this.checkListBoxDocument);
            this.Controls.Add(this.cbTypeStatementStudent);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormsStudentAddStatement";
            this.Text = "Добавление заявления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeStatementStudent;
        private System.Windows.Forms.CheckedListBox checkListBoxDocument;
        private System.Windows.Forms.ListBox listBoxNewDocument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTypeDocument;
        private System.Windows.Forms.TextBox textBoxNameEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddNewDocument;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddNewStatement;
        private System.Windows.Forms.Button btnAddStatementCancel;
    }
}