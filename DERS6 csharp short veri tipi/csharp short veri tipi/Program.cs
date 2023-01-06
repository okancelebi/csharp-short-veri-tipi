using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_short_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Byte birinci = 5;
            Byte ikinci = 25;
            Byte ucuncu = 255;
            Byte MınDeger = Byte.MaxValue;
            Byte MaxDeger = Byte.MinValue;
            //Byte 0-255 arasındaki tam sayıları kabul eder.
            //cw ve 2 kez tab basınca: "Console.WritLine" yazar.
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine(MınDeger);
            Console.WriteLine(MaxDeger);
            Console.ReadLine();
        }
    }
}
