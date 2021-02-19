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
using System.Windows.Shapes;
using Exam1111;
namespace UI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        DALClass dAL = new DALClass();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login(TUser.Text, TPasswd.Text);
        }

        private void Login(string login, string password)
        {
            if(!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(password))
            {
                var user = dAL.Login(login, password);
                if(user != null)
                {
                    foreach(var item in user)
                    {
                        MessageBox.Show($"Hellow {item.Name}");
                        Shop shop = new Shop(user);
                        this.Close();
                        shop.ShowDialog();
                    }
                  
                }
            }
        }
    }
}
