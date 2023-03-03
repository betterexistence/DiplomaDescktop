using Diplom.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Diplom.Pages.MainPages
{
    public partial class DataGridPage : Page
    {
        public ObservableCollection<Data> Data;
        private Actions<Data> model;
        public DataGridPage()
        {
            InitializeComponent();
            model = new Actions<Data>();
            UpdateGrid();
        }

        public void UpdateGrid(Data data = null)
        {
            if ((data == null) && (DataGrid.ItemsSource != null))
            {
                data = (Data)DataGrid.SelectedItem;
            }
            Data = new ObservableCollection<Data>(SourceCore.entities.Data);
            DataGrid.ItemsSource = Data;
            DataGrid.SelectedItem = data ?? Data[0];
            DataGrid.DataContext = this;
        }

        private void ViewDoc_Click(object sender, RoutedEventArgs e)
        {
            Data item = DataGrid.SelectedItem as Data;
            if(item != null)
            {
                new MultiLineWindow(item.description).Show();
            }
        }

        private void UpdateData_Click(object sender, RoutedEventArgs e)
        {
            UpdateGrid();
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            //Data.Add(new Data());
            model.Add(new Data());
            //DataGrid.[Data.Count-1, 0].value = ;
            DataGrid.SelectedItem = Data[Data.Count-1];
        }

        private void EditNote_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteNote_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AccpetChanges_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelChanges_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
