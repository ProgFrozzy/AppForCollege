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

            SqlCommand getDataFromTable = new SqlCommand($"SELECT * FROM {name.sNameChangingTable}", DataBaseConnection);

            //В классее sqlCommand есть метод executeReader, а sqlDataReader позволяет нам читать сразу несколько столбцов
            SqlDataReader sqlDataReader = getDataFromTable.ExecuteReader();

            List<string[]> listDataFromTable = new List<string[]>();

            while (sqlDataReader.Read())
            {
                //Сколько столбцов столько и ячеек в массиве
                listDataFromTable.Add(new string[15]);

                // Обращаемся к листу   к последней ячейки    какой столбец такой и номер

                listDataFromTable[listDataFromTable.Count - 1][0] = sqlDataReader[0].ToString();
                listDataFromTable[listDataFromTable.Count - 1][1] = sqlDataReader[1].ToString();
                listDataFromTable[listDataFromTable.Count - 1][2] = sqlDataReader[2].ToString();
                listDataFromTable[listDataFromTable.Count - 1][3] = sqlDataReader[3].ToString();
                listDataFromTable[listDataFromTable.Count - 1][4] = sqlDataReader[4].ToString();
                listDataFromTable[listDataFromTable.Count - 1][5] = sqlDataReader[5].ToString();
                listDataFromTable[listDataFromTable.Count - 1][6] = sqlDataReader[6].ToString();
                listDataFromTable[listDataFromTable.Count - 1][7] = sqlDataReader[7].ToString();
                listDataFromTable[listDataFromTable.Count - 1][8] = sqlDataReader[8].ToString();
                listDataFromTable[listDataFromTable.Count - 1][9] = sqlDataReader[9].ToString();
                listDataFromTable[listDataFromTable.Count - 1][10] = sqlDataReader[10].ToString();
                listDataFromTable[listDataFromTable.Count - 1][11] = sqlDataReader[11].ToString();
                listDataFromTable[listDataFromTable.Count - 1][12] = sqlDataReader[12].ToString();
                listDataFromTable[listDataFromTable.Count - 1][13] = sqlDataReader[13].ToString();
                listDataFromTable[listDataFromTable.Count - 1][14] = sqlDataReader[14].ToString();
            }

            DataBaseConnection.Close();

            foreach (string[] s in listDataFromTable)
            {
                dataGridView1.Rows.Add(s);
            }
        }
    }
}
