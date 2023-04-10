using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pert5
{
    internal class Numbers
    {
        // Menggunakan method void yang memeliki 3 variabel inputan
        public void nilaiMin(int a, int b, int c)
        {
            Console.WriteLine("Nilai terkecil antara {0}, {1}, {2}", a, b, c);
            //Melakukan dua perkondisian di setiap if
            if (a <= b && a <= c)
            {               
                Console.WriteLine("Nilai terkecilnya : {0}", a);
            }
            else if (b <= a && b <= c)
            {               
                Console.WriteLine("Nilai terkecilnya : {0}", b);
            }
            else if (c <= a && c <= b)
            {
                Console.WriteLine("Nilai terkecilnya : {0}", c);
            }
        }

        //Menggunakan method non void yang memeliki 3 variabel inputan
        public int nilaiMax(int a, int b, int c)
        {
            Console.WriteLine("Nilai terbesar antara : {0}, {1}, {2}", a, b, c);
            //Melakukan dua perkondisian di setiap if
            if (a >= b && a >= c)
            {
                Console.WriteLine("Nilai terbesarnya : {0}", a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("Nilai terbesarnya : {0}", b);
            }
            else if (c >= a && c <= b)
            {
                Console.WriteLine("Nilai terbesarnya : {0}", c);
            }
            return 0;
        }
    }
}
