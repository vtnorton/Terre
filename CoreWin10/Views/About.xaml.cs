using Core;
using Core.Shared;
using CoreWin10.Code;
//using ProjectLasVegas;
//using ProjectPasadena;
using ProjectDouai;
//using ProjectLyon;
//using ProjectNice;
//using ProjectRio;
using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CoreWin10.Views
{
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            txtThisAppVersion.Text = LocalizedStrings.Get("VersionCore", "Shared") + Core.Version.Core + "\n" + LocalizedStrings.Get("VersionApp", "Shared") + Information.W10Version;
            SocialNetworks.Text = "E-mail: " + SharedInformation.EmailContact + "\nTwitter: " + SharedInformation.UsernameTwitter + "\nInstagram: " + SharedInformation.UsernameInstagram + "\nSkype: " + SharedInformation.UsernameSkype + "\nSnapchat: " + SharedInformation.UsernameSnapchat + "\nSite: " + SharedInformation.URLSite + "\nYoutube: " + SharedInformation.URLYoutube + "\nGitHub: " + SharedInformation.URLGitHub;
            LasVegas.NavigateUri = StoreURI.OpenLasVegas;
            Nice.NavigateUri = StoreURI.OpenNice;
            Douai.NavigateUri = StoreURI.OpenDouai;
            Pasadena.NavigateUri = StoreURI.OpenPasadena;
            Rio.NavigateUri = StoreURI.OpenRio;
            Site.NavigateUri = new Uri(@SharedInformation.URLSite);
            Twitter.NavigateUri = new Uri(@SharedInformation.URLTwitter);
            Ad.ApplicationId = Information.AdApplicationId;
            Ad.AdUnitId = Information.AdAdUnitId;
        }
        private void RateThisApp_Click(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            var launched = Launcher.LaunchUriAsync(new Uri(SharedInformation.URLYapp));
        }
    }
}
