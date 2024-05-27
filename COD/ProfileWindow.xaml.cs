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
    /// Логика взаимодействия для ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        User _user;
        public ProfileWindow(User user)
        {
            _user = user;
            InitializeComponent();
            Birthday.DisplayDateEnd = DateTime.Today;
            GetData();
        }

        public void GetData()
        {
            Name.Text = _user.Name;
            Surname.Text = _user.Email;
            Birthday.SelectedDate = _user.Birthday;
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(Name.Text.Trim()) || string.IsNullOrEmpty(Surname.Text.Trim()))
            {
                MessageBox.Show("Все поля должны быть заполненны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (Birthday.SelectedDate >= DateTime.Today)
            {
                MessageBox.Show("Ты как в будущем родился, дебик", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return true;
        }
    }
}
