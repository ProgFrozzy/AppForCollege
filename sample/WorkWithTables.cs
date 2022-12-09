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
    public partial class WorkWithTables : Form
    {
        
        const string DataBasePath = "Data Source=DESKTOP-VMLJJ4E\\SQLEXPRESS;Initial Catalog=device;Integrated Security=True;TrustServerCertificate=true";
        SqlConnection DataBaseConnection = new SqlConnection(DataBasePath);

        public WorkWithTables()
        {
            InitializeComponent();
            getDataFromTable();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            this.Hide();
        }

        private void getDataFromTable()
        {
            ChangingTable name = new ChangingTable();

            DataBaseConnection.Open();
            string sName = name.sNameTable;
            string command = $"SELECT * FROM {sName}";
            SqlCommand getDataFromTable = new SqlCommand(command, DataBaseConnection);

            //В классее sqlCommand есть метод executeReader, а sqlDataReader позволяет нам читать сразу несколько столбцов
            SqlDataReader sqlDataReader = getDataFromTable.ExecuteReader();

            List<string[]> listDataFromTable = new List<string[]>();

            while (sqlDataReader.Read())
            {
                //Сколько столбцов столько и ячеек в массиве
                listDataFromTable.Add(new string[1]);

                // Обращаемся к листу   к последней ячейки    какой столбец такой и номер

                listDataFromTable[listDataFromTable.Count - 1][0] = sqlDataReader[0].ToString();
            }

            DataBaseConnection.Close();

            foreach (string[] s in listDataFromTable)
            {
                dataGridView1.Rows.Add(s);
            }
        }
    }
}
