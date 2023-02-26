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

namespace Diplom.Pages
{
    /// <summary>
    /// Interaction logic for ChangePasswordPage.xaml
    /// </summary>
    public partial class ChangePasswordPage : Page
    {
        public ChangePasswordPage()
        {
            InitializeComponent();
        }

        private void RollBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }
    }
}
