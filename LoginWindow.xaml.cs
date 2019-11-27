using MertKaymaz_HW5.Data;
using MertKaymaz_HW5.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MertKaymaz_HW5
{
    /// <summary>
    /// LoginWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class LoginWindow : Window
    {
        CetRole CetRole1 = new CetRole();
        CetRole CetRole2 = new CetRole();
        CetRole CetRole3 = new CetRole();

        public LoginWindow()

        {

            CetRole1.Name = "Admin";
            CetRole2.Name = "Super Admin";
            CetRole3.Name = "User";
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            CetUserService cetUserService = new CetUserService();
            //txtPassword.Text=cetUserService.hashPassword("admin");
            var loginUser = cetUserService.Login(txtUserName.Text, txtPassword.Password);
            if (loginUser == null)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            else
            {
                /// Doğru giriş yapıldı.
                MainWindow mainWindow = new MainWindow(loginUser);
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
