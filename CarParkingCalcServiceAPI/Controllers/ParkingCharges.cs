using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarParkingCalcServiceAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarParkingCalcServiceAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ParkingCharges : ControllerBase
    {
        // GET: ParkingCharges
       

        // GET: ParkingCharges/Details/5
        [HttpGet]
        public IEnumerable<ParkingCharges> GetParkingCharge(DateTime CarEntryTime ,DateTime CarExistTime)
        {
             var calculator = new ParkingChargeCalculator();
            Model.ParkingCharges charge = calculator.CaclulateParkingCharges(CarEntryTime, CarExistTime);           
            List<Model.ParkingCharges> lst = new List<Model.ParkingCharges>();
            lst.Add(charge);
            return lst;
        }

    }
}
