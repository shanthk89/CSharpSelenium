using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unisys.CSharpConcept;

namespace CSharpConcept
{
    public class DemoMethods
    {
       
        public static void Main(string[] args)
        {
            Area area = new Area();
            Console.WriteLine(Area.AreaOfSquare(10.20));
            Console.WriteLine(Area.AreaOfTriangle(10.2,10.30));
            Console.WriteLine(area.AreaOfRectangle(2.2,2.43));
            Console.WriteLine(Area.AreaOfCircle(3));
        }
    }
}
