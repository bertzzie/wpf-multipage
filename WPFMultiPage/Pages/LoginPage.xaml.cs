using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMultiPage.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page, INavigatable, INavigator
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void Navigate(Page nextPage, object state)
        {
            Window.GetWindow(this).Content = nextPage;
            INavigatable n = nextPage as INavigatable;

            if (n != null)
            {
                n.ProcessState(state);
            }
            else
            {
                throw new ArgumentException("Halaman " + nextPage.Name + " tidak memiliki state!");
            }

        }

        public void Navigate(Page nextPage)
        {
            Window.GetWindow(this).Content = nextPage;
        }

        public void ProcessState(object state)
        {
            throw new NotImplementedException();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Navigate(new MainPage());
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            Navigate(new AfterLogin());
        }
    }
}
