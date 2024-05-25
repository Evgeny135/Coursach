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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Coursach
{
    public partial class FormStudentEditStatement : Form
    {
        private SqlConnection conn = new SqlConnection();
        private int IdStudent;
        private string type;
        private int IdStatement;
        private Dictionary<string, int> statementDictionary = new Dictionary<string, int>();
        private Dictionary<string, int> typeDocumentDictionary = new Dictionary<string, int>();

        List<Document> docks = new List<Document>();
        List<Document> newDocuments = new List<Document>();

        struct Document
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Url { get; set; }
        }
        List<string> existDocument = new List<string>();
        public FormStudentEditStatement(int IdStudent, int IdStatement ,string type, List<string> existDocument)
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;"
          + "Initial Catalog=Деканат;"
         + "User ID=sa;" + "Password=sa;";
            this.IdStudent = IdStudent;
            this.type = type;
            this.IdStatement = IdStatement;
            this.existDocument = existDocument;
            cbTypeStatementStudent.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadTypeStatements();
        }


        private void LoadTypeStatements()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetStatementTypeByStudent";

            cmd.Parameters.AddWithValue("@ID", IdStudent);

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

            if (cbTypeStatementStudent.Items.Contains(type))
            {
                cbTypeStatementStudent.SelectedItem = type;
            }
        }


        private void cbTypeStatementStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetDocumentByStudent";

            cmd.Parameters.AddWithValue("@ID", IdStudent);
            cmd.Parameters.AddWithValue("@IdState", statementDictionary[cbTypeStatementStudent.SelectedItem.ToString()]);

            conn.Open();

            var reader = cmd.ExecuteReader();

            checkListBoxDocumentEdit.Items.Clear();
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
                if (existDocument.Contains(dock.Name.ToString() + " " + dock.Description.ToString()))
                {
                    checkListBoxDocumentEdit.Items.Add(dock.Name.ToString() + " " + dock.Description.ToString(),true);
                }
                else
                {
                    checkListBoxDocumentEdit.Items.Add(dock.Name.ToString() + " " + dock.Description.ToString(), false);
                }
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

                listBoxEditNewDocument.Items.Add(document.Name + " " + document.Description + " " + document.Url);

            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все текстовые поля и выберите тип документа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateStatement()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateStatementById";

            conn.Open();
            
            cmd.Parameters.AddWithValue("@ID", IdStatement);
            cmd.Parameters.AddWithValue("@ВидЗаявления", statementDictionary[cbTypeStatementStudent.SelectedItem.ToString()]);

            
            cmd.ExecuteNonQuery();
           

            conn.Close();
        }

        private void addDocument()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddDocumentByStatement";

            conn.Open();

            foreach (string document in checkListBoxDocumentEdit.CheckedItems)
            {


                Document findDocument = new Document();

                foreach (Document name in docks)
                {
                    if ((name.Name + " " + name.Description) == document && !existDocument.Contains(name.Name + " " + name.Description))
                    {
                        findDocument.Id = name.Id;
                        findDocument.Name = name.Name;
                        findDocument.Description = name.Description;
                        findDocument.Url = name.Url;
                        break;
                    }
                }

                if (findDocument.Id != null && findDocument.Name != null && findDocument.Description != null && findDocument.Url != null)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Заявление", IdStatement);
                    cmd.Parameters.AddWithValue("@Документ", findDocument.Id);
                    cmd.Parameters.AddWithValue("@Название", findDocument.Description);
                    cmd.Parameters.AddWithValue("@Ссылка", findDocument.Url);

                    cmd.ExecuteNonQuery();
                }

            }

            conn.Close();
        }

        private void addNewDocumentsByStatement()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddDocumentByStatement";

            conn.Open();

            foreach (var document in newDocuments)
            {
                cmd.Parameters.AddWithValue("@Заявление", IdStatement);
                cmd.Parameters.AddWithValue("@Документ", document.Id);
                cmd.Parameters.AddWithValue("@Название", document.Description);
                cmd.Parameters.AddWithValue("@Ссылка", document.Url);

                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        private void deleteOldDocument()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteDocumentByStatement";

            conn.Open();
           
            foreach (string document in checkListBoxDocumentEdit.Items)
            {
                if (!checkListBoxDocumentEdit.CheckedItems.Contains(document))
                {
                    Document findDocument = new Document();

                    foreach (Document name in docks)
                    {
                        if ((name.Name + " " + name.Description) == document && existDocument.Contains(name.Name + " " + name.Description))
                        {
                            findDocument.Id = name.Id;
                            findDocument.Name = name.Name;
                            findDocument.Description = name.Description;
                            findDocument.Url = name.Url;
                            break;
                        }
                    }
                   
                    if (findDocument.Id != null && findDocument.Name != null && findDocument.Description != null && findDocument.Url != null)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Заявление", IdStatement);
                        cmd.Parameters.AddWithValue("@Документ", findDocument.Id);
                        cmd.Parameters.AddWithValue("@Название", findDocument.Description);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            conn.Close();
        }

        private void btnAddNewStatement_Click(object sender, EventArgs e)
        {
            updateStatement();
            deleteOldDocument();
            addDocument();
            addNewDocumentsByStatement();
            this.Close();
        }

        private void btnAddStatementCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
