using System;
using System.Text;

namespace Core.Methods
{
    public static class RandomExtention
    {
        /// <summary>
        /// Return a random double value
        /// </summary>
        /// <param name="xRandom"></param>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <returns>Return a random double number</returns>
        public static double NextDouble(this Random xRandom, double minValue, double maxValue)
        {
            if (minValue.ToString().Contains(".") || maxValue.ToString().Contains("."))
            {
                int lenght = 2, minValueLenght = 0, maxValueLenght = 0;
                string format = "0.";

                if (minValue.ToString().Contains(".") == true)
                    minValueLenght = minValue.ToString().Substring((minValue.ToString().IndexOf(".") - 1), minValue.ToString().Length).Length;

                if (maxValue.ToString().Contains(".") == true)
                    maxValueLenght = maxValue.ToString().Substring((maxValue.ToString().IndexOf(".") - 1), maxValue.ToString().Length).Length;

                if (maxValueLenght > minValueLenght)
                    lenght = maxValueLenght;
                else if (minValueLenght > maxValueLenght)
                    lenght = minValueLenght;
                else if (minValueLenght == maxValueLenght)
                    lenght = minValueLenght;
                else
                    lenght = 2;

                lenght = lenght - 3;
                for (int i = 0; i <= lenght; i++)
                {
                    format += "#";
                }
                return double.Parse((new Random().NextDouble() * (maxValue - minValue) + minValue).ToString(format));
            }
            else
                return new Random().Next(int.Parse(minValue.ToString()), int.Parse(maxValue.ToString())+1);
        }

        public static double NextDouble(this Random xRandom, double minValue, double maxValue, bool IsRepeated, string PreviusNumbers)
        {
            return 0.2;
        }
        public static double NextDouble(this Random xRandom, double minValue, double maxValue, bool IsDouble)
        {
            if ((IsDouble == true) && !minValue.ToString().Contains(".") && !minValue.ToString().Contains("."))
            {
                if (new Random().Next(0, 50) == 5)
                    return maxValue;
                else
                    return new Random().NextDouble(double.Parse(minValue.ToString() + ".01"), maxValue) - 0.01;
            }
                
            return new Random().NextDouble(minValue, maxValue);
        }
        public static double NextDouble(this Random xRandom, double minValue, double maxValue, bool IsDouble, bool IsRepeated, string PreviusNumbers)
        {
            return new Random().NextDouble(minValue, maxValue, IsDouble);
        }
    }
}
