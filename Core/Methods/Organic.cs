using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Methods
{
    public class Organic
    {
        public static string[] Colors       = { "#663333", "#4E0000", "#380000", "#9E1716", "#B81B1B", "#FF2E12", "#B01E00", "#E56C19", "#C27D4F", "#FE7C22", "#C35D15", "#632F00", "#543A24", "#2E1700", "#261300", "#FF981D", "#CEA539", "#F3B200", "#C69408", "#D39D09", "#E1B700", "#91D100", "#7BAD18", "#77B900", "#94BD4A", "#83BA1F", "#199900", "#2D652B", "#003E00", "#004A00", "#3A9548", "#15992A", "#128425", "#00C13F", "#00D8CC", "#439D9A", "#00AAAA", "#00A3A3", "#008E8E", "#008287", "#306772", "#004D60", "#004050", "#56C5FF", "#1FAEFF", "#006AC1", "#4294DE", "#569CE3", "#6BA5E7", "#2C4566", "#6E7E94", "#001E4E", "#2572EB", "#001940", "#1B58B8", "#16499A", "#423173", "#180052", "#1F0068", "#4617B4", "#7F6E94", "#57169A", "#691BB8", "#4C2C66", "#AA40FF", "#250040", "#2D004E", "#7200AC", "#662C58", "#4E0038", "#40002E", "#E064B7", "#DE4AAD", "#E773BD", "#B81B6C", "#AA4379", "#FF76BC", "#9E165B", "#C1004F", "#FF1D77", "#AD103C", "#61292B", "#AA4344", "#8ACC6D", "#555555" };
        public static string[] LightColors  = { "#9A7979", "#8B5959", "#7D5959", "#C06766", "#D06A6A", "#FF7663", "#CB6B59", "#EE9F69", "#D7AA8C", "#FEAA6E", "#D79565", "#997759", "#8F7E70", "#766759", "#726459", "#FFBB6B", "#DFC47D", "#F7CD59", "#DABA5D", "#E2BF5E", "#EBD059", "#B7E159", "#A9C968", "#A6D159", "#BAD488", "#ADD26B", "#69BC59", "#759A74", "#598059", "#598859", "#7EBB87", "#65BC73", "#63AE71", "#59D781", "#59E6DE", "#84BFBC", "#59C8C8", "#59C3C3", "#59B4B4", "#59ADB1", "#789BA2", "#598A97", "#59828D", "#90D9FF", "#6BCAFF", "#599DD7", "#83BAE9", "#90BEED", "#9EC4EF", "#74869A", "#A1AABA", "#596B8B", "#71A2F2", "#596982", "#6A92D0", "#6687BC", "#8379A3", "#68598E", "#6B599C", "#8667CE", "#ABA1BA", "#9166BC", "#9D6AD0", "#8A749A", "#C882FF", "#715982", "#75598B", "#A259C9", "#9A7492", "#8B597D", "#825976", "#EB9AD0", "#E988C9", "#EFA3D4", "#D06A9F", "#C884A7", "#FFA5D3", "#D7598C", "#FF6BA6", "#C96280", "#987274", "#C88485", "#B3DEA0", "#8F8F8F", "#555555" };
        public static string BackgroundColor()
        {
            //é preciso fazer teste para ver se as cores estão funcionando como deve, e se a quantidade de cores é igual. Uma página da web serve.
            return Colors[new Random().Next(0, CoreInformation.Colors)];
        }
        public static string BackgroundLightColor()
        {
            return LightColors[new Random().Next(0, CoreInformation.Colors)];
        }
        public static string BackgroundColor(int RandomNumber)
        {
            return Colors[RandomNumber];
        }
        public static string BackgroundLightColor(int RandomNumber)
        {
            return LightColors[RandomNumber];
        }
    }
}
