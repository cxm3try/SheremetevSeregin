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
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
            string login = txb_Login.Text;
        }

        private void btn_signin(object sender, RoutedEventArgs e)
        {
            var userObj = ODBConnectHelper.entobj.registration.FirstOrDefault(X => X.login.ToLower() == txb_Login.Text.ToLower() && X.password == txb_Password.Password && X.email == txb_Email.Text);
            if (userObj == null)
            {
                MessageBox.Show("This person is not found ", "Message",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

            }
            else
            {

                App.Current.Resources["TextTes1t"] = txb_Password.Password;
                App.Current.Resources["TextTest"] = txb_Login.Text;
                FrmApp.frmObj.Navigate(new Page1());

            }
        }

    }
}
