using Windows.ApplicationModel.Resources;

namespace ProjectNice.Code
{
    public class LocalizedStrings
    {
        public static string Get(string key)
        {
            return ResourceLoader.GetForCurrentView().GetString(key);
        }
        public static string Get(string key, string loader)
        {
            return ResourceLoader.GetForCurrentView(loader).GetString(key);
        }
    }
}
