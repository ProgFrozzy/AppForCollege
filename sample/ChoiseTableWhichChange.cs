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
using static sample.Main;

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
            string sName;

            DataBaseConnection.Open();

            string getDataFromDB = "SELECT name FROM sys.objects WHERE type in (N'U')";

            SqlCommand sqlCommand = new SqlCommand(getDataFromDB, DataBaseConnection);

            SqlDataReader readDataBase = sqlCommand.ExecuteReader();

            List<string> list = new List<string>();

            //Читаем данные из всех столбцов
            while (readDataBase.Read())
            {
                sName = readDataBase.GetString(0);
                //MessageBox.Show(sName.ToString());
                //comboBoxTables.Items.Add(sName);
                list.Add(sName.ToString());
            }
            readDataBase.Close();

            DataBaseConnection.Close();

            foreach (string s in list)
            {
                MessageBox.Show(s);
                sName = s;
                comboBoxTables.Items.Add(sName);
            }
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

            if (comboBoxTables.Text.Length > 0)
            {
                name.sNameChangingTable = comboBoxTables.Text;
            }
        }
    }
}
