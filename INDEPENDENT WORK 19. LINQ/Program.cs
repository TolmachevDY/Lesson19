using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEPENDENT_WORK_19.LINQ
{    
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Comp> comps = new List<Comp>()
            {
                new Comp(){Code="A001",Brand="Asus", TypeProc="Intel Core i7",RateProc=3.6,RAM=64, HardDrive=500,MemoryVC=6, Price=1500, Copies=20},
                new Comp(){Code="B005",Brand="Dell", TypeProc="Intel Core i5",RateProc=3.7,RAM=32, HardDrive=250,MemoryVC=2, Price=1300, Copies=15},
                new Comp(){Code="G032",Brand="MSI", TypeProc="Intel Core i5",RateProc=3.3,RAM=32, HardDrive=1000,MemoryVC=8, Price=1700, Copies=35},
                new Comp(){Code="A002",Brand="HP", TypeProc="Intel Core i9",RateProc=3.6,RAM=16, HardDrive=500,MemoryVC=6, Price=2000, Copies=10},
                new Comp(){Code="DSR111",Brand="Lenovo", TypeProc="AMD Ryzen 9",RateProc=3.4,RAM=128, HardDrive=750,MemoryVC=4, Price=2500, Copies=13},
                new Comp(){Code="RGE955",Brand="Acer", TypeProc="AMD Athlon 200",RateProc=3.2,RAM=64, HardDrive=500,MemoryVC=6, Price=1500, Copies=9}
            };
            
            Console.WriteLine("Введите тип процессора");
            string typeProc = Console.ReadLine();
            List<Comp> comps1 = comps.Where(x => x.TypeProc == typeProc).ToList();
            Print(comps1);
            
            Console.WriteLine("Введите объем ОЗУ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Comp> comps2 = comps.Where(x => x.RAM >= ram).ToList();
            Print(comps2);
            
            List<Comp> comps3 = comps.OrderBy(x => x.Price).ToList();
            Print(comps3);
            IEnumerable<IGrouping<string, Comp>> comps4 = comps.GroupBy(x => x.TypeProc);
            foreach (IGrouping<string, Comp> gr in comps4)
            {
                Console.WriteLine(gr.Key);
                foreach (Comp e in gr)
                {
                    Console.WriteLine($"{e.Code}/ {e.Brand}/ процессор {e.TypeProc}/ ОЗУ {e.RAM}/ стоимость {e.Price}");
                }
            }
            Comp comps5 = comps.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{comps5.Code}/ {comps5.Brand}/ процессор {comps5.TypeProc}/ ОЗУ {comps5.RAM}/ стоимость {comps5.Price}");
            Comp comps6 = comps.OrderBy(x => x.Price).LastOrDefault();
            Console.WriteLine($"{comps6.Code}/ {comps6.Brand}/ процессор {comps6.TypeProc}/ ОЗУ {comps6.RAM}/ стоимость {comps6.Price}");
            Console.WriteLine(comps.Any(x => x.Copies >= 30)); 

            Console.ReadKey();
        }
        
        static void Print(List<Comp> comps)
        {
            foreach (Comp e in comps)
            {
                Console.WriteLine($"{e.Code}/ {e.Brand}/ процессор {e.TypeProc}/ ОЗУ {e.RAM}/ стоимость {e.Price}");
            }
            Console.WriteLine();
        }
    }
}
