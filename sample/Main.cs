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
    public partial class Main : Form
    {
        const string DataBasePath = "Data Source=DESKTOP-VMLJJ4E\\SQLEXPRESS;Initial Catalog=device;Integrated Security=True;TrustServerCertificate=true";
        SqlConnection DataBaseConnection = new SqlConnection(DataBasePath);
        
        public Main()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataBaseConnection.Open();

            SqlCommand getDataFromTable = new SqlCommand("SELECT * FROM objects_View", DataBaseConnection);

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

        #region Кнопки
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //Очищаем таблицу
            dataGridView1.Rows.Clear();
            LoadData();
        }


        private void buttonNewWrite_Click(object sender, EventArgs e)
        {
            NewWrite OpeningForm = new NewWrite();
            OpeningForm.Show();
            this.Hide();
        }

        private void buttonTemplate_Click(object sender, EventArgs e)
        {
            ChoiseTableWhichChange OpeningForm = new ChoiseTableWhichChange();
            OpeningForm.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteEntry OpeningForm = new DeleteEntry();
            OpeningForm.Show();
            this.Hide();
        }
        #endregion

        #region поиск
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Сохраняем все данные в лист data и позже его выводим
            List<string[]> listDataFromTable = new List<string[]>();

            //Очищаем таблицу
            dataGridView1.Rows.Clear();

            if (textBoxSearch.Text.Length == 0)
            {
                LoadData();
            }
            else
            {
                DataBaseConnection.Open();
                bool flag = false;

                string sSearch = textBoxSearch.Text;
                flag = false;

                if (!flag)
                {
                    //Запрос на получение данных из базы данных
                    string getDataFromDB = $"select * from objects_View where concat (id, ObjectName, ObjectType, OS_Name, LocationRoom, interface) like '%" + textBoxSearch.Text + "%'";

                    //Создание экземпляра для получение таблицы
                    SqlCommand sqlCommand = new SqlCommand(getDataFromDB, DataBaseConnection);

                    //Считываем таблицу
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        //Сколько столбцов столько и ячеек в массиве
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

                    sqlDataReader.Close();
                }
            }
            foreach (string[] s in listDataFromTable)
            {
                dataGridView1.Rows.Add(s);
            }
            DataBaseConnection.Close();
            #endregion
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
