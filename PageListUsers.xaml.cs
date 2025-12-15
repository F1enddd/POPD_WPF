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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace POPD_WPF
{
    /// <summary>
    /// Логика взаимодействия для PageListUsers.xaml
    /// </summary>
    public partial class PageListUsers : Page
    {
        AppDbContext db;
        List<User> ListUsers;
        public PageListUsers(string userLogin)
        {
            InitializeComponent();
            db = new AppDbContext();
            ListUsers = db.Users.ToList();
            ListViewUsers.ItemsSource = ListUsers;
            TBLoginInfo.Text =  $"Вы вошли как: {userLogin}";
        }


        private void TBFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = TBFilter.Text.ToLower();
            var FilteredListUsers = ListUsers.Where(b => ($"{b.Name} {b.Login} {b.Password}".ToLower()).Contains(filter)).ToList();
            ListViewUsers.ItemsSource = FilteredListUsers;

            if (String.IsNullOrEmpty(TBFilter.Text))
                ListViewUsers.ItemsSource = ListUsers;
        }
    }
}
