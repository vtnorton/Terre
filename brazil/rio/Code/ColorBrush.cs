using Core.Methods;
using System.Globalization;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace ProjectRio.Code
{
    public class ColorBrush
    {
        public static Brush ColorToBrush(int NumeroAleatorio)
        {
            string color = Organic.BackgroundColor(NumeroAleatorio).Replace("#", "");
            return new SolidColorBrush(ColorHelper.FromArgb(255, byte.Parse(color.Substring(0, 2), NumberStyles.HexNumber), byte.Parse(color.Substring(2, 2), NumberStyles.HexNumber), byte.Parse(color.Substring(4, 2), NumberStyles.HexNumber))); ;
        }
        public static Brush ColorToBrushClara(int NumeroAleatorio)
        {
            string color = Organic.BackgroundLightColor(NumeroAleatorio).Replace("#", "");
            return new SolidColorBrush(ColorHelper.FromArgb(255, byte.Parse(color.Substring(0, 2), NumberStyles.HexNumber), 
                byte.Parse(color.Substring(2, 2), NumberStyles.HexNumber), 
                byte.Parse(color.Substring(4, 2), NumberStyles.HexNumber))); ;
        }

        public static Color ColorToColorLight(int NumeroAleatorio)
        {
            string hexCode = Organic.BackgroundLightColor(NumeroAleatorio).Replace("#", "");
            var color = new Color();
            color.A = 255;
            color.R = byte.Parse(hexCode.Substring(0, 2), NumberStyles.HexNumber);
            color.G = byte.Parse(hexCode.Substring(2, 2), NumberStyles.HexNumber);
            color.B = byte.Parse(hexCode.Substring(4, 2), NumberStyles.HexNumber);
            return color;
        }

    }
}
