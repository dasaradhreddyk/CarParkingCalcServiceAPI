using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarParkingCalcServiceAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using CarParkingCalcServiceAPI.Data;

namespace CarParkingCalcServiceAPI.Controllers.Tests
{
    [TestClass()]
    public class ParkingChargesTests
    {
        [TestMethod()]
        public void GetParkingChargeTest()
        {
            
            
             ParkingCharges ctr = new ParkingCharges();
            //Rule week end 

            var charge = ctr.GetParkingCharge(DateTime.Parse("2020-07-18 T18:00:00"), DateTime.Parse("2020-07-18T20:00:00"));

            //Rule early bird
           // charge =ctr.GetParkingCharge(DateTime.Now.AddHours(-9), DateTime.Now.AddHours(2));

            //Rule night
            charge = ctr.GetParkingCharge(DateTime.Parse("2020-07-01T18:00:00"), DateTime.Parse("2020-07-01T20:00:00"));

            //Rule standard
            //https://localhost:44336/ParkingCharges?CarEntryTime=2020-07-01T09:00:00&CarExistTime=2020-07-01T12:00:00

           // ctr.GetParkingCharge( DateTime.Parse("2020-07-01T09:00:00"), DateTime.Parse("2020-07-01T12:00:00"));

            //Exception Testing. 
           // charge = ctr.GetParkingCharge(DateTime.Now.AddHours(-9),DateTime.Now.AddHours(2));

            Assert.Fail();
        }
    }
}
