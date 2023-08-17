using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class MainForm : Form
    {
        private int columnWidth = 180; // Установливаем ширину столбцов
        public MainForm()
        {
            InitializeComponent();
            //TabControl.SelectedIndexChanged += new EventHandler(TabControl_SelectedIndexChanged);
            LoadEmployeesData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранную вкладку
            TabControl tabControl = (TabControl)sender;
            TabPage selectedTab = tabControl.SelectedTab;

            // Определяем, какая вкладка выбрана и вызываем соответствующий метод загрузки данных
            if (selectedTab == Employees)
            {
                LoadEmployeesData();
            }
            else if (selectedTab == Customers)
            {
                LoadCustomersData();
            }
            else if (selectedTab == Movies)
            {
                LoadMoviesData();
            }
            else if (selectedTab == Rentals)
            {
                LoadRentalsData();
            }
            else if (selectedTab == Ratings)
            {
                LoadRatingsData();
            }
        }

        private void LoadMoviesData()
        {
            // Очистите предыдущие данные в listViewMovies
            listViewMovies.Items.Clear();

            listViewMovies.View = View.Details;

            // Добавление заголовков столбцов
            listViewMovies.Columns.Clear();
            listViewMovies.Columns.Add("ID");
            listViewMovies.Columns.Add("Наименование");
            listViewMovies.Columns.Add("Год выпуска");
            listViewMovies.Columns.Add("Режиссёр");
            listViewMovies.Columns.Add("Страна");
            listViewMovies.Columns.Add("Продолжительность");
            listViewMovies.Columns.Add("Стоимость в день");

            foreach (ColumnHeader column in listViewMovies.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT * FROM Movies";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewMovies данными
                        while (reader.Read())
                        {
                            int movieID = reader.GetInt32(0);
                            string title = reader.GetString(1);
                            int releaseYear = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                            string director = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string country = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            int duration = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                            decimal dailyRentalCost = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);

                            ListViewItem item = new ListViewItem(movieID.ToString());
                            item.SubItems.Add(title);
                            item.SubItems.Add(releaseYear.ToString());
                            item.SubItems.Add(director);
                            item.SubItems.Add(country);
                            item.SubItems.Add(duration.ToString());
                            item.SubItems.Add(dailyRentalCost.ToString("0.00"));

                            listViewMovies.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void LoadEmployeesData()
        {
            // Очистка предыдущих данных в listViewEmployees
            listViewEmployees.Items.Clear();

            listViewEmployees.View = View.Details;

            // Добавление заголовков столбцов
            listViewEmployees.Columns.Clear();
            listViewEmployees.Columns.Add("ID");
            listViewEmployees.Columns.Add("ФИО");
            listViewEmployees.Columns.Add("День рождения");
            listViewEmployees.Columns.Add("Адрес");
            listViewEmployees.Columns.Add("Телефон");
            listViewEmployees.Columns.Add("Дата устройства");
            listViewEmployees.Columns.Add("Дата увольнения");

            foreach (ColumnHeader column in listViewEmployees.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT * FROM Employees";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewEmployees данными
                        while (reader.Read())
                        {
                            int employeeID = reader.GetInt32(0);
                            string fullName = reader.GetString(1);
                            DateTime birthDate = reader.GetDateTime(2);
                            string address = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string phoneNumber = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            DateTime hireDate = reader.GetDateTime(5);
                            DateTime terminationDate = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6);

                            ListViewItem item = new ListViewItem(employeeID.ToString());
                            item.SubItems.Add(fullName);
                            item.SubItems.Add(birthDate.ToShortDateString());
                            item.SubItems.Add(address);
                            item.SubItems.Add(phoneNumber);
                            item.SubItems.Add(hireDate.ToShortDateString());
                            item.SubItems.Add(terminationDate.ToShortDateString());

                            listViewEmployees.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void LoadCustomersData()
        {
            // Очистите предыдущие данные в listViewCustomers
            listViewCustomers.Items.Clear();

            listViewCustomers.View = View.Details;

            // Добавление заголовков столбцов
            listViewCustomers.Columns.Clear();
            listViewCustomers.Columns.Add("ID");
            listViewCustomers.Columns.Add("ФИО");
            listViewCustomers.Columns.Add("Дата рождения");
            listViewCustomers.Columns.Add("Адрес");
            listViewCustomers.Columns.Add("Телефон");
            listViewCustomers.Columns.Add("Дата найма");
            listViewCustomers.Columns.Add("Дата регистрации");

            foreach (ColumnHeader column in listViewCustomers.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT * FROM Customers";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewCustomers данными
                        while (reader.Read())
                        {
                            int customerID = reader.GetInt32(0);
                            string fullName = reader.GetString(1);
                            DateTime birthDate = reader.GetDateTime(2);
                            string address = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string phoneNumber = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            DateTime registrationDate = reader.GetDateTime(5);

                            ListViewItem item = new ListViewItem(customerID.ToString());
                            item.SubItems.Add(fullName);
                            item.SubItems.Add(birthDate.ToShortDateString());
                            item.SubItems.Add(address);
                            item.SubItems.Add(phoneNumber);
                            item.SubItems.Add(registrationDate.ToShortDateString());

                            listViewCustomers.Items.Add(item);
                        }
                    }
                }
            }
        }


        private void LoadRentalsData()
        {
            // Очистите предыдущие данные в listViewRentals
            listViewRentals.Items.Clear();

            listViewRentals.View = View.Details;

            // Добавление заголовков столбцов
            listViewRentals.Columns.Clear();
            listViewRentals.Columns.Add("ID");
            listViewRentals.Columns.Add("Клиент");
            listViewRentals.Columns.Add("Сотрудник");
            listViewRentals.Columns.Add("Фильм");
            listViewRentals.Columns.Add("Дата получения");
            listViewRentals.Columns.Add("Дата возврата");

            foreach (ColumnHeader column in listViewRentals.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT * FROM Rentals";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewRentals данными
                        while (reader.Read())
                        {
                            int rentalID = reader.GetInt32(0);
                            int customerID = reader.GetInt32(1);
                            int employeeID = reader.GetInt32(2);
                            int movieID = reader.GetInt32(3);
                            DateTime rentalDate = reader.GetDateTime(4);
                            DateTime returnDate = reader.GetDateTime(5);

                            ListViewItem item = new ListViewItem(rentalID.ToString());
                            item.SubItems.Add(customerID.ToString());
                            item.SubItems.Add(employeeID.ToString());
                            item.SubItems.Add(movieID.ToString());
                            item.SubItems.Add(rentalDate.ToShortDateString());
                            item.SubItems.Add(returnDate.ToShortDateString());

                            listViewRentals.Items.Add(item);
                        }
                    }
                }
            }
        }


        private void LoadRatingsData()
        {
            // Очистите предыдущие данные в listViewRatings
            listViewRatings.Items.Clear();

            listViewRatings.View = View.Details;

            // Добавление заголовков столбцов
            listViewRatings.Columns.Clear();
            listViewRatings.Columns.Add("ID");
            listViewRatings.Columns.Add("Клиент");
            listViewRatings.Columns.Add("Фильм");
            listViewRatings.Columns.Add("Оценка");
            listViewRatings.Columns.Add("Комментарий");

            foreach (ColumnHeader column in listViewRatings.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT * FROM Ratings";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewRatings данными
                        while (reader.Read())
                        {
                            int ratingID = reader.GetInt32(0);
                            int customerID = reader.GetInt32(1);
                            int movieID = reader.GetInt32(2);
                            int rating = reader.GetInt32(3);
                            string comment = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

                            ListViewItem item = new ListViewItem(ratingID.ToString());
                            item.SubItems.Add(customerID.ToString());
                            item.SubItems.Add(movieID.ToString());
                            item.SubItems.Add(rating.ToString());
                            item.SubItems.Add(comment);

                            listViewRatings.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void buttonAddEmployees_Click(object sender, EventArgs e)
        {
            AddEmployeesForm addEmployeesForm = new AddEmployeesForm();
            addEmployeesForm.ShowDialog();
        }


    }
}
