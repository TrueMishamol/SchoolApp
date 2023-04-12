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

namespace SchoolApp.Pages {
    /// <summary>
    /// Interaction logic for LessonsPage.xaml
    /// </summary>
    public partial class LessonsPage : Page {
        public LessonsPage() {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) {
            if (Visibility == Visibility.Visible) {
                SchoolDataBaseEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGrid.ItemsSource = SchoolDataBaseEntities.GetContext().Lessons.ToList();
            }
        }
    }
}
