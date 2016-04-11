using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace ProjectRio
{
    public sealed partial class MasterPage : Page
    {
        private int Selected;
        private SplitView Temp;
        private SolidColorBrush fillColor = new SolidColorBrush(Colors.Firebrick);
        private SolidColorBrush fillWhite = new SolidColorBrush(Colors.White);
        private SolidColorBrush fillTransparent = new SolidColorBrush(Colors.Transparent);
        private SolidColorBrush fillGray = new SolidColorBrush(ColorHelper.FromArgb(255, 46, 46, 46));

        public MasterPage()
        {
            this.InitializeComponent();
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = Colors.Firebrick;
            titleBar.InactiveBackgroundColor = Colors.Firebrick;
            titleBar.InactiveForegroundColor = Colors.White;
            titleBar.ButtonInactiveForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = Colors.Firebrick;
            titleBar.ButtonInactiveBackgroundColor = Colors.Firebrick;
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

        private void btnAbout_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.About));
            ResetAll();
            FillColorAbout();
            Selected = 7;
        }

        private void ResetAll()
        {
            txtAbout.Foreground = fillWhite;
            txtHome.Foreground = fillWhite;
            btnHome.Foreground = fillWhite;
            btnAbout.Foreground = fillWhite;
            btnMenu.Foreground = fillWhite;
            gridAbout.Background = fillTransparent;
            gridHome.Background = fillTransparent;
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
