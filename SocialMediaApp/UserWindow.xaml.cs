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

namespace SocialMediaApp
{
    /// <summary>
    /// Interaction logic for PersonalizedWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        Window previousWindow;
        public UserWindow(User user, Window previousWindow)
        {
            InitializeComponent();
            DataContext = user;
            Title = $"{user.FirstName} {user.LastName}'s page";
            this.previousWindow = previousWindow;
        }

        private void UploadImageButton_Click(object sender, RoutedEventArgs e)
        {
            // Code for uploading image goes here
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            previousWindow.Show();
            Close();
        }
    }
}
