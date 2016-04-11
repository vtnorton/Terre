using Core;
using CoreWin10.Code;
using CoreWin8.Views;
using ProjectDouai;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ProjectDouaiWin8.Views
{
    public sealed partial class Conjulgado : Page
    {
        private string verbo;
        public Conjulgado()
        {
            this.InitializeComponent();
            Ad.ApplicationId = Ads.Douai[0];
            Ad.AdUnitId = Ads.Douai[1];
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            verbo = (string)e.Parameter;
            string Radical = verbo.Substring(0, verbo.Length - 2).ToLower();

            AppCode code = new AppCode();

            if (code.EhVerboIrregular(verbo))
            {
                Verbo VerboIrregurlar = code.VerboIrregular(verbo);
                Principal.Text = VerboIrregurlar.Principal;
                Presente.Text = VerboIrregurlar.Presente;
                PreteritoImperfeito.Text = VerboIrregurlar.PreteritoImperfeito;
                PreteritoPerfeito.Text = VerboIrregurlar.PreteritoPerfeito;
                PreteritoMaisQuePerfeito.Text = VerboIrregurlar.PreteritoMaisQuePerfeito;
                FuturoDoPresente.Text = VerboIrregurlar.FuturoDoPresente;
                FuturoDoPreterito.Text = VerboIrregurlar.FuturoDoPreterito;
                PresenteDoSubjuntivo.Text = VerboIrregurlar.PresenteDoSubjuntivo;
                PreteritoImperfeitoDoSubjuntivo.Text = VerboIrregurlar.PreteritoImperfeitoDoSubjuntivo;
                FuturoDoSubjuntivo.Text = VerboIrregurlar.FuturoDoSubjuntivo;
                Imperativo.Text = VerboIrregurlar.Imperativo;
            }
            else
            {
                if (verbo.EndsWith("ar"))
                {
                    Principal.Text = "infinitivo: " + verbo + "\ngerúndio: " + Radical + "ando\nparticípio: " + Radical + "ado";
                    Presente.Text = "eu " + Radical + "o \ntu " + Radical + "as \nele " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "ais \neles " + Radical + "am";
                    PreteritoImperfeito.Text = "eu " + Radical + "ava \ntu " + Radical + "avas \nele " + Radical + "ava \nnós " + Radical + "ávamos \nvós " + Radical + "áveis \neles " + Radical + "avam";
                    PreteritoPerfeito.Text = "eu " + Radical + "ei \ntu " + Radical + "aste \nele " + Radical + "ou \nnós " + Radical + "amos \nvós " + Radical + "astes \neles " + Radical + "aram";
                    PreteritoMaisQuePerfeito.Text = "eu " + Radical + "ara \ntu " + Radical + "aras \nele " + Radical + "ara \nnós " + Radical + "áramos \nvós " + Radical + "áreis \neles " + Radical + "aram";
                    FuturoDoPresente.Text = "eu " + Radical + "arei \ntu " + Radical + "arás \nele " + Radical + "ará \nnós " + Radical + "aremos \nvós " + Radical + "areis \neles " + Radical + "arão";
                    FuturoDoPreterito.Text = "eu " + Radical + "aria \ntu " + Radical + "arias \nele " + Radical + "aria \nnós " + Radical + "aríamos \nvós " + Radical + "aríeis \neles " + Radical + "ariam";
                    PresenteDoSubjuntivo.Text = "eu " + Radical + "e \ntu " + Radical + "es \nele " + Radical + "e \nnós " + Radical + "emos \nvós " + Radical + "eis \neles " + Radical + "em";
                    PreteritoImperfeitoDoSubjuntivo.Text = "eu " + Radical + "asse \ntu " + Radical + "assses \nele " + Radical + "asse \nnós " + Radical + "ássemos \nvós " + Radical + "ásseis \neles " + Radical + "assem";
                    FuturoDoSubjuntivo.Text = "eu " + Radical + "ar \ntu " + Radical + "ares \nele " + Radical + "ar \nnós " + Radical + "armos \nvós " + Radical + "ardes \neles " + Radical + "arem";
                    Imperativo.Text = "eu --- \ntu " + Radical + "a \nele " + Radical + "e \nnós " + Radical + "emos \nvós " + Radical + "ai \neles " + Radical + "em";
                }
                else if (verbo.EndsWith("er"))
                {
                    Principal.Text = "infinitivo: " + verbo + "\ngerúndio: " + Radical + "endo\nparticípio: " + Radical + "ito";
                    Presente.Text = "eu " + Radical + "o \ntu " + Radical + "es \nele " + Radical + "e \nnós " + Radical + "emos \nvós " + Radical + "eis \neles " + Radical + "em";
                    PreteritoImperfeito.Text = "eu " + Radical + "ia \ntu " + Radical + "ias \nele " + Radical + "ia \nnós " + Radical + "iamos \nvós " + Radical + "ieis \neles " + Radical + "iam";
                    PreteritoPerfeito.Text = "eu " + Radical + "i \ntu " + Radical + "este \nele " + Radical + "eu \nnós " + Radical + "emos \nvós " + Radical + "estes \neles " + Radical + "eram";
                    PreteritoMaisQuePerfeito.Text = "eu " + Radical + "era \ntu " + Radical + "eras \nele " + Radical + "era \nnós " + Radical + "êramos \nvós " + Radical + "êreis \neles " + Radical + "eram";
                    FuturoDoPresente.Text = "eu " + Radical + "erei \ntu " + Radical + "erás \nele " + Radical + "erá \nnós " + Radical + "eremos \nvós " + Radical + "ereis \neles " + Radical + "erão";
                    FuturoDoPreterito.Text = "eu " + Radical + "eria \ntu " + Radical + "erias \nele " + Radical + "eria \nnós " + Radical + "eríamos \nvós " + Radical + "eríeis \neles " + Radical + "eriam";
                    PresenteDoSubjuntivo.Text = "eu " + Radical + "a \ntu " + Radical + "as \nele " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "ais \neles " + Radical + "am";
                    PreteritoImperfeitoDoSubjuntivo.Text = "eu " + Radical + "esse \ntu " + Radical + "essses \nele " + Radical + "esse \nnós " + Radical + "êssemos \nvós " + Radical + "êsseis \neles " + Radical + "essem";
                    FuturoDoSubjuntivo.Text = "eu " + Radical + "er \ntu " + Radical + "eres \nele " + Radical + "er \nnós " + Radical + "ermos \nvós " + Radical + "erdes \neles " + Radical + "erem";
                    Imperativo.Text = "eu --- \ntu " + Radical + "e \nele " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "ei \neles " + Radical + "am";
                }
                else if (verbo.EndsWith("ir"))
                {
                    Principal.Text = "infinitivo: " + verbo + "\ngerúndio: " + Radical + "indo\nparticípio: " + Radical + "ido";
                    Presente.Text = "eu " + Radical + "o \ntu " + Radical + "es \nele " + Radical + "e \nnós " + Radical + "imos \nvós " + Radical + "is \neles " + Radical + "em";
                    PreteritoImperfeito.Text = "eu " + Radical + "ia \ntu " + Radical + "ias \nele " + Radical + "ia \nnós " + Radical + "iamos \nvós " + Radical + "ieis \neles " + Radical + "iam";
                    PreteritoPerfeito.Text = "eu " + Radical + "i \ntu " + Radical + "iste \nele " + Radical + "iu \nnós " + Radical + "imos \nvós " + Radical + "istes \neles " + Radical + "iram";
                    PreteritoMaisQuePerfeito.Text = "eu " + Radical + "ira \ntu " + Radical + "iras \nele " + Radical + "ira \nnós " + Radical + "íramos \nvós " + Radical + "íreis \neles " + Radical + "iram";
                    FuturoDoPresente.Text = "eu " + Radical + "irei \ntu " + Radical + "irás \nele " + Radical + "irá \nnós " + Radical + "iremos \nvós " + Radical + "ireis \neles " + Radical + "irão";
                    FuturoDoPreterito.Text = "eu " + Radical + "iria \ntu " + Radical + "irias \nele " + Radical + "iria \nnós " + Radical + "iríamos \nvós " + Radical + "iríeis \neles " + Radical + "iriam";
                    PresenteDoSubjuntivo.Text = "eu " + Radical + "a \ntu " + Radical + "as \nele " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "ais \neles " + Radical + "am";
                    PreteritoImperfeitoDoSubjuntivo.Text = "eu " + Radical + "isse \ntu " + Radical + "issses \nele " + Radical + "isse \nnós " + Radical + "íssemos \nvós " + Radical + "ísseis \neles " + Radical + "issem";
                    FuturoDoSubjuntivo.Text = "eu " + Radical + "ir \ntu " + Radical + "ires \nele " + Radical + "ir \nnós " + Radical + "irmos \nvós " + Radical + "irdes \neles " + Radical + "irem";
                    Imperativo.Text = "eu --- \ntu " + Radical + "e \nele " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "i \neles " + Radical + "am";
                }
                else
                {
                    //or
                    Principal.Text = "infinitivo: " + verbo + "\ngerúndio: " + Radical + "ando\nparticípio: " + Radical + "ado";
                    Presente.Text = "eu " + Radical + "o \ntu " + Radical + "as \nele " + Radical + "a \nnós " + Radical + "amos \nvós " + Radical + "ais \neles " + Radical + "am";
                    PreteritoImperfeito.Text = "eu " + Radical + "ava \ntu " + Radical + "avas \nele " + Radical + "ava \nnós " + Radical + "ávamos \nvós " + Radical + "áveis \neles " + Radical + "avam";
                    PreteritoPerfeito.Text = "eu " + Radical + "ei \ntu " + Radical + "aste \nele " + Radical + "ou \nnós " + Radical + "amos \nvós " + Radical + "astes \neles " + Radical + "aram";
                    PreteritoMaisQuePerfeito.Text = "eu " + Radical + "ara \ntu " + Radical + "aras \nele " + Radical + "ara \nnós " + Radical + "áramos \nvós " + Radical + "áreis \neles " + Radical + "aram";
                    FuturoDoPresente.Text = "eu " + Radical + "arei \ntu " + Radical + "arás \nele " + Radical + "ará \nnós " + Radical + "aremos \nvós " + Radical + "areis \neles " + Radical + "arão";
                    FuturoDoPreterito.Text = "eu " + Radical + "aria \ntu " + Radical + "arias \nele " + Radical + "aria \nnós " + Radical + "aríamos \nvós " + Radical + "aríeis \neles " + Radical + "ariam";
                    PresenteDoSubjuntivo.Text = "eu " + Radical + "e \ntu " + Radical + "es \nele " + Radical + "e \nnós " + Radical + "emos \nvós " + Radical + "eis \neles " + Radical + "em";
                    PreteritoImperfeitoDoSubjuntivo.Text = "eu " + Radical + "asse \ntu " + Radical + "assses \nele " + Radical + "asse \nnós " + Radical + "ássemos \nvós " + Radical + "ásseis \neles " + Radical + "assem";
                    FuturoDoSubjuntivo.Text = "eu " + Radical + "ar \ntu " + Radical + "ares \nele " + Radical + "ar \nnós " + Radical + "armos \nvós " + Radical + "ardes \neles " + Radical + "arem";
                    Imperativo.Text = "eu --- \ntu " + Radical + "a \nele " + Radical + "e \nnós " + Radical + "emos \nvós " + Radical + "ai \neles " + Radical + "em";

                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConjulgarVerbo();
        }
        private void ErroVerboIrregular()
        {
            MessageDialog dialogo = new MessageDialog(LocalizedStrings.Get("ErroNotRegularVerbDescription"), LocalizedStrings.Get("ErroNotRegularVerbTitle"));
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
                    Frame.Navigate(typeof(Views.Conjulgado), verboaenviar);
                else
                    ErroNaoVerbo();
            }
        }
        private void ErroNaoVerbo()
        {
            MessageDialog dialogo = new MessageDialog(LocalizedStrings.Get("ErroNotAVerbDescription"), LocalizedStrings.Get("ErroNotAVerbTitle"));
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
