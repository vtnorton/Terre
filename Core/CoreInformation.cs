using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CoreInformation
    {
        //Open command prompt
        //git rev-list --all --count

        public static int CodeLines = 189;
        public static int Colors = 85;
        public static int RevisonNumber = 19;
        public static string BuildCode = "0f707934";
        public static string Targat = " ";
        public static string Build = RevisonNumber + "." + BuildCode + Targat;
        

        #region PATHS
        //public static string PathColors = "\\Data\\colors.txt";
        //public static string PathColorsLight = "\\Data\\whitecolors.txt";
        #endregion
    }
}
