using Core;
using Core.Shared;
using ProjectLasVegas.Code;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectLasVegas.Views
{
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            txtThisAppVersion.Text = LocalizedStrings.Get("VersionCore", "Shared") + Core.Version.Core + "\n" + LocalizedStrings.Get("VersionApp", "Shared") + Core.Version.Win10LasVegas;
            SocialNetworks.Text = "E-mail: " + SharedInformation.EmailContact + "\nTwitter: " + SharedInformation.UsernameTwitter + "\nInstagram: " + SharedInformation.UsernameInstagram + "\nSkype: " + SharedInformation.UsernameSkype + "\nSnapchat: " + SharedInformation.UsernameSnapchat + "\nSite: " + SharedInformation.URLSite + "\nYoutube: " + SharedInformation.URLYoutube + "\nGitHub: " + SharedInformation.URLGitHub;
            LasVegas.NavigateUri = StoreURI.OpenLasVegas;
            Nice.NavigateUri = StoreURI.OpenNice;
            Douai.NavigateUri = StoreURI.OpenDouai;
            Pasadena.NavigateUri = StoreURI.OpenPasadena;
            Rio.NavigateUri = StoreURI.OpenRio;
            Site.NavigateUri = new Uri(@SharedInformation.URLSite);
            Twitter.NavigateUri = new Uri(@SharedInformation.URLTwitter);
            Ad.ApplicationId = Ads.LasVegas[0];
            Ad.AdUnitId = Ads.LasVegas[1];
        }
        private void RateThisApp_Click(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
        }
    }
}
