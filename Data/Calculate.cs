using System;

namespace Convertor.Data
{
    public static class Calculate
    {
        //Angle
        public static double DegToRad(double _value)
        {
            //1Deg × π/180 = 0,01745Rad
            return _value * (180.0 / Math.PI);
        }
        public static double RadToDeg(double _value)
        {
            //1Rad × 180 / π = 57,296Deg
            return _value * (Math.PI / 180.0);
        }

        //Area
        public static double AcrToSqu(double _value)
        {
            //multiply the area value by 43560
            return _value * 43560;
        }             
        public static double SquToAcr(double _value)
        {
            //multiply the area value by 43560
            return _value / 43560;
        }

        //Length
        public static double CenToInc(double _value)
        {
            return _value / 2.54;
        }        
        public static double IncToCen(double _value)
        {
            return _value * 2.54;
        }    
        public static double FeeToInc(double _value)
        {
            return _value / 2.54;
        }        
        public static double IncToFee(double _value)
        {
            return _value * 2.54;
        }     
        public static double FeeToMet(double _value)
        {
            return _value / 3.281;
        }           
        public static double MetToFee(double _value)
        {
            return _value * 3.281;
        }
        public static double IncToMil(double _value)
        {
            return _value * 25.4;
        }   
        public static double MilToInc(double _value)
        {
            return _value / 25.4;
        }     
        public static double KilToMil(double _value)
        {
            return _value / 1.609;
        }     
        public static double MilToKil(double _value)
        {
            return _value * 1.609;
        }

        //Temperature
        public static double CelToFah(double _value)
        {
            return _value * (9.0 / 5.0) + 32;
        }    
        public static double FahToCel(double _value)
        {
            return (_value - 32) * (5.0/9.0);
        }  
        public static double KelToCel(double _value)
        {
            return _value - 273.15;
        }    
        public static double CelToKel(double _value)
        {
            return _value + 273.15;
        }
        
        //Time
        public static double HouToMin(double _value)
        {
            return _value * 60;
        }   
        public static double MinToHou(double _value)
        {
            return _value / 60;
        }     
        public static double HouToSec(double _value)
        {
            return _value * 3600;
        }      
        public static double SecToHou(double _value)
        {
            return _value / 3600;
        }            
        public static double SecToMin(double _value)
        {
            return _value / 60;
        }      
        public static double MinToSec(double _value)
        {
            return _value * 60;
        }
    }
}
