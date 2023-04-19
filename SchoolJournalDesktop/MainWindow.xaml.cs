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
using Microsoft.EntityFrameworkCore;
using SchoolJournalDesktop.Models;

namespace SchoolJournalDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void clSign(object sender, RoutedEventArgs e)
        {
            User? currentUser;
            if(rbDirector.IsChecked == true)
            {
                currentUser = await MyContext.GetContext().Users
                    .FirstOrDefaultAsync(p => p.Login == tbLogin.Text && p.Password == tbPassword.Password && p.IdRole == 1);
                MessageBox.Show("Welcome/");
                new Forms.DIrectorWindow().Show();
                Close();
            }
            else if(rbZav.IsChecked == true) {
                currentUser = await MyContext.GetContext().Users
                    .FirstOrDefaultAsync(p => p.Login == tbLogin.Text && p.Password == tbPassword.Password && p.IdRole == 2);
                MessageBox.Show("Welcome/");
                new Forms.ZavWindow().Show();
                Close();
            }
            else
            {
                MessageBox.Show("Your login or(and) password not correct/");
            }
        }

        private void clExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
