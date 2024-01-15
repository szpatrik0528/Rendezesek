using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rendezesek

{
    public class tools
    {
        public static readonly int[] szamok;
        static void Main(string[] args)
        {
            beolvas("10");
        }
        public static int[] beolvas(string args)
        {
            int[] szamok;
            string fileName=string.Empty;
            if(args.Length == 0 || args.Equals("10") )
            {
                fileName = "szamok10.csv";
                szamok = new int[10];
            } else
            {
                fileName = "szamok100ezer.csv";
                szamok= new int[100000];
            }
            using (StreamReader sr = new StreamReader(fileName))
            {
                int index = 0;
                while (!sr.EndOfStream)
                {
                    szamok[index++] = int.Parse(sr.ReadLine());
                }
            }
            return szamok;

        }

    }
}
