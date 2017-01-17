using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(); //created a new house object called house1
            House house2 = new House("red", 6, 1000, 8);//creating a new object using our constructor to assign field values 

            house1.Paint("Green");  //painting the house green using method we created called Paint
            Console.WriteLine(house1.CurrentColor());  //output the current color stored in house 1 using method we created named CurrentColor

            House house2 = new House(); //created another new house object called house2
            house2.Paint("Blue");
            Console.WriteLine("House one is: " + house1.CurrentColor() + ". House two is: " + house2.CurrentColor());
        }
    }
}
