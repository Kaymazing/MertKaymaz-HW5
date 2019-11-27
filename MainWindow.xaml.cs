using MertKaymaz_HW5.Data;
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

namespace MertKaymaz_HW5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private CetUser loginUser;
        public MainWindow(CetUser cetUser)
        {
            loginUser = cetUser;
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
         
          txtLoginUser.Text = "Hoş geldin " + loginUser.Name + " " + loginUser.Surname + ", " + loginUser.role.ToString();
        } 

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çıkmak İstediğinize Emin misiniz?", "Onay", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void PChange_Click(object sender, RoutedEventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange(loginUser);
            passwordChange.Show();
        }
    }
}
