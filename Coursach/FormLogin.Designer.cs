namespace Coursach
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.brnLoginAdmin = new System.Windows.Forms.Button();
            this.btnLoginStudent = new System.Windows.Forms.Button();
            this.cbStudentLogin = new System.Windows.Forms.ComboBox();
            this.btnLoginStudentAccept = new System.Windows.Forms.Button();
            this.btnStudentLoginCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brnLoginAdmin
            // 
            this.brnLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brnLoginAdmin.Location = new System.Drawing.Point(205, 91);
            this.brnLoginAdmin.Name = "brnLoginAdmin";
            this.brnLoginAdmin.Size = new System.Drawing.Size(390, 70);
            this.brnLoginAdmin.TabIndex = 0;
            this.brnLoginAdmin.Text = "Войти как сотрудник деканата";
            this.brnLoginAdmin.UseVisualStyleBackColor = true;
            this.brnLoginAdmin.Click += new System.EventHandler(this.brnLoginAdmin_Click);
            // 
            // btnLoginStudent
            // 
            this.btnLoginStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoginStudent.Location = new System.Drawing.Point(205, 236);
            this.btnLoginStudent.Name = "btnLoginStudent";
            this.btnLoginStudent.Size = new System.Drawing.Size(390, 70);
            this.btnLoginStudent.TabIndex = 1;
            this.btnLoginStudent.Text = "Войти как студент";
            this.btnLoginStudent.UseVisualStyleBackColor = true;
            this.btnLoginStudent.Click += new System.EventHandler(this.btnLoginStudent_Click);
            // 
            // cbStudentLogin
            // 
            this.cbStudentLogin.FormattingEnabled = true;
            this.cbStudentLogin.Location = new System.Drawing.Point(205, 336);
            this.cbStudentLogin.Name = "cbStudentLogin";
            this.cbStudentLogin.Size = new System.Drawing.Size(390, 21);
            this.cbStudentLogin.TabIndex = 2;
            this.cbStudentLogin.Visible = false;
            // 
            // btnLoginStudentAccept
            // 
            this.btnLoginStudentAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoginStudentAccept.Location = new System.Drawing.Point(205, 384);
            this.btnLoginStudentAccept.Name = "btnLoginStudentAccept";
            this.btnLoginStudentAccept.Size = new System.Drawing.Size(177, 47);
            this.btnLoginStudentAccept.TabIndex = 3;
            this.btnLoginStudentAccept.Text = "Вход";
            this.btnLoginStudentAccept.UseVisualStyleBackColor = true;
            this.btnLoginStudentAccept.Visible = false;
            this.btnLoginStudentAccept.Click += new System.EventHandler(this.btnLoginStudentAccept_Click);
            // 
            // btnStudentLoginCancel
            // 
            this.btnStudentLoginCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudentLoginCancel.Location = new System.Drawing.Point(418, 384);
            this.btnStudentLoginCancel.Name = "btnStudentLoginCancel";
            this.btnStudentLoginCancel.Size = new System.Drawing.Size(177, 47);
            this.btnStudentLoginCancel.TabIndex = 4;
            this.btnStudentLoginCancel.Text = "Отмена";
            this.btnStudentLoginCancel.UseVisualStyleBackColor = true;
            this.btnStudentLoginCancel.Visible = false;
            this.btnStudentLoginCancel.Click += new System.EventHandler(this.btnStudentLoginCancel_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnStudentLoginCancel);
            this.Controls.Add(this.btnLoginStudentAccept);
            this.Controls.Add(this.cbStudentLogin);
            this.Controls.Add(this.btnLoginStudent);
            this.Controls.Add(this.brnLoginAdmin);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormLogin";
            this.Text = "Приложение";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brnLoginAdmin;
        private System.Windows.Forms.Button btnLoginStudent;
        private System.Windows.Forms.ComboBox cbStudentLogin;
        private System.Windows.Forms.Button btnLoginStudentAccept;
        private System.Windows.Forms.Button btnStudentLoginCancel;
    }
}

