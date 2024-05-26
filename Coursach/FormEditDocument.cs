using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursach
{
    public partial class FormEditDocument : Form
    {
        private int idStatement;
        private string curType;
        private int currentType;
        private string name;
        private string url;
        private int oldType;
        private SqlConnection conn = new SqlConnection();
        private Dictionary<string, int> statementDictionary = new Dictionary<string, int>();
        private Dictionary<string, int> typeDocumentDictionary = new Dictionary<string, int>();
        public FormEditDocument(int idStatement, string curType, string name, string url)
        {
            InitializeComponent();
            this.idStatement = idStatement;
            this.curType = curType;
            this.name = name;
            this.url = url;
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;"
          + "Initial Catalog=Деканат;"
         + "User ID=sa;" + "Password=sa;";


            cbTypeDocument.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxNameEvent.Text = name;
            textBoxUrl.Text = url;

            currentType = getTypeStatement();

            addTypeDocument(currentType);
        }

        private int getTypeStatement()
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetTypeDocument";

            cmd.Parameters.AddWithValue("@ID", idStatement);

            conn.Open();

            var reader = cmd.ExecuteReader();

            int typeState = 0;

            while (reader.Read())
            {
                typeState = Convert.ToInt32(reader[0]);
            }

            
            conn.Close();

            return typeState;
        }

        private void addTypeDocument(int typeState)
        {

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetIdDockumentsByTypeStatement";

            cmd.Parameters.AddWithValue("@IdState", typeState);

            conn.Open();

            var reader = cmd.ExecuteReader();

            cbTypeDocument.Items.Clear();

            while (reader.Read())
            {
                int typeDocument = Convert.ToInt32(reader["Документ"]);
                cbTypeDocument.Items.Add(reader["Название"]);
                typeDocumentDictionary[reader["Название"] + ""] = typeDocument;
                if (reader["Название"].Equals(curType))
                {
                    cbTypeDocument.SelectedItem = curType;
                    oldType = typeDocument;

                }
            }

            conn.Close();
        }

        private void btnEdutDocumentAccept_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateDocument";

            cmd.Parameters.AddWithValue("@id", idStatement);
            cmd.Parameters.AddWithValue("@curType", oldType); 
            cmd.Parameters.AddWithValue("@newtype", typeDocumentDictionary[cbTypeDocument.SelectedItem.ToString()]);
            cmd.Parameters.AddWithValue("@oldName", name);
            if (textBoxNameEvent.Text == "" || textBoxNameEvent.Text == null)
            {
                cmd.Parameters.AddWithValue("@newName", name);
            }
            else
            {
                cmd.Parameters.AddWithValue("@newName", textBoxNameEvent.Text);
            }
            if (textBoxUrl.Text == "" || textBoxUrl.Text == null) {
                cmd.Parameters.AddWithValue("@url", url);
            }
            else {
                cmd.Parameters.AddWithValue("@url", textBoxUrl.Text.ToString()); 
            }

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }

        private void btnEditDocumentCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
