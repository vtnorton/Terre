namespace Core
{
    public class Version
    {
        public static string Core = "1.2." + CoreInformation.BuildCode;

        #region WEB
        public static string Vtnorton = "1.0.0";
        public static string OpenSearch = "4.0.0 _discontinued_";
        #endregion
        
        #region WINDOWS 10
        public static string Win10LasVegas = "2.1." + CoreInformation.Build + " _discontinued_";
        public static string Win10Pasadena = "2.1." + CoreInformation.Build + " _discontinued_";
        public static string Win10Lyon = "2.3." + CoreInformation.Build;
        public static string Win10Douai = "2.1." + CoreInformation.Build;
        public static string Win10Nice = "2.1." + CoreInformation.Build;
        public static string Win10Miame = "1.0." + CoreInformation.Build;
        public static string Win10Rio = "1.1." + CoreInformation.Build + " _discontinued_";
        public static string Win10Teresopolis = "2.0." + CoreInformation.Build;
        #endregion

        #region WINDOWS 8.1
        public static string Win8LasVegas = "1.1." + CoreInformation.Build + " _discontinued_";
        public static string Win8Pasadena = "1.1." + CoreInformation.Build + " _discontinued_";
        public static string Win8Lyon = "2.2." + CoreInformation.Build;
        public static string Win8Douai = "1.1." + CoreInformation.Build;
        public static string Win8Nice = "1.1." + CoreInformation.Build;
        public static string Win8Miame = "0.0." + CoreInformation.Build;
        public static string Win8Rio = "1.1." + CoreInformation.Build + " _discontinued_";
        public static string Win8Teresopolis = "2.0." + CoreInformation.Build;
        #endregion
    }
}
