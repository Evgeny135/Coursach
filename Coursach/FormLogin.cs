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
    public partial class FormLogin : Form
    {
        private SqlConnection conn = new SqlConnection();
        private string TextStudent;

        private Dictionary<string, int> studentDictionary = new Dictionary<string, int>();
        public FormLogin()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;"
           + "Initial Catalog=Деканат;"
          + "User ID=sa;" + "Password=sa;";

            cbStudentLogin.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnLoginStudent_Click(object sender, EventArgs e)
        {
            cbStudentLogin.Visible = true;
            btnLoginStudentAccept.Visible = true;
            btnStudentLoginCancel.Visible = true;

            cbStudentLogin.Items.Clear();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT Студенты.ID, Студенты.Фамилия, Студенты.Имя, Студенты.Отчество, Студенты.Группа
                                FROM Студенты";

            conn.Open();
            
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int studentID = Convert.ToInt32(reader["ID"]);

                cbStudentLogin.Items.Add(reader["Фамилия"] + " " + reader["Имя"] + " " + reader["Отчество"] + " " + reader["Группа"]);
                studentDictionary[reader["Фамилия"] + " " + reader["Имя"] + " " + reader["Отчество"] + " " + reader["Группа"]] = studentID;
            }

            conn.Close();

        }

        private void btnStudentLoginCancel_Click(object sender, EventArgs e)
        {
            cbStudentLogin.Visible =false;
            btnStudentLoginCancel.Visible = false;
            btnLoginStudentAccept.Visible = false;
        }

        private void btnLoginStudentAccept_Click(object sender, EventArgs e)
        {
            if (cbStudentLogin.SelectedItem != null)
            {
                string selectedStudent = cbStudentLogin.SelectedItem.ToString();
                if (studentDictionary.ContainsKey(selectedStudent))
                {
                    int studentID = studentDictionary[selectedStudent];
                    FormStudent formStudent = new FormStudent(studentID, selectedStudent);
                    formStudent.Show();
                    this.Visible = false;
                    formStudent.FormClosed += new FormClosedEventHandler(closeForms);
                }
                else
                {
                    MessageBox.Show("Selected student not found in the dictionary.");
                }
            }       
          
        }

        private void closeForms(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void brnLoginAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin();
            this.Visible = false;
            form.Show();
            form.FormClosed += new FormClosedEventHandler(closeForms);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
