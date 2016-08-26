using Core;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjectLasVegas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        AppCode code = new AppCode();
        public MainPage()
        {
            this.InitializeComponent();
            Ad.ApplicationId = Ads.LasVegas[0];
            Ad.AdUnitId = Ads.LasVegas[1];
        }
        private async void TrueOrDareQuestion(int garrafa)
        {
            MessageDialog msgbox = new MessageDialog('Então, Verdade ou consequência?', '#VerdadeOuConsequência');

            msgbox.Commands.Clear();
            msgbox.Commands.Add(new UICommand { Label = 'Verdade', Id = 0 });
            msgbox.Commands.Add(new UICommand { Label = 'Consequência', Id = 1 });

            var res = await msgbox.ShowAsync();

            if ((int)res.Id == 0)
            {
                MessageDialog dialogo = new MessageDialog(code.SortTruth(garrafa), 'Verdade');
                await dialogo.ShowAsync();
            }

            if ((int)res.Id == 1)
            {
                MessageDialog dialogo = new MessageDialog(code.SortDare(garrafa), 'Consequência');
                await dialogo.ShowAsync();
            }

        }

        private async void thebestsbottle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            spinthebests.Resume();
            spinthebests.Stop();
            spinthebests.Begin();
            Random rad = new Random();
            await Task.Delay(rad.Next(1500, 4500));
            spinthebests.Pause();
            await Task.Delay(1500);
            TrueOrDareQuestion(8);
        }

        private async void squarebottle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            spinsquare.Resume();
            spinsquare.Stop();
            spinsquare.Begin();
            Random rad = new Random();
            await Task.Delay(rad.Next(1500, 4500));
            spinsquare.Pause();
            await Task.Delay(1500);
            TrueOrDareQuestion(7);
        }

        private async void friendsbottle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            spinfriends.Resume();
            spinfriends.Stop();
            spinfriends.Begin();
            Random rad = new Random();
            await Task.Delay(rad.Next(1500, 4500));
            spinfriends.Pause();
            await Task.Delay(1500);
            TrueOrDareQuestion(6);
        }

        private async void familybottle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            spinfamily.Resume();
            spinfamily.Stop();
            spinfamily.Begin();
            Random rad = new Random();
            await Task.Delay(rad.Next(1500, 4500));
            spinfamily.Pause();
            await Task.Delay(1500);
            TrueOrDareQuestion(5);
        }

        private async void drunksbottle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            spindrunks.Resume();
            spindrunks.Stop();
            spindrunks.Begin();
            Random rad = new Random();
            await Task.Delay(rad.Next(1500, 4500));
            spindrunks.Pause();
            await Task.Delay(1500);
            TrueOrDareQuestion(4);
        }

        private async void couplebottle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            spincouple.Resume();
            spincouple.Stop();
            spincouple.Begin();
            Random rad = new Random();
            await Task.Delay(rad.Next(1500, 4500));
            spincouple.Pause();
            await Task.Delay(1500);
            TrueOrDareQuestion(3);
        }

        private async void atclassbottle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            spinatclass.Resume();
            spinatclass.Stop();
            spinatclass.Begin();
            Random rad = new Random();
            await Task.Delay(rad.Next(1500, 4500));
            spinatclass.Pause();
            await Task.Delay(1500);
            TrueOrDareQuestion(2);
        }

        private async void alonebottle_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            spinalone.Resume();
            spinalone.Stop();
            spinalone.Begin();
            Random rad = new Random();
            await Task.Delay(rad.Next(1500, 4500));
            spinalone.Pause();
            await Task.Delay(1500);
            TrueOrDareQuestion(1);
        }
    }
}