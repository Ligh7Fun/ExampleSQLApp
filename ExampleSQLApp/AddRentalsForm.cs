﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class AddRentalsForm : Form
    {
        private MainForm mainForm;
        public AddRentalsForm(MainForm mainForm)
        {
            InitializeComponent();
            LoadCustomersList();
            LoadMoviesList();
            LoadEmployeesList();
            this.mainForm = mainForm;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomersList()
        {
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT FullName FROM Customers";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = reader.GetString(1);
                            ComboBoxMovie.Items.Add(fullName);
                        }
                    }
                }
            }
        }

        private void LoadMoviesList()
        {
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT Title FROM Movies";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString(0);
                            ComboBoxMovie.Items.Add(title);
                        }
                    }
                }
            }
        }

        private void LoadEmployeesList()
        {
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT FullName FROM Employees";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = reader.GetString(0);
                            ComboBoxEmployee.Items.Add(fullName);
                        }
                    }
                }
            }
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

        // Метод для получения идентификатора по значению из определенной таблицы и столбца
        private int GetIDForValue(string tableName, string columnName, string value, NpgsqlConnection connection)
        {
            int id = -1;

            string selectQuery = $"SELECT {columnName} FROM {tableName} WHERE {columnName} = @value";
            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@value", value);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
            }

            return id;
        }
        //TODO: Проверить после добавления клиентов
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получаем значения из ComboBox и DateTimePicker
            string selectedCustomer = ComboBoxCustomer.SelectedItem?.ToString();
            string selectedEmployee = ComboBoxEmployee.SelectedItem?.ToString();
            string selectedMovie = ComboBoxMovie.SelectedItem?.ToString();
            DateTime rentalDate = RentalStartDate.Value;
            DateTime returnDate = RentalReturnDate.Value;

            // Проверяем, что все необходимые значения выбраны
            if (selectedCustomer == string.Empty || selectedEmployee == string.Empty || selectedMovie == string.Empty)
            {
                MessageBox.Show("Заполните все поля.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Получаем идентификаторы выбранных клиента, сотрудника и фильма из базы данных
                int customerID = GetIDForValue("Customers", "FullName", selectedCustomer, connection);
                int employeeID = GetIDForValue("Employees", "FullName", selectedEmployee, connection);
                int movieID = GetIDForValue("Movies", "Title", selectedMovie, connection);

                // SQL-запрос для вставки данных
                string insertQuery = @"
                    INSERT INTO Rentals (CustomerID, EmployeeID, MovieID, RentalDate, ReturnDate)
                    VALUES (@customerID, @employeeID, @movieID, @rentalDate, @returnDate)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    // Добавляем параметры
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@employeeID", employeeID);
                    command.Parameters.AddWithValue("@movieID", movieID);
                    command.Parameters.AddWithValue("@rentalDate", rentalDate);
                    command.Parameters.AddWithValue("@returnDate", returnDate);

                    // Выполняем запрос
                    command.ExecuteNonQuery();

                    MessageBox.Show("Аренда успешно добавлена.");
                }
            }

            // Очищаем поля ввода
            ComboBoxCustomer.Text = string.Empty;
            ComboBoxEmployee.Text = string.Empty;
            ComboBoxMovie.Text = string.Empty;

            this.Close();
            mainForm.LoadRentalsData();
        }
    }
}
