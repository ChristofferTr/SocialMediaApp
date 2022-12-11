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
    /// Interaction logic for FeedPost.xaml
    /// </summary>
    public partial class FeedPost : Window
    {

        private readonly List<User> users;

        public FeedPost()
        {
            this.users = LocalUsersStorage.GetUsers();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string PostText = PostTextBox.Text;

            if (string.IsNullOrEmpty(PostText))
            {
                MessageBox.Show("Please enter what you are doing.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)| All Files (*.*)|*.*";
            openFileDialog.FilterIndex= 1;

            if (openFileDialog.ShowDialog() == true)
            {
                string textPath = openFileDialog.FileName;
                TextFile.Source = new BitmapCache(new Uri(textPath));
            }*/

            FeedPost postWindow = new FeedPost();
            postWindow.Show();
            Close();
        }

        

       
    }
}
