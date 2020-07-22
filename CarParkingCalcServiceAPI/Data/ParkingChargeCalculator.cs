using CarParkingCalcServiceAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkingCalcServiceAPI.Data
{
    public class ParkingChargeCalculator
    {
       
        public ParkingCharges CaclulateParkingCharges(DateTime CarEntryTime, DateTime CarExistTime)
        {
            ChargeCalcUtils.InitializeRates();
            double charge = 0;
            double ParkingRate = 0;
            NameoftheRate chargetype = NameoftheRate.Standard;
            var type = ChargeCalcUtils.GetNameOfRate(CarEntryTime, CarExistTime);
            if (type == NameoftheRate.Standard)
            {
                //Apply charges based on duration
                chargetype = type;
                var t = ChargeCalcUtils.GetChargesforStandard( CarEntryTime,  CarExistTime);
                ParkingRate = t.ParkingRate;
                charge = t.Charge;
            }
            else
            {
                //Get rates based on Night/EarlyBirad/Week end.
                chargetype = type;
                charge = ChargeCalcUtils.chargeRatelookup.Where(x => x.RateType == type).Select(y => y.ParkingRate).FirstOrDefault();
                ParkingRate = charge;

            }
            ParkingCharges TotalchargeObj = new ParkingCharges();
            TotalchargeObj.ParkingRate = ParkingRate;
            TotalchargeObj.TotalCcharges = charge;
            TotalchargeObj.CarParkingStartTime = CarEntryTime;
            TotalchargeObj.CarParkingEndTime = CarExistTime;
            return TotalchargeObj;
        }


       
    }
}
