using Diplom.Pages.MainPages;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void DataGrid_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new DataGridPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new WelcomePage());
        }

        private void Welcome_Click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new WelcomePage());
        }
    }
}
