using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;
using System.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.AccessControl;

namespace TurAgentstvo
{
    public partial class ClientControl : Form
    {
        public string nomer_pass;

        MySqlConnection conn;
        public ClientControl()
        {
            InitializeComponent();
        }
        private void ClientControl_Load(object sender, EventArgs e)
        {
            nomer_pass = nomer.Text;

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите закрыть данное окно?", "Закрытие окна", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();

        }
        private void btnControl_Click(object sender, EventArgs e)
        {
            conn = DbConn.GetDBConnection();

            if (btnControl.Text == "Добавить")
            {
                MySqlDataAdapter ms_data = new MySqlDataAdapter($"SELECT id_country FROM countries WHERE name = '{country.Text}';", conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                if (name.Text == "" || name.Text == "" || surname.Text == "" || seriya.Text == "" || seriya.Text.Length != 4 || nomer.Text == "" || nomer.Text.Length != 6 || country.Text == "" || email.Text == "")
                {
                    MessageBox.Show("Данные введены неверно", "Не удалось добавить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (table.Rows.Count > 0)
                {
                    string id_country = table.Rows[0].ItemArray[0].ToString();
                    char gender = radioButton1.Checked ? 'М' : 'Ж';

                    string script = $"INSERT INTO clients (name, surname, patronymic, gender, passport_seriya, passport_number, id_country, birth_date, `E-mail`, phone)" +
                                    $"VALUES ( '{name.Text}', '{surname.Text}', '{patronymic.Text}', '{gender}', '{seriya.Text}', '{nomer.Text}', '{id_country}', '{birth_date.Value.ToString("yyyy-MM-dd")}', '{email.Text}', '{phone.Text}' );";
                    var sqlcommand = new MySqlCommand(script, conn);

                    var result = MessageBox.Show("Добавить клиента?", "Добавление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        try
                        {
                            sqlcommand.ExecuteNonQuery();
                            MessageBox.Show("Клиент успешно был добавлен", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            if (ex.Message == $"Duplicate entry '{nomer.Text}' for key 'UK_clients_passport_number'")
                                MessageBox.Show("Клиент с таким номером паспорта уже существует", "Не удалось добавить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        conn.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Введенной страны не существует", "Не удалось добавить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (btnControl.Text == "Редактировать")
            {
                //UPDATE clients SET name = '', surname = '', patronymic = '', gender = '', passport_seriya = '', number_passport = '', id_country = '', birth_date = '', `E-mail` = '', phone = '' WHERE number_passport = ''

                MySqlDataAdapter ms_data = new MySqlDataAdapter($"SELECT id_country FROM countries WHERE name = '{country.Text}';", conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                if (name.Text == "" || name.Text == "" || surname.Text == "" || seriya.Text == "" || seriya.Text.Length != 4 || nomer.Text == "" || nomer.Text.Length != 6 || country.Text == "" || email.Text == "")
                {
                    MessageBox.Show("Данные введены неверно", "Не удалось добавить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (table.Rows.Count > 0)
                {
                    string id_country = table.Rows[0].ItemArray[0].ToString();
                    char gender = radioButton1.Checked ? 'М' : 'Ж';

                    string script = $"UPDATE clients SET name = '{name.Text}', surname = '{surname.Text}', patronymic = '{patronymic.Text}', gender = '{gender}', passport_seriya = '{seriya.Text}', passport_number = '{nomer.Text}', id_country = '{id_country}', birth_date = '{birth_date.Value.ToString("yyyy-MM-dd")}', `E-mail` = '{email.Text}', phone = '{phone.Text}'  WHERE passport_number = '{nomer_pass}'; ";
                    var sqlcommand = new MySqlCommand(script, conn);

                    var result = MessageBox.Show("Подтвердить изменение данных клиента?", "Редактирование", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        try
                        {
                            sqlcommand.ExecuteNonQuery();
                            MessageBox.Show("Данные клиента успешно были изменены", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            if (ex.Message == $"Duplicate entry '{nomer.Text}' for key 'UK_clients_passport_number'")
                                MessageBox.Show("Клиент с таким номером паспорта уже существует", "Не удалось добавить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        conn.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Введенной страны не существует", "Не удалось добавить", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }



        }
        private void text_formation(object sender, KeyPressEventArgs e)
        {
            if (((System.Windows.Forms.TextBox)sender).Name == "seriya")
                e.Handled = (seriya.Text.Length >= 4 && !char.IsControl(e.KeyChar)) || (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
            else if (((System.Windows.Forms.TextBox)sender).Name == "nomer")
                e.Handled = (nomer.Text.Length >= 6 && !char.IsControl(e.KeyChar)) || (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
            else
                e.Handled = e.KeyChar == '\'' || e.KeyChar == '"';
        }


    }
}
