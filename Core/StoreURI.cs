using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class StoreURI
    {
        #region France
        private static string ProductIdNice = "60181VTNORTON.Random42";
        private static string ProductIdLyon = "60181VTNORTON.Calculadoradetempo";
        private static string ProductIdDouai = "60181VTNORTON.Conjugar";
        private static string ProductIdMarselha = "";
        private static string ProductIdWin8Nice = "9bfa14f4-201c-4253-b5ad-799fe2da3135";
        private static string ProductIdWin8Lyon = "57686c13-7f66-45c6-9fdf-413b7606a97c";
        private static string ProductIdWin8Douai = "";
        private static string ProductIdWin8Marselha = "";
        #endregion

        #region USA
        private static string ProductIdLasVegas = "60181VTNORTON.TrueOrDare";
        private static string ProductIdPasadena = "60181VTNORTON.NeverEver";
        private static string ProductIdSeattle = "";
        private static string ProductIdMiami = "";
        private static string ProductIdWin8LasVegas = "";
        private static string ProductIdWin8Pasadena = "";
        private static string ProductIdWin8Seattle = "";
        private static string ProductIdWin8Miami = "";
        #endregion

        #region Brazil
        private static string ProductIdRio = "60181VTNORTON.TochaOlmpica";
        private static string ProductIdTeresopolis = "";
        private static string ProductIdWin8Rio = "";
        private static string ProductIdWin8Teresopolis = "";
        #endregion

        #region Canada
        private static string ProductIdQuebec = "9nblggh4wb6b ";
        #endregion

        #region Review France
        public static Uri ReviewNice = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdNice);
        public static Uri ReviewLyon = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdLyon);
        public static Uri ReviewDouai = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdDouai);
        public static Uri ReviewMarselha = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdMarselha);
        #endregion

        #region Review USA
        public static Uri ReviewLasVegas = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdLasVegas);
        public static Uri ReviewPasadena = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdPasadena);
        public static Uri ReviewSeattle = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdSeattle);
        public static Uri ReviewMiami = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdMiami);
        #endregion

        #region Review Brazil
        public static Uri ReviewBrazil = new Uri(@"ms-windows-store://review/?ProductId=" + ProductIdRio);
        #endregion

        #region Open France
        public static Uri OpenNice = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdNice);
        public static Uri OpenLyon = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdLyon);
        public static Uri OpenDouai = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdDouai);
        public static Uri OpenMarselha = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdMarselha);
        public static Uri OpenWin8Nice = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Nice);
        public static Uri OpenWin8Lyon = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Lyon);
        public static Uri OpenWin8Douai = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Douai);
        public static Uri OpenWin8Marselha = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Marselha);
        public static Uri OpenWP8Nice = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Nice);
        public static Uri OpenWP8Lyon = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Lyon);
        public static Uri OpenWP8Douai = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Douai);
        public static Uri OpenWP8Marselha = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Marselha);
        #endregion

        #region Open USA
        public static Uri OpenLasVegas = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdWin8LasVegas);
        public static Uri OpenPasadena = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdWin8Pasadena);
        public static Uri OpenSeattle = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdWin8Seattle);
        public static Uri OpenMiami = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdWin8Miami);
        public static Uri OpenWin8LasVegas = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8LasVegas);
        public static Uri OpenWin8Pasadena = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Pasadena);
        public static Uri OpenWin8Seattle = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Seattle);
        public static Uri OpenWin8Miami = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Miami);
        public static Uri OpenWP8LasVegas = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8LasVegas);
        public static Uri OpenWP8Pasadena = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Pasadena);
        public static Uri OpenWP8Seattle = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Seattle);
        public static Uri OpenWP8Miami = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Miami);
        #endregion

        #region Open Canada
        public static Uri OpenQuebec = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdQuebec);
        #endregion

        #region Open Brazil
        public static Uri OpenRio = new Uri(@"ms-windows-store://pdp/?ProductId=" + ProductIdRio);
        public static Uri OpenWin8Rio = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Rio);
        public static Uri OpenWP8Rio = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Rio);
        public static Uri OpenTeresopolis = new Uri(@"ms-windows-store://pdp/?ProductId=" + OpenTeresopolis);
        public static Uri OpenWin8Teresopolis = new Uri(@"ms-windows-store://pdp/?AppId=" + ProductIdWin8Teresopolis);
        public static Uri OpenWP8Teresopolis = new Uri(@"ms-windows-store://pdp/?PhoneAppId=" + ProductIdWin8Teresopolis);
        #endregion
    }
}
