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
    public partial class FormsStudentAddStatement : Form
    {
        private SqlConnection conn = new SqlConnection();
        private int StudentId;

        List<Document> docks = new List<Document>();
        List<Document> newDocuments = new List<Document>();

        struct Document
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
        }

        private Dictionary<string, int> statementDictionary = new Dictionary<string, int>();
        private Dictionary<string, int> typeDocumentDictionary = new Dictionary<string, int>();

        public FormsStudentAddStatement(int studentId)
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;"
          + "Initial Catalog=Деканат;"
         + "User ID=sa;" + "Password=sa;";
            StudentId = studentId;

            cbTypeStatementStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeDocument.DropDownStyle = ComboBoxStyle.DropDownList;

            listBoxNewDocument.Items.Clear();

            LoadTypeStatement();
        }

        private void LoadTypeStatement()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetStatementTypeByStudent";

            cmd.Parameters.AddWithValue("@ID", StudentId);

            conn.Open();

            var reader = cmd.ExecuteReader();

            cbTypeStatementStudent.Items.Clear();

            while (reader.Read())
            {
                int typeStatement = Convert.ToInt32(reader["ID"]);
                cbTypeStatementStudent.Items.Add(reader["Название"]);
                statementDictionary[reader["Название"] + ""] = typeStatement;

            }
            conn.Close();
        }

        private void cbTypeStatementStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetDocumentByStudent";

            cmd.Parameters.AddWithValue("@ID", StudentId);
            cmd.Parameters.AddWithValue("@IdState",statementDictionary[cbTypeStatementStudent.SelectedItem.ToString()]);

            conn.Open();

            var reader = cmd.ExecuteReader();

            checkListBoxDocument.Items.Clear();
            docks.Clear();

            while (reader.Read())
            {
                Document dock = new Document();
                dock.Id = Convert.ToInt32(reader["ID"]);
                dock.Name = reader["Название"].ToString();
                dock.Description = reader["Олимпиада/Статья"].ToString();
                dock.Url = reader["Ссылка"].ToString();
                docks.Add(dock);
            }

            foreach (Document dock in docks)
            {
                checkListBoxDocument.Items.Add(dock.Name.ToString() +" " + dock.Description.ToString());
            }
            conn.Close();

            LoadTypeDocument();
        }

        private void LoadTypeDocument()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetIdDockumentsByTypeStatement";

            cmd.Parameters.AddWithValue("@IdState", statementDictionary[cbTypeStatementStudent.SelectedItem.ToString()]);

            conn.Open();

            var reader = cmd.ExecuteReader();

            cbTypeDocument.Items.Clear();

            while (reader.Read())
            {
                int typeDocument = Convert.ToInt32(reader["Документ"]);
                cbTypeDocument.Items.Add(reader["Название"]);
                typeDocumentDictionary[reader["Название"] + ""] = typeDocument;
            }

            conn.Close();
        }

        private void btnAddNewDocument_Click(object sender, EventArgs e)
        {
            if (cbTypeDocument.SelectedIndex != -1 && !string.IsNullOrEmpty(textBoxUrl.Text) && !string.IsNullOrEmpty(textBoxNameEvent.Text))
            {
                Document document = new Document();
                document.Id = typeDocumentDictionary[cbTypeDocument.SelectedItem.ToString()];
                document.Name = cbTypeDocument.SelectedItem.ToString();
                document.Description = textBoxNameEvent.Text;
                document.Url = textBoxUrl.Text;
                textBoxUrl.Clear();
                textBoxNameEvent.Clear();

                newDocuments.Add(document);
                
                listBoxNewDocument.Items.Add(document.Name + " " + document.Description + " " + document.Url);

            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все текстовые поля и выберите тип документа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int addNewStatement()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddNewStatement";

            cmd.Parameters.AddWithValue("@Student", StudentId);
            cmd.Parameters.AddWithValue("@Type", statementDictionary[cbTypeStatementStudent.SelectedItem.ToString()]);

            SqlParameter outputIdParam = new SqlParameter("@NewId", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputIdParam);

            conn.Open();

            cmd.ExecuteNonQuery();

            int newId = (int)outputIdParam.Value;

            conn.Close();

            return newId;
        }

        private void addExistingDocumentByStatement(int idStatement)
        {

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddDocumentByStatement";

            conn.Open();

            foreach (string document in checkListBoxDocument.CheckedItems) {


                Document findDocument = new Document();

                foreach (Document name in docks)
                {
                    if ((name.Name + " " + name.Description) == document)
                    {
                        findDocument.Id = name.Id;
                        findDocument.Name = name.Name;
                        findDocument.Description = name.Description;
                        findDocument.Url = name.Url;
                        break;
                    }
                }

                cmd.Parameters.AddWithValue("@Заявление", idStatement);
                cmd.Parameters.AddWithValue("@Документ", findDocument.Id);
                cmd.Parameters.AddWithValue("@Название", findDocument.Description);
                cmd.Parameters.AddWithValue("@Ссылка", findDocument.Url);

                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        private void addNewDocumentsByStatement(int idStatement)
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddDocumentByStatement";

            conn.Open();

            foreach (var document in newDocuments)
            {
                cmd.Parameters.AddWithValue("@Заявление", idStatement);
                cmd.Parameters.AddWithValue("@Документ", document.Id);
                cmd.Parameters.AddWithValue("@Название", document.Description);
                cmd.Parameters.AddWithValue("@Ссылка", document.Url);

                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        private void btnAddNewStatement_Click(object sender, EventArgs e)
        {
            int id = addNewStatement();
            addExistingDocumentByStatement(id);
            addNewDocumentsByStatement(id);
            this.Close();
        }

        private void btnAddStatementCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
