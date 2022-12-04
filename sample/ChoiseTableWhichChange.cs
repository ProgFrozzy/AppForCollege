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

namespace sample
{
    public partial class ChoiseTableWhichChange : Form
    {
        const string DataBasePath = "Data Source=DESKTOP-VMLJJ4E\\SQLEXPRESS;Initial Catalog=device;Integrated Security=True;TrustServerCertificate=true";
        SqlConnection DataBaseConnection = new SqlConnection(DataBasePath);

        public ChoiseTableWhichChange()
        {
            loadItemsComboBoxTables();
            InitializeComponent();
        }

        private void loadItemsComboBoxTables()
        {
            string getDataFromDB;
            SqlCommand sqlCommand;
            SqlDataReader readDataBase;
            DataBaseConnection.Open();

            getDataFromDB = $"SELECT name FROM sys.objects WHERE type in (N'U')";

            //Создание экземпляра для получение таблицы
            sqlCommand = new SqlCommand(getDataFromDB, DataBaseConnection);

            readDataBase = sqlCommand.ExecuteReader();

            //Читаем данные из всех столбцов
            while (readDataBase.Read())
            {
                comboBoxTables.Items.Add(readDataBase[0].ToString());
            }
            readDataBase.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Main OpeningForm = new Main();
            OpeningForm.Show();
            this.Hide();
        }

        private void buttonChoise_Click(object sender, EventArgs e)
        {

        }
    }
}
