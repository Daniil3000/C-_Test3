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
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
            
        }

        List<Student> students = new List<Student>();

        private void btnSaveStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student()
            {
                Id = Int32.Parse(txtId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLarstName.Text,
                IsRegistered = cbIsRegistered.IsChecked ?? false
            };
            
            students.Add(student);
            MessageBox.Show(students.Count().ToString());
        }

        
    }
}
