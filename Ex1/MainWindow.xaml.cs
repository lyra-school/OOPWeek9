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

namespace Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Expense> expenses = new ObservableCollection<Expense>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            Expense exp1 = new Expense((decimal)Math.Truncate(rnd.NextDouble() * 10000)/100, new DateTime(2023, 10, rnd.Next(1, 32)), (Categories)rnd.Next(0, 3));
            Expense exp2 = new Expense((decimal)Math.Truncate(rnd.NextDouble() * 10000)/100, new DateTime(2023, 10, rnd.Next(1, 32)), (Categories)rnd.Next(0, 3));
            Expense exp3 = new Expense((decimal)Math.Truncate(rnd.NextDouble() * 10000)/100, new DateTime(2023, 10, rnd.Next(1, 32)), (Categories)rnd.Next(0, 3));

            expenses.Add(exp1);
            expenses.Add(exp2);
            expenses.Add(exp3);

            ExpList.ItemsSource = expenses;
            TotalCalc();
        }

        private void AddExp_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            expenses.Add(new Expense((decimal)Math.Truncate(rnd.NextDouble() * 10000) / 100, new DateTime(2023, 10, rnd.Next(1, 32)), (Categories)rnd.Next(0, 3)));
            TotalCalc();
        }

        public void TotalCalc()
        {
            decimal total = 0;
            foreach(Expense exp in expenses)
            {
                total += exp.Amount;
            }
            TotalExp.Text = "€" + total.ToString();
        }
    }
}
