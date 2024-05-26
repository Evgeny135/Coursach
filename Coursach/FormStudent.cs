using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursach
{
    public partial class FormStudent : Form
    {
        private SqlConnection conn = new SqlConnection();
        private int IdStudent;
        private DataSet ds;
        private SqlDataAdapter adapter;


        public FormStudent(int id, string text)
        {
            InitializeComponent();
            this.IdStudent = id;

            labelCurrentStudent.Text = text;

            dgStudentExams.ReadOnly = true;
            dgStatementStudent.ReadOnly = true;
            dgStatementStudent.MultiSelect = false;
            dgStatementsDocument.ReadOnly = true;

            foreach (DataGridViewColumn col in dgStatementStudent.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgStatementStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;"
           + "Initial Catalog=Деканат;"
          + "User ID=sa;" + "Password=sa;";

            LoadExamsByStudent();
            LoadStatementByStudent();
        }

        private void LoadExamsByStudent()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetExamsByStudent";

            cmd.Parameters.AddWithValue("@ID", IdStudent);

            conn.Open();

            adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            ds = new DataSet();
            adapter.Fill(ds);

            dgStudentExams.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void LoadStatementByStudent()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetStatementByStudent";

            cmd.Parameters.AddWithValue("@ID", IdStudent);

            conn.Open();

            adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            ds = new DataSet();
            adapter.Fill(ds);

            dgStatementStudent.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void dgStatementStudent_SelectionChanged(object sender, EventArgs e)
        {
            conn.Close();
            if (dgStatementStudent.CurrentRow != null && dgStatementStudent.CurrentRow.Index >= 0)
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDocumentByStatement";

                cmd.Parameters.AddWithValue("@ID", dgStatementStudent.CurrentRow.Cells[0].Value.ToString());

                conn.Open();

                adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;

                ds = new DataSet();
                adapter.Fill(ds);

                dgStatementsDocument.DataSource = ds.Tables[0];

                conn.Close();
            }
            
        }

        private void btnAddStatementByStudent_Click(object sender, EventArgs e)
        {
            FormsStudentAddStatement form = new FormsStudentAddStatement(IdStudent);
            form.Show();
            form.FormClosed += new FormClosedEventHandler(closeForms);
        }

        private void closeForms(object sender, FormClosedEventArgs e)
        {
            LoadStatementByStudent();
        }

        private void btnDeleteStatementStudent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Удалить заявление и привязанные к нему документы с номером " + dgStatementStudent.CurrentRow.Cells[0].Value.ToString() + " ?",
               "Удалить ?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteStatementById";

                cmd.Parameters.AddWithValue("@ID", dgStatementStudent.CurrentRow.Cells[0].Value.ToString());

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadStatementByStudent();
            }
        }

        private void btnEditStatementStudent_Click(object sender, EventArgs e)
        {
            List<string> documents = new List<string>();
            foreach (DataGridViewRow row in dgStatementsDocument.Rows)
            {
                if (!row.IsNewRow)
                {
                    documents.Add(row.Cells[0].Value.ToString() + " " + row.Cells[1].Value.ToString());
                }
            }
            if (dgStatementStudent.CurrentRow != null  && dgStatementStudent.CurrentRow.Cells[0].Value != null)
            {
                if (!dgStatementStudent.CurrentRow.IsNewRow)
                {
                    FormStudentEditStatement form = new FormStudentEditStatement(IdStudent, Convert.ToInt32(dgStatementStudent.CurrentRow.Cells[0].Value), dgStatementStudent.CurrentRow.Cells[1].Value.ToString(), documents);
                    form.Show();
                    form.FormClosed += new FormClosedEventHandler(closeForms);
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a valid row.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEditDocument_Click(object sender, EventArgs e)
        {
            if (dgStatementStudent.CurrentRow != null && dgStatementsDocument.CurrentRow != null)
            {
                if (dgStatementStudent.CurrentRow.Cells[0].Value != null &&
                    dgStatementsDocument.CurrentRow.Cells[0].Value != null &&
                    dgStatementsDocument.CurrentRow.Cells[1].Value != null &&
                    dgStatementsDocument.CurrentRow.Cells[2].Value != null)
                {
                    FormEditDocument form = new FormEditDocument(
                        Convert.ToInt32(dgStatementStudent.CurrentRow.Cells[0].Value),
                        dgStatementsDocument.CurrentRow.Cells[0].Value.ToString(),
                        dgStatementsDocument.CurrentRow.Cells[1].Value.ToString(),
                        dgStatementsDocument.CurrentRow.Cells[2].Value.ToString());

                    form.Show();
                    form.FormClosed += new FormClosedEventHandler(closeForms);
                }
                else
                {
                    MessageBox.Show("Ошибка.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Не выбрано заявление.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
