using Core;
using Core.Shared;
using CoreWin10.Code;
using ProjectDouaiWin8;
using ProjectDouaiWin8.Views;
//using ProjectNiceWIn8;
//using ProjectNiceWIn8.Views;
//using ProjectLyonWin8;
//using ProjectLyonWin8.Views;
using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace CoreWin8.Views
{
    public sealed partial class About : Page
    {

        public About()
        {
            this.InitializeComponent();
            SocialNetworks.Text = "E-mail: " + SharedInformation.EmailContact + "\nTwitter: " + SharedInformation.UsernameTwitter + "\nInstagram: " + SharedInformation.UsernameInstagram + "\nSkype: " + SharedInformation.UsernameSkype + "\nSnapchat: " + SharedInformation.UsernameSnapchat + "\nSite: " + SharedInformation.URLSite + "\nYoutube: " + SharedInformation.URLYoutube + "\nGitHub: " + SharedInformation.URLGitHub;
            txtThisAppVersion.Text = LocalizedStrings.Get("VersionCore", "Shared") + Core.Version.Core + "\n" + LocalizedStrings.Get("VersionApp", "Shared") + Information.W8Version;
            Ad.ApplicationId = Information.AdApplicationId;
            Ad.AdUnitId = Information.AdAdUnitId;
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
            var launched = Launcher.LaunchUriAsync(StoreURI.OpenRio);
        }
    }
}
