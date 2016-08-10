using Core;
using Core.Code;
using ProjectPasadena.Code;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectPasadena
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MudarCor();
            Ad.ApplicationId = Ads.Pasadena[0];
            Ad.AdUnitId = Ads.Pasadena[1];
        }
        private void Sortear_Click(object sender, RoutedEventArgs e)
        {
            Sortear.Text = AppCode.SortNeverEver();
            MudarCor();
        }
        private void MudarCor()
        {
            Random number = new Random();
            int Num = number.Next(1, CoreInformation.Colors); //Editar número de cores no Core
            Mensagem.Background = ColorBrush.ColorToBrush(Num);
            BotaoEuNunca.Background = ColorBrush.ColorToBrush(Num);
            xBotao.Background = ColorBrush.ColorToBrushClara(Num);
        }
       
    }
}
