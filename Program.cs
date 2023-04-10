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
            method.nilaiMin(5, 7, 6);
            method.nilaiMin(7, 5, 6);
            method.nilaiMin(8, 8, 8);
            Console.WriteLine("--------------------------------------");
            // memanggil method dari class Numbers menggunakan nama_object.nama_method
            method.nilaiMax(3, 6, 4);
            method.nilaiMax(8, 7, 6);
            method.nilaiMax(9, 9, 9);
            Console.ReadKey();
        }
    }
}
