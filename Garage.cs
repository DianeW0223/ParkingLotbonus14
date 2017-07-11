using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBonus13
{
    class Garage
    {
        private int level;
        private int vehicles;
        //private int motorcycle;
        private int bus;
        

        public Garage(int level , int vehicles)
        {
            this.vehicles = vehicles;
            this.level = level;
            
            
        }

                
        public int getBus(int x)
        {
            bus = 5;
            return bus;
        }

        public int getSpaces(int x, int y)
        {
            int Spaces = x * vehicles * y;
            return Spaces;
        }

        public int getBusSpace(int x, int y)
        {
            int BusSpace = x / getBus(bus)*y;
            return BusSpace;
        }
        
    }
}
