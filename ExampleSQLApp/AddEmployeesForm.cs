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
    public partial class AddEmployeesForm : Form
    {
        private MainForm mainForm;
        public AddEmployeesForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            TerminationDateField.Value = DateTimePicker.MinimumDateTime;
            TerminationDateField.CustomFormat = " ";
            TerminationDateField.Format = DateTimePickerFormat.Custom;
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получаем значения из компонентов ввода
            string fullName = FullNameField.Text;
            DateTime birthDate = BirthDateField.Value;
            string address = AddressField.Text;
            string phoneNumber = PhoneNumberField.Text;
            DateTime hireDate = HireDateField.Value;
            //DateTime terminationDate = TerminationDateField.Value;
            DateTime? terminationDate = null;

            if (TerminationDateField.Value != DateTimePicker.MinimumDateTime)
            {
                terminationDate = TerminationDateField.Value;
            }


            if (fullName == string.Empty || address == string.Empty || phoneNumber == string.Empty)
            {
                MessageBox.Show("Поля \"ФИО\", \"Адрес\", \"Телефон\" обязательны к заполнению.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // SQL-запрос для вставки данных
                string insertQuery = @"
                    INSERT INTO Employees (FullName, BirthDate, Address, PhoneNumber, HireDate, TerminationDate)
                    VALUES (@fullName, @birthDate, @address, @phoneNumber, @hireDate, @terminationDate)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    // Добавляем параметры
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@birthDate", birthDate);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@hireDate", hireDate);
                    command.Parameters.AddWithValue("@terminationDate", terminationDate.HasValue ? (object)terminationDate.Value : DBNull.Value);


                    // Выполняем запрос
                    command.ExecuteNonQuery();

                    //MessageBox.Show("Сотрудник успешно добавлен.");
                }
            }

            // Очищаем поля ввода
            FullNameField.Clear();
            AddressField.Clear();
            PhoneNumberField.Clear();
            this.Close();
            mainForm.LoadEmployeesData();
        }

    }
}
