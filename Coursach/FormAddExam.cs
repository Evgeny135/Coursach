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
using System.Xml.Linq;

namespace Coursach
{
    public partial class FormAddExam : Form
    {
        private SqlConnection conn = new SqlConnection();
        private DataSet ds;
        private SqlDataAdapter adapter;

        private Dictionary<string, int> disciplineDictionary = new Dictionary<string, int>();

        public FormAddExam()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;"
           + "Initial Catalog=Деканат;"
          + "User ID=sa;" + "Password=sa;";

            cbNumberGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDiscipline.DropDownStyle = ComboBoxStyle.DropDownList;
            //dgStudent.ReadOnly = true;
            dgStudent.AllowUserToAddRows = false;
            dgStudent.AllowUserToDeleteRows = false;
            dgStudent.MultiSelect = false;

            calendar.MaxSelectionCount = 1;

            loadNumberGroup();

            loadDisciplines();
        }

        private void loadDisciplines()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT Дисциплины.ID, Дисциплины.Название
                                FROM Дисциплины";


            conn.Open();

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int idDiscipline = Convert.ToInt32(reader["ID"]);
                cbDiscipline.Items.Add(reader["Название"]);
                disciplineDictionary[reader["Название"]+""] = idDiscipline;
            }

            conn.Close();

        }

        private void loadNumberGroup()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT DISTINCT Студенты.Группа
                                FROM Студенты";


            conn.Open();

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbNumberGroup.Items.Add(reader["Группа"]);
            }

            conn.Close();
        }

        private void cbNumberGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT Студенты.ID,Студенты.Фамилия, Студенты.Имя, Студенты.Отчество
                                FROM Студенты
                                WHERE Студенты.Группа = " + "@group";

            cmd.Parameters.AddWithValue("@group", cbNumberGroup.SelectedItem.ToString());


            conn.Open();

            adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            ds = new DataSet();
            adapter.Fill(ds);

            dgStudent.Columns.Clear();

            DataTable studentTable = ds.Tables[0];
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "Оценка";
            comboBoxColumn.HeaderText = "Оценка";
            comboBoxColumn.DataPropertyName = "Оценка";
            comboBoxColumn.Items.AddRange("2","3","4","5");


            dgStudent.DataSource = studentTable;
            dgStudent.Columns.Add(comboBoxColumn);

            dgStudent.Columns["ID"].ReadOnly = true;
            dgStudent.Columns["Фамилия"].ReadOnly = true;
            dgStudent.Columns["Имя"].ReadOnly = true;
            dgStudent.Columns["Отчество"].ReadOnly = true;
            dgStudent.Columns["Оценка"].ReadOnly = false;

            conn.Close();
        }

        private void btnAddNewExam_Click(object sender, EventArgs e)
        {
            if (cbNumberGroup.SelectedItem != null && cbDiscipline.SelectedItem != null)
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddExams";

                foreach (DataGridViewRow row in dgStudent.Rows)
                {
                    if (row.IsNewRow) continue; // Пропустить пустую строку для добавления новой записи
                    if (row.Cells["Оценка"].Value != null)
                    {

                        conn.Open();

                        int id = Convert.ToInt32(row.Cells["ID"].Value);
                        string grade = row.Cells["Оценка"].Value?.ToString(); // Возможно, значение будет null

                        cmd.Parameters.AddWithValue("@student", id);
                        cmd.Parameters.AddWithValue("@disciplineId", disciplineDictionary[cbDiscipline.SelectedItem.ToString()]);
                        cmd.Parameters.AddWithValue("@date", calendar.SelectionStart.ToShortDateString());
                        cmd.Parameters.AddWithValue("@mark", grade);

                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Выставите оценки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните номер группы и дисциплины.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
