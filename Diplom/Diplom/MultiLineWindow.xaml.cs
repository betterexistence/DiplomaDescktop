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

namespace Diplom
{
    /// <summary>
    /// Interaction logic for MultiLineWindow.xaml
    /// </summary>
    public partial class MultiLineWindow : Window
    {
        public MultiLineWindow(string textBoxContent)
        {
            InitializeComponent();
            MultiTextBox.Text = textBoxContent;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            //описать логику сохранения с MultiTextBox
            Close();
        }
    }
}
