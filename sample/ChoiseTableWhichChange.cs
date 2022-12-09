using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static sample.Main;

namespace sample
{
    public partial class ChoiseTableWhichChange : Form
    {        

        const string DataBasePath = "Data Source=DESKTOP-VMLJJ4E\\SQLEXPRESS;Initial Catalog=device;Integrated Security=True;TrustServerCertificate=true";
        SqlConnection DataBaseConnection = new SqlConnection(DataBasePath);

        public ChoiseTableWhichChange()
        {
            InitializeComponent();
            loadItemsComboBoxTables();
        }


        private void loadItemsComboBoxTables()
        {
            string sName;

            DataBaseConnection.Open();

            string getDataFromDB = "SELECT name FROM sys.objects WHERE type in (N'U')";

            SqlCommand sqlCommand = new SqlCommand("SELECT name FROM sys.objects WHERE type in (N'U')", DataBaseConnection);

            SqlDataReader readDataBase = sqlCommand.ExecuteReader();

            List<string[]> list = new List<string[]>();
            //Читаем данные из всех столбцов
            while (readDataBase.Read())
            {
                sName = readDataBase.GetString(0);
                list.Add(new string[1]);
                comboBoxTables.Items.Add(sName);
            }
            readDataBase.Close();

            DataBaseConnection.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Main OpeningForm = new Main();
            OpeningForm.Show();
            this.Hide();
        }

        private void buttonChoise_Click(object sender, EventArgs e)
        {
            ChangingTable name = new ChangingTable();

            name.sNameTable = comboBoxTables.Text;

            WorkWithTables OpeningForm = new WorkWithTables();
            OpeningForm.Show();
            this.Hide();
        }
    }
}
