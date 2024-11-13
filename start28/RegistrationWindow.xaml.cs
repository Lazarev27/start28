using System;
using System.Windows;
using System.Windows.Controls;

namespace start28
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            DateTime? birthDate = BirthDatePicker.SelectedDate;
            string teamName = TeamNameTextBox.Text;
            string category = (CategoryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || !birthDate.HasValue ||
                string.IsNullOrEmpty(teamName) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            

            MessageBox.Show("Регистрация успешна!");
            this.Close(); // Закрыть окно после успешной регистрации
        }
    }
}
