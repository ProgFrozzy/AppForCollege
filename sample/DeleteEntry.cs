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
    public partial class DeleteEntry : Form
    {
        const string DataBasePath = "Data Source=DESKTOP-VMLJJ4E\\SQLEXPRESS;Initial Catalog=device;Integrated Security=True;TrustServerCertificate=true";
        SqlConnection DataBaseConnection = new SqlConnection(DataBasePath);

        public DeleteEntry()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool fNoError = false;
            int iId = 0;
            if (textBoxDelete.Text.Length > 0)
            {
                try
                {
                    iId = Convert.ToInt32(textBoxDelete.Text);
                }
                catch
                {
                    MessageBox.Show("Ошибка! Введите номер объекта!");
                    fNoError = true;
                }
                if (!fNoError)
                {
                    DataBaseConnection.Open();

                    //Запрос на получение данных из базы данных
                    string commandText = $"DELETE FROM Object WHERE id = {iId}";

                    //Создание экземпляра для получение таблицы
                    SqlCommand command = new SqlCommand(commandText, DataBaseConnection);

                    command.ExecuteNonQuery().ToString();

                    DataBaseConnection.Close();

                    MessageBox.Show("Удалено!");

                    Main form = new Main();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Введите номер записи!");
            }


        }
    }
}
