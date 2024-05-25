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
    public partial class FormEditExam : Form
    {
        private SqlConnection conn = new SqlConnection();
        private Dictionary<string, int> disciplineDictionary = new Dictionary<string, int>();
        private string nameDiscipline;
        private DateTime oldDate;
        private string StudentId;

        public FormEditExam(string nameDiscipline, DateTime date, string mark, string StudentId)
        {
            InitializeComponent();
            this.nameDiscipline = nameDiscipline;
            this.oldDate = date;
            this.StudentId = StudentId;
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;"
           + "Initial Catalog=Деканат;"
          + "User ID=sa;" + "Password=sa;";

            cbDiscipline.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMark.DropDownStyle = ComboBoxStyle.DropDownList;

            loadDisciplines();

            cbDiscipline.SelectedItem = nameDiscipline;
            cbMark.Items.Clear();
            cbMark.Items.Add("2");
            cbMark.Items.Add("3");
            cbMark.Items.Add("4");
            cbMark.Items.Add("5");
            cbMark.SelectedItem = mark;

            dateTimeExam.Value = date;

        }

        private void loadDisciplines()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT ID, Название
                                FROM Дисциплины";


            conn.Open();

            cbDiscipline.Items.Clear();
            
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idTypeDocument = Convert.ToInt32(reader["ID"]);
                cbDiscipline.Items.Add(reader["Название"]);
                disciplineDictionary[reader["Название"].ToString()] = idTypeDocument;
            }

            conn.Close();
        }

        private void btnAcceptEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EditExam";

            cmd.Parameters.AddWithValue("@student", StudentId);
            cmd.Parameters.AddWithValue("@oldDiscipline", disciplineDictionary[nameDiscipline]);
            cmd.Parameters.AddWithValue("@newDiscipline", disciplineDictionary[cbDiscipline.SelectedItem.ToString()]);
            cmd.Parameters.AddWithValue("@oldDate", oldDate);
            cmd.Parameters.AddWithValue("@newDate", dateTimeExam.Value);
            cmd.Parameters.AddWithValue("mark", cbMark.SelectedItem.ToString());


            conn.Open();

            cmd.ExecuteNonQuery();
            

            conn.Close();

            this.Close();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
