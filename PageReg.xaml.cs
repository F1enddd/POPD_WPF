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

namespace POPD_WPF
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        WindowRegistration WReg;
        PageAft PAft;
        AppDbContext db;
        public PageReg(WindowRegistration Wreg)
        {
            InitializeComponent();
            WReg = Wreg;
        }

        private void ButtonConfirmReg_Click(object sender, RoutedEventArgs e)
        {
            string Login = TextBoxLogin.Text;
            string Name = TextBoxName.Text;
            string Pass = PassBoxPass.Password;

            using(db = new AppDbContext())
            {
                User newUser = new User();
                newUser.Login = Login;
                newUser.Name = Name;
                newUser.Password = Pass;

                db.Users.Add(newUser);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Вы успешно зарегестрировались", "Успешно!");
                else
                {
                    MessageBox.Show("Проверьте данные, возможно, они содержат больше 30 символов или уже существуют", "Ошибка!");
                    TextBoxLogin.Text = null;
                    TextBoxName.Text = null;
                    PassBoxPass.Password = null;
                }
            }
            
        }

        private void ButtonAft_Click(object sender, RoutedEventArgs e)
        {
            PAft = new PageAft(WReg);
            WReg.FrameRegAft.Navigate(PAft);
            WReg.TBTitle.Text = "Авторизация";
        }
    }
}
