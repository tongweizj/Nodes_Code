﻿using Converters.Models;
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

namespace Converters
{
    /// <summary>
    /// Interaction logic for BookUserControl.xaml
    /// </summary>
    public partial class BookUserControl : UserControl
    {
        public Book? Book
        {
            get => (Book)GetValue(BookProperty);
            set => SetValue(BookProperty, value);
        }

        // Constructor
        public BookUserControl()
        {
            DataContext = this;
            InitializeComponent();
        }

        // Required to bind
        public static readonly DependencyProperty BookProperty =
            DependencyProperty.Register("Book", typeof(Book), typeof(BookUserControl), new PropertyMetadata(null));
    }
}
