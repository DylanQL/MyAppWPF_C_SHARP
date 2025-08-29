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

namespace MyAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string VALID_USERNAME = "admin";
        private const string VALID_PASSWORD = "admin";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (username == VALID_USERNAME && password == VALID_PASSWORD)
            {
                // Login successful, open menu window
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                this.Close();
            }
            else
            {
                // Login failed, show error message
                txtError.Text = "Usuario o contraseña incorrectos. Por favor, intente nuevamente.";
                txtPassword.Password = "";
            }
        }
    }
}