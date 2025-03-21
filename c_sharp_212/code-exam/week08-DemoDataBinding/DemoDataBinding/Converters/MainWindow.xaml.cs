﻿using Converters.Models;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Converters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Book> _booksService = new ObservableCollection<Book>(SampleBooksService.GetAll());
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

            BooksList.ItemsSource = _booksService;
        }

    }
}