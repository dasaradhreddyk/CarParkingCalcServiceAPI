using CarParkingCalcServiceAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkingCalcServiceAPI.Data
{
    public static class ChargeCalcUtils
    {
        public static List<RateLookup> chargeRatelookup = new List<RateLookup>();

        public static void   InitializeRates()
        {
            chargeRatelookup.Add(new RateLookup(NameoftheRate.EarlyBird, 13));
            chargeRatelookup.Add(new RateLookup(NameoftheRate.Night, 6.5));
            chargeRatelookup.Add(new RateLookup(NameoftheRate.Weekend, 10));
            return;

        }
        /// <summary>==============================================================
        /// Rules Based on entry and exit time applicable rate is determined.
        ///Rule 1: less than 1 hour ( week days) - Early Bird
        ///Rule 2: less then 2 and greater han 1 ( week days) NIGHT rate
        ///Rule 3: less than 3 and greater than 2
        ///Rule 4: 3+ ( should be for each calender day)
        public static StarndardRates GetChargesforStandard(DateTime CarEntryTime, DateTime CarExistTime)
        {

            if ((CarExistTime - CarEntryTime).Hours < 1)
                return new StarndardRates(5, 5);
            else if ((CarExistTime - CarEntryTime).Hours < 2)
                return new StarndardRates(10, 10);
            else if ((CarExistTime - CarEntryTime).Hours < 3)
                return new StarndardRates(15, 15);
            else if ((CarExistTime - CarEntryTime).Hours < 4)
                return new StarndardRates(20, 20);

            return null;


        }

        /// <summary>==============================================================
        /// Rules Based on entry and exit time applicable rate is determined.
        ///Rule 1: 6 am to 9 am ( week days) - Early Bird
        ///Rule 2: 6 pm to mid night ( week days) NIGHT rate
        ///Rule 3: on week end weekendrate
        ///Rule 4: Otherwise standard rate 

        public static NameoftheRate GetNameOfRate(DateTime CarEntryTime, DateTime CarExistTime)
        {
            //  #Rule weekedn
               if ((CarEntryTime.DayOfWeek ==DayOfWeek.Sunday  || CarEntryTime.DayOfWeek == DayOfWeek.Saturday) &&
              (CarExistTime.DayOfWeek == DayOfWeek.Sunday  || CarExistTime.DayOfWeek == DayOfWeek.Saturday ))
                return NameoftheRate.Weekend;
            //  #Rule early bird

            if (CarEntryTime.TimeOfDay.Hours >= 6 && CarEntryTime.TimeOfDay.Hours <= 10 &&
                CarExistTime.TimeOfDay.Hours > 15.30 && CarExistTime.TimeOfDay.Hours < 23.30)
                return NameoftheRate.EarlyBird;

            //  #Rule night

            if (CarEntryTime.TimeOfDay.Hours >= 18 && CarEntryTime.TimeOfDay.Hours < 24 &&
                CarExistTime.TimeOfDay.Hours > 15.30 && CarExistTime.TimeOfDay.Hours < 23.30)
                return NameoftheRate.Night;              
        
            return NameoftheRate.Standard;
        }
    }
}
