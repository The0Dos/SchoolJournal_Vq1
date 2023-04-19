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
using SchoolJournalDesktop.Models;

namespace SchoolJournalDesktop.Forms
{
    /// <summary>
    /// Логика взаимодействия для ZavWindow.xaml
    /// </summary>
    public partial class ZavWindow : Window
    {
        public ZavWindow()
        {
            InitializeComponent();
            cbClass.ItemsSource = MyContext.GetContext().StudingClasses.ToList();
            cbPoluYear.ItemsSource = new string[] { "1 полугодие", "2 полугодие" };
            cbYear.ItemsSource = MyContext.GetContext().AcademicYears.ToList();
            dgStudents.ItemsSource = MyContext.GetContext().Students.ToList();
        }

        private void clAccept(object sender, RoutedEventArgs e)
        {
            if (cbClass.SelectedItem == null
                || cbPoluYear.SelectedItem == null
                || cbYear.SelectedItem == null)
            {
                MessageBox.Show("Проверьте все поля на заполненность и повторите попытку.");
            }
            else
            {
                try
                {
                    dgStudents.ItemsSource = MyContext.GetContext().Students.Where(p => p.Grades.Any(s => s.DateJournalRecord.RegisterJournal.AcademicYear == cbYear.SelectedItem as AcademicYear));
                    tbAvg.Text = "Средняя успеваемость: " + MyContext.GetContext().Grades.Where(p => p.DateJournalRecord.RegisterJournal.AcademicYear == cbYear.SelectedItem as AcademicYear).Average(p => p.GradeNum);
                }
                catch
                {
                    MessageBox.Show("Увы");
                }
            }
        }

        private void clBreak(object sender, RoutedEventArgs e)
        {
            cbClass.SelectedIndex = -1;
            cbPoluYear.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            tbAvg.Text = "Средняя успеваемость:";
            dgStudents.ItemsSource = MyContext.GetContext().Students.ToList();
        }
    }
}
