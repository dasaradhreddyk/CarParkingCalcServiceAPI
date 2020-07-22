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

            var charge = ctr.GetParkingCharge(DateTime.Now.AddHours(-9), DateTime.Now.AddHours(2));

            //Rule early bird
            charge =ctr.GetParkingCharge(DateTime.Now.AddHours(-9), DateTime.Now.AddHours(2));

            //Rule night
            charge = ctr.GetParkingCharge(DateTime.Now.AddHours(-9), DateTime.Now.AddHours(2));

            //Rule standard
            ctr.GetParkingCharge(DateTime.Now.AddHours(-9), DateTime.Now.AddHours(2));

            //Exception Testing. 
            charge = ctr.GetParkingCharge(DateTime.Now.AddHours(-9),DateTime.Now.AddHours(2));

            Assert.Fail();
        }
    }
}