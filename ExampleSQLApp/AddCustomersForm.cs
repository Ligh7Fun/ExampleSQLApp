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
    public partial class AddCustomersForm : Form
    {
        private MainForm mainForm;
        public AddCustomersForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получаем значения из компонентов ввода
            string fullName = FullNameField.Text;
            DateTime birthDate = BirthDateField.Value;
            string address = AddressField.Text;
            string phoneNumber = PhoneNumberField.Text;
            DateTime registrationDate = RegistrationDateField.Value;



            if (fullName == string.Empty || address == string.Empty || phoneNumber == string.Empty)
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // SQL-запрос для вставки данных
                string insertQuery = @"
                    INSERT INTO Customers (FullName, BirthDate, Address, PhoneNumber, RegistrationDate)
                    VALUES (@fullName, @birthDate, @address, @phoneNumber, @registrationDate)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    // Добавляем параметры
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@birthDate", birthDate);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@registrationDate", registrationDate);

                    // Выполняем запрос
                    command.ExecuteNonQuery();

                    //MessageBox.Show("Клиент успешно добавлен.");
                }
            }

            this.Close();
            mainForm.LoadCustomersData();

        }
    }
}
