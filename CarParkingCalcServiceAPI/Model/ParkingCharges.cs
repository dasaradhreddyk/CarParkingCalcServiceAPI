using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkingCalcServiceAPI.Model
{
    public class ParkingCharges
    {
        public DateTime CarParkingStartTime { get; set; }
        public DateTime CarParkingEndTime { get; set; }
        public double TotalCcharges { get; set; }
        public double ParkingRate { get; set; }
    }
    public class RateLookup
    {
        public double ParkingRate;
        public NameoftheRate RateType;
        public RateLookup( NameoftheRate ratetype, double rate)
        {
            ParkingRate = rate;
            RateType = ratetype;
        }

    }
    public class StarndardRates
    {
        public double ParkingRate;
        public double Charge ;
        public StarndardRates(double rate, double charge)
        {
            ParkingRate = rate;
            Charge = charge;
        }
    }
    }

