using POPD_WPF.Models;
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

namespace POPD_WPF
{
    /// <summary>
    /// Логика взаимодействия для WindowADm.xaml
    /// </summary>
    public partial class WindowAdm : Window
    {
        AppDbContext db;
        public WindowAdm()
        {
            InitializeComponent();
            db = new AppDbContext();
            var AdmList = db.AdministrativeOffenses.ToList();
            ListViewAdm.ItemsSource = AdmList;
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

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }
    }
}
