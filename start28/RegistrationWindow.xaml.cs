using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Annotations;
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

            DateTime birthDate = (DateTime)BirthDatePicker.SelectedDate;
            Participants ParticipantsEntity = new Participants
            {
                Login = LoginBox.Text.Trim(),
                Password = PasswordBox.Text.Trim(),
                FirstName = FirstNameTextBox.Text.Trim(),
                LastName = LastNameTextBox.Text.Trim(),
                BirthDate = birthDate,
                TeamName = TeamNameTextBox.Text.Trim(),
            };
            UserExistsAsync(ParticipantsEntity);




            if (string.IsNullOrEmpty(FirstNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text)|| string.IsNullOrEmpty(LoginBox.Text)|| string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
        }
        private void ButtonOpenProtocol_start_Click(object sender, RoutedEventArgs e)
        {
            Protocol_start Protocol_start = new Protocol_start(); // Создаем экземпляр второго окна
            Protocol_start.Show(); // Открываем второе окно
            this.Close();
        }
        public void UserExistsAsync(Participants participants)
        {

            if (participants == null || string.IsNullOrEmpty(participants.Login))
            {
                MessageBox.Show("Логин не может быть пустым.");
            }
            else
            {
                using (var context = new Context())
                {
                    bool userExists = context.Participants.Any(u => u.Login == participants.Login);

                    if (userExists)
                    {
                        MessageBox.Show("Пользователь уже существует.");
                    }
                    else
                    {
                        context.Participants.Add(participants);
                        context.SaveChanges();
                        MessageBox.Show("Пользователь успешно добавлен.");
                    }
                }
            }

        }


    }
    
}
