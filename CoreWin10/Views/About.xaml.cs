using Core;
using Core.Code;
using Core.Shared;
using System;
using Windows.System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace CoreWin10.Views
{
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            txtThisAppVersion.Text = LocalizedStrings.Get("VersionCore", "Shared") + Core.Version.Core + "\n" + LocalizedStrings.Get("VersionApp", "Shared") + Information.W10Version;
            SocialNetworks.Text = "E-mail: " + SharedInformation.EmailContact + "\nTwitter: " + SharedInformation.UsernameTwitter + "\nInstagram: " + SharedInformation.UsernameInstagram + "\nSkype: " + SharedInformation.UsernameSkype + "\nSnapchat: " + SharedInformation.UsernameSnapchat + "\nSite: " + SharedInformation.URLSite + "\nYoutube: " + SharedInformation.URLYoutube + "\nGitHub: " + SharedInformation.URLGitHub;
            Nice.NavigateUri = StoreURI.OpenNice;
            Douai.NavigateUri = StoreURI.OpenDouai;
            Rio.NavigateUri = StoreURI.OpenRio;
            Quebec.NavigateUri = StoreURI.OpenQuebec;
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
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            lblMenssage.Foreground = new SolidColorBrush(Colors.Red);
            if (txtSubject.Text == null || txtSubject.Text == "")
            {
                lblMenssage.Text = "Please, write a subject";
                counter++;
            }
            else
            {
                if (txtMenssage.Text == null || txtMenssage.Text == "")
                {
                    lblMenssage.Text = "Please, write your menssage.";
                    counter++;
                }
                else
                {
                    if (txtEmail.Text == null || txtEmail.Text == "")
                    {
                        if (counter < 2)
                            lblMenssage.Text = "Please you have to write you e-mail, we are not going to spam you!";
                        else
                            lblMenssage.Text = "Come on! You haven't writed the subject, the menssage and now you want to send it without the e-mail adress? Oh hell no! Please type your e-mail adress";
                    }
                    else
                    {
                        try
                        {
                            //ProjectNice.SendFeedbackMenssageService.FeedbackSoapClient sendFeedback = new ProjectNice.SendFeedbackMenssageService.FeedbackSoapClient();
                            //sendFeedback.SendFeedbackEmailAsync(Information.ProjectName, txtMenssage.Text, txtEmail.Text, txtSubject.Text);
                            lblMenssage.Foreground = new SolidColorBrush(Colors.White);
                            lblMenssage.Text = "Feedback sent with success! ;) Thanks a lot!";
                            txtEmail.Text = "";
                            txtMenssage.Text = "";
                            txtSubject.Text = "";
                        }
                        catch
                        {
                            lblMenssage.Text = "There was an erro sending your menssage.";
                        }
                    }
                }
            }
        }
    }
}
