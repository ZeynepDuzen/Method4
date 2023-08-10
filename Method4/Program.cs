using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen notunuzu giriniz : ");
            int notInput = Convert.ToInt32(Console.ReadLine());

             string sonuc = Not(notInput);
            Console.WriteLine("Sinif gecme dereceniz : " + sonuc);



            Console.Read();
        }
        static string Not(int notInput)
        {
            if (notInput >= 0 && notInput <= 44)
            {
                //Console.WriteLine("Kaldiniz");
                 return "Kaldiniz";
            }
            if (notInput >= 45 && notInput <= 54)
            {
                //Console.WriteLine("Gectiniz");
                return "Gectiniz";
            }
            if (notInput >= 55 && notInput <= 69)
            {
                //Console.WriteLine("Orta");
                return "Orta";
            }
            if (notInput >= 70 && notInput <= 84)
            {
                //Console.WriteLine("Iyi");
                return "Iyi";
            }
            if (notInput >= 85 && notInput <= 99)
            {
                //Console.WriteLine("Cok iyi");
                return "Cok Iyi";
            }
            if (notInput == 100)
            {
                //Console.WriteLine("Tam not aldiniz");
                return "Tam not aldiniz";
            }
            else
            {
                //Console.WriteLine("Not girisi hatali");
                return "Not girisi hatali";
            }

           
        }
    }
}
