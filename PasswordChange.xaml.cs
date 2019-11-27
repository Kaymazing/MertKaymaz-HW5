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
    /// PasswordChange.xaml etkileşim mantığı
    /// </summary>
    public partial class PasswordChange : Window
    {
        private CetUser loginUser;
        private Database db = new Database();
        public PasswordChange(CetUser cetUser)
        {
            loginUser = cetUser;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CetUserService cetUserService = new CetUserService();

            string tempeskisifre = cetUserService.hashPassword(txtEski.Password.ToString());

            if (tempeskisifre == loginUser.Password)
            {
                string tempyenisifre = cetUserService.hashPassword(txtYeni.Password.ToString());
                string tempyenisifretekrar = cetUserService.hashPassword(txtYeniTekrar.Password.ToString());
                if (tempyenisifre == tempyenisifretekrar)
                {
                    loginUser.Password = tempyenisifre;
                    db.CetUsers.Update(loginUser);
                    db.SaveChangesAsync();
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                }
               else MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            else MessageBox.Show("Hatalı Giriş Yaptınız");
        }
    }
}
