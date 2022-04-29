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
using static sessia2_BJA.Entity.Entity;

namespace sessia2_BJA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class Rustle : Window
    {
        public int RowAll { get; set; } = 0;
        public string Search { get; set; } = "";
        public int RowsShowed { get; set; } = 0;
        public int Page { get; set; } = 0;

        public Rustle()
        {
            InitializeComponent();
            Update();
        }

        private void MainTabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        public void Update()
        {
            var datasourse = content.Agent.ToList();
            RowAll = datasourse.Count();
            if (string.IsNullOrEmpty(Search) != true)
            {
                string search = Search.ToLower();
                datasourse = datasourse.Where(i => i.Title.ToLower().Contains(search) || i.Email.ToLower().Contains(search) || i.Phone.ToLower().Contains(search) == true).ToList();
            }
            RowsShowed = datasourse.Count();
            ListViewer.ItemsSource = datasourse;

            datasourse = datasourse.Skip(10 * Page).Take(10).ToList();
            if (datasourse.Count < 10)
            {
                Next.IsEnabled = false;
            }
            else
            {
                Next.IsEnabled = true;
            }
            
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Poisk_TB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RowsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void List_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Page--;
            Update();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Page++;
            Update();
        }

    }
}
