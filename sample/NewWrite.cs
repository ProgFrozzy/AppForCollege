using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class NewWrite : Form
    {
        const string DataBasePath = "Data Source=DESKTOP-VMLJJ4E\\SQLEXPRESS;Initial Catalog=device;Integrated Security=True;TrustServerCertificate=true";
        SqlConnection DataBaseConnection = new SqlConnection(DataBasePath);
        public NewWrite()
        {
            InitializeComponent();
            ComboBox();
        }

        #region ComboBoxObjectTypeItem
        private void ComboBox()
        {
            string getDataFromDB;
            SqlCommand sqlCommand;
            SqlDataReader readDataBase;
            DataBaseConnection.Open();

            /*#region ObjectTypeComboBox
            getDataFromDB = "SELECT [id] FROM ObjectType";

            //Создание экземпляра для получение таблицы
            sqlCommand = new SqlCommand(getDataFromDB, DataBaseConnection);

            readDataBase = sqlCommand.ExecuteReader();

            //Читаем данные из всех столбцов
            while (readDataBase.Read())
            {
                comboBoxObjectType.Items.Add(readDataBase[0].ToString());
            }
            readDataBase.Close();
            #endregion*/

            #region osComboBox
            getDataFromDB = "SELECT [id] FROM OS";

            //Создание экземпляра для получение таблицы
            sqlCommand = new SqlCommand(getDataFromDB, DataBaseConnection);

            readDataBase = sqlCommand.ExecuteReader();

            //Читаем данные из всех столбцов
            while (readDataBase.Read())
            {
                comboBoxOS.Items.Add(readDataBase[0].ToString());
                MessageBox.Show(readDataBase[0].ToString());
            }
            readDataBase.Close();
            #endregion
            #region InterfaceComboBox
            getDataFromDB = "SELECT [id] FROM Interfaces";

            //Создание экземпляра для получение таблицы
            sqlCommand = new SqlCommand(getDataFromDB, DataBaseConnection);

            readDataBase = sqlCommand.ExecuteReader();

            //Читаем данные из всех столбцов
            while (readDataBase.Read())
            {
                comboBoxInterface.Items.Add(readDataBase[0].ToString());
            }
            readDataBase.Close();
            #endregion
            #region LocationMap
            getDataFromDB = "SELECT [id] FROM LocationMap";

            //Создание экземпляра для получение таблицы
            sqlCommand = new SqlCommand(getDataFromDB, DataBaseConnection);

            readDataBase = sqlCommand.ExecuteReader();

            //Читаем данные из всех столбцов
            while (readDataBase.Read())
            {
                comboBoxLocationMap.Items.Add(readDataBase[0].ToString());
            }
            readDataBase.Close();
            #endregion

            DataBaseConnection.Close();
        }
        #endregion

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        #region Кнопки
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            /*Main form = new Main();
            form.Show();
            this.Hide();*/

            string sObjectName="", sResponsible="", sInstalled="";
            int iCabinet=0;
            int iComboType=0, iComboOS=0, iComboInterface=0, iComboLocation=0;
            if((textBoxName.Text.Length > 0) &&
               (textBoxCabinet.Text.Length > 0) &&
               (textBoxResponsible.Text.Length > 0) &&
               (textBoxInstalled.Text.Length > 0) &&
               (comboBoxObjectType.Text.Length > 0) &&
               (comboBoxOS.Text.Length > 0) &&
               (comboBoxInterface.Text.Length > 0) &&
               (comboBoxLocationMap.Text.Length > 0))
            {
                bool fExamination = false;
                try
                {
                    //Присваеваем все данные по переменным для удобства их использования
                    sObjectName = textBoxName.Text;
                    iComboType = Convert.ToInt32(comboBoxObjectType.Text);
                    iComboOS = Convert.ToInt32(comboBoxOS.Text);
                    iCabinet = Convert.ToInt16(textBoxCabinet.Text);
                    iComboInterface = Convert.ToInt32(comboBoxInterface.Text);
                    sResponsible = textBoxResponsible.Text;
                    sInstalled = textBoxInstalled.Text;
                    iComboLocation = Convert.ToInt32(comboBoxLocationMap.Text);
                }
                catch
                {
                    MessageBox.Show("Ошибка! Введите корректные данные!");
                    fExamination = true;
                }

                if(!fExamination)
                {
                    DataBaseConnection.Open();

                    //Запрос на ввод данных в базу данных
                    string sendDataToDataBase = $"INSERT INTO [Object] ([ObjectName], [ObjectType_id], [OS_id], [LocationRoom], [LocationMap_id], [LocationX], [LocationY], [Last_ip], [HVID], [Interfaces_id], [Last_Date_ON], [Responsible], [Installed]) VALUES ('{sObjectName}', {iComboType}, {iComboOS}, {iCabinet}, {iComboLocation}, NULL, NULL, NULL, NULL, {iComboInterface}, NULL, 'ss', 'dd')";
                    //Создание экземпляра для получение таблицы
                    SqlCommand sqlCommand = new SqlCommand(sendDataToDataBase, DataBaseConnection);

                    //Добавляем в каждую ячейку данные
                    sqlCommand.Parameters.AddWithValue("ObjectName", sObjectName);
                    sqlCommand.Parameters.AddWithValue("ObjectType", iComboType);
                    sqlCommand.Parameters.AddWithValue("OS_id", iComboOS);
                    sqlCommand.Parameters.AddWithValue("LocationRoom", iCabinet);
                    sqlCommand.Parameters.AddWithValue("Interfaces_id", iComboInterface);
                    sqlCommand.Parameters.AddWithValue("Responsible", sResponsible);
                    sqlCommand.Parameters.AddWithValue("Installed", sInstalled);

                    sqlCommand.ExecuteNonQuery().ToString();

                    MessageBox.Show("Добавлено!");

                    textBoxName.Clear();
                    comboBoxObjectType.Items.Clear();
                    comboBoxOS.Items.Clear();
                    textBoxCabinet.Clear();
                    comboBoxInterface.Items.Clear();
                    textBoxResponsible.Clear();
                    textBoxInstalled.Clear();

                    DataBaseConnection.Close();

                    Main form = new Main();
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            this.Hide();
        }
        #endregion
    }
}
