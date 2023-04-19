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
using Microsoft.EntityFrameworkCore;
using SchoolJournalDesktop.Models;
using SchoolJournalDesktop.ViewModels;

namespace SchoolJournalDesktop.Forms
{
    /// <summary>
    /// Логика взаимодействия для DIrectorWindow.xaml
    /// </summary>
    public partial class DIrectorWindow : Window
    {
        public DIrectorWindow()
        {
            InitializeComponent();
            List<TeacherBadGradesMaxViewModel> outputList = new List<TeacherBadGradesMaxViewModel>();
            outputList = MyContext.GetContext().RegisterJournals
                .ToList()
                .Select(p => new TeacherBadGradesMaxViewModel
                {
                    FullName = p.TeacherCard?.FullName,
                    Position = p.TeacherCard?.NowPosition?.Position,
                    Category = p.TeacherCard?.NowPosition?.TeacherCategory?.Name,
                    Subject = p.Subject?.Name,
                    BadGradesCount = p.BadGradesCount
                }).ToList();
            dgTeachers.ItemsSource = outputList;
        }

        private void clAccept(object sender, RoutedEventArgs e)
        {
            DateTime? beginDate = dpBegin.SelectedDate;
            DateTime? endDate = dpEnd.SelectedDate;

            if (beginDate.HasValue)
            {
                dgTeachers.ItemsSource = MyContext.GetContext().RegisterJournals
                .ToList()
                .Select(p => new TeacherBadGradesMaxViewModel
                {
                    FullName = p.TeacherCard?.FullName,
                    Position = p.TeacherCard?.NowPosition?.Position,
                    Category = p.TeacherCard?.NowPosition?.TeacherCategory?.Name,
                    Subject = p.Subject?.Name,
                    BadGradesCount = p.DateJournalRecords
                    .Where(p => p.DateRecord >= beginDate.Value)
                    .Sum(p => p.BadGradesCount)
                }).OrderByDescending(p => p.BadGradesCount)
                .ToList();
            }
            else if (endDate.HasValue)
            {
                dgTeachers.ItemsSource = MyContext.GetContext().RegisterJournals
                .ToList()
                .Select(p => new TeacherBadGradesMaxViewModel
                {
                    FullName = p.TeacherCard?.FullName,
                    Position = p.TeacherCard?.NowPosition?.Position,
                    Category = p.TeacherCard?.NowPosition?.TeacherCategory?.Name,
                    Subject = p.Subject?.Name,
                    BadGradesCount = p.DateJournalRecords
                    .Where(p => p.DateRecord <= endDate.Value)
                    .Sum(p => p.BadGradesCount)
                }).OrderByDescending(p => p.BadGradesCount)
                .ToList();
            }
            else if (beginDate.HasValue && endDate.HasValue)
            {
                dgTeachers.ItemsSource = MyContext.GetContext().RegisterJournals
                    .ToList()
                        .Select(p => new TeacherBadGradesMaxViewModel
                        {
                            FullName = p.TeacherCard?.FullName,
                            Position = p.TeacherCard?.NowPosition?.Position,
                            Category = p.TeacherCard?.NowPosition?.TeacherCategory?.Name,
                            Subject = p.Subject?.Name,
                            BadGradesCount = p.DateJournalRecords
                                .Where(p => p.DateRecord <= endDate.Value && p.DateRecord >= beginDate.Value)
                                    .Sum(p => p.BadGradesCount)
                        }).OrderByDescending(p => p.BadGradesCount)
                    .ToList();
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одну временную шкалу/");
            }
        }

        private void clBreak(object sender, RoutedEventArgs e)
        {
            dpBegin.SelectedDate = null;
            dpEnd.SelectedDate = null;
            dgTeachers.ItemsSource = MyContext.GetContext().RegisterJournals
                    .ToList()
                    .Select(p => new TeacherBadGradesMaxViewModel
                    {
                        FullName = p.TeacherCard?.FullName,
                        Position = p.TeacherCard?.NowPosition?.Position,
                        Category = p.TeacherCard?.NowPosition?.TeacherCategory?.Name,
                        Subject = p.Subject?.Name,
                        BadGradesCount = p.BadGradesCount
                    }).OrderByDescending(p => p.BadGradesCount)
                    .ToList();
        }
    }
}
