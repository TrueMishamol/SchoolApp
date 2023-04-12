using SchoolApp.Pages;
using SchoolApp.Scripts;
using System;
using System.Windows;

namespace SchoolApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            PagesFrame.Navigate(new MenuPage());
            SwitchMainFrame.MainFrame = PagesFrame;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.GoBack();
        }

        private void PagesFrame_ContentRendered(object sender, EventArgs e) {
            if (PagesFrame.CanGoBack) {
                BackButton.Visibility = Visibility.Visible;
            } else {
                BackButton.Visibility = Visibility.Hidden;
            }
        }

    }
}
