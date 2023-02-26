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
    /// <summary>
    /// Interaction logic for DataGridPage.xaml
    /// </summary>
    public partial class DataGridPage : Page
    {
        public DataGridPage()
        {
            InitializeComponent();
            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            members.Add(new Member { Number = "1", Character = "A", BgColor = (Brush)converter.ConvertFromString("#123456"), Name = "Q", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "2", Character = "B", BgColor = (Brush)converter.ConvertFromString("#12345d"), Name = "W", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "3", Character = "C", BgColor = (Brush)converter.ConvertFromString("#12e456"), Name = "E", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "4", Character = "D", BgColor = (Brush)converter.ConvertFromString("#1f3456"), Name = "R", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "5", Character = "F", BgColor = (Brush)converter.ConvertFromString("#178956"), Name = "T", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "6", Character = "G", BgColor = (Brush)converter.ConvertFromString("#1af456"), Name = "Y", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "7", Character = "Z", BgColor = (Brush)converter.ConvertFromString("#888456"), Name = "U", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "8", Character = "X", BgColor = (Brush)converter.ConvertFromString("#123776"), Name = "I", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "9", Character = "C", BgColor = (Brush)converter.ConvertFromString("#952456"), Name = "O", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "10", Character = "B", BgColor = (Brush)converter.ConvertFromString("#fff456"), Name = "P", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "11", Character = "Q", BgColor = (Brush)converter.ConvertFromString("#000456"), Name = "A", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "12", Character = "W", BgColor = (Brush)converter.ConvertFromString("#999456"), Name = "S", Position = "", Email = "", Phone = "" });

            members.Add(new Member { Number = "1", Character = "A", BgColor = (Brush)converter.ConvertFromString("#123456"), Name = "Q", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "2", Character = "B", BgColor = (Brush)converter.ConvertFromString("#12345d"), Name = "W", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "3", Character = "C", BgColor = (Brush)converter.ConvertFromString("#12e456"), Name = "E", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "4", Character = "D", BgColor = (Brush)converter.ConvertFromString("#1f3456"), Name = "R", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "5", Character = "F", BgColor = (Brush)converter.ConvertFromString("#178956"), Name = "T", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "6", Character = "G", BgColor = (Brush)converter.ConvertFromString("#1af456"), Name = "Y", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "7", Character = "Z", BgColor = (Brush)converter.ConvertFromString("#888456"), Name = "U", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "8", Character = "X", BgColor = (Brush)converter.ConvertFromString("#123776"), Name = "I", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "9", Character = "C", BgColor = (Brush)converter.ConvertFromString("#952456"), Name = "O", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "10", Character = "B", BgColor = (Brush)converter.ConvertFromString("#fff456"), Name = "P", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "11", Character = "Q", BgColor = (Brush)converter.ConvertFromString("#000456"), Name = "A", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "12", Character = "W", BgColor = (Brush)converter.ConvertFromString("#999456"), Name = "S", Position = "", Email = "", Phone = "" });

            members.Add(new Member { Number = "1", Character = "A", BgColor = (Brush)converter.ConvertFromString("#123456"), Name = "Q", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "2", Character = "B", BgColor = (Brush)converter.ConvertFromString("#12345d"), Name = "W", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "3", Character = "C", BgColor = (Brush)converter.ConvertFromString("#12e456"), Name = "E", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "4", Character = "D", BgColor = (Brush)converter.ConvertFromString("#1f3456"), Name = "R", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "5", Character = "F", BgColor = (Brush)converter.ConvertFromString("#178956"), Name = "T", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "6", Character = "G", BgColor = (Brush)converter.ConvertFromString("#1af456"), Name = "Y", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "7", Character = "Z", BgColor = (Brush)converter.ConvertFromString("#888456"), Name = "U", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "8", Character = "X", BgColor = (Brush)converter.ConvertFromString("#123776"), Name = "I", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "9", Character = "C", BgColor = (Brush)converter.ConvertFromString("#952456"), Name = "O", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "10", Character = "B", BgColor = (Brush)converter.ConvertFromString("#fff456"), Name = "P", Position = "Coach", Email = "", Phone = "" });
            members.Add(new Member { Number = "11", Character = "Q", BgColor = (Brush)converter.ConvertFromString("#000456"), Name = "A", Position = "", Email = "", Phone = "" });
            members.Add(new Member { Number = "12", Character = "W", BgColor = (Brush)converter.ConvertFromString("#999456"), Name = "S", Position = "", Email = "", Phone = "" });

            DataGrid.ItemsSource = members;
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}
