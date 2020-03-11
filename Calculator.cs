using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator 
    {
        static void Main(string[] args) 
        {
            Console.Title = "Aplikasi Calculator";
            Console.WriteLine("Pilih Menu Calculator : \n\n");
            Console.WriteLine("1. Penambahan\n");
            Console.WriteLine("2. Pengurangan\n");
            Console.WriteLine("3. Perkalian\n");
            Console.WriteLine("4. Pembagian\n\n");
            Console.WriteLine("Input nomor menu [1..4]: ");
            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan) 
            {
                case 1:
                    Penambahan();
                    break;
                case 2:
                    Pengurangan();
                    break;
                case 3:
                    Perkalian();
                    break;
                case 4:
                    Pembagian();
                    break;
                default:
                    Console.WriteLine("\nMaaf, menu yang Anda pilih tidak tersedia");
                    break;
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static void Penambahan() {

            Console.WriteLine("\nInputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());

            int hasil = a + b;

            Console.WriteLine("\nHasil Penambahan {0} + {1} = {2}", a, b, hasil);
        }

        static void Pengurangan() {
            Console.WriteLine("\nInputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());

            int hasil = a - b;

            Console.WriteLine("\nHasil Pengurangan {0} - {1} = {2}", a, b, hasil);
        }

        static void Perkalian() {
            Console.WriteLine("\nInputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());

            int hasil = a * b;

            Console.WriteLine("\nHasil Perkalian {0} * {1} = {2}", a, b, hasil);
        }

        static void Pembagian() {
            Console.WriteLine("\nInputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());

            int hasil = a / b;

            Console.WriteLine("\nHasil Pembagian {0} / {1} = {2}", a, b, hasil);
        }

    }
}
