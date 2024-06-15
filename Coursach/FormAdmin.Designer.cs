namespace Coursach
{
    partial class FormAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.btnSetSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeStatement = new System.Windows.Forms.ComboBox();
            this.dgDocument = new System.Windows.Forms.DataGridView();
            this.dgStatements = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnEditExam = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNumberGroup = new System.Windows.Forms.ComboBox();
            this.dgExams = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatements)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExams)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxCount);
            this.tabPage1.Controls.Add(this.btnSetSalary);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbTypeStatement);
            this.tabPage1.Controls.Add(this.dgDocument);
            this.tabPage1.Controls.Add(this.dgStatements);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1276, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заявления";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество мест";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(441, 5);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCount.TabIndex = 5;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnSetSalary
            // 
            this.btnSetSalary.Location = new System.Drawing.Point(556, 4);
            this.btnSetSalary.Name = "btnSetSalary";
            this.btnSetSalary.Size = new System.Drawing.Size(173, 23);
            this.btnSetSalary.TabIndex = 4;
            this.btnSetSalary.Text = "Провести конкурс";
            this.btnSetSalary.UseVisualStyleBackColor = true;
            this.btnSetSalary.Click += new System.EventHandler(this.btnSetSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вид заявлений:";
            // 
            // cbTypeStatement
            // 
            this.cbTypeStatement.FormattingEnabled = true;
            this.cbTypeStatement.Location = new System.Drawing.Point(123, 3);
            this.cbTypeStatement.Name = "cbTypeStatement";
            this.cbTypeStatement.Size = new System.Drawing.Size(174, 24);
            this.cbTypeStatement.TabIndex = 2;
            this.cbTypeStatement.SelectedIndexChanged += new System.EventHandler(this.cbTypeStatement_SelectedIndexChanged);
            // 
            // dgDocument
            // 
            this.dgDocument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDocument.Location = new System.Drawing.Point(710, 32);
            this.dgDocument.Name = "dgDocument";
            this.dgDocument.Size = new System.Drawing.Size(558, 492);
            this.dgDocument.TabIndex = 1;
            // 
            // dgStatements
            // 
            this.dgStatements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStatements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatements.Location = new System.Drawing.Point(8, 32);
            this.dgStatements.Name = "dgStatements";
            this.dgStatements.Size = new System.Drawing.Size(696, 492);
            this.dgStatements.TabIndex = 0;
            this.dgStatements.SelectionChanged += new System.EventHandler(this.dgStatements_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteExam);
            this.tabPage2.Controls.Add(this.btnEditExam);
            this.tabPage2.Controls.Add(this.btnAddExam);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbNumberGroup);
            this.tabPage2.Controls.Add(this.dgExams);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1276, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Экзамены";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Location = new System.Drawing.Point(615, 7);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(156, 27);
            this.btnDeleteExam.TabIndex = 5;
            this.btnDeleteExam.Text = "Удалить экзамен";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // btnEditExam
            // 
            this.btnEditExam.Location = new System.Drawing.Point(433, 7);
            this.btnEditExam.Name = "btnEditExam";
            this.btnEditExam.Size = new System.Drawing.Size(156, 27);
            this.btnEditExam.TabIndex = 4;
            this.btnEditExam.Text = "Изменить экзамен";
            this.btnEditExam.UseVisualStyleBackColor = true;
            this.btnEditExam.Click += new System.EventHandler(this.btnEditExam_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(204, 7);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(199, 27);
            this.btnAddExam.TabIndex = 3;
            this.btnAddExam.Text = "Добавить экзамен";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Группа";
            // 
            // cbNumberGroup
            // 
            this.cbNumberGroup.FormattingEnabled = true;
            this.cbNumberGroup.Location = new System.Drawing.Point(68, 10);
            this.cbNumberGroup.Name = "cbNumberGroup";
            this.cbNumberGroup.Size = new System.Drawing.Size(121, 24);
            this.cbNumberGroup.TabIndex = 1;
            this.cbNumberGroup.SelectedIndexChanged += new System.EventHandler(this.cbNumberGroup_SelectedIndexChanged);
            // 
            // dgExams
            // 
            this.dgExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExams.Location = new System.Drawing.Point(8, 48);
            this.dgExams.Name = "dgExams";
            this.dgExams.Size = new System.Drawing.Size(1260, 476);
            this.dgExams.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1300, 600);
            this.MinimumSize = new System.Drawing.Size(1300, 600);
            this.Name = "FormAdmin";
            this.Text = "Администратор";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatements)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgStatements;
        private System.Windows.Forms.DataGridView dgDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeStatement;
        private System.Windows.Forms.Button btnSetSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.DataGridView dgExams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNumberGroup;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Button btnEditExam;
        private System.Windows.Forms.Button btnDeleteExam;
    }
}