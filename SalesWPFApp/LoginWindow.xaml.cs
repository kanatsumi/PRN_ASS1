using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IMemberRepository _memberRepository;
        public LoginWindow()
        {
            InitializeComponent();
            _memberRepository = new MemberRepository();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = ConfigurationManager.AppSettings["Email"];
            string password = ConfigurationManager.AppSettings["Password"];
            if (txtUsername.Text == email && txtPassword.Password == password)
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            } 
            else if (_memberRepository.GetMemberLogin(txtUsername.Text, txtPassword.Password) != null)
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            } else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
