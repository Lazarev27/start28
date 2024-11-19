using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace start28
{
    /// <summary>
    /// Логика взаимодействия для Protocol_finish.xaml
    /// </summary>
    public partial class Protocol_finish : Window
    {
        public Protocol_finish()
        {
            InitializeComponent();
        }
        private void ProtocolFinish_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan finishtime = (TimeSpan)FinishTime;
            Finish_Protocol Finish_ProtocolEntity = new Finish_Protocol
            {
                Time_finish = finishtime,
                distance = DistanceBox.Text.Trim(),
            };
            UserExistsF(Finish_ProtocolEntity);
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
        }
        public void UserExistsF(Finish_Protocol finish_protocol)
        {
            using (var contextF = new Context())
            {
                contextF.Finish_Protocol.Add(finish_protocol);
                contextF.SaveChanges();
                MessageBox.Show("Успешно добавлено.");
                this.Close();
            }
        }

    }
}
 