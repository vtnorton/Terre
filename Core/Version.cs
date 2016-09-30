namespace Core
{
    public class Version
    {
        public static string Core = "1.2." + CoreInformation.BuildCode;
        
        #region WINDOWS 10
        public static string Win10LasVegas = "2.1." + CoreInformation.Build;
        public static string Win10Pasadena = "2.1." + CoreInformation.Build + " _discontinued_";
        public static string Win10Lyon = "2.3." + CoreInformation.Build;
        public static string Win10Douai = "2.1." + CoreInformation.Build;
        public static string Win10Nice = "2.1." + CoreInformation.Build;
        public static string Win10Miame = "1.0." + CoreInformation.Build;
        public static string Win10Rio = "1.1." + CoreInformation.Build + " _discontinued_";
        public static string Win10Teresopolis = "2.0." + CoreInformation.Build;
        #endregion
    }
}
