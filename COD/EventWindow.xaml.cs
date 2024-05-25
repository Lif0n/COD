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
    /// Логика взаимодействия для EventWindow.xaml
    /// </summary>
    public partial class EventWindow : Window
    {
        Context _context;
        Event _event;
        public EventWindow( Event @event )
        {
            _context = new Context();
            _event = @event;
            InitializeComponent();
            NameTextBox.Text = @event.Name;
            DateEvent.SelectedDate = @event.Date.Date;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить эту хуйню?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _context.Events.Remove(_event);
                _context.SaveChanges();
                this.DialogResult = true;
                this.Close();
            }
        }
    }
}
