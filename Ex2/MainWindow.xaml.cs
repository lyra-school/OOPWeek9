using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Member> members = new ObservableCollection<Member>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dropdown.ItemsSource = Enum.GetValues(typeof(MemberType)).Cast<MemberType>().ToList();
            memberList.ItemsSource = members;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string nameInp = nameInput.Text;
            if(dropdown.SelectedItem == null || String.IsNullOrEmpty(nameInp) || datePick.SelectedDate == null)
            {
                return;
            }
            Random rnd = new Random();
            DateTime dt = (DateTime)datePick.SelectedDate;
            MemberType mem = (MemberType)dropdown.SelectedItem;
            members.Add(new Member(nameInp, mem, new DateTime(rnd.Next(2000, 2016), dt.Month, dt.Day)));
            memberCount.Text ="Number of members: " + members.Count;
        }
    }
}
