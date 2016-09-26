using Core;
using Core.Code;
using System;
using UniversalRateReminder;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

namespace ProjectDouai.alpha
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            var rootFrame = Window.Current.Content as MasterPage;
            if (rootFrame == null)
            {
                rootFrame = new MasterPage();
                rootFrame.ContentFrame.NavigationFailed += OnNavigationFailed;
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.ContentFrame.Content == null)
            {
                if (!rootFrame.ContentFrame.Navigate(typeof(MainPage)))
                    throw new Exception("Failed to create initial page");
            }
            Window.Current.Activate();

            RatePopup.LaunchLimit = RatePopupSettings.LaunchLimit;
            RatePopup.ResetCountOnNewVersion = RatePopupSettings.ResetCountOnNewVersion;
            RatePopup.RateButtonText = LocalizedStrings.Get("RatePopupRateButton", "Shared");
            RatePopup.CancelButtonText = LocalizedStrings.Get("RatePopupCancelButton", "Shared");
            RatePopup.Title = LocalizedStrings.Get("RatePopupTitle", "Shared");
            RatePopup.Content = LocalizedStrings.Get("RatePupupContent", "Shared");
            RatePopup.CheckRateReminderAsync();
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
