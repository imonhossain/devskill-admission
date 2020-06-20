using System;

namespace Answer3
{
    class Program
    {
        static void Main(string[] args)
        {
            string converToPascale(string s){
                for (int i = 0; i < s.Length; i++)
                {
                    if(s[i]==' ' && s[i+1] !=' '){
                        s[i+1] = s[i+1]-32;
                    }
                   
                }

            return s;
            }


            Console.WriteLine(converToPascale("Hello world"));
        }
    }
}
