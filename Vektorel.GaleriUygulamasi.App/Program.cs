using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.GaleriUygulamasi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Marka:");
            string marka = Console.ReadLine();
            Console.Write("Model:");
            string model = Console.ReadLine();
            Console.Write("Yıl:");
            short yil = Convert.ToInt16(Console.ReadLine());

            //int buYil = 2019;
            int buYil = DateTime.Now.Year;

            Console.WriteLine("Marka:{0} Model:{1} Yaş:{2}",marka,model,buYil-yil);


            Console.ReadKey();


        }
    }
}
