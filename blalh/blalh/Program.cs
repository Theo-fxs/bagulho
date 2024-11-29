using System;

namespace Theo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota = 1;
            switch (nota)
            {
                case >= 18 and <= 20:
                    Console.WriteLine("Too smart");
                    break;


                case >= 14 and <= 17:
                    Console.WriteLine("Smart");
                    break;


                case >= 10 and <= 13:

                    Console.WriteLine("Aint that bad");
                    break;

                case >= 0 and <= 9:

                    Console.WriteLine("Hell nah ,  U a damn failure");
                    break;

                default:

                    Console.WriteLine("What the hell how in the world did u get that grade?!!");
                    break;




            }
        }
    }
}

