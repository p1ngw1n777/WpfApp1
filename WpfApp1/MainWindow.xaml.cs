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

namespace WpfApp1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            big.Background = new SolidColorBrush(Colors.Red);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            big.Background = new SolidColorBrush(Colors.Blue);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            big.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Class1 cl1 = new Class1(textBox1.Text);
        }
    }
}
