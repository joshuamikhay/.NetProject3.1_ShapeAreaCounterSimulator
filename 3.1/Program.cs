using System;
using System.Linq;
using System.Threading.Tasks;
//2018326660145
//Joshua Mikhay Kusuma
//Triangle Rectangle Square Area Counter Simulator
namespace _3._1
{
    class Program
    {
        //public static string opCode = "";
        public static double areaResult = 0.0;
        static void Main(string[] args)
        {
            Console.WriteLine(">> Area Counter Simulator << " + "\n");
            
            beginSimulation:
            try
            {
                Console.WriteLine("1.Rectangle" + "\n" + "2.Triangle" + "\n" + "3.Square");
                Console.WriteLine("Select Shape to do Area Counter: ");
                string opCode = Convert.ToString(Console.ReadLine());
                switch (opCode)
                {
                    case "1":
                        rectangleAreaCounter();
                        Console.WriteLine("The Rectangle has an Area of : " + areaResult);
                        break;
                    case "2":
                        triangleAreaCounter();
                        Console.WriteLine("The Triangle has an Area of : "  + areaResult);
                        break;
                    case "3":
                        squareAreaCounter();
                        Console.WriteLine("The Square has an Area of : " + areaResult);
                        break;
                    

                }
                Console.WriteLine("Do another Simulation ? (Y/N)" +"\n");
                string doAnother = Console.ReadLine();
                if(doAnother=="Y" || doAnother=="y")
                {
                    goto beginSimulation;
                }
                else
                {
                    Console.WriteLine("Thankyou for using, See You....");
                }
            }
            catch
            {
                Console.WriteLine("Input Error, do you wish to try again ? (Y/N) "+"\n");
                string tryAgain = Convert.ToString(Console.ReadLine());
                if(tryAgain=="y" || tryAgain=="Y")
                {
                    goto beginSimulation;
                }
                else
                {
                    Console.WriteLine("Thankyou for using, See You....");
                }
                
            }
        }
        public static double rectangleAreaCounter()
        {
            
            Console.WriteLine("Please input rectangle Length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input rectangle Width:");
            double width = Convert.ToDouble(Console.ReadLine());
            areaResult = Convert.ToDouble(length * width);
            return areaResult;
        }
        public static double triangleAreaCounter()
        {

            Console.WriteLine("Please input triangle side lower side Length:");
            double lowerSideLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input triangle Height:");
            double height = Convert.ToDouble(Console.ReadLine());
            areaResult = Convert.ToDouble((lowerSideLength*height)/2);
            return areaResult;
        }
        public static double squareAreaCounter()
        {

            Console.WriteLine("Please input square side Length:");
            double sideLength = Convert.ToDouble(Console.ReadLine());
            areaResult = Convert.ToDouble(sideLength*sideLength);
            return areaResult;
        }
    }
}
