namespace Coursach
{
    partial class FormEditDocument
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
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameEvent = new System.Windows.Forms.TextBox();
            this.cbTypeDocument = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdutDocumentAccept = new System.Windows.Forms.Button();
            this.btnEditDocumentCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUrl.Location = new System.Drawing.Point(75, 158);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(556, 26);
            this.textBoxUrl.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(238, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ссылка на документ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(360, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Название статьи/олимпиады";
            // 
            // textBoxNameEvent
            // 
            this.textBoxNameEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameEvent.Location = new System.Drawing.Point(364, 59);
            this.textBoxNameEvent.Name = "textBoxNameEvent";
            this.textBoxNameEvent.Size = new System.Drawing.Size(267, 26);
            this.textBoxNameEvent.TabIndex = 30;
            // 
            // cbTypeDocument
            // 
            this.cbTypeDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTypeDocument.FormattingEnabled = true;
            this.cbTypeDocument.Location = new System.Drawing.Point(75, 55);
            this.cbTypeDocument.Name = "cbTypeDocument";
            this.cbTypeDocument.Size = new System.Drawing.Size(188, 24);
            this.cbTypeDocument.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Тип документа";
            // 
            // btnEdutDocumentAccept
            // 
            this.btnEdutDocumentAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdutDocumentAccept.Location = new System.Drawing.Point(127, 254);
            this.btnEdutDocumentAccept.Name = "btnEdutDocumentAccept";
            this.btnEdutDocumentAccept.Size = new System.Drawing.Size(136, 53);
            this.btnEdutDocumentAccept.TabIndex = 34;
            this.btnEdutDocumentAccept.Text = "Изменить документ";
            this.btnEdutDocumentAccept.UseVisualStyleBackColor = true;
            this.btnEdutDocumentAccept.Click += new System.EventHandler(this.btnEdutDocumentAccept_Click);
            // 
            // btnEditDocumentCancel
            // 
            this.btnEditDocumentCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditDocumentCancel.Location = new System.Drawing.Point(364, 254);
            this.btnEditDocumentCancel.Name = "btnEditDocumentCancel";
            this.btnEditDocumentCancel.Size = new System.Drawing.Size(106, 53);
            this.btnEditDocumentCancel.TabIndex = 35;
            this.btnEditDocumentCancel.Text = "Отмена";
            this.btnEditDocumentCancel.UseVisualStyleBackColor = true;
            this.btnEditDocumentCancel.Click += new System.EventHandler(this.btnEditDocumentCancel_Click);
            // 
            // FormEditDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnEditDocumentCancel);
            this.Controls.Add(this.btnEdutDocumentAccept);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNameEvent);
            this.Controls.Add(this.cbTypeDocument);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormEditDocument";
            this.Text = "Редактирование документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameEvent;
        private System.Windows.Forms.ComboBox cbTypeDocument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdutDocumentAccept;
        private System.Windows.Forms.Button btnEditDocumentCancel;
    }
}