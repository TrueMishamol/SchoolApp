using SchoolApp.Scripts;
using System.Windows;
using System.Windows.Controls;

namespace SchoolApp.Pages {
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page {
        public MenuPage() {
            InitializeComponent();
        }

        private void ClassesButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new ClassesPage());
        }

        private void AttendanceButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new AttendancePage());
        }

        private void GradesButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new GradesPage());
        }

        private void LessonsButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new LessonsPage());
        }

        private void LessonsAddEditButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new LessonsAddEditPage());
        }

        private void StudentsButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new StudentsPage());
        }

        private void StudentsAddEditButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new StudentsAddEditPage());
        }

        private void TeachersButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new TeachersPage());
        }

        private void TeachersAddEditButton_Click(object sender, RoutedEventArgs e) {
            SwitchMainFrame.MainFrame.Navigate(new TeachersAddEditPage());
        }
    }
}
