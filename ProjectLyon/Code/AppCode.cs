using Core.Code;
using Jace;

namespace ProjectLyon.Code
{
    public class AppCode
    {
        private double Hour, Temp, Minutes;
        private string FinalResult;
        public double Calculate(string xCont)
        {
            return new CalculationEngine().Calculate(xCont.Replace("x", "*").Replace("÷", "/"));
        }
        public string CalculoInteligent(string xCont)
        {
            double Result = Calculate(xCont);

            //if ((Result >= 1440) && (Result <= 44640))
            //    return ConvertToDays(Result);
            //else if ((Result > 44640) && (Result <= 16338240))
            //    return ConvertToMonths(Result);
            //else if (Result > 16338240)
            //    return ConvertToYear(Result);
            //else 
            if ((Result < 60) && (Result <= 5))
                return ConvertToMinutes(Result);
            //else if (Result < 5)
            //    return ConvertToSeconds(Result);
            else
                return ConvertToHours(Result);

            //Posteriormente ver se o ConvertToHours fica mais rapído se não passar por todos esses procedimentos
        }
        public string ConvertToMinutes(double xConta)
        {
            Temp = xConta / 60;
            if (((xConta % 60) == 0))
            {
                if (Temp == 1)
                    FinalResult = "1 " + LocalizedStrings.Get("Minute");
                else
                    FinalResult = Temp + " " + LocalizedStrings.Get("Minutes");
            }
            else
            {
                Minutes = xConta % 60;
                Hour = (int)Temp;
                if (Hour == 1)
                    FinalResult = "1 " + LocalizedStrings.Get("MinuteAnd");
                else
                    FinalResult = Hour + " " + LocalizedStrings.Get("MinutesAnd");
                if (Minutes == 1)
                    FinalResult += "1 " + LocalizedStrings.Get("Second");
                else
                    FinalResult += Minutes.ToString() + " " + LocalizedStrings.Get("Seconds");
            }
            return FinalResult;
        }
        public string ConvertToHours(double xConta)
        {
            Temp = xConta / 60;
            if (((xConta % 60) == 0))
            {
                if (Temp == 1)
                    FinalResult = "1 " + LocalizedStrings.Get("Hour");
                else
                    FinalResult = Temp + " " + LocalizedStrings.Get("Hours");
            }
            else
            {
                Minutes = xConta % 60;
                Hour = (int)Temp;
                if (Hour == 1)
                    FinalResult = "1 " + LocalizedStrings.Get("HourAnd");
                else
                    FinalResult = Hour + " " + LocalizedStrings.Get("HoursAnd") + " ";
                if (Minutes == 1)
                    FinalResult += "1 " + LocalizedStrings.Get("Minute");
                else
                    FinalResult += Minutes.ToString() + " " + LocalizedStrings.Get("Minutes");
            }

            return FinalResult;
        }
        public string ConvertToDays(double xConta)
        {
            return FinalResult;
        }
        public string ConvertToMonths(double xConta)
        {
            return FinalResult;
        }
        public string ConvertToSeconds(double xConta)
        {
            return FinalResult;
        }
        public string ConvertToYear(double xConta)
        {
            return FinalResult;
        }
    }
}
