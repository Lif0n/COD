using COD.Models;
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

namespace COD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Context _context;
        public MainWindow()
        {
            InitializeComponent();
            _context = new Context();
            //EventsList.DataContext = _context.Events.ToList();
            EventsList.ItemsSource = _context.Events.ToList();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow AW = new AuthWindow();
            AW.Show();
            this.Close();
        }

        private void EventsList_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            EventWindow EW = new EventWindow(EventsList.SelectedValue as Event);
            EW.Show();
        }
    }
}
