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
        public static int RevisonNumber = 28;
        public static string BuildCode = "009139aa";
        public static string Target = " ";
        public static string Build = RevisonNumber + "." + BuildCode + Target;
        

        #region PATHS
        //public static string PathColors = "\\Data\\colors.txt";
        //public static string PathColorsLight = "\\Data\\whitecolors.txt";
        #endregion
    }
}
