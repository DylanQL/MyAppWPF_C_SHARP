using System.Windows;
using System.Windows.Controls;

namespace MyAppWPF
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        // Operaciones
        private void btnIngresos_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new OperacionesIngresos();
        }

        private void btnSalidas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new OperacionesSalidas();
        }

        // Mantenimientos
        private void btnConductores_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MantenimientoConductores();
        }

        private void btnTransportistas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MantenimientoTransportistas();
        }

        private void btnCamiones_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MantenimientoCamiones();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MantenimientoProductos();
        }

        // Reportes
        private void btnReporteCargas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ReporteCargas();
        }

        private void btnReporteIngresos_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ReporteIngresos();
        }

        private void btnReporteSalidas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ReporteSalidas();
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
