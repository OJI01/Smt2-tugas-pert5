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
                //output yang akan di keluarkan jika memenuhi syarat
                Console.WriteLine("Adalah: {0}", a);
            }
            else if (b <= a && b <= c)
            {
                //output yang akan di keluarkan jika memenuhi syarat
                Console.WriteLine("Adalah: {0}", b);
            }
            else if (c <= a && c <= b)
            {
                //output yang akan di keluarkan jika memenuhi syarat
                Console.WriteLine("Adalah: {0}", c);

            }
        }

        //Menggunakan method non void yang memeliki 3 variabel inputan
        public int nilaiMax(int a, int b, int c)
        {
            Console.WriteLine("Nilai terbesar antara {0}, {1}, {2} adalah :", a, b, c);
            //Melakukan dua perkondisian di setiap if
            if (a >= b && a >= c)
            {
                //output yang akan di keluarkan jika kondisi memenuhi syarat
                Console.WriteLine("Adalah: {0}", a);
            }
            else if (b >= a && b >= c)
            {
                //output yang akan di keluarkan jika kondisi memenuhi syarat
                Console.WriteLine("Adalah: {0}", b);
            }
            else if (c >= a && c <= b)
            {
                //output yang akan di keluarkan jika kondisi memenuhi syarat
                Console.WriteLine("Adalah: {0}", c);
            }
            return 0;
        }

