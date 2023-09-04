using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS
{
     public enum FuelType
    {
        Petrol,
        Diesel,
        Gasoline
    }
    public interface Ivehicle
    {   
        String vehicleType { get;}
         FuelType fuel { get;}

        public void start();
        public void stop();
    }
}
