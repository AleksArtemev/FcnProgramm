﻿using System;
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
    /// Логика взаимодействия для Page_List.xaml
    /// </summary>
    public partial class Page_List : Page
    {
        public Page_List()
        {
            InitializeComponent();
        }

        private void Page_Test1(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page_Test();
        }

        private void Page_Dialogue1(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page_Dialogue();
        }
    }
}
