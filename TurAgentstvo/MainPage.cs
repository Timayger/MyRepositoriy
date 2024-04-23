using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TurAgentstvo
{
    public partial class MainPage : Form
    {
        private byte stars = 0;
        private bool isActive_compare = false;
        MySqlConnection conn;
        public MainPage()
        {
            InitializeComponent();
            UpdateComboBoxs();

        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            dbContracts_view("SELECT * FROM contracts_info");
            dbTours_view("SELECT * FROM tours_info");
            dbFlights_view("SELECT * FROM flights_info");
            dbHotels_view("SELECT * FROM hotels_info");
            dbClients_view("SELECT * FROM clients_info");

        }

        /// <summary>
        ///  Обновление данных, содержащих в выпадающих списках ComboBox
        /// </summary>
        public void UpdateComboBoxs()
        {
            conn = DbConn.GetDBConnection();
            MySqlDataAdapter ms_data_tours = new MySqlDataAdapter("SELECT * FROM tours", conn);
            MySqlDataAdapter ms_data_tour_types = new MySqlDataAdapter("SELECT * FROM tour_types", conn);
            MySqlDataAdapter ms_data_hotels = new MySqlDataAdapter("SELECT * FROM hotels", conn);
            MySqlDataAdapter ms_data_clients = new MySqlDataAdapter("SELECT * FROM clients", conn);
            MySqlDataAdapter ms_data_countries = new MySqlDataAdapter("SELECT * FROM countries", conn);
            MySqlDataAdapter ms_data_flights = new MySqlDataAdapter("SELECT * FROM flights", conn);
            MySqlDataAdapter ms_data_citys = new MySqlDataAdapter("SELECT * FROM citys", conn);
            DataTable table_tours = new DataTable();
            ms_data_tours.Fill(table_tours);
            DataTable table_tour_types = new DataTable();
            ms_data_tour_types.Fill(table_tour_types);
            DataTable table_hotels = new DataTable();
            ms_data_hotels.Fill(table_hotels);
            DataTable table_clients = new DataTable();
            ms_data_clients.Fill(table_clients);
            DataTable table_countries = new DataTable();
            ms_data_countries.Fill(table_countries);
            DataTable table_flights = new DataTable();
            ms_data_flights.Fill(table_flights);
            DataTable table_citys = new DataTable();
            ms_data_citys.Fill(table_citys);

            foreach (DataRow row in table_tours.Rows)
            {
                comboBox17.Items.Add("№" + row.ItemArray[0]);
                comboBox1.Items.Add(row.ItemArray[1]);
                comboBox7.Items.Add(row.ItemArray[1]);
            }
            foreach (DataRow row in table_tour_types.Rows)
                comboBox8.Items.Add(row.ItemArray[0]);
            foreach (DataRow row in table_hotels.Rows)
            {
                comboBox2.Items.Add(row.ItemArray[1]);
                comboBox9.Items.Add(row.ItemArray[1]);
                comboBox14.Items.Add(row.ItemArray[1]);
            }
            foreach (DataRow row in table_clients.Rows)
            {
                string patronymic = row.ItemArray[3].ToString() == "" ? "" : row.ItemArray[3].ToString()[0] + ".";
                comboBox0.Items.Add($"{row.ItemArray[2]} {row.ItemArray[1].ToString()[0]}. {patronymic}");
                comboBox3.Items.Add($"{row.ItemArray[1]} {row.ItemArray[2]} {row.ItemArray[3]}");
                comboBox6.Items.Add(row.ItemArray[9]);
            }
            foreach (DataRow row in table_countries.Rows)
            {
                comboBox10.Items.Add(row.ItemArray[1]);
                comboBox11.Items.Add(row.ItemArray[1]);
                comboBox15.Items.Add(row.ItemArray[1]);
            }
            foreach (DataRow row in table_flights.Rows)
            {
                comboBox12.Items.Add(row.ItemArray[1]);
                comboBox13.Items.Add(row.ItemArray[1]);
            }
            foreach (DataRow row in table_citys.Rows)
                comboBox16.Items.Add(row.ItemArray[1]);

        }

        //view databases
        private void dbContracts_view(string script)
        {
            try
            {
                conn = DbConn.GetDBConnection();
                conn.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dbContracts.DataSource = table;
                dbContracts.Columns[0].FillWeight = 65;
                dbContracts.Columns[1].FillWeight = 120;
                dbContracts.Columns[2].FillWeight = 120;
                dbContracts.Columns[3].FillWeight = 120;
                dbContracts.Columns[5].FillWeight = 90;
                dbContracts.Columns[6].FillWeight = 90;
                dbContracts.Columns[7].FillWeight = 110;
                dbContracts.Columns[8].FillWeight = 110;
                dbContracts.Columns[9].FillWeight = 120;
                dbContracts.Columns[10].FillWeight = 50;
                dbContracts.Columns[11].FillWeight = 75;
                dbContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                double sum = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                    sum += Convert.ToDouble(table.Rows[i].ItemArray[11]);
                label2.Text = Convert.ToString(Math.Round(sum, 2) + " ₽");
                label28.Text = label98.Text = Convert.ToString(table.Rows.Count);
                conn.Close();
            }
            catch { }
        }
        private void dbClients_view(string script)
        {
            try
            {
                conn = DbConn.GetDBConnection();
                conn.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dbClients.DataSource = table;
                dbClients.Columns[0].FillWeight = 80;
                dbClients.Columns[1].FillWeight = 80;
                dbClients.Columns[2].FillWeight = 80;
                dbClients.Columns[3].FillWeight = 30;
                dbClients.Columns[4].FillWeight = 50;
                dbClients.Columns[5].FillWeight = 50;
                dbClients.Columns[6].FillWeight = 70;
                dbClients.Columns[7].FillWeight = 60;
                dbClients.Columns[8].FillWeight = 140;
                dbClients.Columns[9].FillWeight = 70;
                dbClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                label_zapic2.Text = Convert.ToString(table.Rows.Count);

                conn.Close();
            }
            catch { }

        }
        private void dbTours_view(string script)
        {
            try
            {
                conn = DbConn.GetDBConnection();
                conn.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dbTours.DataSource = table;
                dbTours.Columns[0].FillWeight = 200;
                dbTours.Columns[5].FillWeight = 100;
                dbTours.Columns[8].FillWeight = 130;
                dbTours.Columns[7].FillWeight = 50;

                double sum_services = 0;
                double sum_tours = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    sum_services += Convert.ToDouble(table.Rows[i].ItemArray[8]);
                    sum_tours += Convert.ToDouble(table.Rows[i].ItemArray[9]);
                }
                label19.Text = Convert.ToString(Math.Round(sum_services, 2) + " ₽");
                label17.Text = Convert.ToString(Math.Round(sum_tours, 2) + " ₽");
                label86.Text = Convert.ToString(table.Rows.Count);

                conn.Close();
            }
            catch { }

        }
        private void dbFlights_view(string script)
        {
            try
            {
                conn = DbConn.GetDBConnection();
                conn.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dbFlights.DataSource = table;
                dbFlights.Columns[0].FillWeight = 50;
                label3.Text = Convert.ToString(table.Rows.Count);

                conn.Close();
            }
            catch { }

        }
        private void dbHotels_view(string script)
        {
            try
            {
                conn = DbConn.GetDBConnection();
                conn.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                dbHotels.DataSource = table;
                dbHotels.Columns[1].FillWeight = 200;
                dbHotels.Columns[3].FillWeight = 50;
                dbHotels.Columns[4].FillWeight = 50;
                label8.Text = Convert.ToString(table.Rows.Count);

                conn.Close();
            }
            catch { }

        }

        //filtration
        private void filtrationContracts(object sender, EventArgs e)
        {
            dbContracts_view($"SELECT * FROM contracts_info WHERE `ФИО клиента` LIKE \"{comboBox0.Text}%\" AND `Название тура` LIKE \"{comboBox1.Text}%\" AND `Забронированный отель` LIKE \"{comboBox2.Text}%\" AND (`Номер договора` LIKE \"{comboBox17.Text}%\" OR `Номер договора` LIKE \"_{comboBox17.Text}%\");");

        }
        private void filtrationTours(object sender, EventArgs e)
        {
            dbTours_view($"SELECT * FROM tours_info WHERE `Название тура` LIKE \"{comboBox7.Text}%\" AND `Вид тура` LIKE \"{comboBox8.Text}%\" AND `Отель` LIKE \"{comboBox9.Text}%\";");

        }
        private void filtrationFlights(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button)
                isActive_compare = true;
            else if (sender is System.Windows.Forms.ComboBox)
            {
                if (((System.Windows.Forms.ComboBox)sender).Name == "comboBox10" || ((System.Windows.Forms.ComboBox)sender).Name == "comboBox11")
                    isActive_compare = false;
            }
            else if (sender is PictureBox)
            {
                if (((PictureBox)sender).Name == "pictureBox3")
                {
                    isActive_compare = false;
                    string country_from = comboBox10.Text;
                    string country_to = comboBox11.Text;
                    comboBox10.Text = country_to;
                    comboBox11.Text = country_from;
                }
            }

            if (sender is System.Windows.Forms.CheckBox)
            {
                if (((System.Windows.Forms.CheckBox)sender).Name == "checkBox1")
                    checkBox2.Checked = false;
                else if ((((System.Windows.Forms.CheckBox)sender).Name == "checkBox2"))
                    checkBox1.Checked = false;
            }

            if (isActive_compare)
            {
                if (checkBox1.Checked && !checkBox3.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE (`Номер рейса` = '{comboBox12.Text}' OR `Номер рейса` = '{comboBox13.Text}')" +
                                   $" AND `Дата вылета` > NOW() ORDER BY `Дата вылета` DESC;");

                else if (checkBox1.Checked && checkBox3.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE (`Номер рейса` = '{comboBox12.Text}' OR `Номер рейса` = '{comboBox13.Text}')" +
                                   $" AND `Страна отправления` > NOW() AND `Страна отправления` IN(SELECT `Страна назначения` FROM flights_info WHERE NOT flights_info.`Страна отправления` = `Страна назначения`)\r\n  AND `Страна назначения` IN(SELECT `Страна отправления` FROM flights_info WHERE NOT flights_info.`Страна назначения` = `Страна отправления`) ORDER BY `Дата вылета` DESC;");

                else if (checkBox2.Checked && !checkBox3.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE (`Номер рейса` = '{comboBox12.Text}' OR `Номер рейса` = '{comboBox13.Text}')" +
                                   $" AND `Дата прилета` IS NOT NULL ORDER BY `Дата вылета` DESC;");

                else if (checkBox2.Checked && checkBox3.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE (`Номер рейса` = '{comboBox12.Text}' OR `Номер рейса` = '{comboBox13.Text}')" +
                                   $" AND `Дата прилета` IS NOT NULL AND `Страна отправления` IN(SELECT `Страна назначения` FROM flights_info WHERE NOT flights_info.`Страна отправления` = `Страна назначения`)\r\n  AND `Страна назначения` IN(SELECT `Страна отправления` FROM flights_info WHERE NOT flights_info.`Страна назначения` = `Страна отправления`) ORDER BY `Дата вылета` DESC;");

                else if (checkBox3.Checked && !checkBox1.Checked && !checkBox2.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE (`Номер рейса` = '{comboBox12.Text}' OR `Номер рейса` = '{comboBox13.Text}')" +
                                   $" AND `Страна отправления` IN(SELECT `Страна назначения` FROM flights_info WHERE NOT flights_info.`Страна отправления` = `Страна назначения`)\r\n  AND `Страна назначения` IN(SELECT `Страна отправления` FROM flights_info WHERE NOT flights_info.`Страна назначения` = `Страна отправления`) ORDER BY `Дата вылета` DESC;");
                else if (!checkBox3.Checked && !checkBox1.Checked && !checkBox2.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE (`Номер рейса` = '{comboBox12.Text}' OR `Номер рейса` = '{comboBox13.Text}') ORDER BY `Страна отправления` DESC;");

                panel1.BackColor = Color.LightBlue;
                panel2.BackColor = Color.LightGray;

            }
            else
            {
                if (checkBox1.Checked && !checkBox3.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE `Страна отправления` LIKE \"{comboBox10.Text}%\" AND" +
                                   $" `Страна назначения` LIKE \"{comboBox11.Text}%\" AND `Дата вылета` > NOW() ORDER BY `Страна отправления` DESC ;");

                else if (checkBox1.Checked && checkBox3.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE `Страна отправления` LIKE \"{comboBox10.Text}%\" AND" +
                                   $" `Страна назначения` LIKE \"{comboBox11.Text}%\" AND `Дата вылета` > NOW() AND `Страна отправления` IN(SELECT `Страна назначения` FROM flights_info WHERE NOT flights_info.`Страна отправления` = `Страна назначения`)\r\n  AND `Страна назначения` IN(SELECT `Страна отправления` FROM flights_info WHERE NOT flights_info.`Страна назначения` = `Страна отправления`) ORDER BY `Дата вылета` DESC;");

                else if (checkBox2.Checked && !checkBox3.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE `Страна отправления` LIKE \"{comboBox10.Text}%\" AND" +
                                   $" `Страна назначения` LIKE \"{comboBox11.Text}%\" AND `Дата прилета` IS NOT NULL ORDER BY `Дата вылета` DESC;");

                else if (checkBox2.Checked && checkBox3.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE `Страна отправления` LIKE \"{comboBox10.Text}%\" AND" +
                                   $" `Страна назначения` LIKE \"{comboBox11.Text}%\" AND `Дата прилета` IS NOT NULL AND `Страна отправления` IN(SELECT `Страна назначения` FROM flights_info WHERE NOT flights_info.`Страна отправления` = `Страна назначения`)\r\n  AND `Страна назначения` IN(SELECT `Страна отправления` FROM flights_info WHERE NOT flights_info.`Страна назначения` = `Страна отправления`) ORDER BY `Дата вылета` DESC;");

                else if (checkBox3.Checked && !checkBox1.Checked && !checkBox2.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE `Страна отправления` LIKE \"{comboBox10.Text}%\" AND" +
                                   $"`Страна назначения` LIKE \"{comboBox11.Text}%\" AND `Страна отправления` IN(SELECT `Страна назначения` FROM flights_info WHERE NOT flights_info.`Страна отправления` = `Страна назначения`)\r\n  AND `Страна назначения` IN(SELECT `Страна отправления` FROM flights_info WHERE NOT flights_info.`Страна назначения` = `Страна отправления`) ORDER BY `Дата вылета` DESC;");
                else if (!checkBox3.Checked && !checkBox1.Checked && !checkBox2.Checked)
                    dbFlights_view($"SELECT * FROM flights_info WHERE `Страна отправления` LIKE \"{comboBox10.Text}%\" AND `Страна назначения` LIKE \"{comboBox11.Text}%\" ORDER BY `Дата вылета` DESC;");

                panel2.BackColor = Color.LightBlue;
                panel1.BackColor = Color.LightGray;
            }



        }
        private void filtrationHotels(object sender, EventArgs e)
        {
            if (stars == 0)
                dbHotels_view($"SELECT hotels_info.* FROM hotels_info LEFT JOIN hotels ON hotels.name = hotels_info.`Название отеля` LEFT JOIN citys ON citys.id_city = hotels.id_city LEFT JOIN countries ON citys.id_country = countries.id_country WHERE citys.name LIKE '{comboBox16.Text}%' AND hotels_info.`Название отеля` LIKE '{comboBox14.Text}%'  AND countries.`name` LIKE '{comboBox15.Text}%';");
            else dbHotels_view($"SELECT hotels_info.* FROM hotels_info LEFT JOIN hotels ON hotels.name = hotels_info.`Название отеля` LEFT JOIN citys ON citys.id_city = hotels.id_city LEFT JOIN countries ON citys.id_country = countries.id_country WHERE citys.name LIKE '{comboBox16.Text}%' AND hotels_info.`Название отеля` LIKE '{comboBox14.Text}%'  AND countries.`name` LIKE '{comboBox15.Text}%' AND hotels_info.`Звезды` = {stars};");
        }
        private void filtrationClients(object sender, EventArgs e)
        {
            string[] FIO = comboBox3.Text.Trim().Split();
            string client_name = "";
            string client_surname = "";
            string client_patronymic = "";

            if (FIO.Length >= 1) client_name = FIO[0];
            if (FIO.Length >= 2) client_surname = FIO[1];
            if (FIO.Length >= 3) client_patronymic = FIO[2];

            dbClients_view($"SELECT * FROM clients_info WHERE ((`Имя` LIKE \"{client_name}%\" AND `Фамилия` LIKE \"{client_surname}%\" AND `Отчество` LIKE \"{client_patronymic}%\") OR (CONCAT( `Фамилия`, ' ', left(`Имя`, 1), '.', IF(`Отчество` = \"\", TRUE, CONCAT(' ', left(`Отчество`, 1), '. ' )) ) LIKE '{comboBox3.Text.Trim()}%')) AND `Серия паспорта` LIKE \"{comboBox4.Text}%\" AND `Номер паспорта` LIKE \"{comboBox5.Text}%\" AND `E-mail адрес` LIKE \"{comboBox6.Text}%\";");

        }

        private void passport_formation(object sender, KeyPressEventArgs e)
        {
            if (((System.Windows.Forms.ComboBox)sender).Name == "comboBox4")
                e.Handled = (comboBox4.Text.Length >= 4 && !char.IsControl(e.KeyChar)) || (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
            else if (((System.Windows.Forms.ComboBox)sender).Name == "comboBox5")
                e.Handled = (comboBox5.Text.Length >= 6 && !char.IsControl(e.KeyChar)) || (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));

        }

        //stars
        private void stars_MouseEnter(object sender, EventArgs e)
        {
            switch (((Label)sender).Name)
            {
                case ("star1"):
                    if (star1.ForeColor != Color.DarkOrange)
                        star1.ForeColor = Color.Orange;
                    break;
                case ("star2"):
                    if (star1.ForeColor != Color.DarkOrange && star2.ForeColor != Color.DarkOrange)
                    {
                        star1.ForeColor = Color.Orange;
                        star2.ForeColor = Color.Orange;
                    }
                    break;
                case ("star3"):
                    if (star1.ForeColor != Color.DarkOrange && star2.ForeColor != Color.DarkOrange && star3.ForeColor != Color.DarkOrange)
                    {
                        star1.ForeColor = Color.Orange;
                        star2.ForeColor = Color.Orange;
                        star3.ForeColor = Color.Orange;
                    }
                    break;
                case ("star4"):
                    if (star1.ForeColor != Color.DarkOrange && star2.ForeColor != Color.DarkOrange && star3.ForeColor != Color.DarkOrange && star4.ForeColor != Color.DarkOrange)
                    {
                        star1.ForeColor = Color.Orange;
                        star2.ForeColor = Color.Orange;
                        star3.ForeColor = Color.Orange;
                        star4.ForeColor = Color.Orange;
                    }
                    break;
                case ("star5"):
                    if (star1.ForeColor != Color.DarkOrange && star2.ForeColor != Color.DarkOrange && star3.ForeColor != Color.DarkOrange && star4.ForeColor != Color.DarkOrange && star5.ForeColor != Color.DarkOrange)
                    {
                        star1.ForeColor = Color.Orange;
                        star2.ForeColor = Color.Orange;
                        star3.ForeColor = Color.Orange;
                        star4.ForeColor = Color.Orange;
                        star5.ForeColor = Color.Orange;
                    }
                    break;
            }

        }
        private void stars_MouseLeave(object sender, EventArgs e)
        {
            switch (stars)
            {
                case (5):
                    break;
                case (4):
                    star5.ForeColor = Color.DarkGray;
                    break;
                case (3):
                    star4.ForeColor = Color.DarkGray;
                    star5.ForeColor = Color.DarkGray;
                    break;
                case (2):
                    star3.ForeColor = Color.DarkGray;
                    star4.ForeColor = Color.DarkGray;
                    star5.ForeColor = Color.DarkGray;
                    break;
                case (1):
                    star2.ForeColor = Color.DarkGray;
                    star3.ForeColor = Color.DarkGray;
                    star4.ForeColor = Color.DarkGray;
                    star5.ForeColor = Color.DarkGray;
                    break;
                case (0):
                    star1.ForeColor = Color.DarkGray;
                    star2.ForeColor = Color.DarkGray;
                    star3.ForeColor = Color.DarkGray;
                    star4.ForeColor = Color.DarkGray;
                    star5.ForeColor = Color.DarkGray;
                    break;
            }
        }
        private void star_Click(object sender, EventArgs e)
        {
            switch (((Label)sender).Name)
            {
                case ("star1"):
                    if (star1.ForeColor == Color.DarkOrange)
                    {
                        star1.ForeColor = Color.DarkGray;
                        star2.ForeColor = Color.DarkGray;
                        star3.ForeColor = Color.DarkGray;
                        star4.ForeColor = Color.DarkGray;
                        star5.ForeColor = Color.DarkGray;
                        stars = 0;
                    }
                    else
                    {
                        star1.ForeColor = Color.DarkOrange;
                        star2.ForeColor = Color.DarkGray;
                        star3.ForeColor = Color.DarkGray;
                        star4.ForeColor = Color.DarkGray;
                        star5.ForeColor = Color.DarkGray;
                        stars = 1;

                    }
                    break;
                case ("star2"):
                    star1.ForeColor = Color.DarkOrange;
                    star2.ForeColor = Color.DarkOrange;
                    star3.ForeColor = Color.DarkGray;
                    star4.ForeColor = Color.DarkGray;
                    star5.ForeColor = Color.DarkGray;
                    stars = 2;

                    break;
                case ("star3"):
                    star1.ForeColor = Color.DarkOrange;
                    star2.ForeColor = Color.DarkOrange;
                    star3.ForeColor = Color.DarkOrange;
                    star4.ForeColor = Color.DarkGray;
                    star5.ForeColor = Color.DarkGray;
                    stars = 3;

                    break;
                case ("star4"):
                    star1.ForeColor = Color.DarkOrange;
                    star2.ForeColor = Color.DarkOrange;
                    star3.ForeColor = Color.DarkOrange;
                    star4.ForeColor = Color.DarkOrange;
                    star5.ForeColor = Color.DarkGray;
                    stars = 4;

                    break;
                case ("star5"):
                    star1.ForeColor = Color.DarkOrange;
                    star2.ForeColor = Color.DarkOrange;
                    star3.ForeColor = Color.DarkOrange;
                    star4.ForeColor = Color.DarkOrange;
                    star5.ForeColor = Color.DarkOrange;
                    stars = 5;

                    break;
            }
            if (stars == 0)
                dbHotels_view($"SELECT hotels_info.* FROM hotels_info LEFT JOIN hotels ON hotels.name = hotels_info.`Название отеля` LEFT JOIN citys ON citys.id_city = hotels.id_city LEFT JOIN countries ON citys.id_country = countries.id_country WHERE citys.name LIKE '{comboBox16.Text}%' AND hotels_info.`Название отеля` LIKE '{comboBox14.Text}%'  AND countries.`name` LIKE '{comboBox15.Text}%';");
            else dbHotels_view($"SELECT hotels_info.* FROM hotels_info LEFT JOIN hotels ON hotels.name = hotels_info.`Название отеля` LEFT JOIN citys ON citys.id_city = hotels.id_city LEFT JOIN countries ON citys.id_country = countries.id_country WHERE citys.name LIKE '{comboBox16.Text}%' AND hotels_info.`Название отеля` LIKE '{comboBox14.Text}%'  AND countries.`name` LIKE '{comboBox15.Text}%' AND hotels_info.`Звезды` = {stars};");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            switch (((System.Windows.Forms.Button)sender).Name)
            {
                case ("btnClearToContracts"):
                    comboBox0.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox17.Text = "";
                    dbContracts_view("SELECT * FROM contracts_info");
                    break;
                case ("btnClearToTours"):
                    comboBox7.Text = "";
                    comboBox8.Text = "";
                    comboBox9.Text = "";
                    dbTours_view("SELECT * FROM tours_info");
                    break;
                case ("btnClearToFlights"):
                    isActive_compare = false;
                    panel2.BackColor = Color.LightBlue;
                    panel1.BackColor = Color.LightGray;
                    dbFlights_view("SELECT * FROM flights_info");
                    comboBox10.Text = "";
                    comboBox11.Text = "";
                    comboBox12.Text = "";
                    comboBox13.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    break;
                case ("btnClearToHotels"):
                    comboBox14.Text = "";
                    comboBox15.Text = "";
                    comboBox16.Text = "";
                    stars = 0;
                    star1.ForeColor = Color.DarkGray;
                    star2.ForeColor = Color.DarkGray;
                    star3.ForeColor = Color.DarkGray;
                    star4.ForeColor = Color.DarkGray;
                    star5.ForeColor = Color.DarkGray;
                    dbHotels_view("SELECT * FROM hotels_info");
                    break;
                case ("btnClearToClients"):
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                    comboBox6.Text = "";
                    dbClients_view("SELECT * FROM clients_info");
                    break;
            }

        }

        //dbSelectionChanged
        private void dbClients_SelectionChanged(object sender, EventArgs e)
        {

            if (dbClients.CurrentRow != null)
            {
                //Запись i из N
                label_zapic1.Text = Convert.ToString(dbClients.CurrentRow.Index + 1);

                string name = dbClients.Rows[dbClients.CurrentRow.Index].Cells[0].Value.ToString();
                string surname = dbClients.Rows[dbClients.CurrentRow.Index].Cells[1].Value.ToString();
                string? patronymic = dbClients.Rows[dbClients.CurrentRow.Index].Cells[2].Value.ToString();
                string gender = dbClients.Rows[dbClients.CurrentRow.Index].Cells[3].Value.ToString();
                string seriya = dbClients.Rows[dbClients.CurrentRow.Index].Cells[4].Value.ToString();
                string nomer = dbClients.Rows[dbClients.CurrentRow.Index].Cells[5].Value.ToString();
                string? country = dbClients.Rows[dbClients.CurrentRow.Index].Cells[6].Value.ToString();
                string birthday = dbClients.Rows[dbClients.CurrentRow.Index].Cells[7].Value.ToString();
                string email = dbClients.Rows[dbClients.CurrentRow.Index].Cells[8].Value.ToString();
                string? phone = dbClients.Rows[dbClients.CurrentRow.Index].Cells[9].Value.ToString();

                label38.Text = name;
                label39.Text = surname;
                if (patronymic == "")
                {
                    label40.Text = "??";
                    label40.BorderStyle = BorderStyle.None;
                    label40.ForeColor = Color.DimGray;
                }
                else
                {
                    label40.Text = patronymic;
                    label40.BorderStyle = BorderStyle.FixedSingle;
                    label40.ForeColor = Color.FromArgb(0, 0, 64);
                }

                if (gender == "М") pictureBox10.Image = imageList1.Images[0];
                else if (gender == "Ж") pictureBox10.Image = imageList1.Images[1];
                label41.Text = seriya;
                label42.Text = nomer;
                if (country == "")
                {
                    label43.Text = "??";
                    label43.BorderStyle = BorderStyle.None;
                    label43.ForeColor = Color.DimGray;
                }
                else
                {
                    label43.Text = country;
                    label43.BorderStyle = BorderStyle.FixedSingle;
                    label43.ForeColor = Color.FromArgb(0, 0, 64);
                }
                label44.Text = birthday.Split()[0];
                label45.Text = email;
                if (phone == "")
                {
                    label46.Text = "??";
                    label46.BorderStyle = BorderStyle.None;
                    label46.ForeColor = Color.DimGray;
                }
                else
                {
                    label46.Text = phone;
                    label46.BorderStyle = BorderStyle.FixedSingle;
                    label46.ForeColor = Color.FromArgb(0, 0, 64);
                }

                string patronymic2 = patronymic == "" ? "" : patronymic[0] + ".";
                string FIO = ($"{surname} {name[0]}. {patronymic2}").Trim();
                int count = 0;
                MySqlDataAdapter ms_data = new MySqlDataAdapter($"SELECT concat(`cl`.`surname`, ' ', left(`cl`.`name`, 1), if((`cl`.`patronymic` = ''), '.', concat('. ', left(`cl`.`patronymic`, 1), '.'))) AS `ФИО клиента`\r\nFROM\r\n  clients AS cl\r\nINNER JOIN contracts AS ct\r\nON cl.id_client = ct.id_client\r\n", conn);
                DataTable table = new DataTable();
                ms_data.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    if (row.ItemArray[0].ToString() == FIO)
                        count++;
                }
                label47.Text = Convert.ToString(count);
            }


        }
        private void dbHotels_SelectionChanged(object sender, EventArgs e)
        {
            if (dbHotels.CurrentRow != null)
            {
                //Запись i из N
                label88.Text = Convert.ToString(dbHotels.CurrentRow.Index + 1);

                //удаляем изображения услуг для добавления новых
                panel_services_info.Controls.Clear();

                //заполняем информацию, добавляем изображения услуг
                string name = dbHotels.Rows[dbHotels.CurrentRow.Index].Cells[0].Value.ToString();
                string opisanie = dbHotels.Rows[dbHotels.CurrentRow.Index].Cells[1].Value.ToString();
                string country = dbHotels.Rows[dbHotels.CurrentRow.Index].Cells[2].Value.ToString().Split(", ")[0];
                string city = dbHotels.Rows[dbHotels.CurrentRow.Index].Cells[2].Value.ToString().Split(", ")[1];
                string stars = dbHotels.Rows[dbHotels.CurrentRow.Index].Cells[3].Value.ToString();
                string price = dbHotels.Rows[dbHotels.CurrentRow.Index].Cells[4].Value.ToString();
                string[] services = dbHotels.Rows[dbHotels.CurrentRow.Index].Cells[5].Value.ToString().Split(',');

                label69.Text = name;
                textBox1.Text = opisanie;
                label72.Text = country;
                label35.Text = city;
                label65.Text = price + " ₽";
                label67.Text = String.Concat(Enumerable.Repeat("⭐", Convert.ToInt32(stars)));

                //добавляем информацию о доп. услугах (изображения)
                for (int i = 0; i < services.Length; i++)
                {
                    PictureBox image = new PictureBox();
                    switch (services[i])
                    {
                        case ("Бесплатный интернет"):
                            image.Image = imageList2.Images[0];
                            break;
                        case ("Бар или ресторан"):
                            image.Image = imageList2.Images[1];
                            break;
                        case ("Бассейн"):
                            image.Image = imageList2.Images[2];
                            break;
                        case ("Спа"):
                            image.Image = imageList2.Images[3];
                            break;
                        case ("Фитнес"):
                            image.Image = imageList2.Images[4];
                            break;
                        case ("Массаж"):
                            image.Image = imageList2.Images[5];
                            break;
                    }
                    image.SizeMode = PictureBoxSizeMode.Zoom;
                    panel_services_info.Controls.Add(image);
                }

            }


        }
        private void dbFlights_SelectionChanged(object sender, EventArgs e)
        {
            if (dbFlights.CurrentRow != null)
            {
                //Запись i из N
                label90.Text = Convert.ToString(dbFlights.CurrentRow.Index + 1);

                //заполняем информацию
                string N_flight = dbFlights.Rows[dbFlights.CurrentRow.Index].Cells[0].Value.ToString();
                string airline = dbFlights.Rows[dbFlights.CurrentRow.Index].Cells[1].Value.ToString();
                string _country_from = dbFlights.Rows[dbFlights.CurrentRow.Index].Cells[2].Value.ToString();
                string _country_to = dbFlights.Rows[dbFlights.CurrentRow.Index].Cells[3].Value.ToString();
                string _date_from = dbFlights.Rows[dbFlights.CurrentRow.Index].Cells[4].Value.ToString();
                string _date_to = dbFlights.Rows[dbFlights.CurrentRow.Index].Cells[5].Value.ToString();
                string price = dbFlights.Rows[dbFlights.CurrentRow.Index].Cells[6].Value.ToString();
                string seats = dbFlights.Rows[dbFlights.CurrentRow.Index].Cells[7].Value.ToString();
                string status;

                MySqlDataAdapter isdate_last = new MySqlDataAdapter($"SELECT date_from <= now() FROM flights WHERE N_flight = '{N_flight}';", conn);
                DataTable table = new DataTable();
                isdate_last.Fill(table);
                if (seats == "0" || _date_to != "" || table.Rows[0].ItemArray[0].ToString() == "1")
                    status = "недоступно";
                else status = "доступно";

                label81.Text = N_flight;
                label80.Text = airline;
                country_from.Text = _country_from;
                country_to.Text = _country_to;
                date_from.Text = _date_from;
                label68.Text = price + " ₽";
                label60.Text = seats;
                label58.Text = status;

                if (_date_to == "")
                {
                    date_to.Text = "??";
                    date_to.BorderStyle = BorderStyle.None;
                    date_to.ForeColor = Color.DimGray;
                }
                else
                {
                    date_to.Text = _date_to;
                    date_to.BorderStyle = BorderStyle.FixedSingle;
                }

            }


        }
        private void dbTours_SelectionChanged(object sender, EventArgs e)
        {
            if (dbTours.CurrentRow != null)
            {
                //Запись i из N
                label92.Text = Convert.ToString(dbTours.CurrentRow.Index + 1);

                //заполняем информацию
                string name = dbTours.Rows[dbTours.CurrentRow.Index].Cells[0].Value.ToString();
                string tour_type = dbTours.Rows[dbTours.CurrentRow.Index].Cells[1].Value.ToString();
                string hotel = dbTours.Rows[dbTours.CurrentRow.Index].Cells[2].Value.ToString();
                string _country_from = dbTours.Rows[dbTours.CurrentRow.Index].Cells[3].Value.ToString();
                string _country_to = dbTours.Rows[dbTours.CurrentRow.Index].Cells[4].Value.ToString();
                string _date_from = dbTours.Rows[dbTours.CurrentRow.Index].Cells[5].Value.ToString().Split()[0];
                string _date_to = dbTours.Rows[dbTours.CurrentRow.Index].Cells[6].Value.ToString().Split()[0];
                string kolvo_nights = dbTours.Rows[dbTours.CurrentRow.Index].Cells[7].Value.ToString();
                string _services_price = dbTours.Rows[dbTours.CurrentRow.Index].Cells[8].Value.ToString();
                string price = dbTours.Rows[dbTours.CurrentRow.Index].Cells[9].Value.ToString();

                label103.Text = name;
                label102.Text = tour_type;
                label106.Text = hotel;
                country_from2.Text = _country_from;
                country_to2.Text = _country_to;
                date_from2.Text = _date_from;
                date_to2.Text = _date_to;
                label21.Text = kolvo_nights;
                tour_price.Text = price + " ₽";
                services_price.Text = _services_price + " ₽";


            }
        }
        private void dbContracts_SelectionChanged(object sender, EventArgs e)
        {
            if (dbContracts.CurrentRow != null)
            {
                //Запись i из N
                label94.Text = Convert.ToString(dbContracts.CurrentRow.Index + 1);

                //заполняем информацию
                string N_contract = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[0].Value.ToString();
                string FIO_client = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[1].Value.ToString();
                string tour = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[2].Value.ToString();
                string hotel = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[3].Value.ToString();
                string adres = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[4].Value.ToString();
                string _country_from = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[5].Value.ToString();
                string _country_to = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[6].Value.ToString();
                string _date_from = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[7].Value.ToString().Split()[0];
                string _date_to = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[8].Value.ToString().Split()[0];
                string date_of_contract = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[9].Value.ToString();
                string kolvo_nights = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[10].Value.ToString();
                string price = dbContracts.Rows[dbContracts.CurrentRow.Index].Cells[11].Value.ToString();

                label121.Text = N_contract;
                label120.Text = FIO_client;
                label124.Text = tour;
                label63.Text = hotel;
                label1.Text = adres;
                label109.Text = date_of_contract;
                country_from3.Text = _country_from;
                country_to3.Text = _country_to;
                date_from3.Text = _date_from;
                label113.Text = kolvo_nights;
                label119.Text = price + " ₽";
                if (_date_to == "")
                {
                    date_to3.Text = "??";
                    date_to3.BorderStyle = BorderStyle.None;
                    date_to3.ForeColor = Color.DimGray;
                }
                else
                {
                    date_to3.Text = _date_to;
                    date_to3.BorderStyle = BorderStyle.FixedSingle;
                }


            }
        }

        private void btn_INSERT_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case ("ContractsPage"):
                    break;
                case ("ToursPage"):
                    break;
                case ("HotelsPage"):
                    //переход на другую форму для добавления отеля
                    HotelControl hotelControl 
                    addhotel.ShowDialog();
                    addhotel.Controls[0].Controls[0].Controls[0].Text = "Добавить";

                    //обновление таблицы Отели после добавления
                    if (stars == 0)
                        dbHotels_view($"SELECT hotels_info.* FROM hotels_info LEFT JOIN hotels ON hotels.name = hotels_info.`Название отеля` LEFT JOIN citys ON citys.id_city = hotels.id_city LEFT JOIN countries ON citys.id_country = countries.id_country WHERE citys.name LIKE '{comboBox16.Text}%' AND hotels_info.`Название отеля` LIKE '{comboBox14.Text}%'  AND countries.`name` LIKE '{comboBox15.Text}%';");
                    else dbHotels_view($"SELECT hotels_info.* FROM hotels_info LEFT JOIN hotels ON hotels.name = hotels_info.`Название отеля` LEFT JOIN citys ON citys.id_city = hotels.id_city LEFT JOIN countries ON citys.id_country = countries.id_country WHERE citys.name LIKE '{comboBox16.Text}%' AND hotels_info.`Название отеля` LIKE '{comboBox14.Text}%'  AND countries.`name` LIKE '{comboBox15.Text}%' AND hotels_info.`Звезды` = {stars};");

                    break;
                case ("ClientsPage"):
                    //переход на другую форму для добавления клиента
                    ClientControl addClient = new ClientControl();
                    addClient.ShowDialog();
                    addClient.Controls[0].Controls[0].Controls[0].Text = "Добавить";

                    //обновление таблицы Клиенты после добавления
                    string[] FIO = comboBox3.Text.Trim().Split();
                    string client_name = "";
                    string client_surname = "";
                    string client_patronymic = "";

                    if (FIO.Length >= 1) client_name = FIO[0];
                    if (FIO.Length >= 2) client_surname = FIO[1];
                    if (FIO.Length >= 3) client_patronymic = FIO[2];

                    dbClients_view($"SELECT * FROM clients_info WHERE ((`Имя` LIKE \"{client_name}%\" AND `Фамилия` LIKE \"{client_surname}%\" AND `Отчество` LIKE \"{client_patronymic}%\") OR (CONCAT( `Фамилия`, ' ', left(`Имя`, 1), '.', IF(`Отчество` = \"\", TRUE, CONCAT(' ', left(`Отчество`, 1), '. ' )) ) LIKE '{comboBox3.Text.Trim()}%')) AND `Серия паспорта` LIKE \"{comboBox4.Text}%\" AND `Номер паспорта` LIKE \"{comboBox5.Text}%\" AND `E-mail адрес` LIKE \"{comboBox6.Text}%\";");

                    break;
            }
            UpdateComboBoxs();
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case ("ContractsPage"):
                    break;
                case ("ToursPage"):
                    break;
                case ("HotelsPage"):
                    break;
                case ("ClientsPage"):
                    if (dbClients.CurrentRow != null)
                    {
                        ClientControl updateClient = new ClientControl();
                        string gender = dbClients.Rows[dbClients.CurrentRow.Index].Cells[3].Value.ToString();
                        var controls = updateClient.Controls[0].Controls[0].Controls[3].Controls;
                        updateClient.Controls[0].Controls[0].Controls[0].Text = "Редактировать";
                        for (int i = 0; i < controls.Count; i++)
                        {
                            switch (controls[i].Name)
                            {
                                case("name"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[0].Value.ToString();
                                    break;
                                case ("surname"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[1].Value.ToString();
                                    break;
                                case ("patronymic"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[2].Value.ToString();
                                    break;
                                case ("radioButton1"):
                                    if(gender == "М") ((System.Windows.Forms.RadioButton)controls[i]).Checked = true;
                                    break;
                                case ("radioButton2"):
                                    if (gender == "Ж") ((System.Windows.Forms.RadioButton)controls[i]).Checked = true;
                                    break;
                                case ("seriya"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[4].Value.ToString();
                                    break;
                                case ("nomer"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[5].Value.ToString();
                                    break;
                                case ("country"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[6].Value.ToString();
                                    break;
                                case ("birth_date"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[7].Value.ToString();
                                    break;
                                case ("email"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[8].Value.ToString();
                                    break;
                                case ("phone"):
                                    controls[i].Text = dbClients.Rows[dbClients.CurrentRow.Index].Cells[9].Value.ToString();
                                    break;
                            }
                        }


                        updateClient.ShowDialog();
                    }

                    //обновление таблицы Клиенты
                    string[] FIO = comboBox3.Text.Trim().Split();
                    string client_name = "";
                    string client_surname = "";
                    string client_patronymic = "";

                    if (FIO.Length >= 1) client_name = FIO[0];
                    if (FIO.Length >= 2) client_surname = FIO[1];
                    if (FIO.Length >= 3) client_patronymic = FIO[2];

                    dbClients_view($"SELECT * FROM clients_info WHERE ((`Имя` LIKE \"{client_name}%\" AND `Фамилия` LIKE \"{client_surname}%\" AND `Отчество` LIKE \"{client_patronymic}%\") OR (CONCAT( `Фамилия`, ' ', left(`Имя`, 1), '.', IF(`Отчество` = \"\", TRUE, CONCAT(' ', left(`Отчество`, 1), '. ' )) ) LIKE '{comboBox3.Text.Trim()}%')) AND `Серия паспорта` LIKE \"{comboBox4.Text}%\" AND `Номер паспорта` LIKE \"{comboBox5.Text}%\" AND `E-mail адрес` LIKE \"{comboBox6.Text}%\";");

                    break;
            }
            UpdateComboBoxs();
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case ("ContractsPage"):
                    break;
                case ("ToursPage"):
                    break;
                case ("HotelsPage"):
                    break;
                case ("ClientsPage"):
                    if (dbClients.CurrentRow != null)
                    {
                        string nomer = dbClients.Rows[dbClients.CurrentRow.Index].Cells[5].Value.ToString();
                        var sqlcommand = new MySqlCommand($"DELETE FROM clients WHERE passport_number = {nomer};", conn);
                        var result = MessageBox.Show("Удалить выбранного(ых) клиента(ов)?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            conn.Open();
                            sqlcommand.ExecuteNonQuery();
                            MessageBox.Show("Клиент успешно был удален", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //обновление таблицы Клиенты
                            string[] FIO = comboBox3.Text.Trim().Split();
                            string client_name = "";
                            string client_surname = "";
                            string client_patronymic = "";

                            if (FIO.Length >= 1) client_name = FIO[0];
                            if (FIO.Length >= 2) client_surname = FIO[1];
                            if (FIO.Length >= 3) client_patronymic = FIO[2];

                            dbClients_view($"SELECT * FROM clients_info WHERE ((`Имя` LIKE \"{client_name}%\" AND `Фамилия` LIKE \"{client_surname}%\" AND `Отчество` LIKE \"{client_patronymic}%\") OR (CONCAT( `Фамилия`, ' ', left(`Имя`, 1), '.', IF(`Отчество` = \"\", TRUE, CONCAT(' ', left(`Отчество`, 1), '. ' )) ) LIKE '{comboBox3.Text.Trim()}%')) AND `Серия паспорта` LIKE \"{comboBox4.Text}%\" AND `Номер паспорта` LIKE \"{comboBox5.Text}%\" AND `E-mail адрес` LIKE \"{comboBox6.Text}%\";");

                            conn.Close();

                        }
                    }
                    break;
            }
            UpdateComboBoxs();
        }
    }
}
