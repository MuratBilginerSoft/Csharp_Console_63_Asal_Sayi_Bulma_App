using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Asal_Sayı_Bulma_App
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parameters

            int k = 0;

            int toplamx = 0;
            int toplamy = 0;

            int ortx, orty;

            #endregion

            #region Definitions

            ArrayList TS = new ArrayList();
            ArrayList AS = new ArrayList();
            ArrayList AOS = new ArrayList();

            Random x = new Random();

            #endregion

            for (int i = 0; i < 10; i++)
            {
                TS.Add(x.Next(1000));
            }

           

            Console.WriteLine(AS.Count);
            Console.WriteLine(AOS.Count);

            foreach (var item in AS)
            {
                toplamx += Convert.ToInt32(item);
            }

            ortx = toplamx / AS.Count;


            foreach (var item in AOS)
            {
                toplamy += Convert.ToInt32(item);
            }

            orty = toplamy / AOS.Count;

            foreach (var item in AS)
            {
                Console.Write(item+"-");
            }

            Console.WriteLine();

            foreach (var item in AOS)
            {
                Console.Write(item + "-");
            }

            Console.WriteLine();

            Console.WriteLine(ortx);
            Console.WriteLine(orty);

            Console.ReadKey();
        }
    }
}
