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
using System.Windows.Annotations;


namespace start28
{
    /// <summary>
    /// Логика взаимодействия для Protocol_start.xaml
    /// </summary>
    public partial class Protocol_start : Window
    {
        public Protocol_start()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            DateTime starttime = (DateTime)Time_Start.SelectedDate;
            Start_Protocol Start_ProtocolEntity = new Start_Protocol
            {
                Time_start = starttime,
                distance = Distance.Text.Trim(),
            };
        }

    }
}
   
