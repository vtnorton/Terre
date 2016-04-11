using Core;
using UniversalRateReminder;

namespace ProjectLasVegas.Code
{
    public class RateApp
    {
        public static void RateThisApp()
        {
            RatePopup.LaunchLimit = RatePopupSettings.LaunchLimit;
            RatePopup.ResetCountOnNewVersion = RatePopupSettings.ResetCountOnNewVersion;
            RatePopup.RateButtonText = LocalizedStrings.Get("RatePopupRateButton", "Shared");
            RatePopup.CancelButtonText = LocalizedStrings.Get("RatePopupCancelButton", "Shared");
            RatePopup.Title = LocalizedStrings.Get("RatePopupTitle", "Shared");
            RatePopup.Content = LocalizedStrings.Get("RatePupupContent", "Shared");
            RatePopup.ResetLaunchCount();
            RatePopup.CheckRateReminderAsync();
        }
    }
}
