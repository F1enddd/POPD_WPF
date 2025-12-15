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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POPD_WPF
{
    /// <summary>
    /// Логика взаимодействия для PageAft.xaml
    /// </summary>
    public partial class PageAft : Page
    {
        WindowRegistration PWin;
        PageReg PReg;
        PageListUsers PListUsers;
        public PageAft(WindowRegistration Pwin)
        {
            InitializeComponent();
            PWin = Pwin;
        }

        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            PReg = new PageReg(PWin);
            PWin.FrameRegAft.Navigate(PReg);
            PWin.TBTitle.Text = "Регистрация";
        }

        private void ButtonConfirmAft_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text;
            string pass = PassBoxPass.Password;
            using (AppDbContext db = new AppDbContext())
            {
                User CurUser = new User();
                CurUser = null;

                CurUser = db.Users.Where(b => b.Login == login && b.Password == pass).FirstOrDefault();
                if (CurUser != null)
                {
                    db.SaveChanges();
                    MessageBox.Show($"Здравствуйте, {CurUser.Name}, Вы успешно вошли!", "Успех!");
                    PListUsers = new PageListUsers(CurUser.Login);
                    PWin.FrameRegAft.Navigate(PListUsers);
                    PWin.Title = "Список пользователей";
                }
                else
                    MessageBox.Show("Не получилось найти аккаунт с подходящим логином или паролем", "Ошибка!");
            }
        }
    }
}
