namespace Coursach
{
    partial class FormStudentEditStatement
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
            this.btnAddStatementCancel = new System.Windows.Forms.Button();
            this.btnAddNewStatement = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddNewDocument = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameEvent = new System.Windows.Forms.TextBox();
            this.cbTypeDocument = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxEditNewDocument = new System.Windows.Forms.ListBox();
            this.checkListBoxDocumentEdit = new System.Windows.Forms.CheckedListBox();
            this.cbTypeStatementStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStatementCancel
            // 
            this.btnAddStatementCancel.Location = new System.Drawing.Point(480, 418);
            this.btnAddStatementCancel.Name = "btnAddStatementCancel";
            this.btnAddStatementCancel.Size = new System.Drawing.Size(142, 37);
            this.btnAddStatementCancel.TabIndex = 32;
            this.btnAddStatementCancel.Text = "Отменить";
            this.btnAddStatementCancel.UseVisualStyleBackColor = true;
            this.btnAddStatementCancel.Click += new System.EventHandler(this.btnAddStatementCancel_Click);
            // 
            // btnAddNewStatement
            // 
            this.btnAddNewStatement.Location = new System.Drawing.Point(52, 418);
            this.btnAddNewStatement.Name = "btnAddNewStatement";
            this.btnAddNewStatement.Size = new System.Drawing.Size(145, 38);
            this.btnAddNewStatement.TabIndex = 31;
            this.btnAddNewStatement.Text = "Изменить заявление";
            this.btnAddNewStatement.UseVisualStyleBackColor = true;
            this.btnAddNewStatement.Click += new System.EventHandler(this.btnAddNewStatement_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Новые документы";
            // 
            // btnAddNewDocument
            // 
            this.btnAddNewDocument.Location = new System.Drawing.Point(625, 126);
            this.btnAddNewDocument.Name = "btnAddNewDocument";
            this.btnAddNewDocument.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewDocument.TabIndex = 29;
            this.btnAddNewDocument.Text = "Добавить";
            this.btnAddNewDocument.UseVisualStyleBackColor = true;
            this.btnAddNewDocument.Click += new System.EventHandler(this.btnAddNewDocument_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Добавить существующий документ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Добавить новый документ";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(416, 126);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(185, 20);
            this.textBoxUrl.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ссылка на документ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Название статьи/олимпиады";
            // 
            // textBoxNameEvent
            // 
            this.textBoxNameEvent.Location = new System.Drawing.Point(413, 82);
            this.textBoxNameEvent.Name = "textBoxNameEvent";
            this.textBoxNameEvent.Size = new System.Drawing.Size(188, 20);
            this.textBoxNameEvent.TabIndex = 23;
            // 
            // cbTypeDocument
            // 
            this.cbTypeDocument.FormattingEnabled = true;
            this.cbTypeDocument.Location = new System.Drawing.Point(413, 42);
            this.cbTypeDocument.Name = "cbTypeDocument";
            this.cbTypeDocument.Size = new System.Drawing.Size(188, 21);
            this.cbTypeDocument.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Тип документа";
            // 
            // listBoxEditNewDocument
            // 
            this.listBoxEditNewDocument.FormattingEnabled = true;
            this.listBoxEditNewDocument.Location = new System.Drawing.Point(52, 317);
            this.listBoxEditNewDocument.Name = "listBoxEditNewDocument";
            this.listBoxEditNewDocument.Size = new System.Drawing.Size(683, 95);
            this.listBoxEditNewDocument.TabIndex = 20;
            // 
            // checkListBoxDocumentEdit
            // 
            this.checkListBoxDocumentEdit.FormattingEnabled = true;
            this.checkListBoxDocumentEdit.Location = new System.Drawing.Point(52, 158);
            this.checkListBoxDocumentEdit.Name = "checkListBoxDocumentEdit";
            this.checkListBoxDocumentEdit.Size = new System.Drawing.Size(683, 139);
            this.checkListBoxDocumentEdit.TabIndex = 19;
            // 
            // cbTypeStatementStudent
            // 
            this.cbTypeStatementStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTypeStatementStudent.FormattingEnabled = true;
            this.cbTypeStatementStudent.Location = new System.Drawing.Point(166, 30);
            this.cbTypeStatementStudent.Name = "cbTypeStatementStudent";
            this.cbTypeStatementStudent.Size = new System.Drawing.Size(205, 24);
            this.cbTypeStatementStudent.TabIndex = 18;
            this.cbTypeStatementStudent.SelectedIndexChanged += new System.EventHandler(this.cbTypeStatementStudent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Вид заявления: ";
            // 
            // FormStudentEditStatement
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
            this.Controls.Add(this.listBoxEditNewDocument);
            this.Controls.Add(this.checkListBoxDocumentEdit);
            this.Controls.Add(this.cbTypeStatementStudent);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormStudentEditStatement";
            this.Text = "Редактирование заявления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStatementCancel;
        private System.Windows.Forms.Button btnAddNewStatement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddNewDocument;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameEvent;
        private System.Windows.Forms.ComboBox cbTypeDocument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxEditNewDocument;
        private System.Windows.Forms.CheckedListBox checkListBoxDocumentEdit;
        private System.Windows.Forms.ComboBox cbTypeStatementStudent;
        private System.Windows.Forms.Label label1;
    }
}