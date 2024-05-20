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
    }
}
