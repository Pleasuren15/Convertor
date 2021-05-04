namespace Convertor.Data
{
    public class CCalculateFactoryPattern
    {
        public static double PerfomConversion(string _methodName, double _value, int _decimalplace = 2)
        {
            //Angle
            if (_methodName.Equals("DegToRad"))
                return Calculate.DegToRad(_value);
            if (_methodName.Equals("RadToDeg"))
                return Calculate.RadToDeg(_value);

            //Area
            if (_methodName.Equals("AcrToSqu"))
                return Calculate.AcrToSqu(_value);        
            if (_methodName.Equals("SquToAcr"))
                return Calculate.SquToAcr(_value);

            //Length
            if (_methodName.Equals("CenToInc"))
                return Calculate.CenToInc(_value);         
            if (_methodName.Equals("IncToCen"))
                return Calculate.IncToCen(_value);         
            if (_methodName.Equals("FeeToInc"))
                return Calculate.FeeToInc(_value);      
            if (_methodName.Equals("IncToFee"))
                return Calculate.IncToFee(_value);    
            if (_methodName.Equals("FeeToMet"))
                return Calculate.FeeToMet(_value);           
            if (_methodName.Equals("MetToFee"))
                return Calculate.MetToFee(_value);
            if (_methodName.Equals("IncToMil"))
                return Calculate.IncToMil(_value);           
            if (_methodName.Equals("MilToInc"))
                return Calculate.MilToInc(_value);        
            if (_methodName.Equals("KilToMil"))
                return Calculate.KilToMil(_value);           
            if (_methodName.Equals("MilToKil"))
                return Calculate.MilToKil(_value);

            //Temperature            
            if (_methodName.Equals("CelToFah"))
                return Calculate.CelToFah(_value);        
            if (_methodName.Equals("FahToCel"))
                return Calculate.FahToCel(_value);  
            if (_methodName.Equals("KelToCel"))
                return Calculate.KelToCel(_value);        
            if (_methodName.Equals("CelToKel"))
                return Calculate.CelToKel(_value);  
            
            //Temperature            
            if (_methodName.Equals("HouToMin"))
                return Calculate.HouToMin(_value);        
            if (_methodName.Equals("MinToHou"))
                return Calculate.MinToHou(_value);  
            if (_methodName.Equals("HouToSec"))
                return Calculate.HouToSec(_value);        
            if (_methodName.Equals("SecToHou"))
                return Calculate.SecToHou(_value);      
            if (_methodName.Equals("SecToMin"))
                return Calculate.SecToMin(_value);        
            if (_methodName.Equals("MinToSec"))
                return Calculate.MinToSec(_value);
            return 0;
        }
    }
}
