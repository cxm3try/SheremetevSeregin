using SheremetevSeregin.classes;
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

namespace SheremetevSeregin.pages
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            int countusers = ODBConnectHelper.entobj.registration.Count();
            if (ODBConnectHelper.entobj.registration.Count(X => X.login == txblogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            else

                if (PsbPassword.Password.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов");
                return;

            }
            else
                if (txblogin.Text == null)
            {
                MessageBox.Show("Заполните поле логина");
                return;

            }
            else
                if (txbEmail.Text == null)
            {
                MessageBox.Show("Заполните поле Email");
                return;

            }
            else

                try
                {
                    registration userObj = new registration()
                    {
                        id_registration = countusers + 1,
                        login = txblogin.Text,
                        password = PsbPassword.Password,
                        email = txbEmail.Text,
                        age = txbAge.Text

                    };
                    ODBConnectHelper.entobj.registration.Add(userObj);
                    ODBConnectHelper.entobj.SaveChanges();
                    userObj = null;
                    MessageBox.Show("Пользователь создан", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    FrmApp.frmObj.Navigate(new login());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы приложения :" + ex.Message.ToString(), "ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

        }

        private void combobox(object sender, MouseButtonEventArgs e)
        {
            txbAge.Items.Add("18");
            txbAge.Items.Add("19");
            txbAge.Items.Add("20");
            txbAge.Items.Add("21");
            txbAge.Items.Add("22");
            txbAge.Items.Add("23");
            txbAge.Items.Add("24");
            txbAge.Items.Add("25");
            txbAge.Items.Add("26");
            txbAge.Items.Add("27");
            txbAge.Items.Add("28");
            txbAge.Items.Add("29");
            txbAge.Items.Add("30");
            txbAge.Items.Add("31");
            txbAge.Items.Add("32");
            txbAge.Items.Add("33");
            txbAge.Items.Add("34");
            txbAge.Items.Add("35");
            txbAge.Items.Add("36");
            txbAge.Items.Add("37");
            txbAge.Items.Add("38");
            txbAge.Items.Add("39");
            txbAge.Items.Add("40");
            txbAge.Items.Add("41");
            txbAge.Items.Add("42");
            txbAge.Items.Add("43");
            txbAge.Items.Add("44");
            txbAge.Items.Add("45");
            txbAge.Items.Add("46");
            txbAge.Items.Add("47");
            txbAge.Items.Add("48");
            txbAge.Items.Add("49");
            txbAge.Items.Add("50");
            txbAge.Items.Add("51");
            txbAge.Items.Add("52");
            txbAge.Items.Add("53");
            txbAge.Items.Add("54");
            txbAge.Items.Add("55");
            txbAge.Items.Add("56");
            txbAge.Items.Add("57");
            txbAge.Items.Add("58");
            txbAge.Items.Add("59");
            txbAge.Items.Add("60");
            txbAge.Items.Add("61");
            txbAge.Items.Add("62");
            txbAge.Items.Add("63");
            txbAge.Items.Add("64");
            txbAge.Items.Add("65");
        }

        private void txbAge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
