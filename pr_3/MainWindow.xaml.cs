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
using pr_3.Practika2DataSetTableAdapters;

namespace pr_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Practika2Entities3 context = new Practika2Entities3();
        List<Table> Tables = new List<Table>();
        District2TableAdapter district = new District2TableAdapter();   
        public MainWindow()
        {
            InitializeComponent();
            Dtg2.ItemsSource = district.GetFullInfo();
            Dtg.ItemsSource = context.District2.ToList();
            foreach (var item in context.District2.ToList())
            {
                Tables.Add(new Table(item));
            }
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Dtg2.Columns[0].Visibility = Visibility.Collapsed;
            Dtg2.Columns[2].Visibility = Visibility.Collapsed;

        }
    }
}
