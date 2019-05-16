using System;
using TestNinja.Fundamentals;

namespace MyTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var user = new User();
            //var reservatrion = new Reservation();
            //reservatrion.MadeBy = null;
            //user.IsAdmin = true;
            //var result = reservatrion.CanBeCancelledBy(user);

            var math = new TestNinja.Fundamentals.Math();

            var result = math.Max(2, 2);

            Console.WriteLine(result);

#if DEBUG
            Console.WriteLine("press any key...");
            Console.ReadKey();
#endif

        }
    }
}
