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

namespace SchoolApp.Pages {
    /// <summary>
    /// Interaction logic for TeachersAddEditPage.xaml
    /// </summary>
    public partial class TeachersAddEditPage : Page {

        private Teacher _selectedTeacher = new Teacher();

        public TeachersAddEditPage(Teacher selectedTeacher) {
            InitializeComponent();

            if (selectedTeacher != null) {
                _selectedTeacher = selectedTeacher;
            }

            DataContext = _selectedTeacher;
            // ! ComboHere
        }
    }
}
