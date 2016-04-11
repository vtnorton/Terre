using CoreWin10.Code;
using CoreWin8.Views;
using ProjectDouai;
using ProjectDouaiWin8.Views;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectDouaiWin8
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ChangeExample();
        }
        private async void ChangeExample()
        {
            Exemplo.Text = AppCode.Exemplos();
            await Task.Delay(5000);
            ChangeExample();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConjulgarVerbo();
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
        private void ErroNaoVerbo()
        {
            MessageDialog dialogo = new MessageDialog(LocalizedStrings.Get("ErroNotAVerbDescription"), LocalizedStrings.Get("ErroNotAVerbTitle"));
            //await dialogo.ShowAsync();
        }
        private void ErroVerboIrregular()
        {
            MessageDialog dialogo = new MessageDialog(LocalizedStrings.Get("ErroNotRegularVerbDescription"), LocalizedStrings.Get("ErroNotRegularVerbTitle"));
            //await dialogo.ShowAsync();
        }
        private void ConjulgarVerbo()
        {
            AppCode code2 = new AppCode();
            string verboaenviar = Verbo.Text.ToLower().Trim();

            if (code2.EhVerboIrregular(verboaenviar))
                ErroVerboIrregular();
            else
            {
                if (code2.EhVerbo(verboaenviar))
                    Frame.Navigate(typeof(Conjulgado), verboaenviar);
                else
                    ErroNaoVerbo();
            }
        }
    }
}
