using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace COD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        Context context;
        public AuthWindow()
        {
            InitializeComponent();
            context = new Context();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (context.Users.FirstOrDefault(u => u.Email == Email.Text && u.Password == Password.Password) == null)
            {
                MessageBox.Show("Пользователя с такими данными не найдено?");
            }
            else
            {
                MainWindow MW = new MainWindow(context.Users.FirstOrDefault(u => u.Email == Email.Text && u.Password == Password.Password));
                MW.Show();
                this.Close();
            }
        }
    }
}