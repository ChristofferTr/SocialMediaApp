using Microsoft.Win32;
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
        User user;
        public UserWindow(User user)
        {
            InitializeComponent();
            DataContext = user;
            this.user = user;
            Title = $"{user.FirstName} {user.LastName}'s page";
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            MessageBox.Show("Du har loggat ut.");
            Close();
        }

        private void UploadProfilePicture_Click(object sender, RoutedEventArgs e)
        {
            // Use a FileOpenDialog to allow the user to select a profile picture
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                ProfilePicture.Source = new BitmapImage(new Uri(filePath));
                // TODO: Store the selected image in a member variable or save it to a file
            }
        }

       
        
        private void Post_Click(object sender, RoutedEventArgs e)
        {

            // Get the text from the textPosts TextBox
            // TODO: Store the text post in a member variable or save it to a file
            
        }

        //Buttons that do nothing yet - Implement new windows?

        private void HemBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Knappen " + btn.Content + " har ingen funkrion än!");
        }

        private void KöpSäljBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Knappen " + btn.Content + " har ingen funkrion än!");
        }

        private void VännerBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Knappen " + btn.Content + " har ingen funkrion än!");
        }

        private void AviseringarBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Knappen " + btn.Content + " har ingen funkrion än!");
        }

        private void InställningarBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Knappen " + btn.Content + " har ingen funkrion än!");
        }

        private void Feedpost_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            FeedWindow feedWindow= new FeedWindow();
            feedWindow.Show();
            Close();
        }



        //private void LoggaUtBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    MessageBox.Show("Knappen " + btn.Content + " har ingen funkrion än!");
        //} 
    }
}
