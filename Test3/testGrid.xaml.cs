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
using System.Windows.Shapes;

namespace Test3
{
    /// <summary>
    /// Interaction logic for testGrid.xaml
    /// </summary>
    public partial class testGrid : Window
    {
        public testGrid()
        {
            InitializeComponent();

            List<Student> students = new List<Student>();

            Student std1 = new Student()
            {
                Id = 1,
                FirstName = "Student",
                LastName = "One",
                IsRegistered = true
            };
            Student std2 = new Student()
            {
                Id = 2,
                FirstName = "Student",
                LastName = "Two",
                IsRegistered = true
            };
            Student std3 = new Student()
            {
                Id = 3,
                FirstName = "Student",
                LastName = "Three",
                IsRegistered = true
            };

            students.Add(std1);
            students.Add(std2);
            students.Add(std3);

            myDatagrid.ItemsSource = students;
        }
    }
}
