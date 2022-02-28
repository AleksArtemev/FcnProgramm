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

namespace FcnProgramm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Page_List1(object sender, RoutedEventArgs e)
        {
            MyFrameList.Content = new Page_List();
        }

        private void Page_Profile1(object sender, RoutedEventArgs e)
        {
            MyFrameList.Content = new Page_Profile();
        }
    }
}
