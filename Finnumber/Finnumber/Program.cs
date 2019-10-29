using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer;
            int c = 0;
            int n = 
            Console.WriteLine("You think one number for 1 to 100");
            int A = 0; int B = 100;
            int count = 1;
            while (B > A + 1)
            {
                c = (A + B) / 2;
                Console.WriteLine("Q{0} : Dose you think number greatetr than {1}",count, c);
                count++;
                answer = Console.ReadLine();
                if (answer == "Y")
                    A = c;
                if (answer == "N")
                    B = c;
            }
            Console.WriteLine("Is you number is {0}", c+1);

        }

    }
}










//    int a = 100;    
//    Console.WriteLine("Plese , you think number for 1 to 100");
//    OnOrUnder50(a,);
//}

//public static void OnOrUnder50( int a, out bool b)
//{
//    Console.WriteLine("you number on or under {0}", a/2);
//    Console.WriteLine("if you think on plese pick yes, if you think under write no");
//    b = Boolean.TryParse(Console.ReadLine(), out b);