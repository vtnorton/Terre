using Core;
using CoreWin10.Code;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjectDouai
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Verbo.PlaceholderText = LocalizedStrings.Get("TextboxField");
            ChangeExample();
            Ad.ApplicationId = Ads.Douai[0];
            Ad.AdUnitId = Ads.Douai[1];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConjulgarVerbo();
        }

        private async void ErroNaoVerbo()
        {
            MessageDialog dialogo = new MessageDialog(LocalizedStrings.Get("ErroNotAVerbDescription"), LocalizedStrings.Get("ErroNotAVerbTitle"));
            await dialogo.ShowAsync();
        }
        private async void ErroVerboIrregular()
        {
            MessageDialog dialogo = new MessageDialog(LocalizedStrings.Get("ErroNotRegularVerbDescription"), LocalizedStrings.Get("ErroNotRegularVerbTitle"));
            await dialogo.ShowAsync();
        }
        private async void ChangeExample()
        {
            Exemplo.Text = AppCode.Exemplos();
            await Task.Delay(5000);
            ChangeExample();
        }

        private void Verbo_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            //if (e.Key == Key.Enter)
            //{
            //    ConjulgarVerbo();
            //}
        }
        private void ConjulgarVerbo()
        {
            AppCode code2 = new AppCode();
            string verboaenviar = Verbo.Text.ToLower().Trim();

            if (code2.EhVerboIrregular(verboaenviar) && !code2.EhVerboIrregularSuportado(verboaenviar))
                ErroVerboIrregular();
            else
            {
                if (code2.EhVerbo(verboaenviar))
                    Frame.Navigate(typeof(Views.Conjulgado), verboaenviar);
                else
                    ErroNaoVerbo();
            }
        }
    }
}
