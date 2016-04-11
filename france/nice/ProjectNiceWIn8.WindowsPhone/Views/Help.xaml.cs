using Core.Shared;
using ProjectNiceWIn8.Code;
using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ProjectNiceWIn8.Views
{
    public sealed partial class Help : Page
    {
        public Help()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page1;
        }
        private void Page4_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page4;
        }

        private void Page5_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page5;
        }

        private void Page6_Click(object sender, RoutedEventArgs e)
        {
            Main.SelectedItem = Page6;
        }
        private void SendFeedback_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri("mailto:feedback@vtnorton.com"));
        }

        private void RateIt_Click(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
        }

        private void GoToSite_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri(SharedInformation.URLSite));
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
    }
}
