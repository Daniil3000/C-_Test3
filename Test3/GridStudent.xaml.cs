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
    /// Interaction logic for GridStudent.xaml
    /// </summary>
    public partial class GridStudent : Window
    {
        public GridStudent()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();

            students.Add(new Student()
            {
                Id = 1,
                FirstName = "Student",
                LastName = "One",
                IsRegistered = true
            });
            students.Add(new Student()
            {
                Id = 2,
                FirstName = "Student",
                LastName = "Two",
                IsRegistered = false
            });
            students.Add(new Student()
            {
                Id = 3,
                FirstName = "Student",
                LastName = "Three",
                IsRegistered = true
            });

            dgStudent.ItemsSource = students;
        }
    }
}
