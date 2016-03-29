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
using _5._2___StoreFront_WPF.StoreServiceReference;

namespace _5._2___StoreFront_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StoreServiceClient ssc;
        public MainWindow()
        {
            InitializeComponent();
            ssc = new StoreServiceClient();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            String username = this.txtRegisterUsername.Text;
            Boolean unique = ssc.Register(username);
            if (unique)
            {
                lblGeneratedPassword2.Foreground = Brushes.Black;
                lblGeneratedPassword2.Content = reverse(username);
            }
            else
            {
                lblGeneratedPassword2.Foreground = Brushes.Red;
                lblGeneratedPassword2.Content = "User is not unique!";
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            User u = ssc.Login(this.txtUsername.Text, this.txtPassword.Password);

            if (u != null)
            {
                Window f = new wndStore(u, ssc);
                f.Show();
            }
        }

        public String reverse(String s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
