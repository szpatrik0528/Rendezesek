using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rendezesek
{
    internal class Buborek
    {
        public static int[] szamok;
        static Stopwatch timer = new Stopwatch();
        static void Main(string[] args)
        {
            szamok = tools.beolvas("104");
            timer.Start();
            for (int i = 1; i < szamok.Length; i++)
            {
                for (int j = i;j<szamok.Length; j++)
                {
                    if (szamok[j - 1] > szamok[j])
                    {
                        int temp = szamok[j];
                        szamok[j] = szamok[j-1];
                        szamok[j-1] = temp;
                    }
                }
            }
            timer.Stop();
            Console.WriteLine($"Felhasznált idő: {timer.ElapsedMilliseconds}");
            Console.WriteLine( "\nProgram vége!");
            Console.ReadLine();
        }
    }
}
