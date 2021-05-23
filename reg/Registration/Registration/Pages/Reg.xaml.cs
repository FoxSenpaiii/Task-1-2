using Registration.Class;
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

namespace Registration.Pages
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
            FrClass.Perexod = FrNav;
        }

        public Frame FrNav { get; }

        private void BTenter_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TBlogin.Text) && //Проверка на пустоту поля
                !string.IsNullOrWhiteSpace(TBlogin.Text) && //Проверка на пробелы поля
                !string.IsNullOrEmpty(TBpass.Text) &&
                !string.IsNullOrWhiteSpace(TBpass.Text) &&
                !string.IsNullOrEmpty(TBmail.Text) &&
                !string.IsNullOrWhiteSpace(TBmail.Text) &&
                TBmail.Text.Contains("@") && //Проверка на @
                TBpass.Text == TBretry.Text //Повтор пароля
                )
            {
                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Есть некорректное поле");
            }
        }

        private void TextBlock_Click(object sender, RoutedEventArgs e)
        {
            FrNav.Navigate(new Auth());
        }
    }
}
