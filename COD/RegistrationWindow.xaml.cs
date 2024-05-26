using COD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        Context _context;

        public RegistrationWindow()
        {
            _context = new Context();
            InitializeComponent();
            Role.ItemsSource = _context.Roles.ToList();
            Role.DisplayMemberPath = "Name";
            Role.SelectedValuePath = "Id";
        }

        //проверка полей
        public bool RegCheck()
        {
            //проверка полей на пустоту
            if (string.IsNullOrEmpty(Name.Text)
                || string.IsNullOrEmpty(Govno.Text)
                || string.IsNullOrEmpty(Password.Password)
                || string.IsNullOrEmpty(PasswordConfirm.Password)
                || Role.SelectedValue == null)
            {
                MessageBox.Show("Проверьте заполненны ли все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            //проверка паролей на совпадение
            if (Password.Password != PasswordConfirm.Password)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (Regex.IsMatch(Name.Text, @"[a-zA-Z]|\s|\d|\W") && Regex.IsMatch(Name.Text, @"[a-zA-Z]|\s|\d|\W"))
            {
                MessageBox.Show("Имя и говно должны состоять только из букв кириллицы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Role.SelectedValue.ToString());
            if (RegCheck())
            {
                MessageBox.Show("Molodec");
            }
        }
    }
}
