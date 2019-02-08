using System;

namespace PrintDateRange
{
    class Program
    { 
        private static DateRange range;

        public static DateRange Range { get => range; set => range = value; }

        static void Main(string[] args)
        {
            
            if(args.Length != 2)
            {
                Console.WriteLine("Please enter a dates");
            }
            else
            {
                if ( !(DateTime.TryParse(args[0], out var firstDate) && DateTime.TryParse(args[1], out var secondDate) ) )
                {
                    Console.WriteLine("Wrong values!"); 
                }
                else
                {     
                    Range= new DateRange(firstDate, secondDate);
                   
                     Console.WriteLine(Range.CreateRange());
                    //Range.PrintRange();
                }
            
            }

        }
    }
}
