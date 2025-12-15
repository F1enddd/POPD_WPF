using POPD_WPF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Логика взаимодействия для WindowThemes.xaml
    /// </summary>
    public partial class WindowThemes : Window
    {
        public WindowThemes()
        {
            InitializeComponent();
            DataContext = new FolderViewModel();
            

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

        private void TreeViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 1. Правовое регулирование экономических отношений на примере предпринимательской деятельности", "ИП_ правовой статус и регистрация.pptx"));
        }

        private void TreeViewItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 1. Правовое регулирование экономических отношений на примере предпринимательской деятельности", "Понятие и признаки субъектов предпринимательской деятельности.docx"));
        }
        private void TreeViewItem_MouseDoubleClick_4(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 1. Правовое регулирование экономических отношений на примере предпринимательской деятельности", "Правовой статус индивидуального предпринимателя.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_2(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 1. Правовое регулирование экономических отношений на примере предпринимательской деятельности", "Субъекты предпринимательского права (1).pptx"));
        }

        private void TreeViewItem_MouseDoubleClick_3(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 1. Правовое регулирование экономических отношений на примере предпринимательской деятельности", "Экономические споры и иск в арбитраже.pptx"));
        }

        public void OpenFile(string path)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл:\n{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Тема2
        private void TreeViewItem_MouseDoubleClick_5(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 2", "3333.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_6(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 2", "1112159.pptx"));
        }

        private void TreeViewItem_MouseDoubleClick_7(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 2", "Занятость и трудоустройство.mp4"));
        }

        private void TreeViewItem_MouseDoubleClick_8(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 2", "Практическая Трудовые споры.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_9(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 2", "Трудовые споры 2.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_10(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 2", "Трудовые споры_ путь к согласию (1).pptx"));
        }

        private void TreeViewItem_MouseDoubleClick_11(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 3", "Понятие и виды информационных ресурсов", "Понятие и виды информационных ресурсов.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_12(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 3", "Правовое регулирование деятельности СМИ", "Pravovye_aspekty_dejatel6nosti_SMI.ppt"));
        }

        private void TreeViewItem_MouseDoubleClick_13(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 3", "Правовые режимы", "На дом. Конспект.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_14(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 3", "Правовые режимы", "Правовые режимы информации.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_15(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 3", "Правовые режимы", "Правовые рижимы информации.pptx"));
        }

        private void TreeViewItem_MouseDoubleClick_16(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 3", "Правовые режимы", "Распечатать.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_17(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 3", "Презентация на тему _Право в области информации_.pptx"));
        }

        private void TreeViewItem_MouseDoubleClick_18(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 3", "Режимы защиты информации для IT-специалиста.pptx"));
        }

        private void TreeViewItem_MouseDoubleClick_19(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "Административные правонарушения", "wepik-analiz-administrativnyx-pravonarusenii-problemy-i-reseniia-20231210105900BB44.pdf"));
        }

        private void TreeViewItem_MouseDoubleClick_20(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "Административные правонарушения", "Админестративные правонарушения.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_21(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "Административные правонарушения", "Задание.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_22(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "Понятие административной ответственности, ее цели, функции и признаки", "wepik-administrativnaia-otvetstvennost-celi-funkcii-i-priznaki-20231210111632F1zE.pdf"));
        }

        private void TreeViewItem_MouseDoubleClick_23(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "Понятие административной ответственности, ее цели, функции и признаки", "Административная ответственность.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_24(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "Понятие административной ответственности, ее цели, функции и признаки", "Задание.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_25(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "ПР административные право нарушения", "Задание_по_административным_правонарушениям.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_26(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "ПР административные право нарушения", "Источники_по_административным_правонарушениям.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_27(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "19418.ppt"));
        }

        private void TreeViewItem_MouseDoubleClick_28(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Тема 4", "Админестративное правонарушение.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_29(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Административная_ответсвенность.docx"));
        }

        private void TreeViewItem_MouseDoubleClick_30(object sender, MouseButtonEventArgs e)
        {
            OpenFile(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Themes", "Заработная плата.docx"));
        }
    }
}
