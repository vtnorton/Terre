using CoreWin10.Views;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace ProjectLyon
{
    public sealed partial class MasterPage : Page
    {
        private int Selected;
        private SolidColorBrush fillColor = new SolidColorBrush(Colors.Purple);
        private SolidColorBrush fillWhite = new SolidColorBrush(Colors.White);
        private SolidColorBrush fillTransparent = new SolidColorBrush(Colors.Transparent);
        private SolidColorBrush fillGray = new SolidColorBrush(ColorHelper.FromArgb(255, 46, 46, 46));
        public MasterPage()
        {
            this.InitializeComponent();
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = Colors.Purple;
            titleBar.InactiveBackgroundColor = Colors.Purple;
            titleBar.InactiveForegroundColor = Colors.Black;
            titleBar.ButtonInactiveForegroundColor = Colors.Black;
            titleBar.ButtonBackgroundColor = Colors.Purple;
            titleBar.ButtonInactiveBackgroundColor = Colors.Purple;
            FillColorHome();

            this.SizeChanged += (s, e) =>
            {
                var state = "VisualState000min";
                if (e.NewSize.Width > 641)
                    state = "VisualState641min";
                else if (e.NewSize.Width > 941)
                    state = "VisualState941min";
                VisualStateManager.GoToState(this, state, true);
            };
        }
        public Frame ContentFrame
        {
            get { return this.frameBody; }
        }
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MySliptView.IsPaneOpen = !MySliptView.IsPaneOpen;
        }
        private void xtnHome_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(MainPage));
            ResetAll();
            FillColorHome();
            Selected = 1;
        }
        private void btnBand_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(MainPage));
            ResetAll();
            FillColorBand();
            Selected = 2;
        }
        private void btnSettings_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(MainPage));
            ResetAll();
            FillColorSettings();
            Selected = 5;
        }

        private void btnHelp_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Help));
            ResetAll();
            FillColorHelp();
            Selected = 6;
        }

        private void btnAbout_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(About));
            ResetAll();
            FillColorAbout();
            Selected = 7;
        }

        private void ResetAll()
        {
            txtAbout.Foreground = fillWhite;
            txtHelp.Foreground = fillWhite;
            txtHome.Foreground = fillWhite;
            txtBand.Foreground = fillWhite;
            txtSettings.Foreground = fillWhite;
            btnHome.Foreground = fillWhite;
            btnAbout.Foreground = fillWhite;
            btnHelp.Foreground = fillWhite;
            btnMenu.Foreground = fillWhite;
            btnBand.Foreground = fillWhite;
            btnSettings.Foreground = fillWhite;
            gridAbout.Background = fillTransparent;
            gridHelp.Background = fillTransparent;
            gridHome.Background = fillTransparent;
            gridBand.Background = fillTransparent;
            gridSettings.Background = fillTransparent;
        }
        private void stpHome_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpHome.Background = fillGray;
            gridHome.Background = fillColor;
            btnHome.Foreground = fillWhite;
        }

        private void stpHome_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 1)
            {
                FillColorHome();
            }
            else
            {
                stpHome.Background = fillTransparent;
                gridHome.Background = fillTransparent;
            }
        }

        private void stpBand_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpBand.Background = fillGray;
            gridBand.Background = fillColor;
            btnBand.Foreground = fillWhite;
        }

        private void stpBand_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 2)
            {
                FillColorBand();
            }
            else
            {
                stpBand.Background = fillTransparent;
                gridBand.Background = fillTransparent;
            }
        }
        private void stpSetting_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpSetting.Background = fillGray;
            gridSettings.Background = fillColor;
            btnSettings.Foreground = fillWhite;
        }
        private void stpSetting_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 5)
            {
                FillColorSettings();
            }
            else
            {
                stpSetting.Background = fillTransparent;
                gridSettings.Background = fillTransparent;
            }
        }

        private void stpHelp_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpHelp.Background = fillGray;
            gridHelp.Background = fillColor;
            btnHelp.Foreground = fillWhite;
        }

        private void stpHelp_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 6)
            {
                FillColorHelp();
            }
            else
            {
                stpHelp.Background = fillTransparent;
                gridHelp.Background = fillTransparent;
            }
        }

        private void stpAbout_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpAbout.Background = fillGray;
            gridAbout.Background = fillColor;
            btnAbout.Foreground = fillWhite;
        }

        private void stpAbout_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 7)
            {
                FillColorAbout();
            }
            else
            {
                stpAbout.Background = fillTransparent;
                gridAbout.Background = fillTransparent;
            }
        }

        private void FillColorHome()
        {
            gridHome.Background = fillColor;
            txtHome.Foreground = fillColor;
            btnHome.Foreground = fillColor;
            btnHome.Background = fillTransparent;
            stpHome.Background = fillTransparent;
        }
        private void FillColorBand()
        {
            gridBand.Background = fillColor;
            txtBand.Foreground = fillColor;
            btnBand.Foreground = fillColor;
            btnBand.Background = fillTransparent;
            stpBand.Background = fillTransparent;
        }
        private void FillColorSettings()
        {
            gridSettings.Background = fillColor;
            txtSettings.Foreground = fillColor;
            btnSettings.Foreground = fillColor;
            btnSettings.Background = fillTransparent;
            stpSetting.Background = fillTransparent;
        }
        private void FillColorHelp()
        {
            gridHelp.Background = fillColor;
            txtHelp.Foreground = fillColor;
            btnHelp.Foreground = fillColor;
            btnHelp.Background = fillTransparent;
            stpHelp.Background = fillTransparent;
        }
        private void FillColorAbout()
        {
            gridAbout.Background = fillColor;
            txtAbout.Foreground = fillColor;
            btnAbout.Foreground = fillColor;
            btnAbout.Background = fillTransparent;
            stpAbout.Background = fillTransparent;
        }
    }
}
