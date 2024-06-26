﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursach
{
    public partial class FormAdmin : Form
    {
        private SqlConnection conn = new SqlConnection();
        private DataSet ds;
        private SqlDataAdapter adapter;

        private Dictionary<string, int> typeDocumentDictionary = new Dictionary<string, int>();
        private Dictionary<string, int> disciplineDictionary = new Dictionary<string, int>();
        public FormAdmin()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;"
           + "Initial Catalog=Деканат;"
          + "User ID=sa;" + "Password=sa;";

            dgStatements.ReadOnly = true;
            cbTypeStatement.DropDownStyle =  ComboBoxStyle.DropDownList;
            cbNumberGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            dgDocument.ReadOnly = true;
            dgStatements.MultiSelect = false;
            dgExams.MultiSelect = false;
            dgExams.ReadOnly = true;


            LoadAllStatements();

            loadTypeStatements();

            loadAllExams();

            loadNumberGroup();

            loadNameDiscipline();

            cbTypeStatement.SelectedIndex = 0;
        }

        private void loadAllExams()
        {
            conn.Close();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT Студенты.ID,Студенты.Фамилия, Студенты.Имя, Студенты.Отчество, Студенты.Группа, Дисциплины.Название, Экзамены.ДатаСдачи, Оценка
                                FROM Экзамены JOIN Студенты ON Студенты.ID = Экзамены.Студент JOIN Дисциплины ON Дисциплины.ID = Экзамены.Дисциплина";


            conn.Open();

            adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            ds = new DataSet();
            adapter.Fill(ds);

            dgExams.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void loadTypeStatements()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT ВидЗаявления.ID, Название
                                FROM ВидЗаявления";


            conn.Open();

            cbTypeStatement.Items.Clear();
            cbTypeStatement.Items.Add("Все");

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idTypeDocument = Convert.ToInt32(reader["ID"]);
                cbTypeStatement.Items.Add(reader["Название"]);
                typeDocumentDictionary[reader["Название"].ToString()] = idTypeDocument;
            }

            conn.Close();
        }

        private void LoadAllStatements()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT Заявления.ID, Студенты.Фамилия, Студенты.Имя, Студенты.Отчество, ВидЗаявления.Название AS Вид, Дата, Статус.Название AS Статус
                                FROM Заявления JOIN Студенты ON Заявления.Студент = Студенты.ID 
                                JOIN ВидЗаявления ON Заявления.ВидЗаявления = ВидЗаявления.ID JOIN Статус ON Статус.ID = Заявления.Статус";


            conn.Open();

            adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            ds = new DataSet();
            adapter.Fill(ds);

            dgStatements.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void dgStatements_SelectionChanged(object sender, EventArgs e)
        {
            conn.Close();
            if (dgStatements.CurrentRow != null && dgStatements.CurrentRow.Index >= 0)
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDocumentByStatement";

                cmd.Parameters.AddWithValue("@ID", dgStatements.CurrentRow.Cells[0].Value.ToString());

                conn.Open();

                adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;

                ds = new DataSet();
                adapter.Fill(ds);

                dgDocument.DataSource = ds.Tables[0];

                conn.Close();
            }
        }

        private void loadNumberGroup()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT DISTINCT Студенты.Группа
                                FROM Студенты";


            conn.Open();

            var reader = cmd.ExecuteReader();

            cbNumberGroup.Items.Clear();

            cbNumberGroup.Items.Add("Все");

            while (reader.Read())
            {
                cbNumberGroup.Items.Add(reader["Группа"]);
            }

            conn.Close();

            cbNumberGroup.SelectedIndex = 0;
        }

        private void loadNameDiscipline()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT ID, Название
                                FROM Дисциплины";


            conn.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idTypeDocument = Convert.ToInt32(reader["ID"]);
                disciplineDictionary[reader["Название"].ToString()] = idTypeDocument;
            }

            conn.Close();
        }

        private void cbTypeStatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeStatement.SelectedItem.ToString() != "Все") {
                SqlCommand cmd = conn.CreateCommand();


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetStatementByTypeDocument";

                cmd.Parameters.AddWithValue("@TypeState", typeDocumentDictionary[cbTypeStatement.SelectedItem.ToString()]);

                conn.Open();

                adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;

                ds = new DataSet();
                adapter.Fill(ds);

                dgStatements.DataSource = ds.Tables[0];

                conn.Close();
            }
            else
            {
                LoadAllStatements();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Отклоняем ввод
            }
        }

        private void btnSetSalary_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCount.Text.ToString()) && Regex.IsMatch(textBoxCount.Text, "\\d+"))
            {
                if (Convert.ToInt32(textBoxCount.Text) >= 1)
                {
                    if (cbTypeStatement.SelectedItem.ToString() != "Все")
                    {
                        SqlCommand cmd = conn.CreateCommand();


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SetSalary";

                        cmd.Parameters.AddWithValue("@TypeState", typeDocumentDictionary[cbTypeStatement.SelectedItem.ToString()]);
                        cmd.Parameters.AddWithValue("@count", textBoxCount.Text);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        LoadAllStatements();

                        loadTypeStatements();

                        cbTypeStatement.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Нельзя провести конкурс, выберите типы заявлений.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }else
            {
                MessageBox.Show("Введите количество мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbNumberGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNumberGroup.SelectedItem.ToString() != "Все")
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = @"SELECT Студенты.ID,Студенты.Фамилия, Студенты.Имя, Студенты.Отчество, Студенты.Группа, Дисциплины.Название, Экзамены.ДатаСдачи, Оценка
                                FROM Экзамены JOIN Студенты ON Студенты.ID = Экзамены.Студент JOIN Дисциплины ON Дисциплины.ID = Экзамены.Дисциплина
                                WHERE Студенты.Группа = " + "@group";

                cmd.Parameters.AddWithValue("@group", cbNumberGroup.SelectedItem.ToString());


                conn.Open();

                adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;

                ds = new DataSet();
                adapter.Fill(ds);

                dgExams.DataSource = ds.Tables[0];

                conn.Close();
            }
            else
            {
                loadAllExams();
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
           
                FormAddExam form = new FormAddExam();
                form.Show();
                form.FormClosed += new FormClosedEventHandler(closeForms);
      
        }

        private void closeForms(object sender, FormClosedEventArgs e)
        {
            loadAllExams();
            cbNumberGroup.SelectedIndex = 0;
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            string dateString = dgExams.CurrentRow.Cells[6].Value.ToString();

            DateTime examDate;
            bool isValidDate = DateTime.TryParse(dateString, out examDate);

            FormEditExam form = new FormEditExam(dgExams.CurrentRow.Cells[5].Value.ToString(), examDate, dgExams.CurrentRow.Cells[7].Value.ToString(), dgExams.CurrentRow.Cells[0].Value.ToString());
            form.Show();
            form.FormClosed += new FormClosedEventHandler(closeForms);
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Удалить запись о экзамене " + dgExams.CurrentRow.Cells[1].Value.ToString() + " " + dgExams.CurrentRow.Cells[4].Value.ToString() + " " +
               dgExams.CurrentRow.Cells[5].Value.ToString() + " ?",
               "Удалить ?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteExam";

                cmd.Parameters.AddWithValue("@student", dgExams.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@discipline", disciplineDictionary[dgExams.CurrentRow.Cells[5].Value.ToString()]);
                cmd.Parameters.AddWithValue("@date", dgExams.CurrentRow.Cells[6].Value.ToString());

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();

                loadAllExams();
                cbNumberGroup.SelectedIndex = 0;
            }
        }
    }
}
