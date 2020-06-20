using System;
namespace Answer1
{
    public static class BigMath
    {
        public static T Sum<T,T2>(T number1, T2 number2){
            dynamic a = number1;
            dynamic b = number2;
            dynamic result = a + b;


            //  dynamic a = (T)Convert.ChangeType(number1, typeof(T)) ;
            // dynamic b = (T)Convert.ChangeType(number2, typeof(T)) ;
           
           
            return Convert.ChangeType(result, typeof(T));
        }
    }
}