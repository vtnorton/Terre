using Core;
using Core.Shared;
using ProjectLyonWin8.Code;
using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ProjectLyonWin8.Views
{
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            SocialNetworks.Text = "E-mail: " + SharedInformation.EmailContact + "\nTwitter: " + SharedInformation.UsernameTwitter + "\nInstagram: " + SharedInformation.UsernameInstagram + "\nSkype: " + SharedInformation.UsernameSkype + "\nSnapchat: " + SharedInformation.UsernameSnapchat + "\nSite: " + SharedInformation.URLSite + "\nYoutube: " + SharedInformation.URLYoutube + "\nGitHub: " + SharedInformation.URLGitHub;
            txtThisAppVersion.Text = LocalizedStrings.Get("VersionCore", "Shared") + Core.Version.Core + "\n" + LocalizedStrings.Get("VersionApp", "Shared") + Core.Version.Win10Lyon;
            Ad.ApplicationId = Ads.Lyon[0];
            Ad.AdUnitId = Ads.Lyon[1];
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private void RateThisApp_Click(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
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
        private void Twitter_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri(SharedInformation.URLTwitter));
        }

        private void Site_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri(SharedInformation.URLSite));
        }

        private void Pasadena_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(StoreURI.OpenWP8Pasadena);
        }

        private void Nice_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(StoreURI.OpenWP8Nice);
        }

        private void Lyon_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(StoreURI.OpenWP8Lyon);
        }

        private void LasVegas_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(StoreURI.OpenWP8LasVegas);
        }

        private void Douai_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(StoreURI.OpenWP8Douai);
        }

        private void Rio_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(StoreURI.OpenWP8Rio);
        }
    }
}
