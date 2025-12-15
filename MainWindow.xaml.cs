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

namespace POPD_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowRegistration WReg;
        WindowAdm WAdm;
        WindowThemes WThemes;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
        {
            WReg = new WindowRegistration();
            WReg.Show();
            this.Close();
        }

        private void ButtonThemes_Click(object sender, RoutedEventArgs e)
        {
            WThemes = new WindowThemes();
            WThemes.Show();
            this.Close();
        }

        private void ButtonAdm_Click(object sender, RoutedEventArgs e)
        {
            WAdm = new WindowAdm();
            WAdm.Show();
            this.Close();
        }
    }
}