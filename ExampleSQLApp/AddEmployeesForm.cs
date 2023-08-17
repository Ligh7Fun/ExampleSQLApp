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
        public AddEmployeesForm()
        {
            InitializeComponent();
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
            DateTime terminationDate = TerminationDateField.Value;

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
                    command.Parameters.AddWithValue("@terminationDate", terminationDate);

                    // Выполняем запрос
                    command.ExecuteNonQuery();

                    MessageBox.Show("Сотрудник успешно добавлен.");
                }
            }

            // Очищаем поля ввода
            FullNameField.Clear();
            AddressField.Clear();
            PhoneNumberField.Clear();
            this.Close();

        }

        private void TerminationDateField_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HireDateField_ValueChanged(object sender, EventArgs e)
        {
        }

        private void BirthDateField_ValueChanged(object sender, EventArgs e)
        {
        }

        private void PhoneNumberField_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddressField_TextChanged(object sender, EventArgs e)
        {
        }

        private void FullNameField_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void LabelPhoneNumber_Click(object sender, EventArgs e)
        {
        }

        private void LabelAddress_Click(object sender, EventArgs e)
        {
        }

        private void LabelFullName_Click(object sender, EventArgs e)
        {
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {
        }

        private void TimerCreateTable_Tick(object sender, EventArgs e)
        {
        }
    }
}
