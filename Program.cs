using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pert5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sebuah object yang bernama method dari class Numbers
            Numbers method = new Numbers();
            // memanggil method dari class Numbers menggunakan nama_object.nama_method
            method.nilaiMin(39, 74, 28);
            method.nilaiMin(61, 83, 93);
            method.nilaiMin(35, 58, 43);
            Console.WriteLine("--------------------------------------");
            // memanggil method dari class Numbers menggunakan nama_object.nama_method
            method.nilaiMax(96, 46, 29);
            method.nilaiMax(84, 65, 57);
            method.nilaiMax(42, 45, 28);
            Console.ReadKey();
        }
    }
}
