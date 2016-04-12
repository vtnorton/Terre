using Core.Shared;
using CoreWin10.Code;
using CoreWin8.Views;
using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectLyonWin8.Views
{
    public sealed partial class Help : Page
    {
        public Help()
        {
            this.InitializeComponent();
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Help));
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            Main.ScrollToSection(Page1);
        }

        private void Page4_Click(object sender, RoutedEventArgs e)
        {
            Main.ScrollToSection(Page4);
        }

        private void Page5_Click(object sender, RoutedEventArgs e)
        {
            Main.ScrollToSection(Page5);
        }

        private void Page6_Click(object sender, RoutedEventArgs e)
        {
            Main.ScrollToSection(Page6);
        }
        private void SendFeedback_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri("mailto:" + SharedInformation.EmailFeedback));
        }

        private void RateIt_Click(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
        }

        private void GoToSite_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri(SharedInformation.URLSite));
        }
    }
}
