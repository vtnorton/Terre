using Core;
using Core.Methods;
using CoreWin10.Code;
using CoreWin8.Views;
using ProjectNiceWIn8.Views;
using System;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace ProjectNiceWIn8
{
    public sealed partial class MainPage : Page
    {
        int TimesSortedNumbers = 0;
        bool IsComma = false;
        Random randomNum = new Random();
        SolidColorBrush White = new SolidColorBrush(Colors.White);
        public MainPage()
        {
            this.InitializeComponent();
            txtClean.Visibility = Visibility.Collapsed;
            bgDark.Background = ColorBrush.ColorToBrushClara(randomNum.Next(1, CoreInformation.Colors));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string xSorted;
            double MinValue = 0, MaxValue = 101;

            if (Min.Text.Contains(",") || Max.Text.Contains(","))
                IsComma = true;

            if (Min.Text != "")
            {
                if (Min.Text.Replace(",", ".").IndexOf(".") == Min.Text.Replace(",", ".").LastIndexOf("."))
                    MinValue = double.Parse(Min.Text.Replace(",", "."));
                else
                    InvalidFormat();
            }

            if (Max.Text != "")
            {
                if (Max.Text.Replace(",", ".").IndexOf(".") == Max.Text.Replace(",", ".").LastIndexOf("."))
                    MaxValue = double.Parse(Max.Text.Replace(",", "."));
                else
                    InvalidFormat();
            }

            if (MinValue > MaxValue)
                ErroMin();
            else if (MinValue == MaxValue)
                IgualValue();
            else
            {
                xSorted = randomNum.NextDouble(MinValue, MaxValue, rptDecimalNumbers.IsOn, true, txtSortedNumbers.Text).ToString();

                if (IsComma == true)
                    xSorted.Replace(".", ",");

                TelaNumeroSorteado.Text = xSorted;
                if (TimesSortedNumbers == 0)
                    txtSortedNumbers.Text = xSorted;
                else
                    txtSortedNumbers.Text += " - " + xSorted;

                TimesSortedNumbers++;
                txtClean.Visibility = Visibility.Visible;
                bgDark.Background = ColorBrush.ColorToBrushClara(randomNum.Next(1, CoreInformation.Colors));
            }
        }
        private async void ErroMin()
        {
            await new MessageDialog(LocalizedStrings.Get("ErroMinDescription"), LocalizedStrings.Get("ErroMinTitle")).ShowAsync();
        }
        private async void IgualValue()
        {
            await new MessageDialog(LocalizedStrings.Get("ErroIgualValueDescription"), LocalizedStrings.Get("ErroIgualValueTitle")).ShowAsync();
        }
        private async void InvalidFormat()
        {
            await new MessageDialog(LocalizedStrings.Get("ErroFormatExeptionDescription"), LocalizedStrings.Get("ErroFormatExeptionTitle")).ShowAsync();
        }
        private void txtClean_Click(object sender, RoutedEventArgs e)
        {
            txtSortedNumbers.Text = "";
            txtClean.Visibility = Visibility.Collapsed;
            TimesSortedNumbers = 0;
            txtClean.Opacity = 0.9;
        }
        private void Min_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Min.Text.Contains(".") || Min.Text.Contains(",") || Max.Text.Contains(".") || Max.Text.Contains(","))
                rptDecimalNumbers.IsOn = true;
            else
                rptDecimalNumbers.IsOn = false;
        }
        private void txtSettings_Click(object sender, RoutedEventArgs e)
        {
            if (bgDark.RowDefinitions[1].Height != new GridLength(150))
            {
                txtSortedNumbers.Visibility = Visibility.Collapsed;
                bgDark.RowDefinitions[1].Height = new GridLength(150);
                gridResults.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
                gridResults.RowDefinitions[2].Height = new GridLength(1, GridUnitType.Star);
                gridResults.RowDefinitions[4].Height = new GridLength(20);
            }
            else
            {
                txtSortedNumbers.Visibility = Visibility.Visible;
                bgDark.RowDefinitions[1].Height = new GridLength(0);
                gridResults.RowDefinitions[0].Height = new GridLength(4, GridUnitType.Star);
                gridResults.RowDefinitions[2].Height = new GridLength(1, GridUnitType.Star);
                gridResults.RowDefinitions[4].Height = new GridLength(60);
            }
        }
        private void txtSort_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            txtSort.Background = White;
            txtSort.Background.Opacity = 0.4;
        }
        private void txtSort_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            txtSort.Background = new SolidColorBrush(Colors.Transparent);
        }
        private void txtClean_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            txtClean.Background = White;
            txtClean.Background.Opacity = 0.4;
        }

        private void txtClean_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            txtClean.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void txtSettings_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            txtSettings.Background = White;
            txtSettings.Background.Opacity = 0.4;
        }

        private void txtSettings_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            txtSettings.Background = new SolidColorBrush(Colors.Transparent);
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
