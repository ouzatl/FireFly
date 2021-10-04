using Microsoft.Win32;
using System;
using System.Windows;

namespace FireFly.UI
{
    public partial class VideoPlayer : Window
    {
        public VideoPlayer()
        {
            InitializeComponent();
        }

        private void PlayButton(object sender, RoutedEventArgs e)
        {
            if (MediaPathTextBox.Text.Length <= 0)

            {
                MessageBox.Show("Enter a valid media file");
                return;
            }

            mediaElement.Source = new Uri(MediaPathTextBox.Text);
            mediaElement.Play();
        }

        private void StopButton(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void PauseButton(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void BrowseButton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.InitialDirectory = @"c:\";
            openDlg.ShowDialog();
            MediaPathTextBox.Text = openDlg.FileName;
        }
    }
}