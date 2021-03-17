using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollApp
{
    public class Motorbike : Vehicle
    {
        // public string GetVehicleType()
        // {
        //     return "Motorbike";
        // }

        public bool IsTollFreeVehicle()
        {
            return true;
        }
    }
}
