using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseOfCourse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _currentUser;
        private Context context;
        private bool expanded;

        public MainWindow()
        {
            InitializeComponent();
            context = new Context();
            expanded = false;

            _currentUser = "Ashan";

            CurrentUser.Text = _currentUser;
        }
        private void Login_page(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new LoginPage());
        }
        private void First_page(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Page1());
        }
        private void Music_page(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Music());
        }

        private void MenuClick(object sender, RoutedEventArgs e)
        {
            if (expanded)
            {
                expanded = false;
                LeftPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                expanded = true;
                LeftPanel.Visibility = Visibility.Visible;
            }
        }
    }
}
