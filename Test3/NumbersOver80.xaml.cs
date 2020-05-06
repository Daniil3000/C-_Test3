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
    /// Interaction logic for NumbersOver80.xaml
    /// </summary>
    public partial class NumbersOver80 : Window
    {
        public NumbersOver80()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            List<int> numbers = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };

            showNumbersGreaterThan80(numbers);

            void showNumbersGreaterThan80(List<int> nums)
            {
                var result = from n in nums
                             where n > 80
                             select n;

                string resultString = "Numbers greater than 80 are: \n";
                foreach (var num in result)
                {
                    resultString += num.ToString() + "\n";
                }
                MessageBox.Show(resultString);
            }
        }
    }
}
