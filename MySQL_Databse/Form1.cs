using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MySQL_Databse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView_database("SELECT * FROM department;");
        }
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "simplehr";
            string username = "root";
            string password = "";
            String connString = "Server=" + host + ";Database=" + database
            + ";port=" + port + ";User Id=" + username + ";password=" +
            password;
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }

        private void dataGridView_database(string script)
        {
            try
            {
                MySqlConnection conn = GetDBConnection();
                conn.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dataGridView1.DataSource = table;
                conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка: " + er.Message);
            }
        }






        private void btnClose(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnUpdate(object sender, EventArgs e)
        {
            dataGridView_database("SELECT * FROM department;");
        }

        private void btnDelete(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
            {
                if (dataGridView1.Rows[0].IsNewRow) { MessageBox.Show("Таблица пуста"); }
                else
                {
                    if (!dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].IsNewRow)
                    {
                        DialogResult result = MessageBox.Show("Вы хотите удалить выбранную строку?", "Удаление", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    }
                    else { MessageBox.Show("Ошибка: для удаления строки необходимо выбрать строку или значение этой строки"); }
                }
            }

        }




            /*        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\source\\repos\\MySQL_Databse\\institut.accdb";

                    private void dataGridView_database(string script)
                    {
                        DataTable table = new DataTable();

                        using (OleDbConnection connection = new OleDbConnection(connectionString))
                        {
                            connection.Open();
                            MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connectionString);
                            ms_data.Fill(table);
                            connection.Close();
                        }
                        dataGridView1.DataSource = table;

                    }*/

        }
}