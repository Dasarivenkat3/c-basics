using System;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
             int a = 0;
             char c;
             bool bl = false;
             double d = 0.0;
             string s = null;
             decimal e;

             Console.WriteLine("Hello World!");
             
             Console.WriteLine("enter your name");
             string x  =  Console.ReadLine();
             Console.WriteLine("Enter your gender M/Y: ");
             string y = Console.ReadLine();
             if(y == "M"){
                bl =true;
             }
             while (x=="")
             {
                 x=Console.ReadLine();
             }

             Console.WriteLine("enter a celcius value 0 t0 50");

              a = int.Parse(Console.ReadLine());      
              if(a>0 && a<=50)
              {
                   
                    Console.WriteLine("select 'f' for farenheit and 'k' for kelvin and 'b' for both");
                    char t = char.Parse(Console.ReadLine());
                   switch (t)
              {
                case 'f':                      
                     Console.WriteLine("temperature in farenheit\t " +temp(a) );
                    break;
                case 'k':
                      d = a + 273.15;

                    Console.WriteLine(" temperature in kelvin\n " + d);
                    break;
                case 'b':
                         d = a * 1.8 + 32 ;
                         double m = a + 273.15;
                     Console.WriteLine(" hell0 {0},temperature in farenheit is {1},temperature in kelvin {2}",x,d,m);
                         break;
                         
                default:
                    Console.WriteLine("select 'f' for farenheit and 'k' for kelvin and 'b' for both");
                    break;
      }
     }
     else
     {
        Console.WriteLine("selected value out of range");
     }                        
        }
       
        public static double temp(int a){
            return a * 1.8 + 32 +2;
        }

    }
}
