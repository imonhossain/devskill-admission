using System;

namespace Answer4
{
    class Program
    {
        static void Main(string[] args)
        {
           //string s = DateTime.ParseExact("23:30", "HH:mm", CultureInfo.CurrentCulture).ToString("hh:mm tt");
           string con(string temps){
               
               bool isPm = false;
               int hour = Int16.Parse(temps.Substring(0,2));
               // Console.WriteLine(temps);
               int min = Int16.Parse(temps.Substring(3,2));
               

               if(hour>11){
                   //Console.WriteLine("inner");
                   hour = hour-12;
                   isPm = true;
               }
               string b = "";
               if(isPm == true){
                 b = hour.ToString() +":"+  min.ToString() + "PM";
               }else{
                b = hour.ToString() +":"+   min.ToString() + "AM";
               }
               return b;
           }

           Console.WriteLine(con("23:30"));
        }
    }
}
