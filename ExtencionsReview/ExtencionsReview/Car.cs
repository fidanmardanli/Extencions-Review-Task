using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtencionsReview
{
    public class Car
    {
        public static int Speed;

        static Car()
        {
            Speed = 500;
            Console.WriteLine(Speed);
        }

        public static int ShowSpeed()
        {
            return Speed;
        }
    }
}
